#include <Adafruit_SH110X.h>
#include <Adafruit_NeoPixel.h>
#include <RotaryEncoder.h>
#include <Wire.h>
#include <AceButton.h>
#include "SimMessage.h"

//#define EVENT_TIMER_MILLIS    600000
#define EVENT_TIMER_MILLIS    600000

#define EVENT_ENCODER_INC     0b00000100
#define EVENT_ENCODER_DEC     0b00000101
#define EVENT_KEY_CLICKED     0b00000000
#define EVENT_KEY_DOUBLECLICK 0b00000001
#define EVENT_KEY_LONGPRESS   0b00000010
#define EVENT_KEY_REPEATPRESS 0b00000011

#define STATE_COM1_MHZ        0b00000100
#define STATE_COM1_KHZ        0b00000101
#define STATE_COM2_MHZ        0b00001000
#define STATE_COM2_KHZ        0b00001001
#define STATE_NAV1_MHZ        0b00001100
#define STATE_NAV1_KHZ        0b00001101
#define STATE_NAV2_MHZ        0b00010000
#define STATE_NAV2_KHZ        0b00010001
#define STATE_HEADING         0b00010100
#define STATE_COURSE          0b00011000
#define STATE_ALTITUDE_1000   0b00011100
#define STATE_ALTITUDE_100    0b00011101
#define STATE_VERTICAL_SPEED  0b00100000
#define STATE_XPND_1000       0b00100100
#define STATE_XPND_100        0b00100101
#define STATE_XPND_10         0b00100110
#define STATE_XPND_1          0b00100111
#define STATE_GPS_GROUP       0b00101000
#define STATE_GPS_PAGE        0b00101001
#define STATE_PFD_GROUP       0b00101100
#define STATE_PFD_PAGE        0b00101101
#define STATE_MFD_GROUP       0b00110000
#define STATE_MFD_PAGE        0b00110001

#define CONTROL_ROTARY  0
#define CONTROL_COM1    1
#define CONTROL_COM2    2
#define CONTROL_GPS     3
#define CONTROL_NAV1    4
#define CONTROL_NAV2    5
#define CONTROL_PFD     6
#define CONTROL_HDG     7
#define CONTROL_CRS     8
#define CONTROL_MFD     9
#define CONTROL_ALT    10
#define CONTROL_VS     11
#define CONTROL_XPND   12


using namespace ace_button;

// Create the neopixel strip with the built in definitions NUM_NEOPIXEL and PIN_NEOPIXEL
Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUM_NEOPIXEL, PIN_NEOPIXEL, NEO_GRB + NEO_KHZ800);

// Create the OLED display
Adafruit_SH1106G display = Adafruit_SH1106G(128, 64, &SPI1, OLED_DC, OLED_RST, OLED_CS);

// Create the rotary encoder
// FOUR3, TWO03, FOUR0
// TWO03 rotates several positions at a time
RotaryEncoder encoder(PIN_ROTA, PIN_ROTB, RotaryEncoder::LatchMode::FOUR3);

AceButton buttons[13];

SimMessage simMessage;

bool blankScreen = false;

void handleButtonEvent(AceButton*, uint8_t, uint8_t);
void handleSimMessageReceived();

void checkPosition() {  encoder.tick(); } // just call tick() to check the state.

// our encoder position state
int encoder_pos = 0;

// Keep track of which pixel is currently illuminated
int currentPixel = 0;

long lastEventMillis = 0;

