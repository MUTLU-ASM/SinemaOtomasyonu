
namespace _05042022CinemaProjeOrigin
{
    partial class frmDeneme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeneme));
            this.flwlytpnlResim = new System.Windows.Forms.FlowLayoutPanel();
            this.tblpnlfilm = new System.Windows.Forms.TableLayoutPanel();
            this.grpSeans = new System.Windows.Forms.GroupBox();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.grpKategori = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flwlytpnlResim.SuspendLayout();
            this.grpSeans.SuspendLayout();
            this.grpKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwlytpnlResim
            // 
            this.flwlytpnlResim.AutoScroll = true;
            this.flwlytpnlResim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwlytpnlResim.Controls.Add(this.tblpnlfilm);
            this.flwlytpnlResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwlytpnlResim.Location = new System.Drawing.Point(0, 0);
            this.flwlytpnlResim.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.flwlytpnlResim.Name = "flwlytpnlResim";
            this.flwlytpnlResim.Size = new System.Drawing.Size(1845, 1055);
            this.flwlytpnlResim.TabIndex = 0;
            // 
            // tblpnlfilm
            // 
            this.tblpnlfilm.BackColor = System.Drawing.Color.Black;
            this.tblpnlfilm.ColumnCount = 2;
            this.tblpnlfilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlfilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlfilm.Location = new System.Drawing.Point(3, 3);
            this.tblpnlfilm.Name = "tblpnlfilm";
            this.tblpnlfilm.RowCount = 2;
            this.tblpnlfilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlfilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlfilm.Size = new System.Drawing.Size(1842, 117);
            this.tblpnlfilm.TabIndex = 0;
            // 
            // grpSeans
            // 
            this.grpSeans.BackColor = System.Drawing.Color.Transparent;
            this.grpSeans.Controls.Add(this.cmbSeans);
            this.grpSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSeans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpSeans.Location = new System.Drawing.Point(394, 12);
            this.grpSeans.Name = "grpSeans";
            this.grpSeans.Size = new System.Drawing.Size(269, 99);
            this.grpSeans.TabIndex = 22;
            this.grpSeans.TabStop = false;
            this.grpSeans.Text = "Seanslar";
            // 
            // cmbSeans
            // 
            this.cmbSeans.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(20, 34);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(232, 39);
            this.cmbSeans.TabIndex = 13;
            // 
            // grpKategori
            // 
            this.grpKategori.BackColor = System.Drawing.Color.Transparent;
            this.grpKategori.Controls.Add(this.cmbKategori);
            this.grpKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpKategori.Location = new System.Drawing.Point(24, 12);
            this.grpKategori.Name = "grpKategori";
            this.grpKategori.Size = new System.Drawing.Size(269, 99);
            this.grpKategori.TabIndex = 21;
            this.grpKategori.TabStop = false;
            this.grpKategori.Text = "Kategoriler";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(21, 34);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(232, 39);
            this.cmbKategori.TabIndex = 12;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Transparent;
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArama.Location = new System.Drawing.Point(1743, 30);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(62, 55);
            this.btnArama.TabIndex = 20;
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(1485, 39);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(236, 30);
            this.txtArama.TabIndex = 19;
            this.txtArama.Click += new System.EventHandler(this.txtArama_Click);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.BackColor = System.Drawing.Color.Transparent;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArama.Location = new System.Drawing.Point(1405, 44);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(76, 25);
            this.lblArama.TabIndex = 18;
            this.lblArama.Text = "Arama:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1851, 129);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1845, 1055);
            this.Controls.Add(this.grpSeans);
            this.Controls.Add(this.grpKategori);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.flwlytpnlResim);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeneme";
            this.Text = "frmDeneme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeneme_Load);
            this.flwlytpnlResim.ResumeLayout(false);
            this.grpSeans.ResumeLayout(false);
            this.grpKategori.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwlytpnlResim;
        private System.Windows.Forms.GroupBox grpSeans;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.GroupBox grpKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TableLayoutPanel tblpnlfilm;
        private System.Windows.Forms.Button button1;
    }
}