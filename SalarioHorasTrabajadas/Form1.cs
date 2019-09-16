using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioHorasTrabajadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblmensaje1.Text = "Se calcula el salario de un empleado ";
            lblmensaje1.Visible = true;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horasT = double.Parse(txtHorastrabajadas.Text);
            double valorH = double.Parse(txtvalorhora.Text);

            double desc1 = 0, desc2 = 2, desc3 = 5 ;
            double increm1 = 10, increm2 = 0, increm3 = 2;
            double salario = valorH * horasT;
            double salariototal = 0, incremento = 0, descuento = 0;

            if (salario < 700000){

                lblporcentaje.Text = desc1.ToString() + "%";
                lblporcentaje.ForeColor = Color.Red;
                lblporcentaje.Visible = true;
                lblporcentaje2.Text = increm1.ToString() + "%";
                lblporcentaje2.ForeColor = Color.Green;
                lblporcentaje2.Visible = true;
                incremento = salario * 0.10;
                salariototal = incremento + salario;
                lbltotal.Text = salariototal.ToString();
                lbltotal.Visible = true;

            }else if (salario < 1000000){

                lblporcentaje.Text = desc2.ToString() + "%";
                lblporcentaje.ForeColor = Color.Green;
                lblporcentaje.Visible = true;
                lblporcentaje2.Text = increm2.ToString() + "%";
                lblporcentaje2.ForeColor = Color.Red;
                lblporcentaje2.Visible = true;
                descuento = salario * 0.2;
                salariototal = salario - descuento;
                lbltotal.Text = salariototal.ToString();
                lbltotal.Visible = true;

            }else if (salario > 1000001){

                lblporcentaje.Text = desc3.ToString() + "%";
                lblporcentaje.ForeColor = Color.Green;
                lblporcentaje.Visible = true;
                lblporcentaje2.Text = increm3.ToString() + "%";
                lblporcentaje2.ForeColor = Color.Green;
                lblporcentaje2.Visible = true;
                descuento = salario * 0.5;
                incremento = salario * 0.2;
                salariototal = (incremento + salario) - descuento;
                lbltotal.Text = salariototal.ToString();
                lbltotal.Visible = true;
            }

        }

        private void txtHorastrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)){

                e.Handled = false;

            }else if (char.IsControl(e.KeyChar)){

                e.Handled = false;

            }else if (char.IsSeparator(e.KeyChar)){

                e.Handled = false;

            }else{

                MessageBox.Show("Solo se admite numeros enteros"
                    ,"Mensaje de Advertencia"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);

                e.Handled = true;
                return;
            }
        }

        private void txtvalorhora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {

                MessageBox.Show("Solo se admite numeros enteros"
                    , "Mensaje de Advertencia"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                e.Handled = true;
                return;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
