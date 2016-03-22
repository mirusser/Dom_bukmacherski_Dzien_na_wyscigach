using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class Bet
    {
        public int Amount;//ilość postawionych pieniedzy
        public int Dog;//numer psa, na którego postawiono
        public Guy Bettor;//Facet, który zawarł zakład

        public string GetDescription()
        {
            //Zwraca string, który określa, kto obstawił wyścig, jak dużo pieniędzy
            //postawił  i na którego psa ("Janek postawił 8zł na psa numer 4").
            //Jeżeli ilość jest rówa zero, zakład nie został zawarty
            //("Janek nie zawarł zakładu")
 
            if(Amount>=5 && Amount<=15)
            {
                return Bettor.Name + " postawił " + Amount + " zł na psa numer" + Dog;
            }
            else
            {
                return this.Bettor.Name + " nie zawarł zakładu";
            }
        }

        public int PayOut(int Winner)
        {
            // Parametrem jest zwyciezca wyścigu. Jeżeli pies wygrał,
            // zwróc wartość postawioną. W przeciwnym razie zwróc wartość
            //postawioną ze znakiem minus
            if (Winner == Dog)  /*mój chart zwyciężył*/
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
