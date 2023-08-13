namespace Ejercicio_2
{
    partial class Numero_primo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtnumero = new TextBox();
            label2 = new Label();
            lblresutado = new Label();
            btnprocesar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 27);
            label1.Name = "label1";
            label1.Size = new Size(601, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero para detrminar si este es un numero primo";
            // 
            // txtnumero
            // 
            txtnumero.AccessibleDescription = "";
            txtnumero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumero.Location = new Point(94, 72);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "Ingrese un numero";
            txtnumero.Size = new Size(601, 31);
            txtnumero.TabIndex = 1;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 152);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "Resultado:";
            // 
            // lblresutado
            // 
            lblresutado.AutoSize = true;
            lblresutado.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblresutado.Location = new Point(202, 152);
            lblresutado.Name = "lblresutado";
            lblresutado.Size = new Size(16, 25);
            lblresutado.TabIndex = 3;
            lblresutado.Text = ".";
            // 
            // btnprocesar
            // 
            btnprocesar.BackColor = Color.PaleTurquoise;
            btnprocesar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnprocesar.Location = new Point(94, 215);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(124, 43);
            btnprocesar.TabIndex = 4;
            btnprocesar.Text = "Procesar";
            btnprocesar.UseVisualStyleBackColor = false;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // Numero_primo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnprocesar);
            Controls.Add(lblresutado);
            Controls.Add(label2);
            Controls.Add(txtnumero);
            Controls.Add(label1);
            Name = "Numero_primo";
            Text = "Numero_primo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero;
        private Label label2;
        private Label lblresutado;
        private Button btnprocesar;
    }
}