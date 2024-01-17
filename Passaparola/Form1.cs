using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
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

        int soruno = 0, dogru = 0, yanlis = 0  ;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch(soruno)
                {
                    case 1:
                        if(textBox1.Text == "akdeniz") { button1.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString();  }
                        else { button1.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa") { button2.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        
                        else { button2.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma") { button3.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button3.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır") { button4.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button4.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski") { button5.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button5.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman") { button6.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button6.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş") { button7.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button7.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı") { button8.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button8.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta") { button9.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button9.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel") { button10.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button10.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma") { button11.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button11.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı") { button12.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button12.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale") { button13.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button13.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart") { button14.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button14.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney") { button15.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button15.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan") { button16.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button16.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa") { button17.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button17.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan") { button18.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button18.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake") { button19.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button19.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan") { button20.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button20.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut") { button21.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button21.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "yıldırım") { button22.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button22.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "zeytin") { button23.BackColor = Color.Green; dogru++; label1.Text = dogru.ToString(); }
                        else { button23.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;




                }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text=soruno.ToString();

           

            if(soruno == 1) {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;

            }
           
            if(soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Evlerin zeminine serilen iplikten yapılan eşya?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi nedir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzelerle yapılan yemek?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın sultanı?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan ve yağı da yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Yellow;
            }

        }
    }
}
