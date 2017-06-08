using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoNamespace
{
    [Serializable]
    class Token
    {

        private string haslo = " ";
        public Token()
        {
            haslo = " ";
        }
        public string ZwrocToken()
        {
            return haslo;
        }
        public bool PorownajToken(string i)
        {
            if (i == haslo)
                return true;
            else
                return false;
        }
        public void GenerujToken()
        {
           
            haslo = "Generowane" ;
        }
    }
}
