namespace gestor_empresa.Views.Admin
{
    partial class UC_Bienvenida
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.gbxCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gbxCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCard
            // 
            this.gbxCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCard.BackColor = System.Drawing.Color.Transparent;
            this.gbxCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.gbxCard.BorderRadius = 20;
            this.gbxCard.BorderThickness = 1;
            this.gbxCard.Controls.Add(this.lblSubtitulo);
            this.gbxCard.Controls.Add(this.lblTitulo);
            this.gbxCard.Controls.Add(this.pcbLogo);
            this.gbxCard.FillColor = System.Drawing.Color.White;
            this.gbxCard.Location = new System.Drawing.Point(175, 114);
            this.gbxCard.Name = "gbxCard";
            this.gbxCard.ShadowDecoration.BorderRadius = 20;
            this.gbxCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbxCard.ShadowDecoration.Enabled = true;
            this.gbxCard.Size = new System.Drawing.Size(680, 420);
            this.gbxCard.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 280);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 62);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Por favor, seleccione una opción en el menú lateral para comenzar a gestionar.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(37, 144);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 118);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "¡Bienvenido al panel de administración!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::gestor_empresa.Properties.Resources.logo_png;
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(184, 42);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(300, 90);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 1;
            this.pcbLogo.TabStop = false;
            // 
            // UC_Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.gbxCard);
            this.Name = "UC_Bienvenida";
            this.Size = new System.Drawing.Size(1030, 648);
            this.gbxCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gbxCard;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}
