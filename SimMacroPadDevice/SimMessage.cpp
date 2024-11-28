#include <cstdint>
#include "Stream.h"
#include "SimMessage.h"
#include "Tones.h"

SimMessage::SimMessage()
{
  State = 0;
  messageState = MSGSTATE_PRE_SOH;
  for (textIndex = 0; textIndex < TEXT_LENGTH; textIndex++)
  {
    Text1[textIndex] = 0;
    Text2[textIndex] = 0;
  }
  textIndex = 0;
  SimMessageReceivedHandler = NULL;
}


bool SimMessage::Receive(Stream* stream)
{
  int lastByteRead = stream->read();
  if (lastByteRead < 0)
  {
    return false;
  }

  switch(messageState)
  {
    case MSGSTATE_PRE_SOH:
      if (lastByteRead == ASCII_SOH)
      {
        messageState = MSGSTATE_STATE;
      }
      else
      {
      }
      break;
    case MSGSTATE_STATE:
      State = lastByteRead;
      textIndex = 0;
      messageState = MSGSTATE_TEXT1;
      break;
    case MSGSTATE_TEXT1:
      Text1[textIndex] = lastByteRead;
      textIndex++;

      if (textIndex >= TEXT_LENGTH)
      {
        messageState = MSGSTATE_TEXT2;
        textIndex = 0;
      }
      break;
    case MSGSTATE_TEXT2:
      Text2[textIndex] = lastByteRead;
      textIndex++;

      if (textIndex > TEXT_LENGTH)
      {
        messageState = MSGSTATE_PRE_EOT;
        textIndex = 0;
      }
      break;
    case MSGSTATE_PRE_EOT:
      if (lastByteRead == ASCII_EOT)
      {
        messageState = MSGSTATE_PRE_SOH;
        if (SimMessageReceivedHandler != NULL)
        {
          SimMessageReceivedHandler();
        }
        return true;
      }
      break;
    default:
      break;
  }

/*
  while (stream->available())
  {
    tone(PIN_SPEAKER, TONE_Cn4, 200);
    delay(100);

    // If we're waiting to start reading a message
    if (messageState == MSGSTATE_PRE_SOH)
    {
      tone(PIN_SPEAKER, TONE_Cn5, 200);
      delay(100);

      lastByteRead = stream->read();
      if (lastByteRead == ASCII_SOH)
      {
        messageState = MSGSTATE_STATE;
        tone(PIN_SPEAKER, 988, 200);
        delay(100);
      }
      else
      {
        tone(PIN_SPEAKER, 247, 200);
        delay(100);
      }
    }
    continue;

    // If we are reading the board state
    if (messageState == MSGSTATE_STATE)
    {
      tone(PIN_SPEAKER, TONE_Cn6, 200);
      delay(100);
      
      lastByteRead = stream->read();
      State = lastByteRead;
      tone(PIN_SPEAKER, 1047, 200);
      delay(100);

      textIndex = 0;
      messageState = MSGSTATE_TEXT;
      continue;
    }

    // If we are reading the text
    if (messageState == MSGSTATE_TEXT)
    {
      tone(PIN_SPEAKER, TONE_Cn7, 200);
      delay(100);
      
      if (textIndex < TEXT_LENGTH)
      {
        lastByteRead = stream->read();
        Text[textIndex] = lastByteRead;
        tone(PIN_SPEAKER, 1175, 200);
        delay(100);

        textIndex++;

        if (textIndex > TEXT_LENGTH)
        {
          tone(PIN_SPEAKER, 1319, 200);
          delay(100);

          messageState = MSGSTATE_PRE_EOT;
          textIndex = 0;
        }
        continue;
      }
    }

    // If we are waiting for End Of Transmission
    if (messageState == MSGSTATE_PRE_EOT)
    {
      tone(PIN_SPEAKER, 523, 200);
      delay(100);

      lastByteRead = stream->read();
      if (lastByteRead == ASCII_EOT)
      {
        messageState = MSGSTATE_PRE_SOH;
        if (SimMessageReceivedHandler != NULL)
        {
          tone(PIN_SPEAKER, 3951, 400);
          delay(200);
          
          SimMessageReceivedHandler();
        }
        return true;
      }
    }
  }
  */

  // We didn't complete a message, so return false
  return false;
}