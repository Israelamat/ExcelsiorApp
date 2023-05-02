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
    public partial class AdministracionUsuarios : Form
    {
        List<Cliente> clientes = RellenarLista();
        public AdministracionUsuarios()
        {
            InitializeComponent();
            dataGridView1.DataSource = clientes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static List<Cliente> RellenarLista()
        {
            List<Cliente> clientes = new List<Cliente>();
            string fichero = "clientes.txt";
            if (File.Exists(fichero))
            {
                try
                {
                    string[] linesFichero = File.ReadAllLines(fichero);
                    for (int i = 0; i < linesFichero.Length; i++)
                    {
                        string[]line = linesFichero[i].Split(';');
                        if (line.Length >= 5 && DateTime.TryParse(line[3], out DateTime fechaDate) && double.TryParse(line[4], out double capital))
                        {
                            clientes.Add(new Cliente(line[0], line[1], line[2], fechaDate, capital));
                        }
                    }
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                
            }
            return clientes;
        }
    }

    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Capital { get; set; }

        public Cliente(string dNI, string nombre, string apellidos, DateTime fechaNacimiento, double capital)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Capital = capital;
        }

        public Cliente()
        {
        }
    }
}
