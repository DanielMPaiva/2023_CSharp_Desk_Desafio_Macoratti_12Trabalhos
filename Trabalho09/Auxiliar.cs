using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho09
{
    internal class Auxiliar
    {
        public void ParametroPorValor(int n)
        {
            n++;
        }

        public  void ParametroPorReferencia(ref int n)
        {
            n++;
        }
    }
}
