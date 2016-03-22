using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        public Greyhound[] GreyhoundArray = new Greyhound[4];
        public Guy[] GuyArray = new Guy[3];
        public  Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGuys();
            CreatingGreyhounds();
        }

        public void InitializeGuys()
        {
            GuyArray[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = joeradioButton1, MyLabel = joeBetLabel};
            GuyArray[0].UpdateLabels();

            GuyArray[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = bobradioButton, MyLabel = bobBetLabel };
            GuyArray[1].UpdateLabels();

            GuyArray[2] = new Guy() { Name = "Al", Cash = 5, MyRadioButton = alradioButton, MyLabel = alBetLabel };
            GuyArray[2].UpdateLabels();
        }

        #region Kod aktualizujący położenie kontroli MyPictureBox 
        public void CreatingGreyhounds() // dodaj for'a
        {
            for (int i = 0; i < 4; i++)
            {
                GreyhoundArray[i] = new Greyhound()
                {
                    StartinPosition = pictureBox1.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                    MyRandom = MyRandomizer
                };
            }

            GreyhoundArray[0].MyPictureBox = pictureBox1;
            GreyhoundArray[1].MyPictureBox = pictureBox2;
            GreyhoundArray[2].MyPictureBox = pictureBox3;
            GreyhoundArray[3].MyPictureBox = pictureBox4;          
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) //pęla po wszyskich chartach
            {
                if (GreyhoundArray[i].Run()) //w ifie - wywołaj metodę Run() psa
                {
                    //mamy zwycięzce!
                    //wywołaj metodę timer1.Stop(), by zatrzymać psy
                    //wyświetl komunikat z informacją, kto wygrał
                    //każdy facet może odebrać wygraną

                    timer1.Stop();      
                    MessageBox.Show("Wygrał chart z numerem: " + (i+1),"Koniec wyścigu");
                    for (int j = 0; j < 4; j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    for (int k = 0; k < 3; k++ )
                    {
                        GuyArray[k].Collect(i+1);
                        GuyArray[k].ClearBet();
                        GuyArray[k].UpdateLabels();
                    }
                    groupBox1.Enabled = true;

                }
            }
        }

        private void joeradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobradioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alradioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        private void stawiabutton_Click(object sender, EventArgs e)
        {
            if(joeradioButton1.Checked)
            {
                GuyArray[0].PlaceBet((int)numericUpDown1.Value,(int)numericUpDown2.Value);
            }
            else if (bobradioButton.Checked)
            {
                GuyArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            else if (alradioButton.Checked)
            {
                GuyArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

    }
}
