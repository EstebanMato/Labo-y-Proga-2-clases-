using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtKilometros.Text == "" || txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException("Algun campo esta vacio");
                }

                this.rtbInformacion.Text =$"km / hs :{Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text))}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
