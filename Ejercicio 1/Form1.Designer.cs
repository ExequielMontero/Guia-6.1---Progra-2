namespace Ejercicio_1
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
            this.rbtnRegex = new System.Windows.Forms.RadioButton();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnRegex
            // 
            this.rbtnRegex.AutoSize = true;
            this.rbtnRegex.Location = new System.Drawing.Point(597, 155);
            this.rbtnRegex.Name = "rbtnRegex";
            this.rbtnRegex.Size = new System.Drawing.Size(51, 17);
            this.rbtnRegex.TabIndex = 16;
            this.rbtnRegex.TabStop = true;
            this.rbtnRegex.Text = "regex";
            this.rbtnRegex.UseVisualStyleBackColor = true;
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(597, 111);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(50, 17);
            this.rbtnString.TabIndex = 15;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "string";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(13, 14);
            this.tbVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVer.Size = new System.Drawing.Size(562, 168);
            this.tbVer.TabIndex = 14;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(597, 14);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(123, 79);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 203);
            this.Controls.Add(this.rbtnRegex);
            this.Controls.Add(this.rbtnString);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRegex;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Button btnProcesar;
    }
}

