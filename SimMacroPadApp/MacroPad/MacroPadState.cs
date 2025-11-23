namespace Hds.MacroPad;

/// <summary>
/// Example MacroPad state enum. You can replace or extend these values
/// to match your actual state machine.
/// </summary>
public enum MacroPadState : byte
{
   Unknown = 0,
   Flight = 1,
   Ground = 2,
   Menu = 3
   // etc.
}
