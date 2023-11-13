namespace NumeroMayorYMenor
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
            button1 = new Button();
            textoNumero1 = new TextBox();
            label1 = new Label();
            textoNumero2 = new TextBox();
            label2 = new Label();
            textoNumero3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textoNumero1
            // 
            textoNumero1.Location = new Point(146, 46);
            textoNumero1.Name = "textoNumero1";
            textoNumero1.Size = new Size(100, 23);
            textoNumero1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 49);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "1er Número:";
            // 
            // textoNumero2
            // 
            textoNumero2.Location = new Point(146, 84);
            textoNumero2.Name = "textoNumero2";
            textoNumero2.Size = new Size(100, 23);
            textoNumero2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 87);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "2do Número:";
            // 
            // textoNumero3
            // 
            textoNumero3.Location = new Point(146, 126);
            textoNumero3.Name = "textoNumero3";
            textoNumero3.Size = new Size(100, 23);
            textoNumero3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 129);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "3er Número:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 273);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoNumero3);
            Controls.Add(textoNumero2);
            Controls.Add(textoNumero1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textoNumero1;
        private Label label1;
        private TextBox textoNumero2;
        private Label label2;
        private TextBox textoNumero3;
        private Label label3;
    }
}