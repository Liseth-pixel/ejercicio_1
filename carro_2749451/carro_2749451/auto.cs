using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_2749451
{
    public class auto
    {
        public auto(string marca, string modelo, int velocidadMax, int velocidadAct)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VelocidadMax = velocidadMax;
            this.VelocidadAct = velocidadAct;
        }
        public string Marca;
        public string Modelo;
        public int VelocidadMax;
        public int VelocidadAct;

        public void Acelerar(int velocidad)
        {
            Console.WriteLine("Acelerando " + velocidad, " km/h");
        }
        public void Desacelerar(int velocidad)
        {
            Console.WriteLine("desacelerando " + velocidad, " km/h");
            this.VelocidadAct = velocidad - 5;
        }
    }
}
//marca, modelo, velocidad máxima, velocidad actual, acelera (de 5 en 5), decelera (de 5 en 5)
    
