using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorDeProdutos
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDasMotos = Directory.GetFiles(@"C:\Users\Usuario\Desktop\Motos");

            foreach (string img in nomeFotosDasMotos)
            {

                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[5].Split('.');
                
                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox1.ImageLocation = @"C:\Users\Usuario\Desktop\Motos\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "HONDA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CG 150");
                comboBox2.Items.Add("CG 160");
                comboBox2.Items.Add("CB 500");
                comboBox2.Items.Add("CB 600");
                comboBox2.Items.Add("XRE 300");
            }
            else if (comboBox1.Text == "YAMAHA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CROSSER");
                comboBox2.Items.Add("FAZER");
                comboBox2.Items.Add("LANDER");
                comboBox2.Items.Add("TENERE");
                comboBox2.Items.Add("MT 03");

            }
            else if (comboBox1.Text == "KAWASAKI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("VERSIS");
                comboBox2.Items.Add("VULCAN");

            }
            else if (comboBox1.Text == "HARLEY DAVIDSON")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("HERITAGE");
                comboBox2.Items.Add("FAT BOY");
                comboBox2.Items.Add("FAT BOB");



            }
            else if (comboBox1.Text == "SUZUKI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YES");
                comboBox2.Items.Add("BANDIT");
                comboBox2.Items.Add("RGSX");

            }

        }
    }
}