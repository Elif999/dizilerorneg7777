namespace WinFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()// ****** BU KODUN MANTIÐINI YAPAY ZEKADAN ÖÐREN*************
        {
            InitializeComponent();
        }

        int[,] dizi;
        int satirsayisi;
        int sütunsayisi;

        private void button1_Click(object sender, EventArgs e)
        {
            satirsayisi = Convert.ToInt32(textBox1.Text);//satir sayisini texboxtan aldýk
            sütunsayisi = Convert.ToInt32(textBox2.Text);//sutun sayýsýný texboxtan aldýk
            dizi = new int[satirsayisi, sütunsayisi];//dizi formatýnda satýr sayýsýný sutun sayýsýna dizi þekline formatýna getirdik***//Bunda Neden new int koyduk
            int rastgeleMin = Convert.ToInt32(textBox3.Text);//rastgele deðer aralýðýný texboxtan aldýk
            int rastgeleMax = Convert.ToInt32(textBox4.Text);// rastgele deðer aralýðýný texboxtan aldýk
            Random rastgele = new Random();
            for (int x = 0; x < satirsayisi; x++)
            {
                for (int y = 0; y < sütunsayisi; y++)
                {
                    dizi[x, y] = rastgele.Next(rastgeleMin, rastgeleMax);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int x=0;x<satirsayisi;x++)
            {
                for(int y=0;y<sütunsayisi;y++)
                {
                    listBox1.Items.Add(x + ","+y + "=>" + dizi[x, y]);
                }
            }
        }
    }
}
/*
 
Dýþ Döngü (Satýrlar)
Ýlk Dönüþ (x = 0):

Ýç döngü baþlar.
y 0'dan 2'ye kadar döner (0, 1, 2).
Bu döngüde dizi[0, 0], dizi[0, 1], ve dizi[0, 2] elemanlarýna rastgele sayýlar atanýr.
Ýkinci Dönüþ (x = 1):

Ýç döngü tekrar baþlar.
y yine 0'dan 2'ye kadar döner (0, 1, 2).
Bu döngüde dizi[1, 0], dizi[1, 1], ve dizi[1, 2] elemanlarýna rastgele sayýlar atanýr.

*/



/*
 You=neden sadece 1 ve 9 deðerleri alýyorda aralýðýndaki deðerleri niye ve nasýl alýyorki 

BLACKBOX.ai= Random kuralýdýr*                                                                                                                                  
Minimum ve Maksimum Deðerler: Random.Next(rastgeleMin, rastgeleMax) metodu, belirtilen aralýkta rastgele bir tamsayý üretir. 
Burada rastgeleMin deðeri dahil edilirken, rastgeleMax deðeri hariç tutulur. 
Yani, eðer rastgeleMin 1 ve rastgeleMax 10 olarak ayarlanmýþsa, üretilen rastgele sayýlar 1 ile 9 arasýnda olacaktýr.

Aralýkta Neden Diðer Deðerler Alýnýyor?
Aralýk Tanýmý: rastgeleMin ve rastgeleMax deðerleri arasýndaki tüm tamsayýlar, rastgele.Next metodu tarafýndan üretilir.
Bu durumda, 1 ile 9 arasýndaki tüm tamsayýlar (1, 2, 3, 4, 5, 6, 7, 8, 9) geçerli sonuçlar olarak dönebilir.

Örnek Durum
Eðer kullanýcý rastgeleMin olarak 1 ve rastgeleMax olarak 10 girerse:
Üretilen rastgele sayýlar: 1, 2, 3, 4, 5, 6, 7, 8, 9
10 sayýsý dahil edilmez çünkü rastgeleMax deðeri hariç tutulur.

Sonuç
Rastgele Sayý Üretimi: Random.Next metodu, belirlenen aralýkta rastgele sayýlar üretmek için kullanýlýr. 
Bu sayede, kullanýcý tarafýndan belirlenen minimum ve maksimum deðerler arasýnda rastgele sayýlar elde edilir.         
*/