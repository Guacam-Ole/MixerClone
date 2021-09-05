using System;
using System.IO;
using System.Text;

namespace MixerClone
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundDevices = new SoundDevices();

            if (args.Length<1 || args.Length>2)
            {
                var builder = new StringBuilder();
                builder.AppendLine("MixerClone <source>");
                builder.AppendLine("MixerClone <source> <target>");
                builder.AppendLine("clones any volume settings from <source> to <target> where <source> and <target> are one of the following guids:");
                builder.AppendLine("(empty target=Default output device)");
                builder.AppendLine();

                foreach (var soundcard in soundDevices.RetrieveAllCardNames())
                {
                    builder.AppendLine($"{soundcard.Key} - {soundcard.Value}");
                }
                var filename = Path.Combine(Environment.CurrentDirectory, "cards.txt");
                using (var helpWriter = File.CreateText(filename))
                {
                    helpWriter.Write(builder.ToString());
                }
                System.Diagnostics.Process.Start("cmd.exe", "/c "+filename);
                return;
            }

            Guid targetGuid = Guid.Empty;
            if (args.Length > 1) targetGuid = new Guid(args[1]);
            soundDevices.CloneDevice(new Guid(args[0]), targetGuid);
            while (true) System.Threading.Thread.Sleep(1000);
        }
    }
}
