namespace gestor_empresa.Views.Admin
{
    partial class UC_Economico
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcEconomico = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbpProcesamiento = new System.Windows.Forms.TabPage();
            this.gbxGeneracion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblAnyo = new System.Windows.Forms.Label();
            this.txtAnyo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRetencionIRPF = new System.Windows.Forms.Label();
            this.txtRetencionIRPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCotizacionSS = new System.Windows.Forms.Label();
            this.txtCotizacionSS = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblExtrasalariales = new System.Windows.Forms.Label();
            this.txtExtrasalariales = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarContratos = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvContratosActivos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbpHistorico = new System.Windows.Forms.TabPage();
            this.txtFiltroEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFiltroMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltroAnyo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvHistorico = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbcEconomico.SuspendLayout();
            this.tbpProcesamiento.SuspendLayout();
            this.gbxGeneracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratosActivos)).BeginInit();
            this.tbpHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(27, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(976, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Área Económica y Nóminas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbcEconomico
            // 
            this.tbcEconomico.Controls.Add(this.tbpProcesamiento);
            this.tbcEconomico.Controls.Add(this.tbpHistorico);
            this.tbcEconomico.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcEconomico.Location = new System.Drawing.Point(27, 69);
            this.tbcEconomico.Name = "tbcEconomico";
            this.tbcEconomico.SelectedIndex = 0;
            this.tbcEconomico.Size = new System.Drawing.Size(976, 553);
            this.tbcEconomico.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEconomico.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.tbcEconomico.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEconomico.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tbcEconomico.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcEconomico.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEconomico.TabButtonIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbcEconomico.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEconomico.TabButtonIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.tbcEconomico.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcEconomico.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEconomico.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.tbcEconomico.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEconomico.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcEconomico.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbcEconomico.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbcEconomico.TabIndex = 1;
            this.tbcEconomico.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            this.tbcEconomico.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbpProcesamiento
            // 
            this.tbpProcesamiento.BackColor = System.Drawing.Color.White;
            this.tbpProcesamiento.Controls.Add(this.gbxGeneracion);
            this.tbpProcesamiento.Controls.Add(this.txtBuscarContratos);
            this.tbpProcesamiento.Controls.Add(this.dgvContratosActivos);
            this.tbpProcesamiento.Location = new System.Drawing.Point(4, 44);
            this.tbpProcesamiento.Name = "tbpProcesamiento";
            this.tbpProcesamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcesamiento.Size = new System.Drawing.Size(968, 505);
            this.tbpProcesamiento.TabIndex = 0;
            this.tbpProcesamiento.Text = "Procesamiento de Nóminas";
            // 
            // gbxGeneracion
            // 
            this.gbxGeneracion.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxGeneracion.BorderRadius = 10;
            this.gbxGeneracion.BorderThickness = 2;
            this.gbxGeneracion.Controls.Add(this.lblMes);
            this.gbxGeneracion.Controls.Add(this.cmbMes);
            this.gbxGeneracion.Controls.Add(this.lblAnyo);
            this.gbxGeneracion.Controls.Add(this.txtAnyo);
            this.gbxGeneracion.Controls.Add(this.lblSalarioBruto);
            this.gbxGeneracion.Controls.Add(this.txtSalarioBruto);
            this.gbxGeneracion.Controls.Add(this.lblRetencionIRPF);
            this.gbxGeneracion.Controls.Add(this.txtRetencionIRPF);
            this.gbxGeneracion.Controls.Add(this.lblCotizacionSS);
            this.gbxGeneracion.Controls.Add(this.txtCotizacionSS);
            this.gbxGeneracion.Controls.Add(this.lblSalarioBase);
            this.gbxGeneracion.Controls.Add(this.txtSalarioBase);
            this.gbxGeneracion.Controls.Add(this.lblSalarioNeto);
            this.gbxGeneracion.Controls.Add(this.txtSalarioNeto);
            this.gbxGeneracion.Controls.Add(this.lblExtrasalariales);
            this.gbxGeneracion.Controls.Add(this.txtExtrasalariales);
            this.gbxGeneracion.Controls.Add(this.btnCalcular);
            this.gbxGeneracion.Controls.Add(this.btnGenerar);
            this.gbxGeneracion.Controls.Add(this.btnLimpiar);
            this.gbxGeneracion.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxGeneracion.FillColor = System.Drawing.Color.Transparent;
            this.gbxGeneracion.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gbxGeneracion.ForeColor = System.Drawing.Color.Black;
            this.gbxGeneracion.Location = new System.Drawing.Point(20, 22);
            this.gbxGeneracion.Name = "gbxGeneracion";
            this.gbxGeneracion.Size = new System.Drawing.Size(446, 465);
            this.gbxGeneracion.TabIndex = 0;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(14, 24);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 20);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes";
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.BorderRadius = 10;
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMes.ItemHeight = 30;
            this.cmbMes.Items.AddRange(new object[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
            this.cmbMes.Location = new System.Drawing.Point(18, 48);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(193, 36);
            this.cmbMes.TabIndex = 1;
            // 
            // lblAnyo
            // 
            this.lblAnyo.AutoSize = true;
            this.lblAnyo.Location = new System.Drawing.Point(223, 24);
            this.lblAnyo.Name = "lblAnyo";
            this.lblAnyo.Size = new System.Drawing.Size(36, 20);
            this.lblAnyo.TabIndex = 2;
            this.lblAnyo.Text = "Año";
            // 
            // txtAnyo
            // 
            this.txtAnyo.BorderRadius = 10;
            this.txtAnyo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnyo.DefaultText = "";
            this.txtAnyo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnyo.Location = new System.Drawing.Point(227, 48);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.PlaceholderText = "Ej: 2026";
            this.txtAnyo.Size = new System.Drawing.Size(193, 36);
            this.txtAnyo.TabIndex = 3;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(14, 180);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(95, 20);
            this.lblSalarioBruto.TabIndex = 4;
            this.lblSalarioBruto.Text = "Salario Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.BorderRadius = 10;
            this.txtSalarioBruto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalarioBruto.DefaultText = "";
            this.txtSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalarioBruto.Location = new System.Drawing.Point(18, 204);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.PlaceholderText = "0.00";
            this.txtSalarioBruto.ReadOnly = true;
            this.txtSalarioBruto.Size = new System.Drawing.Size(193, 36);
            this.txtSalarioBruto.TabIndex = 5;
            // 
            // lblRetencionIRPF
            // 
            this.lblRetencionIRPF.AutoSize = true;
            this.lblRetencionIRPF.Location = new System.Drawing.Point(223, 180);
            this.lblRetencionIRPF.Name = "lblRetencionIRPF";
            this.lblRetencionIRPF.Size = new System.Drawing.Size(109, 20);
            this.lblRetencionIRPF.TabIndex = 6;
            this.lblRetencionIRPF.Text = "Retención IRPF";
            // 
            // txtRetencionIRPF
            // 
            this.txtRetencionIRPF.BorderRadius = 10;
            this.txtRetencionIRPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetencionIRPF.DefaultText = "";
            this.txtRetencionIRPF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRetencionIRPF.Location = new System.Drawing.Point(227, 204);
            this.txtRetencionIRPF.Name = "txtRetencionIRPF";
            this.txtRetencionIRPF.PlaceholderText = "0.00";
            this.txtRetencionIRPF.ReadOnly = true;
            this.txtRetencionIRPF.Size = new System.Drawing.Size(193, 36);
            this.txtRetencionIRPF.TabIndex = 7;
            // 
            // lblCotizacionSS
            // 
            this.lblCotizacionSS.AutoSize = true;
            this.lblCotizacionSS.Location = new System.Drawing.Point(14, 258);
            this.lblCotizacionSS.Name = "lblCotizacionSS";
            this.lblCotizacionSS.Size = new System.Drawing.Size(98, 20);
            this.lblCotizacionSS.TabIndex = 8;
            this.lblCotizacionSS.Text = "Cotización SS";
            // 
            // txtCotizacionSS
            // 
            this.txtCotizacionSS.BorderRadius = 10;
            this.txtCotizacionSS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCotizacionSS.DefaultText = "";
            this.txtCotizacionSS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCotizacionSS.Location = new System.Drawing.Point(18, 282);
            this.txtCotizacionSS.Name = "txtCotizacionSS";
            this.txtCotizacionSS.PlaceholderText = "0.00";
            this.txtCotizacionSS.ReadOnly = true;
            this.txtCotizacionSS.Size = new System.Drawing.Size(193, 36);
            this.txtCotizacionSS.TabIndex = 9;
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalarioNeto.Location = new System.Drawing.Point(223, 258);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(92, 20);
            this.lblSalarioNeto.TabIndex = 10;
            this.lblSalarioNeto.Text = "Salario Neto";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.BorderRadius = 10;
            this.txtSalarioNeto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalarioNeto.DefaultText = "";
            this.txtSalarioNeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSalarioNeto.Location = new System.Drawing.Point(227, 282);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.PlaceholderText = "0.00";
            this.txtSalarioNeto.ReadOnly = true;
            this.txtSalarioNeto.Size = new System.Drawing.Size(193, 36);
            this.txtSalarioNeto.TabIndex = 11;
            // 
            // lblExtrasalariales
            // 
            this.lblExtrasalariales.AutoSize = true;
            this.lblExtrasalariales.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblExtrasalariales.Location = new System.Drawing.Point(223, 102);
            this.lblExtrasalariales.Name = "lblExtrasalariales";
            this.lblExtrasalariales.Size = new System.Drawing.Size(150, 20);
            this.lblExtrasalariales.TabIndex = 20;
            this.lblExtrasalariales.Text = "P. Extrasalariales (€)";
            // 
            // txtExtrasalariales
            // 
            this.txtExtrasalariales.BorderRadius = 10;
            this.txtExtrasalariales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtrasalariales.DefaultText = "0";
            this.txtExtrasalariales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtrasalariales.Location = new System.Drawing.Point(227, 126);
            this.txtExtrasalariales.Name = "txtExtrasalariales";
            this.txtExtrasalariales.PlaceholderText = "Dietas, Transporte...";
            this.txtExtrasalariales.Size = new System.Drawing.Size(193, 36);
            this.txtExtrasalariales.TabIndex = 21;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(14, 102);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(89, 20);
            this.lblSalarioBase.TabIndex = 22;
            this.lblSalarioBase.Text = "Salario Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BorderRadius = 10;
            this.txtSalarioBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalarioBase.DefaultText = "";
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(18, 126);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.PlaceholderText = "0.00";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(193, 36);
            this.txtSalarioBase.TabIndex = 23;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BorderRadius = 10;
            this.btnGenerar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(18, 410);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 38);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar Nómina";
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BorderRadius = 10;
            this.btnCalcular.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(158, 410);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 38);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.FillColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 410);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 38);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtBuscarContratos
            // 
            this.txtBuscarContratos.BorderRadius = 10;
            this.txtBuscarContratos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarContratos.DefaultText = "";
            this.txtBuscarContratos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarContratos.Location = new System.Drawing.Point(498, 22);
            this.txtBuscarContratos.Name = "txtBuscarContratos";
            this.txtBuscarContratos.PlaceholderText = "Buscar contratos activos...";
            this.txtBuscarContratos.Size = new System.Drawing.Size(446, 28);
            this.txtBuscarContratos.TabIndex = 15;
            this.txtBuscarContratos.TextChanged += new System.EventHandler(this.TxtBuscarContratos_TextChanged);
            // 
            // dgvContratosActivos
            // 
            this.dgvContratosActivos.AllowUserToAddRows = false;
            this.dgvContratosActivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvContratosActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContratosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContratosActivos.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContratosActivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContratosActivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvContratosActivos.Location = new System.Drawing.Point(498, 56);
            this.dgvContratosActivos.Name = "dgvContratosActivos";
            this.dgvContratosActivos.ReadOnly = true;
            this.dgvContratosActivos.RowHeadersVisible = false;
            this.dgvContratosActivos.RowHeadersWidth = 51;
            this.dgvContratosActivos.Size = new System.Drawing.Size(446, 431);
            this.dgvContratosActivos.TabIndex = 16;
            this.dgvContratosActivos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvContratosActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvContratosActivos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvContratosActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvContratosActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvContratosActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvContratosActivos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvContratosActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContratosActivos.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvContratosActivos.ThemeStyle.ReadOnly = true;
            this.dgvContratosActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvContratosActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContratosActivos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvContratosActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvContratosActivos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvContratosActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvContratosActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContratosActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContratosActivos_CellClick);
            // 
            // tbpHistorico
            // 
            this.tbpHistorico.BackColor = System.Drawing.Color.White;
            this.tbpHistorico.Controls.Add(this.txtFiltroEmpleado);
            this.tbpHistorico.Controls.Add(this.cmbFiltroMes);
            this.tbpHistorico.Controls.Add(this.txtFiltroAnyo);
            this.tbpHistorico.Controls.Add(this.dgvHistorico);
            this.tbpHistorico.Location = new System.Drawing.Point(4, 44);
            this.tbpHistorico.Name = "tbpHistorico";
            this.tbpHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistorico.Size = new System.Drawing.Size(968, 505);
            this.tbpHistorico.TabIndex = 1;
            this.tbpHistorico.Text = "Histórico Retributivo";
            // 
            // txtFiltroEmpleado
            // 
            this.txtFiltroEmpleado.BorderRadius = 10;
            this.txtFiltroEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroEmpleado.DefaultText = "";
            this.txtFiltroEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroEmpleado.Location = new System.Drawing.Point(20, 22);
            this.txtFiltroEmpleado.Name = "txtFiltroEmpleado";
            this.txtFiltroEmpleado.PlaceholderText = "Filtrar por empleado...";
            this.txtFiltroEmpleado.Size = new System.Drawing.Size(300, 36);
            this.txtFiltroEmpleado.TabIndex = 0;
            this.txtFiltroEmpleado.TextChanged += new System.EventHandler(this.FiltrosHistorico_Changed);
            // 
            // cmbFiltroMes
            // 
            this.cmbFiltroMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroMes.BorderRadius = 10;
            this.cmbFiltroMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFiltroMes.ItemHeight = 30;
            this.cmbFiltroMes.Items.AddRange(new object[] {
            "Todos", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
            this.cmbFiltroMes.Location = new System.Drawing.Point(340, 22);
            this.cmbFiltroMes.Name = "cmbFiltroMes";
            this.cmbFiltroMes.Size = new System.Drawing.Size(150, 36);
            this.cmbFiltroMes.StartIndex = 0;
            this.cmbFiltroMes.TabIndex = 1;
            this.cmbFiltroMes.SelectedIndexChanged += new System.EventHandler(this.FiltrosHistorico_Changed);
            // 
            // txtFiltroAnyo
            // 
            this.txtFiltroAnyo.BorderRadius = 10;
            this.txtFiltroAnyo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAnyo.DefaultText = "";
            this.txtFiltroAnyo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroAnyo.Location = new System.Drawing.Point(510, 22);
            this.txtFiltroAnyo.Name = "txtFiltroAnyo";
            this.txtFiltroAnyo.PlaceholderText = "Filtrar por año...";
            this.txtFiltroAnyo.Size = new System.Drawing.Size(150, 36);
            this.txtFiltroAnyo.TabIndex = 2;
            this.txtFiltroAnyo.TextChanged += new System.EventHandler(this.FiltrosHistorico_Changed);
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistorico.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistorico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHistorico.Location = new System.Drawing.Point(20, 76);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersVisible = false;
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.Size = new System.Drawing.Size(924, 411);
            this.dgvHistorico.TabIndex = 3;
            this.dgvHistorico.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvHistorico.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHistorico.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHistorico.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHistorico.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHistorico.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHistorico.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorico.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHistorico.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvHistorico.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorico.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvHistorico.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorico.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorico.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvHistorico.ThemeStyle.ReadOnly = true;
            this.dgvHistorico.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorico.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorico.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvHistorico.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorico.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHistorico.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvHistorico.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // UC_Economico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbcEconomico);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_Economico";
            this.Size = new System.Drawing.Size(1030, 648);
            this.tbcEconomico.ResumeLayout(false);
            this.tbpProcesamiento.ResumeLayout(false);
            this.gbxGeneracion.ResumeLayout(false);
            this.gbxGeneracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratosActivos)).EndInit();
            this.tbpHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TabControl tbcEconomico;
        private System.Windows.Forms.TabPage tbpProcesamiento;
        private Guna.UI2.WinForms.Guna2GroupBox gbxGeneracion;
        private System.Windows.Forms.Label lblMes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMes;
        private System.Windows.Forms.Label lblAnyo;
        private Guna.UI2.WinForms.Guna2TextBox txtAnyo;
        private System.Windows.Forms.Label lblSalarioBruto;
        private Guna.UI2.WinForms.Guna2TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lblRetencionIRPF;
        private Guna.UI2.WinForms.Guna2TextBox txtRetencionIRPF;
        private System.Windows.Forms.Label lblCotizacionSS;
        private Guna.UI2.WinForms.Guna2TextBox txtCotizacionSS;
        private System.Windows.Forms.Label lblSalarioNeto;
        private Guna.UI2.WinForms.Guna2TextBox txtSalarioNeto;
        private Guna.UI2.WinForms.Guna2Button btnGenerar;
        private Guna.UI2.WinForms.Guna2Button btnCalcular;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarContratos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvContratosActivos;
        private System.Windows.Forms.TabPage tbpHistorico;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroEmpleado;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMes;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroAnyo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorico;
        private System.Windows.Forms.Label lblExtrasalariales;
        private Guna.UI2.WinForms.Guna2TextBox txtExtrasalariales;
        private System.Windows.Forms.Label lblSalarioBase;
        private Guna.UI2.WinForms.Guna2TextBox txtSalarioBase;
    }
}
