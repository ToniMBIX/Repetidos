namespace Repetidos
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
            this.appDescription = new System.Windows.Forms.Label();
            this.txt_Moda = new System.Windows.Forms.TextBox();
            this.buttonCalcModa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appDescription
            // 
            this.appDescription.AutoSize = true;
            this.appDescription.Location = new System.Drawing.Point(12, 9);
            this.appDescription.Name = "appDescription";
            this.appDescription.Size = new System.Drawing.Size(278, 13);
            this.appDescription.TabIndex = 0;
            this.appDescription.Text = "Introduce una lista de números(separados por una coma):";
            // 
            // txt_Moda
            // 
            this.txt_Moda.Location = new System.Drawing.Point(15, 45);
            this.txt_Moda.Name = "txt_Moda";
            this.txt_Moda.Size = new System.Drawing.Size(403, 20);
            this.txt_Moda.TabIndex = 1;
            // 
            // buttonCalcModa
            // 
            this.buttonCalcModa.Location = new System.Drawing.Point(173, 71);
            this.buttonCalcModa.Name = "buttonCalcModa";
            this.buttonCalcModa.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcModa.TabIndex = 4;
            this.buttonCalcModa.Text = "CALCULAR";
            this.buttonCalcModa.UseVisualStyleBackColor = true;
            this.buttonCalcModa.Click += new System.EventHandler(this.buttonCalcModa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 105);
            this.Controls.Add(this.buttonCalcModa);
            this.Controls.Add(this.txt_Moda);
            this.Controls.Add(this.appDescription);
            this.Name = "Form1";
            this.Text = "Calculador Moda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appDescription;
        private System.Windows.Forms.TextBox txt_Moda;
        private System.Windows.Forms.Button buttonCalcModa;
    }
}

