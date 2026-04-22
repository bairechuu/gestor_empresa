namespace gestor_empresa
{
    partial class FormEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new Guna.UI2.WinForms.Guna2Panel();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctbMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctbCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgcDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlIzq = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOff = new Guna.UI2.WinForms.Guna2Button();
            this.sprInfoIzq = new Guna.UI2.WinForms.Guna2Separator();
            this.lblInfoEmpIzq = new System.Windows.Forms.Label();
            this.cpbImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblInfoEmpMedio = new System.Windows.Forms.Label();
            this.gbxDetallesContrato = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblDetallesContrato = new System.Windows.Forms.Label();
            this.gbxNominas = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvNominas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbxBajas = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvBajas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbxJornada = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblEstadoFichaje = new System.Windows.Forms.Label();
            this.btnFichar = new Guna.UI2.WinForms.Guna2Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNominas = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbImg)).BeginInit();
            this.gbxDetallesContrato.SuspendLayout();
            this.gbxNominas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
            this.gbxBajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).BeginInit();
            this.gbxJornada.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.pnlArriba.Controls.Add(this.pcbLogo);
            this.pnlArriba.Controls.Add(this.ctbMinimizar);
            this.pnlArriba.Controls.Add(this.ctbCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(1280, 75);
            this.pnlArriba.TabIndex = 0;
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
            // dgcDrag
            // 
            this.dgcDrag.DockIndicatorTransparencyValue = 0.6D;
            this.dgcDrag.DragStartTransparencyValue = 1D;
            this.dgcDrag.TargetControl = this.pnlArriba;
            this.dgcDrag.UseTransparentDrag = true;
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlIzq.Controls.Add(this.btnLogOff);
            this.pnlIzq.Controls.Add(this.sprInfoIzq);
            this.pnlIzq.Controls.Add(this.lblInfoEmpIzq);
            this.pnlIzq.Controls.Add(this.cpbImg);
            this.pnlIzq.Location = new System.Drawing.Point(0, 75);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(300, 645);
            this.pnlIzq.TabIndex = 1;
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
            this.btnLogOff.Location = new System.Drawing.Point(28, 564);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOff.Size = new System.Drawing.Size(208, 43);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "Cerrar sesión";
            this.btnLogOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
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
            // lblInfoEmpMedio
            // 
            this.lblInfoEmpMedio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoEmpMedio.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpMedio.ForeColor = System.Drawing.Color.Black;
            this.lblInfoEmpMedio.Location = new System.Drawing.Point(328, 97);
            this.lblInfoEmpMedio.Name = "lblInfoEmpMedio";
            this.lblInfoEmpMedio.Size = new System.Drawing.Size(947, 42);
            this.lblInfoEmpMedio.TabIndex = 3;
            this.lblInfoEmpMedio.Text = "Portal del empleado: placeholder nombre 76767 ububebbwbe";
            this.lblInfoEmpMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxDetallesContrato
            // 
            this.gbxDetallesContrato.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxDetallesContrato.BorderRadius = 10;
            this.gbxDetallesContrato.BorderThickness = 2;
            this.gbxDetallesContrato.Controls.Add(this.lblEstado);
            this.gbxDetallesContrato.Controls.Add(this.lblSalario);
            this.gbxDetallesContrato.Controls.Add(this.lblTipoContrato);
            this.gbxDetallesContrato.Controls.Add(this.lblEmpresa);
            this.gbxDetallesContrato.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxDetallesContrato.FillColor = System.Drawing.Color.Transparent;
            this.gbxDetallesContrato.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetallesContrato.ForeColor = System.Drawing.Color.Black;
            this.gbxDetallesContrato.Location = new System.Drawing.Point(334, 168);
            this.gbxDetallesContrato.Name = "gbxDetallesContrato";
            this.gbxDetallesContrato.Size = new System.Drawing.Size(916, 113);
            this.gbxDetallesContrato.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(493, 67);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 28);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalario
            // 
            this.lblSalario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(493, 23);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(132, 28);
            this.lblSalario.TabIndex = 12;
            this.lblSalario.Text = "Salario anual:";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContrato.ForeColor = System.Drawing.Color.Black;
            this.lblTipoContrato.Location = new System.Drawing.Point(34, 67);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(57, 28);
            this.lblTipoContrato.TabIndex = 11;
            this.lblTipoContrato.Text = "Tipo:";
            this.lblTipoContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblEmpresa.Location = new System.Drawing.Point(34, 23);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(94, 28);
            this.lblEmpresa.TabIndex = 10;
            this.lblEmpresa.Text = "Empresa:";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetallesContrato
            // 
            this.lblDetallesContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetallesContrato.AutoSize = true;
            this.lblDetallesContrato.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesContrato.ForeColor = System.Drawing.Color.Black;
            this.lblDetallesContrato.Location = new System.Drawing.Point(368, 152);
            this.lblDetallesContrato.Name = "lblDetallesContrato";
            this.lblDetallesContrato.Size = new System.Drawing.Size(231, 28);
            this.lblDetallesContrato.TabIndex = 5;
            this.lblDetallesContrato.Text = "Mis detalles de contrato";
            this.lblDetallesContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxNominas
            // 
            this.gbxNominas.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxNominas.BorderRadius = 10;
            this.gbxNominas.BorderThickness = 2;
            this.gbxNominas.Controls.Add(this.dgvNominas);
            this.gbxNominas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxNominas.FillColor = System.Drawing.Color.Transparent;
            this.gbxNominas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNominas.ForeColor = System.Drawing.Color.Black;
            this.gbxNominas.Location = new System.Drawing.Point(618, 308);
            this.gbxNominas.Name = "gbxNominas";
            this.gbxNominas.Size = new System.Drawing.Size(632, 185);
            this.gbxNominas.TabIndex = 5;
            // 
            // dgvNominas
            // 
            this.dgvNominas.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvNominas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNominas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvNominas.ColumnHeadersHeight = 32;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNominas.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvNominas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNominas.Location = new System.Drawing.Point(13, 15);
            this.dgvNominas.MultiSelect = false;
            this.dgvNominas.Name = "dgvNominas";
            this.dgvNominas.ReadOnly = true;
            this.dgvNominas.RowHeadersVisible = false;
            this.dgvNominas.RowHeadersWidth = 51;
            this.dgvNominas.RowTemplate.Height = 24;
            this.dgvNominas.Size = new System.Drawing.Size(609, 159);
            this.dgvNominas.TabIndex = 0;
            this.dgvNominas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvNominas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvNominas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNominas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNominas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNominas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNominas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNominas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNominas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvNominas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNominas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNominas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNominas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNominas.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvNominas.ThemeStyle.ReadOnly = true;
            this.dgvNominas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNominas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNominas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNominas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNominas.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNominas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvNominas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gbxBajas
            // 
            this.gbxBajas.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxBajas.BorderRadius = 10;
            this.gbxBajas.BorderThickness = 2;
            this.gbxBajas.Controls.Add(this.dgvBajas);
            this.gbxBajas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxBajas.FillColor = System.Drawing.Color.Transparent;
            this.gbxBajas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBajas.ForeColor = System.Drawing.Color.Black;
            this.gbxBajas.Location = new System.Drawing.Point(618, 523);
            this.gbxBajas.Name = "gbxBajas";
            this.gbxBajas.Size = new System.Drawing.Size(632, 185);
            this.gbxBajas.TabIndex = 6;
            // 
            // dgvBajas
            // 
            this.dgvBajas.AllowUserToAddRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvBajas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBajas.ColumnHeadersHeight = 32;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBajas.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBajas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvBajas.Location = new System.Drawing.Point(13, 15);
            this.dgvBajas.MultiSelect = false;
            this.dgvBajas.Name = "dgvBajas";
            this.dgvBajas.ReadOnly = true;
            this.dgvBajas.RowHeadersVisible = false;
            this.dgvBajas.RowHeadersWidth = 51;
            this.dgvBajas.RowTemplate.Height = 24;
            this.dgvBajas.Size = new System.Drawing.Size(609, 154);
            this.dgvBajas.TabIndex = 1;
            this.dgvBajas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvBajas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvBajas.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvBajas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBajas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBajas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBajas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBajas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvBajas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvBajas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBajas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBajas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBajas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBajas.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvBajas.ThemeStyle.ReadOnly = true;
            this.dgvBajas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBajas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBajas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBajas.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBajas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBajas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gbxJornada
            // 
            this.gbxJornada.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxJornada.BorderRadius = 10;
            this.gbxJornada.BorderThickness = 2;
            this.gbxJornada.Controls.Add(this.guna2GradientPanel1);
            this.gbxJornada.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxJornada.FillColor = System.Drawing.Color.Transparent;
            this.gbxJornada.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxJornada.ForeColor = System.Drawing.Color.Black;
            this.gbxJornada.Location = new System.Drawing.Point(334, 308);
            this.gbxJornada.Name = "gbxJornada";
            this.gbxJornada.Size = new System.Drawing.Size(278, 400);
            this.gbxJornada.TabIndex = 6;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.lblEstadoFichaje);
            this.guna2GradientPanel1.Controls.Add(this.btnFichar);
            this.guna2GradientPanel1.Controls.Add(this.lblHora);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(16, 19);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(250, 365);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblEstadoFichaje
            // 
            this.lblEstadoFichaje.AllowDrop = true;
            this.lblEstadoFichaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoFichaje.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoFichaje.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFichaje.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFichaje.Location = new System.Drawing.Point(23, 246);
            this.lblEstadoFichaje.Name = "lblEstadoFichaje";
            this.lblEstadoFichaje.Size = new System.Drawing.Size(207, 62);
            this.lblEstadoFichaje.TabIndex = 16;
            this.lblEstadoFichaje.Text = "Entrada";
            this.lblEstadoFichaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFichar
            // 
            this.btnFichar.BackColor = System.Drawing.Color.Transparent;
            this.btnFichar.BorderColor = System.Drawing.Color.White;
            this.btnFichar.BorderRadius = 15;
            this.btnFichar.BorderThickness = 1;
            this.btnFichar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFichar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFichar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFichar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFichar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFichar.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnFichar.ForeColor = System.Drawing.Color.White;
            this.btnFichar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFichar.Location = new System.Drawing.Point(23, 180);
            this.btnFichar.Name = "btnFichar";
            this.btnFichar.Size = new System.Drawing.Size(207, 54);
            this.btnFichar.TabIndex = 15;
            this.btnFichar.Text = "Fichar";
            this.btnFichar.Click += new System.EventHandler(this.btnFichar_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(48, 64);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(163, 72);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "20:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNominas
            // 
            this.lblNominas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNominas.AutoSize = true;
            this.lblNominas.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominas.ForeColor = System.Drawing.Color.Black;
            this.lblNominas.Location = new System.Drawing.Point(727, 292);
            this.lblNominas.Name = "lblNominas";
            this.lblNominas.Size = new System.Drawing.Size(200, 28);
            this.lblNominas.TabIndex = 7;
            this.lblNominas.Text = "Mis últimas nóminas";
            this.lblNominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJornada
            // 
            this.lblJornada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornada.ForeColor = System.Drawing.Color.Black;
            this.lblJornada.Location = new System.Drawing.Point(368, 296);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(193, 28);
            this.lblJornada.TabIndex = 8;
            this.lblJornada.Text = "Registro de Jornada";
            this.lblJornada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(727, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Historial de bajas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJornada);
            this.Controls.Add(this.lblNominas);
            this.Controls.Add(this.gbxJornada);
            this.Controls.Add(this.gbxBajas);
            this.Controls.Add(this.gbxNominas);
            this.Controls.Add(this.lblDetallesContrato);
            this.Controls.Add(this.gbxDetallesContrato);
            this.Controls.Add(this.pnlIzq);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.lblInfoEmpMedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleado";
            this.Text = "ec";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.pnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlIzq.ResumeLayout(false);
            this.pnlIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbImg)).EndInit();
            this.gbxDetallesContrato.ResumeLayout(false);
            this.gbxDetallesContrato.PerformLayout();
            this.gbxNominas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
            this.gbxBajas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).EndInit();
            this.gbxJornada.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlArriba;
        private Guna.UI2.WinForms.Guna2ControlBox ctbMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox ctbCerrar;
        private Guna.UI2.WinForms.Guna2DragControl dgcDrag;
        private Guna.UI2.WinForms.Guna2Panel pnlIzq;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbImg;
        private System.Windows.Forms.Label lblInfoEmpIzq;
        private Guna.UI2.WinForms.Guna2Separator sprInfoIzq;
        private System.Windows.Forms.Label lblInfoEmpMedio;
        private Guna.UI2.WinForms.Guna2GroupBox gbxDetallesContrato;
        private System.Windows.Forms.Label lblDetallesContrato;
        private Guna.UI2.WinForms.Guna2GroupBox gbxNominas;
        private Guna.UI2.WinForms.Guna2GroupBox gbxBajas;
        private Guna.UI2.WinForms.Guna2GroupBox gbxJornada;
        private System.Windows.Forms.Label lblNominas;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSalario;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNominas;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBajas;
        private Guna.UI2.WinForms.Guna2Button btnLogOff;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private Guna.UI2.WinForms.Guna2Button btnFichar;
        private System.Windows.Forms.Label lblEstadoFichaje;
    }
}