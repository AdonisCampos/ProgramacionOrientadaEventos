namespace Ejercicio5.Forms
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
            WelcomeLabel = new Label();
            textBoxInput = new TextBox();
            label1 = new Label();
            buttonProcess = new Button();
            textBoxResult = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(39, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(625, 30);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Bienvenid@ al programa de palabras alreves";
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Location = new Point(201, 118);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(220, 23);
            textBoxInput.TabIndex = 1;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(187, 65);
            label1.Name = "label1";
            label1.Size = new Size(270, 30);
            label1.TabIndex = 2;
            label1.Text = "Ingresa la palabra\r\n";
            // 
            // buttonProcess
            // 
            buttonProcess.BackColor = Color.Black;
            buttonProcess.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProcess.ForeColor = Color.FromArgb(255, 255, 128);
            buttonProcess.Location = new Point(201, 161);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(220, 53);
            buttonProcess.TabIndex = 3;
            buttonProcess.Text = "Procesar";
            buttonProcess.UseVisualStyleBackColor = false;
            buttonProcess.Click += buttonProcess_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Location = new Point(201, 245);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(220, 23);
            textBoxResult.TabIndex = 4;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(715, 309);
            Controls.Add(textBoxResult);
            Controls.Add(buttonProcess);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(WelcomeLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private TextBox textBoxInput;
        private Label label1;
        private Button buttonProcess;
        private TextBox textBoxResult;
        private ErrorProvider errorProvider;
    }
}