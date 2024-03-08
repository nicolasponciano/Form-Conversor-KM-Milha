namespace comboBox_tp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxConverter = new ComboBox();
            btnConverter = new Button();
            label1 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            txtValorConvertido = new TextBox();
            SuspendLayout();
            // 
            // cbxConverter
            // 
            cbxConverter.FormattingEnabled = true;
            cbxConverter.Location = new Point(88, 119);
            cbxConverter.Name = "cbxConverter";
            cbxConverter.Size = new Size(121, 23);
            cbxConverter.TabIndex = 0;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(230, 109);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 45);
            btnConverter.TabIndex = 1;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 2;
            label1.Text = "Digite um valor :";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(230, 64);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(75, 23);
            txtValor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 190);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 4;
            label2.Text = "Valor convertido :";
            // 
            // txtValorConvertido
            // 
            txtValorConvertido.Location = new Point(230, 192);
            txtValorConvertido.Name = "txtValorConvertido";
            txtValorConvertido.Size = new Size(75, 23);
            txtValorConvertido.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 272);
            Controls.Add(txtValorConvertido);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(cbxConverter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxConverter;
        private Button btnConverter;
        private Label label1;
        private TextBox txtValor;
        private Label label2;
        private TextBox txtValorConvertido;
    }
}