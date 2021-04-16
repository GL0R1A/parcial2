
namespace segundo_parcial_progra
{
    partial class Form1
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
            this.listBox1resultado = new System.Windows.Forms.ListBox();
            this.textBox1resultado = new System.Windows.Forms.TextBox();
            this.button1nombres = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3GENERALSEC = new System.Windows.Forms.Button();
            this.button4NOTAMAX = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6CLASIALUM = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8NOTAMAXIMAGENE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1resultado
            // 
            this.listBox1resultado.FormattingEnabled = true;
            this.listBox1resultado.Location = new System.Drawing.Point(35, 22);
            this.listBox1resultado.Name = "listBox1resultado";
            this.listBox1resultado.Size = new System.Drawing.Size(366, 355);
            this.listBox1resultado.TabIndex = 0;
            // 
            // textBox1resultado
            // 
            this.textBox1resultado.Location = new System.Drawing.Point(516, 22);
            this.textBox1resultado.Multiline = true;
            this.textBox1resultado.Name = "textBox1resultado";
            this.textBox1resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1resultado.Size = new System.Drawing.Size(272, 392);
            this.textBox1resultado.TabIndex = 1;
            // 
            // button1nombres
            // 
            this.button1nombres.Location = new System.Drawing.Point(62, 410);
            this.button1nombres.Name = "button1nombres";
            this.button1nombres.Size = new System.Drawing.Size(152, 51);
            this.button1nombres.TabIndex = 2;
            this.button1nombres.Text = "NOMBRE";
            this.button1nombres.UseVisualStyleBackColor = true;
            this.button1nombres.Click += new System.EventHandler(this.button1nombres_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "CARGAR ARCHIVO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3GENERALSEC
            // 
            this.button3GENERALSEC.Location = new System.Drawing.Point(261, 413);
            this.button3GENERALSEC.Name = "button3GENERALSEC";
            this.button3GENERALSEC.Size = new System.Drawing.Size(159, 48);
            this.button3GENERALSEC.TabIndex = 4;
            this.button3GENERALSEC.Text = "GENERAL";
            this.button3GENERALSEC.UseVisualStyleBackColor = true;
            this.button3GENERALSEC.Click += new System.EventHandler(this.button3GENERALSEC_Click);
            // 
            // button4NOTAMAX
            // 
            this.button4NOTAMAX.Location = new System.Drawing.Point(261, 495);
            this.button4NOTAMAX.Name = "button4NOTAMAX";
            this.button4NOTAMAX.Size = new System.Drawing.Size(159, 46);
            this.button4NOTAMAX.TabIndex = 5;
            this.button4NOTAMAX.Text = "NOTA MAXIMA";
            this.button4NOTAMAX.UseVisualStyleBackColor = true;
            this.button4NOTAMAX.Click += new System.EventHandler(this.button4NOTAMAX_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(446, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = " PROMEDIOS SECCIÓN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6CLASIALUM
            // 
            this.button6CLASIALUM.Location = new System.Drawing.Point(452, 495);
            this.button6CLASIALUM.Name = "button6CLASIALUM";
            this.button6CLASIALUM.Size = new System.Drawing.Size(158, 46);
            this.button6CLASIALUM.TabIndex = 7;
            this.button6CLASIALUM.Text = "CLASIFICACIÓN";
            this.button6CLASIALUM.UseVisualStyleBackColor = true;
            this.button6CLASIALUM.Click += new System.EventHandler(this.button6CLASIALUM_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(648, 420);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 43);
            this.button7.TabIndex = 8;
            this.button7.Text = "promedio de parcial";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8NOTAMAXIMAGENE
            // 
            this.button8NOTAMAXIMAGENE.Location = new System.Drawing.Point(647, 498);
            this.button8NOTAMAXIMAGENE.Name = "button8NOTAMAXIMAGENE";
            this.button8NOTAMAXIMAGENE.Size = new System.Drawing.Size(141, 43);
            this.button8NOTAMAXIMAGENE.TabIndex = 9;
            this.button8NOTAMAXIMAGENE.Text = "NOTA MAXIMA GENERAL";
            this.button8NOTAMAXIMAGENE.UseVisualStyleBackColor = true;
            this.button8NOTAMAXIMAGENE.Click += new System.EventHandler(this.button8NOTAMAXIMAGENE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::segundo_parcial_progra.Properties.Resources.fondo_gradiente_holografia_fuid_abstracto_minimo_100209_353;
            this.ClientSize = new System.Drawing.Size(1021, 635);
            this.Controls.Add(this.button8NOTAMAXIMAGENE);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6CLASIALUM);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4NOTAMAX);
            this.Controls.Add(this.button3GENERALSEC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1nombres);
            this.Controls.Add(this.textBox1resultado);
            this.Controls.Add(this.listBox1resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1resultado;
        private System.Windows.Forms.TextBox textBox1resultado;
        private System.Windows.Forms.Button button1nombres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3GENERALSEC;
        private System.Windows.Forms.Button button4NOTAMAX;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6CLASIALUM;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8NOTAMAXIMAGENE;
    }
}

