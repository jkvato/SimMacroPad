using System;
using System.Threading.Tasks;
using Hds.MacroLink.Serial;
using Hds.MacroPad;
using DevExpress.XtraEditors;
using Hds.MacroLink;

namespace MacroSimDX;

public partial class MainForm : XtraForm
{
   SerialMacroLinkTransport transport;
   MacroPadClient client;


   public MainForm()
   {
      InitializeComponent();

      transport = new SerialMacroLinkTransport("COM4", 115200);
      client = new MacroPadClient(transport);

      client.PadInputEventReceived += Client_PadInputEventReceived;

      // NEW: log all frames, regardless of type/length
      //transport.FrameReceived += Transport_FrameReceived;
   }

   private void Transport_FrameReceived(object? sender, MacroLinkFrame frame)
   {
      var payload = frame.Payload ?? Array.Empty<byte>();
      var payloadHex = BitConverter.ToString(payload);

      Invoke(() =>
      {
         memoOutput.AppendText(
            $"FrameReceived: Type=0x{frame.MessageType:X2}, Len={payload.Length}, Data={payloadHex}{Environment.NewLine}");
      });
   }
   private async void MainForm_Load(object sender, EventArgs e)
   {
      await transport.OpenAsync();

      if (transport.IsOpen)
      {
         memoOutput.AppendText("Transport opened successfully." + Environment.NewLine);
      }
      else
      {
         memoOutput.AppendText("Failed to open transport." + Environment.NewLine);
      }
   }

   private void Client_PadInputEventReceived(object? sender, byte e)
   {
      string hexString = e.ToString("X2");
      Invoke(() =>
      {
         memoOutput.AppendText($"Pad Input Event Received: 0x{hexString}{Environment.NewLine}");
      });
   }

   private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
   {
      await transport.CloseAsync();
   }

   private async void btnSend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
   {
      var msg = new SimMessage
      {
         MacroPadState = MacroPadState.ALTITUDE_100,
         Text1 = "Hello",
         Text2 = "World"
      };

      await client.SendSimMessageAsync(msg);

      memoOutput.AppendText("Sent SimMessage to MacroPad." + Environment.NewLine);
   }
}
