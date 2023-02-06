using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        int clicks ;
        int wins =0; 
        List<int> choosenNumbers = new List<int>();
        private void label3_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(2);
                label3.BackColor = Color.Blue;
                label3.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(3);
                label4.BackColor = Color.Blue;
                label4.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(12);
                label8.BackColor = Color.Blue;
                label8.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (clicks <= 5) 
            {
                choosenNumbers.Add(1);
                label2.BackColor = Color.Blue;
                label2.ForeColor = Color.White;
                clicks += 1;
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(4);
                label5.BackColor = Color.Blue;
                label5.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(5);
                label6.BackColor = Color.Blue;
                label6.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(6);
                label7.BackColor = Color.Blue;
                label7.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(7);
                label13.BackColor = Color.Blue;
                label13.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(8);
                label12.BackColor = Color.Blue;
                label12.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(9);
                label11.BackColor = Color.Blue;
                label11.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(10);
                label10.BackColor = Color.Blue;
                label10.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(11);
                label9.BackColor = Color.Blue;
                label9.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(13);
                label19.BackColor = Color.Blue;
                label19.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(14);
                label18.BackColor = Color.Blue;
                label18.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(15);
                label17.BackColor = Color.Blue;
                label17.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(16);
                label16.BackColor = Color.Blue;
                label16.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(17);
                label15.BackColor = Color.Blue;
                label15.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(18);
                label14.BackColor = Color.Blue;
                label14.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(19);
                label25.BackColor = Color.Blue;
                label25.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(20);
                label24.BackColor = Color.Blue;
                label24.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(21);
                label23.BackColor = Color.Blue;
                label23.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(22);
                label22.BackColor = Color.Blue;
                label22.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(23);
                label21.BackColor = Color.Blue;
                label21.ForeColor = Color.White;
                clicks += 1;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (clicks <= 5)
            {
                choosenNumbers.Add(24);
                label20.BackColor = Color.Blue;
                label20.ForeColor = Color.White;
                clicks += 1;
                
            }
        }

        private void lbl_draw_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int randomNumber1 = rdm.Next(1,24);
            int randomNumber2 = rdm.Next(1,24);
            int randomNumber3 = rdm.Next(1,24);
            int randomNumber4 = rdm.Next(1,24);
            int randomNumber5 = rdm.Next(1,24);
            int randomNumber6 = rdm.Next(1,24);

            lbl_draw.Text = randomNumber1.ToString()+" "+ randomNumber2.ToString()+" "+
                randomNumber3.ToString()+" "+ randomNumber4.ToString()+" "+ randomNumber5.ToString()+" "+ randomNumber6.ToString();
            
            List<int> winningNumber = new List<int>();
            winningNumber.Add(randomNumber1);
            winningNumber.Add(randomNumber2);
            winningNumber.Add(randomNumber3);
            winningNumber.Add(randomNumber4);
            winningNumber.Add(randomNumber5);
            winningNumber.Add(randomNumber6);

            

            for (int i = 0; i < choosenNumbers.Count; i++)
            {
                for (int j = 0; j < winningNumber.Count; j++)
                {
                    if (choosenNumbers[i] == winningNumber[j])
                    {
                        wins += 1;
                    }
                }
            }

            MessageBox.Show("Correct Numbers : "+wins);
        }

       
    }
}
