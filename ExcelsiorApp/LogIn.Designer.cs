namespace ExcelsiorApp
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Dni = new System.Windows.Forms.Label();
            this.tb_Dni = new System.Windows.Forms.TextBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellidos = new System.Windows.Forms.Label();
            this.lb_FechaNacimiento = new System.Windows.Forms.Label();
            this.lb_Capital = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.tb_Capital = new System.Windows.Forms.TextBox();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.datePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 44);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 77);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Dni
            // 
            this.lb_Dni.AutoSize = true;
            this.lb_Dni.Location = new System.Drawing.Point(27, 93);
            this.lb_Dni.Name = "lb_Dni";
            this.lb_Dni.Size = new System.Drawing.Size(30, 16);
            this.lb_Dni.TabIndex = 7;
            this.lb_Dni.Text = "Dni:";
            // 
            // tb_Dni
            // 
            this.tb_Dni.Location = new System.Drawing.Point(107, 87);
            this.tb_Dni.Name = "tb_Dni";
            this.tb_Dni.Size = new System.Drawing.Size(140, 22);
            this.tb_Dni.TabIndex = 8;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(27, 156);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(59, 16);
            this.lb_Nombre.TabIndex = 9;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Apellidos
            // 
            this.lb_Apellidos.AutoSize = true;
            this.lb_Apellidos.Location = new System.Drawing.Point(27, 225);
            this.lb_Apellidos.Name = "lb_Apellidos";
            this.lb_Apellidos.Size = new System.Drawing.Size(67, 16);
            this.lb_Apellidos.TabIndex = 10;
            this.lb_Apellidos.Text = "Apellidos:";
            // 
            // lb_FechaNacimiento
            // 
            this.lb_FechaNacimiento.AutoSize = true;
            this.lb_FechaNacimiento.Location = new System.Drawing.Point(371, 93);
            this.lb_FechaNacimiento.Name = "lb_FechaNacimiento";
            this.lb_FechaNacimiento.Size = new System.Drawing.Size(116, 16);
            this.lb_FechaNacimiento.TabIndex = 11;
            this.lb_FechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lb_Capital
            // 
            this.lb_Capital.AutoSize = true;
            this.lb_Capital.Location = new System.Drawing.Point(27, 300);
            this.lb_Capital.Name = "lb_Capital";
            this.lb_Capital.Size = new System.Drawing.Size(55, 16);
            this.lb_Capital.TabIndex = 12;
            this.lb_Capital.Text = "Captital:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(107, 156);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(140, 22);
            this.tb_Nombre.TabIndex = 13;
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.Location = new System.Drawing.Point(107, 225);
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(140, 22);
            this.tb_Apellidos.TabIndex = 14;
            // 
            // tb_Capital
            // 
            this.tb_Capital.Location = new System.Drawing.Point(107, 297);
            this.tb_Capital.Name = "tb_Capital";
            this.tb_Capital.Size = new System.Drawing.Size(140, 22);
            this.tb_Capital.TabIndex = 16;
            this.tb_Capital.TextChanged += new System.EventHandler(this.tb_Capital_TextChanged);
            this.tb_Capital.DoubleClick += new System.EventHandler(this.tb_Capital_DoubleClick);
            this.tb_Capital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Capital_KeyPress_1);
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Location = new System.Drawing.Point(310, 374);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(149, 38);
            this.bt_Guardar.TabIndex = 17;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // datePicker_FechaNacimiento
            // 
            this.datePicker_FechaNacimiento.Location = new System.Drawing.Point(522, 93);
            this.datePicker_FechaNacimiento.Name = "datePicker_FechaNacimiento";
            this.datePicker_FechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.datePicker_FechaNacimiento.TabIndex = 18;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datePicker_FechaNacimiento);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.tb_Capital);
            this.Controls.Add(this.tb_Apellidos);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.lb_Capital);
            this.Controls.Add(this.lb_FechaNacimiento);
            this.Controls.Add(this.lb_Apellidos);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.tb_Dni);
            this.Controls.Add(this.lb_Dni);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Dni;
        private System.Windows.Forms.TextBox tb_Dni;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Apellidos;
        private System.Windows.Forms.Label lb_FechaNacimiento;
        private System.Windows.Forms.Label lb_Capital;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.TextBox tb_Capital;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.DateTimePicker datePicker_FechaNacimiento;
    }
}