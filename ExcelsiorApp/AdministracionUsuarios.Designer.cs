namespace ExcelsiorApp
{
    partial class AdministracionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionUsuarios));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Filtrar = new System.Windows.Forms.Label();
            this.cb_Filtrar = new System.Windows.Forms.ComboBox();
            this.bt_VerGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 44);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 77);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 432);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_Filtrar
            // 
            this.lb_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Filtrar.AutoSize = true;
            this.lb_Filtrar.Location = new System.Drawing.Point(805, 86);
            this.lb_Filtrar.Name = "lb_Filtrar";
            this.lb_Filtrar.Size = new System.Drawing.Size(67, 16);
            this.lb_Filtrar.TabIndex = 6;
            this.lb_Filtrar.Text = "Filtrar Por:";
            this.lb_Filtrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_Filtrar
            // 
            this.cb_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Filtrar.FormattingEnabled = true;
            this.cb_Filtrar.Location = new System.Drawing.Point(878, 83);
            this.cb_Filtrar.Name = "cb_Filtrar";
            this.cb_Filtrar.Size = new System.Drawing.Size(121, 24);
            this.cb_Filtrar.TabIndex = 7;
            this.cb_Filtrar.SelectedIndexChanged += new System.EventHandler(this.cb_Filtrar_SelectedIndexChanged);
            // 
            // bt_VerGrafico
            // 
            this.bt_VerGrafico.Location = new System.Drawing.Point(808, 482);
            this.bt_VerGrafico.Name = "bt_VerGrafico";
            this.bt_VerGrafico.Size = new System.Drawing.Size(141, 32);
            this.bt_VerGrafico.TabIndex = 8;
            this.bt_VerGrafico.Text = "Ver Grafico Usuarios";
            this.bt_VerGrafico.UseVisualStyleBackColor = true;
            this.bt_VerGrafico.Click += new System.EventHandler(this.bt_VerGrafico_Click);
            // 
            // AdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 545);
            this.Controls.Add(this.bt_VerGrafico);
            this.Controls.Add(this.cb_Filtrar);
            this.Controls.Add(this.lb_Filtrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdministracionUsuarios";
            this.Text = "AdministracionUsuarios";
            this.Load += new System.EventHandler(this.AdministracionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Filtrar;
        private System.Windows.Forms.ComboBox cb_Filtrar;
        private System.Windows.Forms.Button bt_VerGrafico;
    }
}