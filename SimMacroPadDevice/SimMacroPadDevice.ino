#include <Adafruit_SH110X.h>
#include <Adafruit_NeoPixel.h>
#include <RotaryEncoder.h>
#include <Wire.h>
#include <Keyboard.h>
#include <AceButton.h>

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

//AceButton rotaryButton(0, HIGH, 0);
// AceButton key01(1);
// AceButton key02(2);
// AceButton key03(3);
// AceButton key04(4);
// AceButton key00(0);

AceButton buttons[13];

void handleButtonEvent(AceButton*, uint8_t, uint8_t);

// Create the neopixel strip with the built in definitions NUM_NEOPIXEL and PIN_NEOPIXEL
Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUM_NEOPIXEL, PIN_NEOPIXEL, NEO_GRB + NEO_KHZ800);

// Create the OLED display
Adafruit_SH1106G display = Adafruit_SH1106G(128, 64, &SPI1, OLED_DC, OLED_RST, OLED_CS);

// Create the rotary encoder
// FOUR3, TWO03, FOUR0
// TWO03 rotates several positions at a time
RotaryEncoder encoder(PIN_ROTA, PIN_ROTB, RotaryEncoder::LatchMode::FOUR3);

void checkPosition() {  encoder.tick(); } // just call tick() to check the state.
// our encoder position state
int encoder_pos = 0;

// Keep track of which pixel is currently illuminated
int currentPixel = 0;

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

  // rotaryButton.setEventHandler(handleButtonEvent);
  // key01.setEventHandler(handleButtonEvent);

  // Configure the ButtonConfig with the event handler.
  ButtonConfig* buttonConfig = ButtonConfig::getSystemButtonConfig();
  buttonConfig->setEventHandler(handleButtonEvent);
  buttonConfig->setFeature(ButtonConfig::kFeatureClick);
  buttonConfig->setFeature(ButtonConfig::kFeatureDoubleClick);
  buttonConfig->setFeature(ButtonConfig::kFeatureLongPress);
  buttonConfig->setFeature(ButtonConfig::kFeatureRepeatPress);

  //buttonConfig->setFeature(ButtonConfig::kFeatureSuppressClickBeforeDoubleClick);
  //buttonConfig->setFeature(ButtonConfig::kFeatureSuppressAfterClick);
  //buttonConfig->setFeature(ButtonConfig::kFeatureSuppressAfterDoubleClick);

  // set rotary encoder inputs and interrupts
  pinMode(PIN_ROTA, INPUT_PULLUP);
  pinMode(PIN_ROTB, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(PIN_ROTA), checkPosition, CHANGE);
  attachInterrupt(digitalPinToInterrupt(PIN_ROTB), checkPosition, CHANGE);  

  // text display tests
  display.setTextSize(1);
  display.setTextWrap(false);
  display.setTextColor(SH110X_WHITE, SH110X_BLACK); // white text, black background
}

