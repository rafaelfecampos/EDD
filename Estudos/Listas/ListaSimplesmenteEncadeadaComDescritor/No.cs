using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSimplesmenteEncadeadaComDescritor
{
    public class No
    {
        public int Valor { get; set; }

        private No proximo = null;
        public No Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        
    }
}