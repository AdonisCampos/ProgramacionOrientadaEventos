namespace Ejercicio1.Forms
{
    partial class MainForms
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
            components = new System.ComponentModel.Container();
            txtRadius = new TextBox();
            txtResult = new TextBox();
            lblRadius = new Label();
            lblResult = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            errorProviderRadio = new ErrorProvider(components);
            TitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderRadio).BeginInit();
            SuspendLayout();
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(193, 109);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(219, 23);
            txtRadius.TabIndex = 0;
            txtRadius.TextChanged += txtRadius_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(193, 182);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(219, 23);
            txtResult.TabIndex = 1;
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRadius.Location = new Point(196, 64);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(70, 27);
            lblRadius.TabIndex = 2;
            lblRadius.Text = "Radio";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(196, 135);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(216, 22);
            lblResult.TabIndex = 3;
            lblResult.Text = "Área y Perímetro";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(193, 231);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(331, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProviderRadio
            // 
            errorProviderRadio.ContainerControl = this;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(128, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(450, 42);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Bienvenid@ al programa para calcular \r\nel area y el perimetro de un circulo\r\n";
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(707, 266);
            Controls.Add(TitleLabel);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(lblRadius);
            Controls.Add(txtResult);
            Controls.Add(txtRadius);
            Name = "MainForms";
            Text = "MainForms";
            ((System.ComponentModel.ISupportInitialize)errorProviderRadio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRadius;
        private TextBox txtResult;
        private Label lblRadius;
        private Label lblResult;
        private Button btnCalculate;
        private Button btnClear;
        private ErrorProvider errorProviderRadio;
        private Label TitleLabel;
    }
}