void loop()
{
  //display.clearDisplay();
  //display.setCursor(0,0);
  //display.println("* Adafruit Macropad *");

  // Update buttons
  //rotaryButton.check();
  // key01.check();
  // key02.check();
  // key03.check();
  // key04.check();
  for (uint8_t i = 0; i <= 12; i++)
  {
    buttons[i].check();
  }

  // Check the rotary encoder
  encoder.tick();
  int newPos = encoder.getPosition();
  bool increment = newPos > encoder_pos;

  //display.setCursor(0, 8);
  //display.print("Rotary encoder: ");
  //display.print(encoder_pos);

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

    Serial.write(data);

    // Update pixels to indicate when the encoder has changed position
    // Turn off current pixel before changing it
    //pixels.setPixelColor(currentPixel, pixels.Color(0, 0, 0));

    // Increment or decrement the current pixel as necessary
    if (increment)
    {
      currentPixel++;
    }
    else
    {
      currentPixel--;
    }

    // Check min and max current pixel
    if (currentPixel < 0)
    {
      currentPixel = NUM_NEOPIXEL - 1;
    }
    else if (currentPixel >= (NUM_NEOPIXEL))
    {
      currentPixel = 0;
    }

    // Turn on new current pixel
    // pixels.setPixelColor(currentPixel, pixels.Color(255, 255, 255));
    // pixels.show();

  }



  //pixels.setPixelColor(3, pixels.Color(0, 255, 0));

  if (Serial.available() > 0)
  {
    //char input = Serial.read();
    uint8_t input = Serial.read();
    //uint8_t currentPixel = 0;
    uint8_t previousPixel = currentPixel;
    uint8_t r = 255;
    uint8_t g = 255;
    uint8_t b = 255;

    switch(input)
    {
      case STATE_COM1_MHZ:
        currentPixel = CONTROL_COM1 - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_COM1_KHZ:
        currentPixel = CONTROL_COM1 - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_COM2_MHZ:
        currentPixel = CONTROL_COM2 - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_COM2_KHZ:
        currentPixel = CONTROL_COM2 - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_NAV1_MHZ:
        currentPixel = CONTROL_NAV1 - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_NAV1_KHZ:
        currentPixel = CONTROL_NAV1 - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_NAV2_MHZ:
        currentPixel = CONTROL_NAV2 - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_NAV2_KHZ:
        currentPixel = CONTROL_NAV2 - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_HEADING:
        currentPixel = CONTROL_HDG - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_COURSE:
        currentPixel = CONTROL_CRS - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_ALTITUDE_1000:
        currentPixel = CONTROL_ALT - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_ALTITUDE_100:
        currentPixel = CONTROL_ALT - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_VERTICAL_SPEED:
        currentPixel = CONTROL_VS - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_XPND_1000:
        currentPixel = CONTROL_XPND - 1;
        r = 0; g = 255; b = 0;
        break;
      case STATE_XPND_100:
        currentPixel = CONTROL_XPND - 1;
        r = 0; g = 0; b = 255;
        break;
      case STATE_XPND_10:
        currentPixel = CONTROL_XPND - 1;
        r = 255; g = 255; b = 0;
        break;
      case STATE_XPND_1:
        currentPixel = CONTROL_XPND - 1;
        r = 255; g = 0; b = 0;
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

    pixels.setPixelColor(previousPixel, pixels.Color(0, 0, 0));
    pixels.setPixelColor(currentPixel, pixels.Color(r, g, b));
    // if (currentPixel > 0)
    // {
    //   currentPixel -= 1;
    //   //pixels.setPixelColor(currentPixel, pixels.Color(intensity, intensity, intensity));
    // }
  }
  else
  {
    //pixels.setPixelColor(11, pixels.Color(255, 0, 0));
  }

  pixels.show();

  
  // if (encoder_pos != newPos)
  // {
  //   Serial.print(encoder_pos);
  //   Serial.print(", ");
  //   Serial.print(newPos);
  //   Serial.print(", ");
  //   Serial.print(increment);
  //   Serial.println();

  //   if (increment)
  //   {
  //     Serial.println("increment");
  //     switch (current_state)
  //     {
  //       case NAV1_KHZ:
  //         Keyboard.press(KEY_LEFT_SHIFT);
  //         Keyboard.press(KEY_LEFT_CTRL);
  //         Keyboard.press(KEY_PAGE_UP);
  //         delay(50);
  //         Keyboard.releaseAll();
  //         break;
  //       case ALTITUDE:
  //         Keyboard.press(KEY_LEFT_CTRL);
  //         Keyboard.press(KEY_PAGE_UP);
  //         delay(50);
  //         Keyboard.releaseAll();
  //         break;
  //     }
  //   }
  //   // decrease
  //   else
  //   {
  //     Serial.println("Decrease");
  //     switch (current_state)
  //     {
  //       case NAV1_KHZ:
  //         Keyboard.press(KEY_LEFT_SHIFT);
  //         Keyboard.press(KEY_LEFT_CTRL);
  //         Keyboard.press(KEY_PAGE_DOWN);
  //         delay(50);
  //         Keyboard.releaseAll();
  //         break;
  //       case ALTITUDE:
  //         Keyboard.press(KEY_LEFT_CTRL);
  //         Keyboard.press(KEY_PAGE_DOWN);
  //         delay(50);
  //         Keyboard.releaseAll();
  //         break;
  //     }
  //   }
  //}

  encoder_pos = newPos;

  // // Check buttons
  // for (int i = 1; i <= 12; i++)
  // {
  //   // See if a button was pressed
  //   if (!digitalRead(i))
  //   {
  //     switch (i)
  //     {
  //       case 1:
  //         if (current_state == COM1_KHZ)
  //           current_state = COM1_MHZ;
  //         else
  //           current_state = COM1_KHZ;
  //         break;
  //       case 2:
  //         if (current_state == COM2_KHZ)
  //           current_state = COM2_MHZ;
  //         else
  //           current_state = COM2_KHZ;
  //         break;
  //       case 4:
  //         if (current_state == NAV1_KHZ)
  //           current_state = NAV1_MHZ;
  //         else
  //           current_state = NAV1_KHZ;
  //         break;
  //       case 5:
  //         if (current_state == NAV2_KHZ)
  //           current_state = NAV2_MHZ;
  //         else
  //           current_state = NAV2_KHZ;
  //         break;
  //       case 7:
  //         current_state = HEADING;
  //         break;
  //       case 8:
  //         current_state = ALTITUDE;
  //         break;
  //     }
  //   }
  // }

  //display.setCursor(0, 8);
  //display.print("Rotary encoder: ");
  //display.print(encoder_pos);
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
