using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoNamespace
{
    [Serializable]
    class Miejsce
    {
        
        public bool StanRezerwacja { get; set; }
        public bool StanZakup { get; set; }
        public int NrMiejsca { get; set; }
        public Token haslo = new Token();
       
        public void ustawToken()
        {
            haslo = new Token();
            haslo.GenerujToken();
        }
        
        public void ZakupZarezerwowane(string i)
        {
            if(haslo.PorownajToken(i))
            {
                StanZakup = true;
            }
        }
    }
}
