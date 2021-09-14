using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmHolaWindows : Form
    {
        public FrmHolaWindows()
        {
            InitializeComponent();
        }

        private void FrmHolaWindows_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola, Windows forms!";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text}";
            FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);
            frmSaludo.ShowDialog();
        }
    }
}
