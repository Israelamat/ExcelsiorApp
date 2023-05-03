using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ExcelsiorApp
{
    public partial class EstadisticasUsuarios : Form
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Capital { get; set; }
        public EstadisticasUsuarios()
        {
            InitializeComponent();
        }

        private void EstadisticasUsuarios_Load(object sender, EventArgs e)
        {
            AdministracionUsuarios adminClientes = new AdministracionUsuarios();
            int masUnMillon, medioMillon, menosSeisCifras;
            masUnMillon = medioMillon = menosSeisCifras = 0;

            string[] series = { "Mas de un Millón", "Medio Millon", "Menos de 6 cifras "};
            List<Cliente> clientes = adminClientes.Clientes;
            RepartirClientes(ref masUnMillon, ref medioMillon, ref menosSeisCifras, clientes);
            int[] valores = { masUnMillon, medioMillon, menosSeisCifras };

            char_Usuarios.Palette = ChartColorPalette.EarthTones;

            char_Usuarios.Titles.Add("Clientes");

            for (int i = 0; i < series.Length; i++)
            {
                Series series1 = char_Usuarios.Series.Add(series[i]);
                series1.Label = valores[i].ToString();
                series1.Points.Add(valores[i]);
            }
        }

        public void RepartirClientes(ref int masUnMillon, ref int medioMillon, ref int menosSeisCifras, List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Capital >= 1000000) masUnMillon++;
                else if (cliente.Capital < 1000000 && cliente.Capital >= 100000) medioMillon++;
                else if (cliente.Capital < 100000) menosSeisCifras++;
            }
        }
    }
}
