using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularProject.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O {nomeApp} foi instalado no Iphone. ");
        }
    }
}