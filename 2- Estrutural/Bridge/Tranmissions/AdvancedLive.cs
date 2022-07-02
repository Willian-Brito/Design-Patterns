using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bridge.Plataforms;

namespace Bridge.Tranmissions
{
    public class AdvancedLive : Live
    {

        public AdvancedLive(IPlataform plataform) : base(plataform) { }

        public void Subtitle()
        {
            System.Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            System.Console.WriteLine("Comentários liberados na live!");
        }

        public void Record()
        {
            System.Console.WriteLine("Gravação liberada na live!");
        }
    }
}