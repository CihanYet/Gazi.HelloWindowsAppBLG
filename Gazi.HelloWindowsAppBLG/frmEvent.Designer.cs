namespace Gazi.HelloWindowsAppBLG
{
    partial class frmEvent
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
            this.lblKoordinat = new System.Windows.Forms.Label();
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKoordinat
            // 
            this.lblKoordinat.AutoSize = true;
            this.lblKoordinat.Location = new System.Drawing.Point(253, 60);
            this.lblKoordinat.Name = "lblKoordinat";
            this.lblKoordinat.Size = new System.Drawing.Size(0, 13);
            this.lblKoordinat.TabIndex = 0;
            // 
            // btnSayi1
            // 
            this.btnSayi1.Location = new System.Drawing.Point(368, 138);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(75, 23);
            this.btnSayi1.TabIndex = 1;
            this.btnSayi1.Text = "20";
            this.btnSayi1.UseVisualStyleBackColor = true;
            this.btnSayi1.Click += new System.EventHandler(this.Topla);
            // 
            // btnSayi2
            // 
            this.btnSayi2.Location = new System.Drawing.Point(368, 177);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(75, 23);
            this.btnSayi2.TabIndex = 2;
            this.btnSayi2.Text = "30";
            this.btnSayi2.UseVisualStyleBackColor = true;
            this.btnSayi2.Click += new System.EventHandler(this.Topla);
            // 
            // btnSayi3
            // 
            this.btnSayi3.Location = new System.Drawing.Point(368, 216);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(75, 23);
            this.btnSayi3.TabIndex = 3;
            this.btnSayi3.Text = "40";
            this.btnSayi3.UseVisualStyleBackColor = true;
            this.btnSayi3.Click += new System.EventHandler(this.Topla);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(344, 256);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(127, 42);
            this.btnSonuc.TabIndex = 4;
            this.btnSonuc.Text = "Sonuç Göster";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "50";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Topla);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnSayi3);
            this.Controls.Add(this.btnSayi2);
            this.Controls.Add(this.btnSayi1);
            this.Controls.Add(this.lblKoordinat);
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.MouseLeave += new System.EventHandler(this.frmEvent_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEvent_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKoordinat;
        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button button1;
    }
}