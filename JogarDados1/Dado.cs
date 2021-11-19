using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarDados1
{
    public class Dado
    {
        private int lados;

        public Dado(int lado)
        {
            this.lados = lado;
        }



        public static string Rolar(int lado)
        {
            Random random = new Random();
            
            
            int result = random.Next(1, (lado + 1));

            return result.ToString();
        }


    }
}
