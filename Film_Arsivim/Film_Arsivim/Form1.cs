using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-70RL3KF\\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select AD,KATEGORI,LINK from TBLFILMLER", baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKategori.Text);
            komut.Parameters.AddWithValue("@p3", TxtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film listeye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void BtnHakkmzda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Buse Nur Özturan tarafından yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnCksYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRenkDgisim_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[] { Color.Aqua, Color.Bisque, Color.HotPink, Color.PapayaWhip, Color.PaleTurquoise, Color.Violet, Color.Salmon, Color.SaddleBrown, Color.Peru, Color.MediumSpringGreen };
            Random rnd=new Random();
            int dizieleman = rnd.Next(0, renkler.Length);
            this.BackColor = renkler[dizieleman]; 
        }
    }
}
