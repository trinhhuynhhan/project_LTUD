namespace QuanLyDienThoai
{
    partial class QuanLyDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDT));
            this.bntDT = new System.Windows.Forms.Button();
            this.btnLoaiDT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntDT
            // 
            this.bntDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntDT.BackgroundImage")));
            this.bntDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntDT.Location = new System.Drawing.Point(112, 220);
            this.bntDT.Name = "bntDT";
            this.bntDT.Size = new System.Drawing.Size(133, 66);
            this.bntDT.TabIndex = 0;
            this.bntDT.UseVisualStyleBackColor = true;
            this.bntDT.Click += new System.EventHandler(this.bntDT_Click);
            // 
            // btnLoaiDT
            // 
            this.btnLoaiDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiDT.BackgroundImage")));
            this.btnLoaiDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoaiDT.Location = new System.Drawing.Point(497, 220);
            this.btnLoaiDT.Name = "btnLoaiDT";
            this.btnLoaiDT.Size = new System.Drawing.Size(133, 66);
            this.btnLoaiDT.TabIndex = 0;
            this.btnLoaiDT.UseVisualStyleBackColor = true;
            this.btnLoaiDT.Click += new System.EventHandler(this.btnLoaiDT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(91, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ứng Dụng Quản Lý Điện Thoại";
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShop.BackgroundImage")));
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShop.Location = new System.Drawing.Point(303, 220);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(136, 66);
            this.btnShop.TabIndex = 0;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Location = new System.Drawing.Point(652, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 47);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tra Cứu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLoaiDT);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.bntDT);
            this.Name = "QuanLyDT";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntDT;
        private System.Windows.Forms.Button btnLoaiDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
    }
}

