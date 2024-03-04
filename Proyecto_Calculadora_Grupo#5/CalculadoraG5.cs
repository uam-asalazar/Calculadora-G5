using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Calculadora_G5.Calculadora_G5;
using BLL_Calculadora_G5.Calculadora_G5;

namespace Proyecto_Calculadora_Grupo_5
{
    public partial class CalculadoraG5 : Form
    {
        #region Variables globales
        cls_CalculadoraG5_DAL obj_DAL = new cls_CalculadoraG5_DAL();
        cls_CalculadoraG5_BLL obj_BLL = new cls_CalculadoraG5_BLL();
        #endregion
        string operador;

        public CalculadoraG5()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbxNumerico.Text.Contains(","))
            {
                  tbxNumerico.Text += ",";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxNumerico.Text = tbxNumerico.Text + "9";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            obj_DAL.fNum1 = float.Parse(tbxNumerico.Text);
            tbxNumerico.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            obj_DAL.fNum1 = float.Parse(tbxNumerico.Text);
            tbxNumerico.Clear();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            obj_DAL.fNum1 = float.Parse(tbxNumerico.Text);
            tbxNumerico.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Asigna el operador de suma al campo "operador"
            operador = "+";

            // Intenta convertir el texto ingresado en el cuadro de texto "tbxNumerico" a un número de punto flotante de precisión simple
            float numeroFloat;
            if (float.TryParse(tbxNumerico.Text, out numeroFloat))
            {
                // Si la conversión fue exitosa, asigna el número de punto flotante al campo "fNum1" del objeto "obj_DAL"
                obj_DAL.fNum1 = numeroFloat;

                // Limpia el contenido del cuadro de texto "tbxNumerico"
                tbxNumerico.Clear();
            }
            else
            {
                // Si la conversión falló, muestra un mensaje de error al usuario
                MessageBox.Show("El valor ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            obj_DAL.fNum2 = float.Parse(tbxNumerico.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj_BLL.sumar(ref obj_DAL);
                    tbxNumerico.Text = Sum.ToString("N2");
                    break;
                case "-":
                    Res = obj_BLL.restar(ref obj_DAL);
                    tbxNumerico.Text = Res.ToString("N2");
                    break;
                case "*":
                    Mul = obj_BLL.multiplicar(ref obj_DAL);
                    tbxNumerico.Text = Mul.ToString("N2");
                    break;
                case "/":
                    Div = obj_BLL.dividir(ref obj_DAL);
                    tbxNumerico.Text = Div.ToString("N2");
                    break;




            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxNumerico.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxNumerico.Text.Length == 1) {
                tbxNumerico.Text = "";
            }
            else
            {
               tbxNumerico.Text = tbxNumerico.Text.Substring(0, tbxNumerico.Text.Length - 1);
            }
        }
    }
}
