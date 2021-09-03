using System;

namespace MixerClone
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundDevices = new SoundDevices();

            if (args.Length<1 || args.Length>2)
            {
                Console.WriteLine("MixerClone <source>");
                Console.WriteLine("MixerClone <source> <target>");
                Console.WriteLine("clones any volume settings from <source> to <target> where <source> and <target> are one of the following guids:");
                Console.WriteLine("(empty target=Default output device)");
                Console.WriteLine();

                foreach (var soundcard in soundDevices.RetrieveAllCardNames())
                {
                    Console.WriteLine($"{soundcard.Key} - {soundcard.Value}");
                }
                return;
            }

            Guid targetGuid = Guid.Empty;
            if (args.Length > 1) targetGuid = new Guid(args[1]);
            soundDevices.CloneDevice(new Guid(args[0]), targetGuid);
            Console.WriteLine("Close window to stop cloning");

            while (true) System.Threading.Thread.Sleep(1000);
        }
    }
}
