using System;
using Bridge.Plataforms;
using Bridge.Tranmissions;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StartLiveAdvanced(new YouTube());
            StartLiveAdvanced(new Vimeo());
            StartLive(new Facebook());
            StartLive(new TwitchTV());

            Console.ReadKey();
        }

        static void StartLive(IPlataform plataform)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Aguarde...");

            var live = new Live(plataform);

            live.Broadcasting();
            live.ResultTransmissions();
        }

        static void StartLiveAdvanced(IPlataform plataform)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Aguarde...");

            var live = new AdvancedLive(plataform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.ResultTransmissions();
        }
    }
}