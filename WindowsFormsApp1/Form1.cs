using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTarihEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime tarih = DateTime.Now;

            for(int i = 1945; i <= tarih.Year; i++)
            {
                if(i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        } //DateTime kullanımı

        private void BtnDizi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int[] dizi = new int[3];
            string[] sehirler = new string[3] { "İstanbul", "Sivas", "Ankara"};
            char[] karakter = { 'A', 'b', 'D', 'X' };

            for (int i = 0; i < 3; i++)
            {
                dizi[i] = rnd.Next(50,100);
                listBox1.Items.Add(dizi[i]);
                listBox1.Items.Add(sehirler[i]);
                listBox1.Items.Add(karakter[i].ToString());
            }
        } //Dizi oluşturma
    }
}
