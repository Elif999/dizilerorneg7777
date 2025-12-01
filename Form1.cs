namespace WinFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] dizi;
        int satirsayisi;
        int sütunsayisi;

        private void button1_Click(object sender, EventArgs e)
        {
            satirsayisi = Convert.ToInt32(textBox1.Text);//satir sayisini texboxtan aldık
            sütunsayisi = Convert.ToInt32(textBox2.Text);//sutun sayısını texboxtan aldık
            dizi = new int[satirsayisi, sütunsayisi];//dizi formatında satır sayısını sutun sayısına dizi şekline formatına getirdik***//Bunda Neden new int koyduk
            int rastgeleMin = Convert.ToInt32(textBox3.Text);//rastgele değer aralığını texboxtan aldık
            int rastgeleMax = Convert.ToInt32(textBox4.Text);// rastgele değer aralığını texboxtan aldık
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
 
