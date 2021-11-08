namespace WindowsFormsApplication1
{
    partial class cliente_Form
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.Petición_Marc = new System.Windows.Forms.RadioButton();
            this.Petición_Alba = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Petición_Eloi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userRegister = new System.Windows.Forms.TextBox();
            this.contraRegister = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.contraLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.RadioButton();
            this.Register = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.BackColor = System.Drawing.Color.LawnGreen;
            this.Conectar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.Location = new System.Drawing.Point(16, 15);
            this.Conectar.Margin = new System.Windows.Forms.Padding(4);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(1013, 27);
            this.Conectar.TabIndex = 7;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.BackColor = System.Drawing.Color.DarkRed;
            this.Desconectar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Desconectar.Location = new System.Drawing.Point(16, 49);
            this.Desconectar.Margin = new System.Windows.Forms.Padding(4);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(1013, 27);
            this.Desconectar.TabIndex = 8;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = false;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // enviar
            // 
            this.enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enviar.Location = new System.Drawing.Point(8, 324);
            this.enviar.Margin = new System.Windows.Forms.Padding(4);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(997, 28);
            this.enviar.TabIndex = 5;
            this.enviar.Text = "Enviar Petición";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Petición_Marc
            // 
            this.Petición_Marc.AutoSize = true;
            this.Petición_Marc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Petición_Marc.Location = new System.Drawing.Point(508, 87);
            this.Petición_Marc.Margin = new System.Windows.Forms.Padding(4);
            this.Petición_Marc.Name = "Petición_Marc";
            this.Petición_Marc.Size = new System.Drawing.Size(253, 21);
            this.Petición_Marc.TabIndex = 8;
            this.Petición_Marc.TabStop = true;
            this.Petición_Marc.Text = "¿Número de Partidas jugadas?";
            this.Petición_Marc.UseVisualStyleBackColor = true;
            // 
            // Petición_Alba
            // 
            this.Petición_Alba.AutoSize = true;
            this.Petición_Alba.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Petición_Alba.Location = new System.Drawing.Point(508, 117);
            this.Petición_Alba.Margin = new System.Windows.Forms.Padding(4);
            this.Petición_Alba.Name = "Petición_Alba";
            this.Petición_Alba.Size = new System.Drawing.Size(429, 21);
            this.Petición_Alba.TabIndex = 7;
            this.Petición_Alba.TabStop = true;
            this.Petición_Alba.Text = "¿Número de créditos después de una partida ganada?";
            this.Petición_Alba.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(21, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contraseña:";
            // 
            // Petición_Eloi
            // 
            this.Petición_Eloi.AutoSize = true;
            this.Petición_Eloi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Petición_Eloi.Location = new System.Drawing.Point(508, 146);
            this.Petición_Eloi.Margin = new System.Windows.Forms.Padding(4);
            this.Petición_Eloi.Name = "Petición_Eloi";
            this.Petición_Eloi.Size = new System.Drawing.Size(221, 21);
            this.Petición_Eloi.TabIndex = 17;
            this.Petición_Eloi.TabStop = true;
            this.Petición_Eloi.Text = "¿Contra quién he ganado?";
            this.Petición_Eloi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(21, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(21, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Contraseña:";
            // 
            // userRegister
            // 
            this.userRegister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userRegister.Location = new System.Drawing.Point(113, 85);
            this.userRegister.Margin = new System.Windows.Forms.Padding(4);
            this.userRegister.Name = "userRegister";
            this.userRegister.Size = new System.Drawing.Size(219, 23);
            this.userRegister.TabIndex = 22;
            // 
            // contraRegister
            // 
            this.contraRegister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contraRegister.Location = new System.Drawing.Point(141, 121);
            this.contraRegister.Margin = new System.Windows.Forms.Padding(4);
            this.contraRegister.Name = "contraRegister";
            this.contraRegister.Size = new System.Drawing.Size(191, 23);
            this.contraRegister.TabIndex = 23;
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userLogin.Location = new System.Drawing.Point(113, 225);
            this.userLogin.Margin = new System.Windows.Forms.Padding(4);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(219, 23);
            this.userLogin.TabIndex = 24;
            // 
            // contraLogin
            // 
            this.contraLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contraLogin.Location = new System.Drawing.Point(141, 263);
            this.contraLogin.Margin = new System.Windows.Forms.Padding(4);
            this.contraLogin.Name = "contraLogin";
            this.contraLogin.Size = new System.Drawing.Size(191, 23);
            this.contraLogin.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.fechaPartida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.Register);
            this.groupBox1.Controls.Add(this.contraLogin);
            this.groupBox1.Controls.Add(this.userLogin);
            this.groupBox1.Controls.Add(this.contraRegister);
            this.groupBox1.Controls.Add(this.userRegister);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Petición_Eloi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Petición_Alba);
            this.groupBox1.Controls.Add(this.Petición_Marc);
            this.groupBox1.Controls.Add(this.enviar);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 359);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticiones, Grupo 10";
            // 
            // fechaPartida
            // 
            this.fechaPartida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fechaPartida.Location = new System.Drawing.Point(581, 245);
            this.fechaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.fechaPartida.Name = "fechaPartida";
            this.fechaPartida.Size = new System.Drawing.Size(219, 23);
            this.fechaPartida.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha de la partida";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Login.Location = new System.Drawing.Point(141, 176);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(90, 24);
            this.Login.TabIndex = 27;
            this.Login.TabStop = true;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Register.Location = new System.Drawing.Point(125, 38);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(110, 24);
            this.Register.TabIndex = 26;
            this.Register.TabStop = true;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // cliente_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1045, 458);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cliente_Form";
            this.Text = "Formulario del Cliente, Grupo 10";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.RadioButton Petición_Marc;
        private System.Windows.Forms.RadioButton Petición_Alba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Petición_Eloi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userRegister;
        private System.Windows.Forms.TextBox contraRegister;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox contraLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Login;
        private System.Windows.Forms.RadioButton Register;
        private System.Windows.Forms.TextBox fechaPartida;
        private System.Windows.Forms.Label label2;
    }
}

