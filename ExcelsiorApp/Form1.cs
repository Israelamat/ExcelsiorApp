using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://elpais.com");
            //lb_Admin.LinkArea = new LinkArea(0, 4);
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
