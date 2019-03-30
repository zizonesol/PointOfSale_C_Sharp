namespace PointOfSale_C_Sharp
{
    partial class LogoutConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.YesButtn = new System.Windows.Forms.Button();
            this.noBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to log out?";
            // 
            // YesButtn
            // 
            this.YesButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButtn.Location = new System.Drawing.Point(180, 126);
            this.YesButtn.Name = "YesButtn";
            this.YesButtn.Size = new System.Drawing.Size(117, 46);
            this.YesButtn.TabIndex = 3;
            this.YesButtn.Text = "&Yes";
            this.YesButtn.UseVisualStyleBackColor = true;
            this.YesButtn.Click += new System.EventHandler(this.YesButtn_Click);
            // 
            // noBttn
            // 
            this.noBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBttn.Location = new System.Drawing.Point(338, 126);
            this.noBttn.Name = "noBttn";
            this.noBttn.Size = new System.Drawing.Size(117, 46);
            this.noBttn.TabIndex = 4;
            this.noBttn.Text = "&No";
            this.noBttn.UseVisualStyleBackColor = true;
            this.noBttn.Click += new System.EventHandler(this.noBttn_Click);
            // 
            // LogoutConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 210);
            this.Controls.Add(this.noBttn);
            this.Controls.Add(this.YesButtn);
            this.Controls.Add(this.label1);
            this.Name = "LogoutConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logout Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButtn;
        private System.Windows.Forms.Button noBttn;
    }
}