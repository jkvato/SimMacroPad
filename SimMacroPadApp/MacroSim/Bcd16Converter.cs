using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim;

public static class Bcd16Converter
{
   /// <summary>
   /// Converts a non-negative number (0–9999) to 16-bit packed BCD.
   /// Each decimal digit is stored in a 4-bit nibble.
   /// </summary>
   /// <param name="value">The value to encode (fractional part is rounded).</param>
   /// <returns>BCD16-encoded value as a <see cref="ushort"/>.</returns>
   /// <exception cref="ArgumentOutOfRangeException">
   /// Thrown if the value is negative or exceeds 9999 after rounding.
   /// </exception>
   public static ushort ToBcd16(double value)
   {
      if (value < 0)
         throw new ArgumentOutOfRangeException(nameof(value), "BCD16 cannot represent negative values.");

      int intValue = (int)Math.Round(value, MidpointRounding.AwayFromZero);

      return ToBcd16(intValue);   // delegate to the int version
   }

   // ============================
   //  INT → BCD16  (NEW)
   // ============================
   /// <summary>
   /// Converts an integer (0–9999) to 16-bit packed BCD.
   /// </summary>
   public static ushort ToBcd16(int value)
   {
      if (value < 0 || value > 9999)
         throw new ArgumentOutOfRangeException(nameof(value), "BCD16 supports integers 0–9999.");

      ushort bcd = 0;
      int shift = 0;

      int remaining = value;

      while (shift < 16)
      {
         int digit = remaining % 10;
         bcd |= (ushort)(digit << shift);
         remaining /= 10;
         shift += 4;

         if (remaining == 0)
            break;
      }

      return bcd;
   }

   /// <summary>
   /// Decodes a 16-bit packed BCD value to a double (0–9999).
   /// </summary>
   /// <param name="bcd">The BCD16 value to decode.</param>
   /// <returns>The decoded value as a <see cref="double"/>.</returns>
   /// <exception cref="ArgumentException">
   /// Thrown if any nibble contains a value greater than 9 (invalid BCD digit).
   /// </exception>
   public static double FromBcd16ToDouble(ushort bcd)
   {
      return FromBcd16ToInt(bcd);
   }

   // ============================
   //  BCD16 → INT  (NEW)
   // ============================
   /// <summary>
   /// Decodes a valid 16-bit BCD value into an integer (0–9999).
   /// </summary>
   public static int FromBcd16ToInt(ushort bcd)
   {
      int value = 0;
      int multiplier = 1;

      for (int shift = 0; shift < 16; shift += 4)
      {
         int digit = (bcd >> shift) & 0xF;

         if (digit > 9)
            throw new ArgumentException("Invalid BCD digit (>9) encountered.", nameof(bcd));

         value += digit * multiplier;
         multiplier *= 10;
      }

      return value;
   }
}
