using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Calculo
    {
        private Double baseRetangulo;
        
        public Double BaseRetangulo
        { get { return baseRetangulo; }
          set { baseRetangulo = value; }
        }
        private Double alturaRetangulo;
        
        public Double AlturaRetangulo
        { get { return alturaRetangulo; }
          set { alturaRetangulo = value; }
        }

        //propriedade area
        private double retangulo;
        //metodo para calcular area
        public void CalculoArea() 
        {
            retangulo = this.baseRetangulo * this.alturaRetangulo;
        }

        //metodo para exibir area calculada

        public void ExibirArea()
        {
            Console.WriteLine("Area do retangulo: " + retangulo+"m²");
        }

        public void ExibirValores()
        {
            Console.WriteLine("A base vale = "+this.baseRetangulo+"m²\nA altura equivale = "+this.alturaRetangulo+"m²");

        }
    }
}
