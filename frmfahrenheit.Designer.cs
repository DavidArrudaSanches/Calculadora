namespace Calculadora
{
    partial class frmfahrenheit
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
            txtCelsius = new TextBox();
            buttoncalcf = new Button();
            txtfahrenheit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(12, 35);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(329, 23);
            txtCelsius.TabIndex = 0;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // buttoncalcf
            // 
            buttoncalcf.Location = new Point(128, 64);
            buttoncalcf.Name = "buttoncalcf";
            buttoncalcf.Size = new Size(92, 43);
            buttoncalcf.TabIndex = 1;
            buttoncalcf.Text = "Calcular";
            buttoncalcf.UseVisualStyleBackColor = true;
            buttoncalcf.Click += buttoncalcf_Click;
            // 
            // txtfahrenheit
            // 
            txtfahrenheit.Location = new Point(12, 113);
            txtfahrenheit.Name = "txtfahrenheit";
            txtfahrenheit.Size = new Size(329, 23);
            txtfahrenheit.TabIndex = 2;
            txtfahrenheit.TextChanged += txtfahrenheit_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 3;
            label1.Text = "Valor Celsius";
            // 
            // label2
            // 
            label2.Location = new Point(128, 139);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 4;
            label2.Text = "Valor Fahrenheit";
            // 
            // frmfahrenheit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 176);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtfahrenheit);
            Controls.Add(buttoncalcf);
            Controls.Add(txtCelsius);
            Name = "frmfahrenheit";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsius;
        private Button buttoncalcf;
        private TextBox txtfahrenheit;
        private Label label1;
        private Label label2;
    }
}