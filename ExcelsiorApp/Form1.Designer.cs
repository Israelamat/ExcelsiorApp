namespace ExcelsiorApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.lb_Contraseña = new System.Windows.Forms.Label();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.bt_SingIn = new System.Windows.Forms.Button();
            this.chb_Recurda = new System.Windows.Forms.CheckBox();
            this.lb_Admin = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lb_Info = new System.Windows.Forms.Label();
            this.pb_Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 44);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-7, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(806, 90);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.BackColor = System.Drawing.Color.Gray;
            this.lb_Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Usuario.Location = new System.Drawing.Point(153, 82);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(54, 16);
            this.lb_Usuario.TabIndex = 4;
            this.lb_Usuario.Text = "Usuario";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Location = new System.Drawing.Point(156, 102);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(100, 22);
            this.tb_Usuario.TabIndex = 5;
            // 
            // lb_Contraseña
            // 
            this.lb_Contraseña.AutoSize = true;
            this.lb_Contraseña.BackColor = System.Drawing.Color.Gray;
            this.lb_Contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Contraseña.Location = new System.Drawing.Point(388, 82);
            this.lb_Contraseña.Name = "lb_Contraseña";
            this.lb_Contraseña.Size = new System.Drawing.Size(76, 16);
            this.lb_Contraseña.TabIndex = 6;
            this.lb_Contraseña.Text = "Contraseña";
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Location = new System.Drawing.Point(391, 102);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.Size = new System.Drawing.Size(100, 22);
            this.tb_Contraseña.TabIndex = 7;
            // 
            // bt_SingIn
            // 
            this.bt_SingIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_SingIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_SingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SingIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_SingIn.Location = new System.Drawing.Point(601, 82);
            this.bt_SingIn.Name = "bt_SingIn";
            this.bt_SingIn.Size = new System.Drawing.Size(100, 29);
            this.bt_SingIn.TabIndex = 8;
            this.bt_SingIn.Text = "Sing in";
            this.bt_SingIn.UseVisualStyleBackColor = false;
            // 
            // chb_Recurda
            // 
            this.chb_Recurda.AutoSize = true;
            this.chb_Recurda.BackColor = System.Drawing.Color.Gray;
            this.chb_Recurda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chb_Recurda.Location = new System.Drawing.Point(156, 130);
            this.chb_Recurda.Name = "chb_Recurda";
            this.chb_Recurda.Size = new System.Drawing.Size(100, 20);
            this.chb_Recurda.TabIndex = 9;
            this.chb_Recurda.Text = "Rcuerdame";
            this.chb_Recurda.UseVisualStyleBackColor = false;
            this.chb_Recurda.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_Admin
            // 
            this.lb_Admin.AutoSize = true;
            this.lb_Admin.Location = new System.Drawing.Point(300, 21);
            this.lb_Admin.Name = "lb_Admin";
            this.lb_Admin.Size = new System.Drawing.Size(45, 16);
            this.lb_Admin.TabIndex = 10;
            this.lb_Admin.TabStop = true;
            this.lb_Admin.Text = "Admin";
            this.lb_Admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Admin_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(396, 21);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 16);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(494, 21);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(68, 16);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(598, 21);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(68, 16);
            this.linkLabel4.TabIndex = 13;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(699, 21);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(68, 16);
            this.linkLabel5.TabIndex = 14;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel5";
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.BackColor = System.Drawing.Color.Gray;
            this.lb_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Info.Location = new System.Drawing.Point(262, 131);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(31, 16);
            this.lb_Info.TabIndex = 15;
            this.lb_Info.Text = "Info.";
            this.lb_Info.Click += new System.EventHandler(this.lb_Info_Click);
            // 
            // pb_Fondo
            // 
            this.pb_Fondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Fondo.Location = new System.Drawing.Point(-7, 157);
            this.pb_Fondo.Name = "pb_Fondo";
            this.pb_Fondo.Size = new System.Drawing.Size(806, 296);
            this.pb_Fondo.TabIndex = 16;
            this.pb_Fondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Fondo);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lb_Admin);
            this.Controls.Add(this.chb_Recurda);
            this.Controls.Add(this.bt_SingIn);
            this.Controls.Add(this.tb_Contraseña);
            this.Controls.Add(this.lb_Contraseña);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.Label lb_Contraseña;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.Button bt_SingIn;
        private System.Windows.Forms.CheckBox chb_Recurda;
        private System.Windows.Forms.LinkLabel lb_Admin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.PictureBox pb_Fondo;
    }
}

