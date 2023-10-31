
namespace AltoVolumen
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
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.AceptarB = new System.Windows.Forms.Button();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.ContraLabe = new System.Windows.Forms.Label();
            this.ContraTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Location = new System.Drawing.Point(95, 89);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(96, 13);
            this.CorreoLabel.TabIndex = 0;
            this.CorreoLabel.Text = "Correo electronico:";
            // 
            // AceptarB
            // 
            this.AceptarB.Location = new System.Drawing.Point(336, 231);
            this.AceptarB.Name = "AceptarB";
            this.AceptarB.Size = new System.Drawing.Size(75, 23);
            this.AceptarB.TabIndex = 1;
            this.AceptarB.Text = "Aceptar";
            this.AceptarB.UseVisualStyleBackColor = true;
            this.AceptarB.Click += new System.EventHandler(this.AceptarB_Click);
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(98, 105);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(245, 20);
            this.CorreoTextBox.TabIndex = 2;
            // 
            // ContraLabe
            // 
            this.ContraLabe.AutoSize = true;
            this.ContraLabe.Location = new System.Drawing.Point(95, 145);
            this.ContraLabe.Name = "ContraLabe";
            this.ContraLabe.Size = new System.Drawing.Size(64, 13);
            this.ContraLabe.TabIndex = 3;
            this.ContraLabe.Text = "Contraseña:";
            // 
            // ContraTextBox
            // 
            this.ContraTextBox.Location = new System.Drawing.Point(98, 161);
            this.ContraTextBox.Name = "ContraTextBox";
            this.ContraTextBox.Size = new System.Drawing.Size(171, 20);
            this.ContraTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContraTextBox);
            this.Controls.Add(this.ContraLabe);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.AceptarB);
            this.Controls.Add(this.CorreoLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Button AceptarB;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label ContraLabe;
        private System.Windows.Forms.TextBox ContraTextBox;
        private System.Windows.Forms.Button button1;
    }
}