void setup()
{
  Serial.begin(115200);
  delay(100);  // RP2040 delay is not a bad idea

  // start pixels!
  pixels.begin();
  pixels.setBrightness(255);
  pixels.show(); // Initialize all pixels to 'off'

  // Start OLED
  display.begin(0, true); // we dont use the i2c address but we will reset!
  display.display();
  
  // set all mechanical keys to inputs
  for (uint8_t i=0; i<=12; i++)
  {
    pinMode(i, INPUT_PULLUP);
    buttons[i].init(i, HIGH, i);
  }

  // Enable speaker
  pinMode(PIN_SPEAKER_ENABLE, OUTPUT);
  digitalWrite(PIN_SPEAKER_ENABLE, HIGH);
  pinMode(PIN_SPEAKER, OUTPUT);

  // tone(PIN_SPEAKER, 262, 2000);
  // delay(300);

  // tone(PIN_SPEAKER, 988, 100);  // tone1 - B5
  // delay(100);
  // tone(PIN_SPEAKER, 1319, 100); // tone2 - E6
  // delay(100);

  // Configure the ButtonConfig with the event handler.
  ButtonConfig* buttonConfig = ButtonConfig::getSystemButtonConfig();
  buttonConfig->setEventHandler(handleButtonEvent);
  buttonConfig->setFeature(ButtonConfig::kFeatureClick);
  buttonConfig->setFeature(ButtonConfig::kFeatureDoubleClick);
  buttonConfig->setFeature(ButtonConfig::kFeatureLongPress);
  buttonConfig->setFeature(ButtonConfig::kFeatureRepeatPress);

  // set rotary encoder inputs and interrupts
  pinMode(PIN_ROTA, INPUT_PULLUP);
  pinMode(PIN_ROTB, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(PIN_ROTA), checkPosition, CHANGE);
  attachInterrupt(digitalPinToInterrupt(PIN_ROTB), checkPosition, CHANGE);  

  simMessage.SimMessageReceivedHandler = &handleSimMessageReceived;

  Wire.begin();

  // text display tests
  display.setTextSize(2);
  display.setTextWrap(false);
  display.setTextColor(SH110X_WHITE, SH110X_BLACK); // white text, black background

  lastEventMillis = millis();
}

void loop()
{
  // Update buttons
  for (uint8_t i = 0; i <= 12; i++)
  {
    buttons[i].check();
  }

  // Check the rotary encoder
  encoder.tick();
  int newPos = encoder.getPosition();
  bool increment = newPos > encoder_pos;

  // By default, the encoder considers a clockwise turn as decreasing;
  // We'll invert the direction by inverting the increment variable:
  increment = !increment;

  // If the rotary encoder changed position.
  if (encoder_pos != newPos)
  {
    byte data = 0b00000000;

    if (increment)
    {
      data = EVENT_ENCODER_INC;
    }
    else
    {
      data = EVENT_ENCODER_DEC;
    }

    // Send rotary encoder data to PC
    Serial.write(data);

    lastEventMillis = millis();
  }

  // Read data from PC if available
  simMessage.Receive(&Serial);

  if ((millis() - lastEventMillis) > EVENT_TIMER_MILLIS)
  {
    blankScreen = true;
  }
  else
  {
    blankScreen = false;
  }

  encoder_pos = newPos;
}

void handleButtonEvent(AceButton* button, uint8_t eventType, uint8_t /*buttonState*/)
{
  byte data = 0x00;
  switch(eventType)
  {
    case AceButton::kEventClicked:
      data = EVENT_KEY_CLICKED;
      break;
    case AceButton::kEventDoubleClicked:
      data = EVENT_KEY_DOUBLECLICK;
      break;
    case AceButton::kEventLongPressed:
      data = EVENT_KEY_LONGPRESS;
      break;
    case AceButton::kEventRepeatPressed:
      data = EVENT_KEY_REPEATPRESS;
      break;
    default:
      return;
  }

  uint8_t deviceID = button->getId();
  deviceID = deviceID << 3;
  data |= deviceID;

  Serial.write(data);

  lastEventMillis = millis();
}

