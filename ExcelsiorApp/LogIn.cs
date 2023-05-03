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

namespace ExcelsiorApp
{
    public partial class LogIn : Form
    {
        Cliente cliente;
        public LogIn()
        {
            InitializeComponent();
        }

        public string CalcularLetraDni(int dniNumeros)
        {
            string[] listaLetras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int modulo = dniNumeros % 23;
            return listaLetras[modulo];
        } 

        public bool CheckDNI(string dni)
        {
            bool valido = false;
            if (dni.Length == 9)
            {
                string dniNumeros = dni.Substring(0, dni.Length - 1);
                string dniLetras = dni.Substring(dni.Length - 1, 1);
  
                if (int.TryParse(dniNumeros, out int dniInt) && CalcularLetraDni(dniInt) == dniLetras)
                {
                    valido = true;
                }
            }
            return valido;
        }

        private void tb_Capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Capital_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Esta casilla solo admitirá numeros enteros\nEL objetivo es valorar su capital estimado");
        }

        public void AñadirObjetoAFichero(Cliente c)
        {
            string fichero = "clientes.txt";
            if (File.Exists(fichero))
            {
                try
                {
                    StreamWriter sr = new StreamWriter(fichero, true);
                    sr.WriteLine($"{cliente.DNI};{cliente.Nombre};{cliente.Apellidos};{cliente.FechaNacimiento};{cliente.Capital}");
                    sr.Close();
                }
                catch(IOException err)
                {
                    MessageBox.Show(err.Message);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            if (CheckDNI(tb_Dni.Text) && Double.TryParse(tb_Capital.Text, out double capital))
            {
                cliente = new Cliente(tb_Dni.Text, tb_Nombre.Text, tb_Apellidos.Text, datePicker_FechaNacimiento.Value, capital);
                AñadirObjetoAFichero(cliente);
                Close();
            }
            else
            {
                MessageBox.Show("DNI no Valido");
            }
        }

        private void tb_Capital_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
