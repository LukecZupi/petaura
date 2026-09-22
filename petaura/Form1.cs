using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace petaura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prvih 8 sodih stevil ki ni dejivo s 6
            StreamWriter sw = File.CreateText("stevila1.txt");
            int st = 2;
            int stevec = 0;
            while (stevec != 8)
            {
                if (st % 6 != 0)
                {
                    sw.Write(st + "/");
                    st += 2;
                    stevec++;
                }
                else
                {
                    st += 2;
                }
                /*
                {
                    sw.Write(st + "/");
                    st += 2;
                }*/
            }
            sw.Close();
            MessageBox.Show("Stevila so zapisana");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ustvarimo objekt za izbiro nakljucnih stevil
            Random nakljucna = new Random();
            int spodnja = Convert.ToInt32(numericUpDown1.Value);
            int zgornja = Convert.ToInt32(numericUpDown2.Value);
            StreamWriter sw = File.CreateText("nakljucna.txt");
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(nakljucna.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value));
            }
            sw.Close();
        }
        
    }
}