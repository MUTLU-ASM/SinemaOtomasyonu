
namespace sinematanıtımekranı
{
    partial class Frmgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmgiris));
            this.btnVizyon = new System.Windows.Forms.Button();
            this.pctrAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVizyon
            // 
            this.btnVizyon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVizyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVizyon.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizyon.Location = new System.Drawing.Point(224, 550);
            this.btnVizyon.Margin = new System.Windows.Forms.Padding(4);
            this.btnVizyon.Name = "btnVizyon";
            this.btnVizyon.Size = new System.Drawing.Size(848, 53);
            this.btnVizyon.TabIndex = 3;
            this.btnVizyon.Text = "Vizyondaki Filmlere Göz Atmak İstermisiniz";
            this.btnVizyon.UseVisualStyleBackColor = true;
            this.btnVizyon.Click += new System.EventHandler(this.btnVizyon_Click);
            // 
            // pctrAdmin
            // 
            this.pctrAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pctrAdmin.Image")));
            this.pctrAdmin.Location = new System.Drawing.Point(1192, 522);
            this.pctrAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pctrAdmin.Name = "pctrAdmin";
            this.pctrAdmin.Size = new System.Drawing.Size(117, 97);
            this.pctrAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrAdmin.TabIndex = 1;
            this.pctrAdmin.TabStop = false;
            this.pctrAdmin.Click += new System.EventHandler(this.pctrAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1305, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 618);
            this.Controls.Add(this.btnVizyon);
            this.Controls.Add(this.pctrAdmin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmgiris";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctrAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctrAdmin;
        private System.Windows.Forms.Button btnVizyon;
    }
}