void handleSimMessageReceived()
{
  uint8_t newState = simMessage.State;
  uint8_t previousPixel = currentPixel;
  uint8_t r = 255;
  uint8_t g = 255;
  uint8_t b = 255;

  switch(newState)
  {
    case STATE_COM1_MHZ:
      currentPixel = CONTROL_COM1 - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("COM1 MHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_COM1_KHZ:
      currentPixel = CONTROL_COM1 - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("COM1 KHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_COM2_MHZ:
      currentPixel = CONTROL_COM2 - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("COM2 MHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_COM2_KHZ:
      currentPixel = CONTROL_COM2 - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("COM2 KHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_NAV1_MHZ:
      currentPixel = CONTROL_NAV1 - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("NAV1 MHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_NAV1_KHZ:
      currentPixel = CONTROL_NAV1 - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("NAV1 KHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_NAV2_MHZ:
      currentPixel = CONTROL_NAV2 - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("NAV2 MHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_NAV2_KHZ:
      currentPixel = CONTROL_NAV2 - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("NAV2 KHz");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
        display.setCursor(0, 32);
        display.println(simMessage.Text2);
      }
      break;
    case STATE_HEADING:
      currentPixel = CONTROL_HDG - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("HDG");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_COURSE:
      currentPixel = CONTROL_CRS - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("CRS");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_ALTITUDE_1000:
      currentPixel = CONTROL_ALT - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("ALT 1000");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_ALTITUDE_100:
      currentPixel = CONTROL_ALT - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("ALT 100");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_VERTICAL_SPEED:
      currentPixel = CONTROL_VS - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("VS");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_XPND_1000:
      currentPixel = CONTROL_XPND - 1;
      r = 0; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("XPND 1000");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_XPND_100:
      currentPixel = CONTROL_XPND - 1;
      r = 0; g = 0; b = 255;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("XPND 100");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_XPND_10:
      currentPixel = CONTROL_XPND - 1;
      r = 255; g = 255; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("XPND 10");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_XPND_1:
      currentPixel = CONTROL_XPND - 1;
      r = 255; g = 0; b = 0;
      if (!blankScreen)
      {
        display.clearDisplay();
        display.setCursor(0, 0);
        display.println("XPND 1");
        display.setCursor(0, 16);
        display.println(simMessage.Text1);
      }
      break;
    case STATE_GPS_GROUP:
      currentPixel = CONTROL_GPS - 1;
      r = 0; g = 255; b = 0;
      break;
    case STATE_GPS_PAGE:
      currentPixel = CONTROL_GPS - 1;
      r = 0; g = 0; b = 255;
      break;
    case STATE_PFD_GROUP:
      currentPixel = CONTROL_PFD - 1;
      r = 0; g = 255; b = 0;
      break;
    case STATE_PFD_PAGE:
      currentPixel = CONTROL_PFD - 1;
      r = 0; g = 0; b = 255;
      break;
    case STATE_MFD_GROUP:
      currentPixel = CONTROL_MFD - 1;
      r = 0; g = 255; b = 0;
      break;
    case STATE_MFD_PAGE:
      currentPixel = CONTROL_MFD - 1;
      r = 0; g = 0; b = 255;
      break;
    default:
      break;
  }

  if (blankScreen)
  {
    display.clearDisplay();
  }

  display.display();

  // Turn off the previous button neopixel
  pixels.setPixelColor(previousPixel, pixels.Color(0, 0, 0));

  // Turn on the new button neopixel
  pixels.setPixelColor(currentPixel, pixels.Color(r, g, b));

  pixels.show();
}


//////////////////////////
// COM1 // COM2 // GPS  //
//////////////////////////
// NAV1 // NAV2 // PFD  //
//////////////////////////
// HDG  // CRS  // MFD  //
//////////////////////////
// ALT  //  VS  // XPND //
//////////////////////////

// COM1 First press : COM1_MHZ
// COM1 Second press: COM1_KHZ
// COM1 Rotary press: Swap standby with active
// COM2 First press : COM2_MHZ
// COM2 Second press: COM2_KHZ
// COM2 Rotary press: Swap standby with active
// NAV1 First press : NAV1_MHZ
// NAV1 Second press: NAV1_KHZ
// NAV1 Rotary press: Swap standby with active
// NAV2 First press : NAV2_MHZ
// NAV2 Second press: NAV2_KHZ
// NAV2 Rotary press: Swap standby with active
// HDG press        : HEADING
// HDG Rotary press : Toggle AP heading hold
// CRS press        : COURSE / OBS
// ALT First press  : Thousands
// ALT Second press : Hundreds
// ALT Rotary press : Toggle AP altitude hold
// VS press         : Hundreds
// VS Rotary press  : Toggle AP VS hold
// XPND First press : Thousands
// XPND Second press: Hundreds
// XPND Third press : Tens
// XPND Fourth press: Ones
// XPND Rotary press: Turn transponder on
// GPS First press  : GPS_GROUP
// GPS Second press : GPS_PAGE
// GPS Rotary press : GPS_CURSOR_BUTTON
// PFD First press  : G1000_PFD_GROUP_KNOB
// PFD Second press : G1000_PFD_PAGE_KNOB
// PFD Rotary press : G1000_PFD_CURSOR_BUTTON
// MFD First press  : G1000_MFD_GROUP_KNOB
// MFD Second press : G1000_MFD_PAGE_KNOB
// MFD Rotary press : G1000_MFD_CURSOR_BUTTON
