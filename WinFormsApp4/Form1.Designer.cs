namespace SimpleCalculator
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(0, 0);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(318, 40);
            txtInput.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(318, 0);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(85, 40);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "ENTER";
            btnEnter.BackColor = System.Drawing.Color.LightBlue;
            btnEnter.Click += btnEnter_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 40);
            Controls.Add(btnEnter);
            Controls.Add(txtInput);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CalculatorForm";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEnter;
    }
}


