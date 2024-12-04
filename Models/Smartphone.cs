using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularProject.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero {get => _numero;  set => _numero = value;}
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}