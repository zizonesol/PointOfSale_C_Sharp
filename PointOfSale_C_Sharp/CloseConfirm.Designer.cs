namespace PointOfSale_C_Sharp
{
    partial class CloseConfirm
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
            this.NoButtn = new System.Windows.Forms.Button();
            this.YesButtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to close the application?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NoButtn
            // 
            this.NoButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButtn.Location = new System.Drawing.Point(349, 124);
            this.NoButtn.Name = "NoButtn";
            this.NoButtn.Size = new System.Drawing.Size(117, 46);
            this.NoButtn.TabIndex = 1;
            this.NoButtn.Text = "&No";
            this.NoButtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NoButtn.UseVisualStyleBackColor = true;
            this.NoButtn.Click += new System.EventHandler(this.NoButtn_Click);
            // 
            // YesButtn
            // 
            this.YesButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButtn.Location = new System.Drawing.Point(204, 124);
            this.YesButtn.Name = "YesButtn";
            this.YesButtn.Size = new System.Drawing.Size(117, 46);
            this.YesButtn.TabIndex = 2;
            this.YesButtn.Text = "&Yes";
            this.YesButtn.UseVisualStyleBackColor = true;
            this.YesButtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 208);
            this.Controls.Add(this.YesButtn);
            this.Controls.Add(this.NoButtn);
            this.Controls.Add(this.label1);
            this.Name = "CloseConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit Window";
            this.Load += new System.EventHandler(this.CloseConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NoButtn;
        private System.Windows.Forms.Button YesButtn;
    }
}