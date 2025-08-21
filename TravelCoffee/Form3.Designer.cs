namespace TravelCoffee
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalMoneyAmount = new System.Windows.Forms.TextBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(814, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change: ";
            // 
            // TotalMoneyAmount
            // 
            this.TotalMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMoneyAmount.Location = new System.Drawing.Point(928, 381);
            this.TotalMoneyAmount.Name = "TotalMoneyAmount";
            this.TotalMoneyAmount.Size = new System.Drawing.Size(100, 23);
            this.TotalMoneyAmount.TabIndex = 3;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(800, 425);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(115, 26);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.Text = "Payment:";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // Payment
            // 
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(928, 425);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(100, 23);
            this.Payment.TabIndex = 5;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(928, 478);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(100, 23);
            this.Change.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1004, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 604);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.TotalMoneyAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalMoneyAmount;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.TextBox Payment;
        private System.Windows.Forms.TextBox Change;
        private System.Windows.Forms.Button btnExit;
    }
}