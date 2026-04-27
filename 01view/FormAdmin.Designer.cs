namespace gestor_empresa
{
    partial class FormAdmin
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
            this.pnlArriba = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlIzq = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOff = new Guna.UI2.WinForms.Guna2Button();
            this.sprInfoIzq = new Guna.UI2.WinForms.Guna2Separator();
            this.lblInfoEmpIzq = new System.Windows.Forms.Label();
            this.cpbImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctbMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctbCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnGestPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnContratos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEconomico = new Guna.UI2.WinForms.Guna2Button();
            this.btnPresencia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpIzq = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlArriba.SuspendLayout();
            this.pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tlpIzq.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.pnlArriba.Controls.Add(this.pnlIzq);
            this.pnlArriba.Controls.Add(this.pcbLogo);
            this.pnlArriba.Controls.Add(this.ctbMinimizar);
            this.pnlArriba.Controls.Add(this.ctbCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(1280, 75);
            this.pnlArriba.TabIndex = 1;
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlIzq.Controls.Add(this.btnLogOff);
            this.pnlIzq.Controls.Add(this.sprInfoIzq);
            this.pnlIzq.Controls.Add(this.lblInfoEmpIzq);
            this.pnlIzq.Controls.Add(this.cpbImg);
            this.pnlIzq.Location = new System.Drawing.Point(3, 81);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(300, 645);
            this.pnlIzq.TabIndex = 2;
            // 
            // btnLogOff
            // 
            this.btnLogOff.DefaultAutoSize = true;
            this.btnLogOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOff.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOff.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnLogOff.Image = global::gestor_empresa.Properties.Resources.LogOffNoBg;
            this.btnLogOff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOff.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOff.Location = new System.Drawing.Point(42, 564);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(198, 43);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "Cerrar sesión";
            this.btnLogOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sprInfoIzq
            // 
            this.sprInfoIzq.FillColor = System.Drawing.Color.DimGray;
            this.sprInfoIzq.Location = new System.Drawing.Point(12, 256);
            this.sprInfoIzq.Name = "sprInfoIzq";
            this.sprInfoIzq.Size = new System.Drawing.Size(274, 8);
            this.sprInfoIzq.TabIndex = 2;
            // 
            // lblInfoEmpIzq
            // 
            this.lblInfoEmpIzq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoEmpIzq.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpIzq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoEmpIzq.Location = new System.Drawing.Point(12, 285);
            this.lblInfoEmpIzq.Name = "lblInfoEmpIzq";
            this.lblInfoEmpIzq.Size = new System.Drawing.Size(274, 123);
            this.lblInfoEmpIzq.TabIndex = 1;
            this.lblInfoEmpIzq.Text = "placeholder nombre 76767 ububebbwbe";
            this.lblInfoEmpIzq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cpbImg
            // 
            this.cpbImg.FillColor = System.Drawing.Color.Transparent;
            this.cpbImg.Image = global::gestor_empresa.Properties.Resources.user_img1;
            this.cpbImg.ImageRotate = 0F;
            this.cpbImg.InitialImage = global::gestor_empresa.Properties.Resources.user_img1;
            this.cpbImg.Location = new System.Drawing.Point(50, 40);
            this.cpbImg.Name = "cpbImg";
            this.cpbImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbImg.Size = new System.Drawing.Size(200, 200);
            this.cpbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cpbImg.TabIndex = 0;
            this.cpbImg.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::gestor_empresa.Properties.Resources.logoBlanco_png;
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(-122, -19);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(478, 113);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 5;
            this.pcbLogo.TabStop = false;
            // 
            // ctbMinimizar
            // 
            this.ctbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctbMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.ctbMinimizar.IconColor = System.Drawing.Color.LightGray;
            this.ctbMinimizar.Location = new System.Drawing.Point(1174, 12);
            this.ctbMinimizar.Name = "ctbMinimizar";
            this.ctbMinimizar.Size = new System.Drawing.Size(45, 45);
            this.ctbMinimizar.TabIndex = 1;
            // 
            // ctbCerrar
            // 
            this.ctbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbCerrar.FillColor = System.Drawing.Color.Transparent;
            this.ctbCerrar.IconColor = System.Drawing.Color.LightGray;
            this.ctbCerrar.Location = new System.Drawing.Point(1224, 12);
            this.ctbCerrar.Name = "ctbCerrar";
            this.ctbCerrar.Size = new System.Drawing.Size(45, 45);
            this.ctbCerrar.TabIndex = 0;
            // 
            // btnGestPersonal
            // 
            this.btnGestPersonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnGestPersonal.BorderColor = System.Drawing.Color.White;
            this.btnGestPersonal.BorderRadius = 15;
            this.btnGestPersonal.BorderThickness = 1;
            this.btnGestPersonal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGestPersonal.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnGestPersonal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.btnGestPersonal.CheckedState.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnGestPersonal.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnGestPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGestPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGestPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGestPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGestPersonal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGestPersonal.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnGestPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGestPersonal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGestPersonal.Location = new System.Drawing.Point(23, 50);
            this.btnGestPersonal.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnGestPersonal.Name = "btnGestPersonal";
            this.btnGestPersonal.Size = new System.Drawing.Size(207, 66);
            this.btnGestPersonal.TabIndex = 18;
            this.btnGestPersonal.Text = "Gestión de Personal";
            this.btnGestPersonal.Click += new System.EventHandler(this.btnGestPersonal_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.DefaultAutoSize = true;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.Image = global::gestor_empresa.Properties.Resources.LogOffNoBg;
            this.btnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCerrarSesion.Location = new System.Drawing.Point(27, 593);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(198, 43);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnContratos
            // 
            this.btnContratos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContratos.BackColor = System.Drawing.Color.Transparent;
            this.btnContratos.BorderColor = System.Drawing.Color.White;
            this.btnContratos.BorderRadius = 15;
            this.btnContratos.BorderThickness = 1;
            this.btnContratos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnContratos.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnContratos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.btnContratos.CheckedState.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnContratos.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnContratos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContratos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContratos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContratos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContratos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContratos.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnContratos.ForeColor = System.Drawing.Color.White;
            this.btnContratos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContratos.Location = new System.Drawing.Point(23, 169);
            this.btnContratos.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(207, 66);
            this.btnContratos.TabIndex = 19;
            this.btnContratos.Text = "Gestión Laboral y Contratos";
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnEconomico
            // 
            this.btnEconomico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEconomico.BackColor = System.Drawing.Color.Transparent;
            this.btnEconomico.BorderColor = System.Drawing.Color.White;
            this.btnEconomico.BorderRadius = 15;
            this.btnEconomico.BorderThickness = 1;
            this.btnEconomico.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEconomico.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnEconomico.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.btnEconomico.CheckedState.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnEconomico.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEconomico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEconomico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEconomico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEconomico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEconomico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEconomico.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnEconomico.ForeColor = System.Drawing.Color.White;
            this.btnEconomico.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEconomico.Location = new System.Drawing.Point(23, 288);
            this.btnEconomico.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnEconomico.Name = "btnEconomico";
            this.btnEconomico.Size = new System.Drawing.Size(207, 66);
            this.btnEconomico.TabIndex = 20;
            this.btnEconomico.Text = "Control Económico";
            this.btnEconomico.Click += new System.EventHandler(this.btnEconomico_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPresencia.BackColor = System.Drawing.Color.Transparent;
            this.btnPresencia.BorderColor = System.Drawing.Color.White;
            this.btnPresencia.BorderRadius = 15;
            this.btnPresencia.BorderThickness = 1;
            this.btnPresencia.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPresencia.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnPresencia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.btnPresencia.CheckedState.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnPresencia.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPresencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPresencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPresencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPresencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPresencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPresencia.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnPresencia.ForeColor = System.Drawing.Color.White;
            this.btnPresencia.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPresencia.Location = new System.Drawing.Point(23, 407);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(207, 66);
            this.btnPresencia.TabIndex = 21;
            this.btnPresencia.Text = "Control de Presencia";
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.guna2Panel1.Controls.Add(this.tlpIzq);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(253, 645);
            this.guna2Panel1.TabIndex = 2;
            // 
            // tlpIzq
            // 
            this.tlpIzq.ColumnCount = 1;
            this.tlpIzq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzq.Controls.Add(this.btnCerrarSesion, 0, 5);
            this.tlpIzq.Controls.Add(this.btnGestPersonal, 0, 0);
            this.tlpIzq.Controls.Add(this.btnPresencia, 0, 3);
            this.tlpIzq.Controls.Add(this.btnContratos, 0, 1);
            this.tlpIzq.Controls.Add(this.btnEconomico, 0, 2);
            this.tlpIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpIzq.Location = new System.Drawing.Point(0, 0);
            this.tlpIzq.Name = "tlpIzq";
            this.tlpIzq.RowCount = 6;
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpIzq.Size = new System.Drawing.Size(253, 645);
            this.tlpIzq.TabIndex = 22;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Location = new System.Drawing.Point(249, 75);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1030, 648);
            this.pnlCentral.TabIndex = 3;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.pnlArriba.ResumeLayout(false);
            this.pnlIzq.ResumeLayout(false);
            this.pnlIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.tlpIzq.ResumeLayout(false);
            this.tlpIzq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlArriba;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2ControlBox ctbMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox ctbCerrar;
        private Guna.UI2.WinForms.Guna2Panel pnlIzq;
        private Guna.UI2.WinForms.Guna2Button btnLogOff;
        private Guna.UI2.WinForms.Guna2Separator sprInfoIzq;
        private System.Windows.Forms.Label lblInfoEmpIzq;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbImg;
        private Guna.UI2.WinForms.Guna2Button btnGestPersonal;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
        private Guna.UI2.WinForms.Guna2Button btnContratos;
        private Guna.UI2.WinForms.Guna2Button btnEconomico;
        private Guna.UI2.WinForms.Guna2Button btnPresencia;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tlpIzq;
        private System.Windows.Forms.Panel pnlCentral;
    }
}