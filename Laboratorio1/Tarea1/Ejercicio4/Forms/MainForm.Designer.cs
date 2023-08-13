namespace Ejercicio4.Forms
{
    partial class MainForm
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
            TitleLabel1 = new Label();
            textBoxNumber = new TextBox();
            CheckDivisibilityButton = new Button();
            errorProvider = new ErrorProvider(components);
            WelcomeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel1.ForeColor = Color.Fuchsia;
            TitleLabel1.Location = new Point(215, 86);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(231, 27);
            TitleLabel1.TabIndex = 0;
            TitleLabel1.Text = "Ingrese el numero";
            // 
            // textBoxNumber
            // 
            textBoxNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumber.Location = new Point(215, 128);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(231, 23);
            textBoxNumber.TabIndex = 1;
            // 
            // CheckDivisibilityButton
            // 
            CheckDivisibilityButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckDivisibilityButton.ForeColor = Color.FromArgb(192, 0, 192);
            CheckDivisibilityButton.Location = new Point(215, 168);
            CheckDivisibilityButton.Name = "CheckDivisibilityButton";
            CheckDivisibilityButton.Size = new Size(231, 64);
            CheckDivisibilityButton.TabIndex = 2;
            CheckDivisibilityButton.Text = "Comprobar Divisibilidad";
            CheckDivisibilityButton.UseVisualStyleBackColor = true;
            CheckDivisibilityButton.Click += CheckDivisibilityButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(18, 20);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(657, 66);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "BIENVENID@ AL PROGRAMA PARA DETERMINAR\r\nSI UN NUMERO ES DIVISBLE ENTRE 15";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(687, 244);
            Controls.Add(WelcomeLabel);
            Controls.Add(CheckDivisibilityButton);
            Controls.Add(textBoxNumber);
            Controls.Add(TitleLabel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel1;
        private TextBox textBoxNumber;
        private Button CheckDivisibilityButton;
        private ErrorProvider errorProvider;
        private Label WelcomeLabel;
    }
}