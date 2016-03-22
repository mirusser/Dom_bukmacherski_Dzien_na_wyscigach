using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Greyhound //klasa opisująca Charta (psa)
    {
        public int StartinPosition;//miejsce, gdzie rozpoczyna się PictureBox
        public int RacetrackLength;//jak długa jest trasa
        public PictureBox MyPictureBox = null;//mój obiekt PictureBox
        public int Location = 0; // Moje połozenie na torze wyścigowym
        public Random MyRandom;//instancja klasy Random

        public bool Run()
        {
            //Przesuń się do przodu losowo o 1,2,3 lub 4 punkty (pola,jednostki)
            //zaktualizuj położenie PictureBox na formularzu
            //zwróc true, jeżeli wygrałem wyścig

            MyPictureBox.Left += MyRandom.Next(1, 4);
            Location = MyPictureBox.Left;

            if(Location >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            //wyzeruj położenie i ustaw na linii startowej (ustawienie jednej zmiennej obiekt.left = 0?)
            Location = 0;
            MyPictureBox.Left = 0;
        }

    }
}
