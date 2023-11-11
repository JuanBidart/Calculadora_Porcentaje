using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empezando
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            lvHistorial.Size = new System.Drawing.Size(439, 120);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string historial="";
            float numero;
            try
            {
                
                if (txtNumero.Text.Contains("$"))
                {
                    numero = float.Parse(txtNumero.Text.Remove(0, 1));
                }else numero = float.Parse(txtNumero.Text);

                float porcentaje = float.Parse(txtPorcentaje.Text);
                float porcentajemod = (porcentaje / 100) + 1;
                float resultadoReal;
                float resultadoComun;
                if (rbSumar.Checked)
                {
                    resultadoReal = numero * porcentajemod;
                    resultadoComun = (numero * porcentaje) / 100 + numero;
                    txtResultadoReal.Text = resultadoReal.ToString();
                    txtResultadoComun.Text = resultadoComun.ToString();
                    historial =  $"La SUMA del " + porcentaje.ToString() + "% de " + numero.ToString() +  " Real: " + $"{txtResultadoReal.Text.ToString()}" + "  Comun: " + $"{ txtResultadoComun.Text.ToString()}";
                }
                else if (rbRestar.Checked)
                {
                    resultadoReal = numero / porcentajemod;
                    resultadoComun = numero - ((numero * porcentaje) / 100);
                    txtResultadoReal.Text = resultadoReal.ToString();
                    txtResultadoComun.Text = resultadoComun.ToString();
                    historial = $"La RESTA del " + porcentaje.ToString() + "% de " + numero.ToString() + " Real: " + $"{txtResultadoReal.Text.ToString()}" + "  Comun: " + $"{txtResultadoComun.Text.ToString()}";
                }
                
                if (historial.Contains("SUMA"))
                {
                    lvHistorial.Items.Insert(0,historial).ForeColor = Color.Green;
                   

                }
                else if (historial.Contains("RESTA"))
                {
                    lvHistorial.Items.Insert(0,historial).ForeColor = Color.Red;
                    
                }
               

            }
            catch (Exception ex) { 
            
                
                MessageBox.Show("Error del Programa verifique los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            
        }

        
    }
}
