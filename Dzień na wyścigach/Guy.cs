using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Guy
    {
        public string Name; //imię faceta
        public Bet MyBet = new Bet();// instancja klasy BEt przechowujące dane o zakładzie
        public int Cash;//jak duzo pieniędzy posiada

        //ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton; //moje pole wyboru
        public Label MyLabel;//moje etykieta

        public Guy()
        {
            MyBet.Bettor = this;
        }

        public void UpdateLabels()
        {
            //Ustaw moje pole tekstowe na opis zakładu, a napis obok
            //pola wyobru, tak, aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet() //wyczyść mój zakład, aby był równy zero
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            //ustal nowy zakłąd i przechowaj go w polu MyBet
            //Zwróc true, jeżeli facet ma wystarczająca iloć pienięzy, aby obstawić
            if (Cash >= Amount)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = DogToWin;
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(Name + " nie ma wystarczająco pieniędzy by postawić taki zakład","Brak funduszy");
                return false;
            }
        }

        public void Collect(int Winner)
        {
            //Poproś o wypłąte zakłądu i zaktualizuj etykiety (użyj obiektu Bet)
            Cash += MyBet.PayOut(Winner);
        }
    }
}
