namespace TP_GUI_Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btnExp = new System.Windows.Forms.Button();
            this.btnTanH = new System.Windows.Forms.Button();
            this.btnSinH = new System.Windows.Forms.Button();
            this.btnCosH = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.tbxPrevio = new System.Windows.Forms.TextBox();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.tbxFrente = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.tbxScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.DarkGray;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(8, 289);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(45, 45);
            this.btnExp.TabIndex = 65;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnTanH
            // 
            this.btnTanH.BackColor = System.Drawing.Color.DarkGray;
            this.btnTanH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTanH.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanH.Location = new System.Drawing.Point(59, 187);
            this.btnTanH.Name = "btnTanH";
            this.btnTanH.Size = new System.Drawing.Size(45, 45);
            this.btnTanH.TabIndex = 64;
            this.btnTanH.Text = "tanh";
            this.btnTanH.UseVisualStyleBackColor = false;
            this.btnTanH.Click += new System.EventHandler(this.btnTanH_Click);
            // 
            // btnSinH
            // 
            this.btnSinH.BackColor = System.Drawing.Color.DarkGray;
            this.btnSinH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSinH.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinH.Location = new System.Drawing.Point(57, 136);
            this.btnSinH.Name = "btnSinH";
            this.btnSinH.Size = new System.Drawing.Size(45, 45);
            this.btnSinH.TabIndex = 63;
            this.btnSinH.Text = "sinh";
            this.btnSinH.UseVisualStyleBackColor = false;
            this.btnSinH.Click += new System.EventHandler(this.btnSinH_Click);
            // 
            // btnCosH
            // 
            this.btnCosH.BackColor = System.Drawing.Color.DarkGray;
            this.btnCosH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCosH.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosH.Location = new System.Drawing.Point(57, 85);
            this.btnCosH.Name = "btnCosH";
            this.btnCosH.Size = new System.Drawing.Size(45, 45);
            this.btnCosH.TabIndex = 62;
            this.btnCosH.Text = "cosh";
            this.btnCosH.UseVisualStyleBackColor = false;
            this.btnCosH.Click += new System.EventHandler(this.btnCosH_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.DarkGray;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(8, 238);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(45, 45);
            this.btnLog.TabIndex = 61;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.DarkGray;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(8, 187);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(45, 45);
            this.btnTan.TabIndex = 60;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.DarkGray;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(8, 136);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(45, 45);
            this.btnSin.TabIndex = 59;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.DarkGray;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(8, 85);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(45, 45);
            this.btnCos.TabIndex = 58;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // tbxPrevio
            // 
            this.tbxPrevio.BackColor = System.Drawing.Color.PaleGreen;
            this.tbxPrevio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrevio.ForeColor = System.Drawing.Color.Black;
            this.tbxPrevio.Location = new System.Drawing.Point(8, 12);
            this.tbxPrevio.Name = "tbxPrevio";
            this.tbxPrevio.ReadOnly = true;
            this.tbxPrevio.Size = new System.Drawing.Size(300, 29);
            this.tbxPrevio.TabIndex = 57;
            this.tbxPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.DarkGray;
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuadrado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(57, 289);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(45, 45);
            this.btnCuadrado.TabIndex = 56;
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.DarkGray;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaiz.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(59, 238);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(45, 45);
            this.btnRaiz.TabIndex = 55;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // tbxFrente
            // 
            this.tbxFrente.BackColor = System.Drawing.Color.PaleGreen;
            this.tbxFrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFrente.ForeColor = System.Drawing.Color.Navy;
            this.tbxFrente.Location = new System.Drawing.Point(8, 36);
            this.tbxFrente.Name = "tbxFrente";
            this.tbxFrente.ReadOnly = true;
            this.tbxFrente.Size = new System.Drawing.Size(300, 47);
            this.tbxFrente.TabIndex = 54;
            this.tbxFrente.Text = "0";
            this.tbxFrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(261, 289);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(45, 45);
            this.btnIgual.TabIndex = 53;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(187, 85);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(68, 45);
            this.btnBorrar.TabIndex = 52;
            this.btnBorrar.Text = "←";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(108, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 45);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "CE";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkGray;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(261, 85);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(45, 45);
            this.btnDivision.TabIndex = 50;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(210, 289);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 49;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(210, 238);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(45, 45);
            this.btnN3.TabIndex = 37;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(210, 187);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(45, 45);
            this.btnN6.TabIndex = 48;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(210, 136);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(45, 45);
            this.btnN9.TabIndex = 47;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.DarkGray;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(261, 136);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicacion.TabIndex = 46;
            this.btnMultiplicacion.Text = "×";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(159, 238);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(45, 45);
            this.btnN2.TabIndex = 45;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(159, 187);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(45, 45);
            this.btnN5.TabIndex = 44;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(159, 136);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(45, 45);
            this.btnN8.TabIndex = 43;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.DarkGray;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(261, 187);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(45, 45);
            this.btnResta.TabIndex = 42;
            this.btnResta.Text = "−";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(110, 289);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(94, 45);
            this.btnN0.TabIndex = 41;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(108, 238);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(45, 45);
            this.btnN1.TabIndex = 40;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(108, 187);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(45, 45);
            this.btnN4.TabIndex = 39;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(108, 136);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(45, 45);
            this.btnN7.TabIndex = 38;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.DarkGray;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(261, 238);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(45, 45);
            this.btnSuma.TabIndex = 36;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // tbxScreen
            // 
            this.tbxScreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScreen.ForeColor = System.Drawing.Color.Navy;
            this.tbxScreen.Location = new System.Drawing.Point(10, 35);
            this.tbxScreen.Name = "tbxScreen";
            this.tbxScreen.ReadOnly = true;
            this.tbxScreen.Size = new System.Drawing.Size(300, 47);
            this.tbxScreen.TabIndex = 54;
            this.tbxScreen.Text = "0";
            this.tbxScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 347);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnTanH);
            this.Controls.Add(this.btnSinH);
            this.Controls.Add(this.btnCosH);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.tbxPrevio);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.tbxFrente);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnSuma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnTanH;
        private System.Windows.Forms.Button btnSinH;
        private System.Windows.Forms.Button btnCosH;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.TextBox tbxPrevio;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.TextBox tbxFrente;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox tbxScreen;
    }
}

