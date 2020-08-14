namespace PrototypePattern
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOyun1 = new System.Windows.Forms.Label();
            this.lblOyun2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listOyun1 = new System.Windows.Forms.ListBox();
            this.listOyun2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtOyun2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtOyun1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUrunAnahtari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOyun1
            // 
            this.lblOyun1.AutoSize = true;
            this.lblOyun1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyun1.ForeColor = System.Drawing.Color.Gold;
            this.lblOyun1.Location = new System.Drawing.Point(77, 225);
            this.lblOyun1.Name = "lblOyun1";
            this.lblOyun1.Size = new System.Drawing.Size(77, 25);
            this.lblOyun1.TabIndex = 1;
            this.lblOyun1.Text = "Oyun1 :";
            this.lblOyun1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOyun2
            // 
            this.lblOyun2.AutoSize = true;
            this.lblOyun2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyun2.ForeColor = System.Drawing.Color.Gold;
            this.lblOyun2.Location = new System.Drawing.Point(77, 432);
            this.lblOyun2.Name = "lblOyun2";
            this.lblOyun2.Size = new System.Drawing.Size(77, 25);
            this.lblOyun2.TabIndex = 1;
            this.lblOyun2.Text = "Oyun2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Oyun1 İsmi Gir :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Oyun2 İsmi Gir :";
            // 
            // listOyun1
            // 
            this.listOyun1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listOyun1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOyun1.ForeColor = System.Drawing.Color.Black;
            this.listOyun1.FormattingEnabled = true;
            this.listOyun1.ItemHeight = 22;
            this.listOyun1.Location = new System.Drawing.Point(80, 253);
            this.listOyun1.Name = "listOyun1";
            this.listOyun1.Size = new System.Drawing.Size(360, 158);
            this.listOyun1.TabIndex = 3;
            // 
            // listOyun2
            // 
            this.listOyun2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listOyun2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOyun2.ForeColor = System.Drawing.Color.Black;
            this.listOyun2.FormattingEnabled = true;
            this.listOyun2.ItemHeight = 22;
            this.listOyun2.Location = new System.Drawing.Point(80, 460);
            this.listOyun2.Name = "listOyun2";
            this.listOyun2.Size = new System.Drawing.Size(360, 158);
            this.listOyun2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtOyun2);
            this.panel1.Controls.Add(this.txtOyun1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnUrunAnahtari);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 203);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // txtOyun2
            // 
            this.txtOyun2.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtOyun2.Location = new System.Drawing.Point(157, 78);
            this.txtOyun2.Name = "txtOyun2";
            this.txtOyun2.Size = new System.Drawing.Size(181, 22);
            this.txtOyun2.TabIndex = 6;
            // 
            // txtOyun1
            // 
            this.txtOyun1.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtOyun1.Location = new System.Drawing.Point(157, 41);
            this.txtOyun1.Name = "txtOyun1";
            this.txtOyun1.Size = new System.Drawing.Size(181, 22);
            this.txtOyun1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 28);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adet :";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Image = global::PrototypePattern.Properties.Resources.delete;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(113, 644);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(275, 33);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PrototypePattern.Properties.Resources.cross;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(511, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototypePattern.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(400, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUrunAnahtari
            // 
            this.btnUrunAnahtari.BackColor = System.Drawing.Color.Azure;
            this.btnUrunAnahtari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunAnahtari.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUrunAnahtari.FlatAppearance.BorderSize = 0;
            this.btnUrunAnahtari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunAnahtari.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunAnahtari.ForeColor = System.Drawing.Color.Black;
            this.btnUrunAnahtari.Image = global::PrototypePattern.Properties.Resources.key;
            this.btnUrunAnahtari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunAnahtari.Location = new System.Drawing.Point(157, 137);
            this.btnUrunAnahtari.Name = "btnUrunAnahtari";
            this.btnUrunAnahtari.Size = new System.Drawing.Size(205, 37);
            this.btnUrunAnahtari.TabIndex = 3;
            this.btnUrunAnahtari.Text = "     Ürün Anahtarı Oluştur";
            this.btnUrunAnahtari.UseVisualStyleBackColor = false;
            this.btnUrunAnahtari.Click += new System.EventHandler(this.btnUrunAnahtari_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTemizle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listOyun2);
            this.Controls.Add(this.listOyun1);
            this.Controls.Add(this.lblOyun2);
            this.Controls.Add(this.lblOyun1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOyun1;
        private System.Windows.Forms.Button btnUrunAnahtari;
        private System.Windows.Forms.Label lblOyun2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listOyun1;
        private System.Windows.Forms.ListBox listOyun2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtOyun2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtOyun1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

