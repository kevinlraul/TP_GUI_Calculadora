using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GUI_Calculadora
{
    public partial class Calculadora : Form
    {
        
        bool inicio = true;
        bool reinicio = false ; 
        double primero;
        double segundo=  0;
        double resultado;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsOperaciones objOperacion = new Clases.ClsOperaciones();
        Clases.ClsSuma objSuma = new Clases.ClsSuma();
        Clases.ClsResta objResta = new Clases.ClsResta();
        Clases.ClsMultiplicacion objMultiplicacion = new Clases.ClsMultiplicacion();
        Clases.ClsDivision objDivision = new Clases.ClsDivision();
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text + "^2";
            tbxFrente.Text = Math.Pow(primero, 2).ToString();
            
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "√" + tbxPrevio.Text + tbxFrente.Text;
            tbxFrente.Text = Math.Sqrt(primero).ToString();
            
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "exp (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Exp(primero).ToString();
           
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "log (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Log(primero).ToString();
            
        }
        private void btnTanH_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "tanh (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Tanh(primero).ToString();
            
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "tan (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Tan(primero).ToString();
            
        }
        private void btnSinH_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "sinh (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Sinh(primero).ToString();
            
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "sin (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Sin(primero).ToString();
            
        }
        private void btnCosH_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxPrevio.Text = "cosh (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Cosh(primero).ToString();
            
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            primero = double.Parse(tbxFrente.Text);
            resultado = primero;
            tbxFrente.Text = "cos (" + tbxPrevio.Text + tbxFrente.Text + ")";
            tbxFrente.Text = Math.Cos(primero).ToString();
           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxFrente.Clear();
            tbxPrevio.Clear();
            tbxFrente.Text = "0";
            DesBloquear(); 
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxFrente.Text.Length <= 1)
                tbxFrente.Text = "0";
            else
                tbxFrente.Text = tbxFrente.Text.Substring(0, tbxFrente.Text.Length - 1);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear(); 
            operador = "+";
            primero = double.Parse(tbxFrente.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text + "+";
            tbxFrente.Clear();
            tbxFrente.Text = "0";
            Bloquear(); 
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            tbxPrevio.Clear();
            operador = "-";
            primero = double.Parse(tbxFrente.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text + "−";
            tbxFrente.Clear();
            tbxFrente.Text = "0";
            Bloquear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            operador = "*";
            primero = double.Parse(tbxFrente.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text + "×";
            tbxFrente.Clear();
            tbxFrente.Text = "0"; 
            Bloquear();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            tbxPrevio.Clear();
            operador = "/";
            primero = double.Parse(tbxFrente.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text + "÷";
            tbxFrente.Clear();
            tbxFrente.Text = "0";
            Bloquear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxFrente.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = objOperacion.Suma((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text;
                    tbxFrente.Text = Sum.ToString();                    
                    break;
                case "-":
                    Res = objOperacion.Resta((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text;
                    tbxFrente.Text = Res.ToString();                    
                    break;
                case "*":
                    Mul = objOperacion.Multiplicacion((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text;
                    tbxFrente.Text = Mul.ToString();                    
                    break;
                case "/":
                    Div = objOperacion.Division((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxFrente.Text;
                    tbxFrente.Text = Div.ToString();
                    break;
            }
            DesBloquear();
            reinicio = true;
            if (reinicio)
            {
                reinicio = false;
                tbxPrevio.Clear();
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (tbxFrente.Text == "0")
            {
                return;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "0";
            }            
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (tbxFrente.Text.Contains("."))
            {

            }
            else
            {
                tbxFrente.Text = tbxFrente.Text + ".";
            }            
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                tbxFrente.Clear();
                reinicio = false;
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "1";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length== 1 && tbxFrente.Text== "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "1";
                inicio = false;
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (reinicio)
            { 
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "2";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "2";
                inicio = false;
            }          
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "3";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "3";
                inicio = false;
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "4";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "4";
                inicio = false;
            }            
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = "5";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";


                tbxFrente.Text = tbxFrente.Text + "5";
                inicio = false;
            }           
        } 

    private void btnN6_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "6";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "6";
                inicio = false;
            }
        }                                   
        
        private void btnN7_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "7";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "7";
                inicio = false;
            }            
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio)
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "8";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "8";
                inicio = false;
            }           
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (reinicio)
            {
                reinicio = false;
                tbxFrente.Clear();
            }
            if (inicio )
            {
                tbxFrente.Text = "";
                tbxFrente.Text = "9";
                inicio = false;
            }
            else
            {
                if (tbxFrente.Text.Length == 1 && tbxFrente.Text == "0")
                    tbxFrente.Text = "";
                tbxFrente.Text = tbxFrente.Text + "9";
                inicio = false;
            }            
        }
        private void Bloquear()
        {
            btnSuma.Enabled= false  ;
            btnResta.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnRaiz.Enabled = false; 
            btnSin.Enabled = false;
            btnSinH.Enabled = false;             
            btnCos.Enabled = false;
            btnCosH.Enabled = false;
            btnTan.Enabled = false;
            btnLog.Enabled = false; 
            btnTanH.Enabled = false;
            btnCuadrado.Enabled = false;
            btnExp.Enabled = false;
             
        }
        private void DesBloquear()
        {
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
            btnRaiz.Enabled = true;
            btnSin.Enabled = true;
            btnSinH.Enabled = true;
            btnCos.Enabled = true;
            btnCosH.Enabled = true;
            btnTan.Enabled = true;
            btnLog.Enabled = true;
            btnTanH.Enabled = true;
            btnCuadrado.Enabled = true;
            btnExp.Enabled = true;
             
        }
    }
}
