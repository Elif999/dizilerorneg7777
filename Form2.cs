using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp47
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //kodun mantığını yapay zekaya söyleyebilirsin o da sana anlatabilir
        string[] isimler; // Öğrenci isimlerini tutacak dizi
        int[] ortalamalar; // Öğrenci ortalamalarını tutacak dizi
        int öğrencisayisi; // Toplam öğrenci sayısı
        int index = 0; // Şu anki öğrenci sayısını takip eden değişken
        private void button1_Click(object sender, EventArgs e)
        {
            if (öğrencisayisi == 0)
            {
                try
                {
                    // Öğrenci sayısını texbox3ten al
                    öğrencisayisi = int.Parse(textBox3.Text);
                    isimler = new string[öğrencisayisi]; // İsimler dizisini oluştur
                    ortalamalar = new int[öğrencisayisi]; // Ortalamalar dizisini oluştur
                }
                catch
                {
                    if(öğrencisayisi==0)
                    {
                        MessageBox.Show("öğrenci sayısını belirleyiniz");
                        return;
                    }
                }
            }
            try
            {
                isimler[index] = textBox1.Text; // İsim ekle
                ortalamalar[index] = int.Parse(textBox2.Text); // Ortalama ekle
                index++; // Bir sonraki öğrenciye geç
                         // TextBox'ları temizle
                textBox1.Clear();
                textBox2.Clear();
            }
            catch
            {
                if (index<öğrencisayisi)
                {
                    MessageBox.Show("Boş bırakılan yerleri belirtilen değerlerle doldurunuz");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Önceki verileri temizle
            for (int i = 0; i < index; i++)
            {
                // ListBox'a isim ve ortalamayı ekle
                listBox1.Items.Add(isimler[i] + " => " + ortalamalar[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)//kalan listesi
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] < 50)
                {
                    listBox1.Items.Add(isimler[i] + "=>" + ortalamalar[i]+"-Kaldı");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)//geçen listesi
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] >= 50)
                {
                    listBox1.Items.Add(isimler[i] + "=>" + ortalamalar[i]+"-Geçti");
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)//teşşekkür listesi
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] >70&& ortalamalar[i]<85)
                {
                    listBox1.Items.Add(isimler[i] + "=>" + ortalamalar[i]+"-Teşşekür :)");
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)//taktir listesi
        {
            listBox1.Items.Clear();
            for (int i=0;i<ortalamalar.Length;i++)
            {
                if (ortalamalar[i]>85 && ortalamalar[i] <=100)
                {
                    listBox1.Items.Add(isimler[i] + "=>" + ortalamalar[i]+"-Taktir :)");
                }
            }
        }
    }
}
