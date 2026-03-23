namespace gestor_empresa
{
    partial class MainForm
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pblContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtContrasenya = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pblContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Yu Gothic Medium", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(3, 92);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(594, 61);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a Syncro";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(490, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pblContenedor
            // 
            this.pblContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pblContenedor.BorderRadius = 25;
            this.pblContenedor.Controls.Add(this.lblError);
            this.pblContenedor.Controls.Add(this.lblInstruccion);
            this.pblContenedor.Controls.Add(this.txtContrasenya);
            this.pblContenedor.Controls.Add(this.txtUser);
            this.pblContenedor.Controls.Add(this.pcbLogo);
            this.pblContenedor.Controls.Add(this.lblBienvenida);
            this.pblContenedor.Controls.Add(this.btnLogin);
            this.pblContenedor.FillColor = System.Drawing.Color.White;
            this.pblContenedor.Location = new System.Drawing.Point(335, 69);
            this.pblContenedor.Name = "pblContenedor";
            this.pblContenedor.ShadowDecoration.BorderRadius = 25;
            this.pblContenedor.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pblContenedor.ShadowDecoration.Depth = 10;
            this.pblContenedor.ShadowDecoration.Enabled = true;
            this.pblContenedor.Size = new System.Drawing.Size(600, 450);
            this.pblContenedor.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(3, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(594, 27);
            this.lblError.TabIndex = 8;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
            this.lblInstruccion.Location = new System.Drawing.Point(3, 153);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(594, 27);
            this.lblInstruccion.TabIndex = 7;
            this.lblInstruccion.Text = "Accede a tu cuenta para continuar.";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.BorderRadius = 10;
            this.txtContrasenya.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenya.DefaultText = "";
            this.txtContrasenya.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenya.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenya.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenya.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenya.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContrasenya.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenya.IconLeft = global::gestor_empresa.Properties.Resources.pw_bg;
            this.txtContrasenya.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtContrasenya.Location = new System.Drawing.Point(60, 275);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.PlaceholderText = "Ej: Juan_1234";
            this.txtContrasenya.SelectedText = "";
            this.txtContrasenya.Size = new System.Drawing.Size(489, 58);
            this.txtContrasenya.TabIndex = 6;
            this.txtContrasenya.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // txtUser
            // 
            this.txtUser.BorderRadius = 10;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUser.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconLeft = global::gestor_empresa.Properties.Resources.user;
            this.txtUser.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtUser.Location = new System.Drawing.Point(60, 209);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Ej: 67308761H";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(489, 58);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::gestor_empresa.Properties.Resources.logo_png;
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(60, 14);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(478, 89);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 4;
            this.pcbLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestor_empresa.Properties.Resources.login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pblContenedor);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pblContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBienvenida;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel pblContenedor;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenya;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblError;
    }
}