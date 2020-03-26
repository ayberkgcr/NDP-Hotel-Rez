/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:1
** ÖĞRENCİ ADI............:Ayberk GÖÇER
** ÖĞRENCİ NUMARASI.......:B181200020
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/







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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam, yeni, erkek,kadın,erkekara;

            toplam = Convert.ToInt32(maskedTextBox1.Text);
            yeni = Convert.ToInt32(maskedTextBox2.Text);
            erkek = Convert.ToInt32(textBox2.Text);
            kadın = Convert.ToInt32(textBox1.Text);

            int uygun = toplam - yeni;

            label6.Text ="Kullanılabilir Oda Sayısı :" +uygun;

            int erkektop = erkek;

            label2.Text = "Mevcut Erkek Misafir :" + erkektop;

            int kadıntop = kadın;

            label11.Text = "Mevcut Kadın Misafir :" + kadıntop;

            int french = 0,twin=0;

            /* radio button ile yatak tipi seçimi her tercihte 1 artıyor     */
             if (radioButton1.Checked) { french = french + 1; }
             if (radioButton2.Checked) { twin = twin + 1; }

            

            label9.Text = "Kullanılan French Bed :" + french;
            label10.Text = "Kullanılan Twin Bed :" + twin;
               
         



         
            

           
            


           



               

            
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
