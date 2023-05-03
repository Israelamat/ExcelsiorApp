using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelsiorApp
{
    public partial class Form1 : Form
    {
        AdministracionUsuarios adminForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        public int RandomNumber()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(3);
            return numeroAleatorio;
        }

        public string SelecionarFondo()
        {
            string[] listaFondos = { "Mujer.jpg", "Camara.png", "MackBook.png", "EscuchandoMusica.jpg" };
            return listaFondos[RandomNumber()];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://elpais.com");
            //pb_Fondo.Image = Image.FromFile(SelecionarFondo());
            pb_Fondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Fondo.Refresh();
            pb_Fondo.Update();

            //pb_Fondo.Image = Image.FromFile(SelecionarFondo());

            //----------------------------------------------------------
            //Image originalImage = Image.FromFile(SelecionarFondo());
            //int newWidth = pb_Fondo.Width;
            //int newHeight = pb_Fondo.Height;

            //Image newImage = new Bitmap(newWidth, newHeight);
            //Graphics graphics = Graphics.FromImage(newImage);
            //graphics.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHeight));
            //string newImagePath = "ruta/de/la/nueva/imagen.png";
            //newImage.Save(newImagePath, ImageFormat.Png);
            //originalImage.Dispose();
            //newImage.Dispose();
            //graphics.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pb_Fondo.Image != null)
            {
                pb_Fondo.Image.Dispose();
            }
        }

        private void lb_Admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminForm = new AdministracionUsuarios();
            adminForm.ShowDialog();
            lb_Admin.LinkVisited = true;
        }

        private void lb_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un login es una herramienta de autenticación que se utiliza para permitir el acceso a un sistema o aplicación. Para iniciar sesión, el usuario debe proporcionar un nombre de usuario y una contraseña, que serán verificados por el sistema para determinar si el usuario tiene acceso o no.");
        }
    }
}
