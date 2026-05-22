namespace gestor_empresa.Views.Admin
{
    partial class UC_Presencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcPresencia = new Guna.UI2.WinForms.Guna2TabControl();

            this.tbpMonitor = new System.Windows.Forms.TabPage();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.btnRefrescarMonitor = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMonitor = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tbpAuditoria = new System.Windows.Forms.TabPage();
            this.gbxFormularioAuditoria = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblIdJornada = new System.Windows.Forms.Label();
            this.txtIdJornada = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdContrato = new System.Windows.Forms.Label();
            this.txtIdContrato = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.chkSalidaNula = new System.Windows.Forms.CheckBox();
            this.lblHorasExtra = new System.Windows.Forms.Label();
            this.txtHorasExtra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCrearJornada = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarJornada = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarJornada = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarJornada = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAuditoria = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tbpHorasExtra = new System.Windows.Forms.TabPage();
            this.gbxFiltroHoras = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblFiltroInicio = new System.Windows.Forms.Label();
            this.dtpFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroFin = new System.Windows.Forms.Label();
            this.dtpFiltroFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarHoras = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHorasExtra = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tbcPresencia.SuspendLayout();
            this.tbpMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            this.tbpAuditoria.SuspendLayout();
            this.gbxFormularioAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.tbpHorasExtra.SuspendLayout();
            this.gbxFiltroHoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasExtra)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(976, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Presencia";

            // 
            // tbcPresencia
            // 
            this.tbcPresencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPresencia.Controls.Add(this.tbpMonitor);
            this.tbcPresencia.Controls.Add(this.tbpAuditoria);
            this.tbcPresencia.Controls.Add(this.tbpHorasExtra);
            this.tbcPresencia.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcPresencia.Location = new System.Drawing.Point(15, 69);
            this.tbcPresencia.Name = "tbcPresencia";
            this.tbcPresencia.SelectedIndex = 0;
            this.tbcPresencia.Size = new System.Drawing.Size(1000, 553);
            this.tbcPresencia.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.tbcPresencia.TabButtonIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbcPresencia.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.tbcPresencia.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcPresencia.TabIndex = 1;

            // 
            // tbpMonitor
            // 
            this.tbpMonitor.BackColor = System.Drawing.Color.White;
            this.tbpMonitor.Controls.Add(this.lblMonitor);
            this.tbpMonitor.Controls.Add(this.btnRefrescarMonitor);
            this.tbpMonitor.Controls.Add(this.dgvMonitor);
            this.tbpMonitor.Location = new System.Drawing.Point(4, 44);
            this.tbpMonitor.Name = "tbpMonitor";
            this.tbpMonitor.Size = new System.Drawing.Size(968, 505);
            this.tbpMonitor.TabIndex = 0;
            this.tbpMonitor.Text = "Monitor en Tiempo Real";

            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonitor.Location = new System.Drawing.Point(15, 22);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(262, 25);
            this.lblMonitor.Text = "Jornadas Abiertas (Hoy)";

            // 
            // btnRefrescarMonitor
            // 
            this.btnRefrescarMonitor.BorderRadius = 10;
            this.btnRefrescarMonitor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnRefrescarMonitor.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnRefrescarMonitor.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarMonitor.Location = new System.Drawing.Point(754, 16);
            this.btnRefrescarMonitor.Name = "btnRefrescarMonitor";
            this.btnRefrescarMonitor.Size = new System.Drawing.Size(199, 38);
            this.btnRefrescarMonitor.Text = "Refrescar";
            this.btnRefrescarMonitor.Click += new System.EventHandler(this.btnRefrescarMonitor_Click);

            // 
            // dgvMonitor
            // 
            this.dgvMonitor.AllowUserToAddRows = false;
            this.dgvMonitor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMonitor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonitor.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMonitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonitor.Location = new System.Drawing.Point(15, 70);
            this.dgvMonitor.Name = "dgvMonitor";
            this.dgvMonitor.ReadOnly = true;
            this.dgvMonitor.RowHeadersVisible = false;
            this.dgvMonitor.Size = new System.Drawing.Size(938, 412);
            this.dgvMonitor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvMonitor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMonitor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonitor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMonitor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvMonitor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonitor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvMonitor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMonitor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonitor.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvMonitor.ThemeStyle.ReadOnly = true;
            this.dgvMonitor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonitor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonitor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvMonitor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMonitor.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMonitor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMonitor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonitor.RowTemplate.Height = 24;

            // 
            // tbpAuditoria
            // 
            this.tbpAuditoria.BackColor = System.Drawing.Color.White;
            this.tbpAuditoria.Controls.Add(this.gbxFormularioAuditoria);
            this.tbpAuditoria.Controls.Add(this.dgvAuditoria);
            this.tbpAuditoria.Location = new System.Drawing.Point(4, 44);
            this.tbpAuditoria.Name = "tbpAuditoria";
            this.tbpAuditoria.Size = new System.Drawing.Size(968, 505);
            this.tbpAuditoria.Text = "Auditoría";

            // gbxFormularioAuditoria
            // 
            this.gbxFormularioAuditoria.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxFormularioAuditoria.BorderRadius = 10;
            this.gbxFormularioAuditoria.BorderThickness = 2;
            this.gbxFormularioAuditoria.Controls.Add(this.lblIdJornada);
            this.gbxFormularioAuditoria.Controls.Add(this.txtIdJornada);
            this.gbxFormularioAuditoria.Controls.Add(this.lblIdContrato);
            this.gbxFormularioAuditoria.Controls.Add(this.txtIdContrato);
            this.gbxFormularioAuditoria.Controls.Add(this.lblFecha);
            this.gbxFormularioAuditoria.Controls.Add(this.dtpFecha);
            this.gbxFormularioAuditoria.Controls.Add(this.lblEntrada);
            this.gbxFormularioAuditoria.Controls.Add(this.dtpEntrada);
            this.gbxFormularioAuditoria.Controls.Add(this.lblSalida);
            this.gbxFormularioAuditoria.Controls.Add(this.dtpSalida);
            this.gbxFormularioAuditoria.Controls.Add(this.chkSalidaNula);
            this.gbxFormularioAuditoria.Controls.Add(this.lblHorasExtra);
            this.gbxFormularioAuditoria.Controls.Add(this.txtHorasExtra);
            this.gbxFormularioAuditoria.Controls.Add(this.btnCrearJornada);
            this.gbxFormularioAuditoria.Controls.Add(this.btnModificarJornada);
            this.gbxFormularioAuditoria.Controls.Add(this.btnEliminarJornada);
            this.gbxFormularioAuditoria.Controls.Add(this.btnLimpiarJornada);
            this.gbxFormularioAuditoria.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxFormularioAuditoria.FillColor = System.Drawing.Color.Transparent;
            this.gbxFormularioAuditoria.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbxFormularioAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.gbxFormularioAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxFormularioAuditoria.Location = new System.Drawing.Point(15, 22);
            this.gbxFormularioAuditoria.Name = "gbxFormularioAuditoria";
            this.gbxFormularioAuditoria.Size = new System.Drawing.Size(370, 460);
            this.gbxFormularioAuditoria.Text = "Formulario de Registro";

            // 
            // Labels & TextBoxes for Auditoria
            // 
            this.lblIdJornada.AutoSize = true;
            this.lblIdJornada.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblIdJornada.ForeColor = System.Drawing.Color.Black;
            this.lblIdJornada.Location = new System.Drawing.Point(12, 55);
            this.lblIdJornada.Text = "ID Jornada:";
            this.txtIdJornada.Location = new System.Drawing.Point(15, 75);
            this.txtIdJornada.Size = new System.Drawing.Size(155, 28);
            this.txtIdJornada.ReadOnly = true;
            this.txtIdJornada.BorderRadius = 10;

            this.lblIdContrato.AutoSize = true;
            this.lblIdContrato.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblIdContrato.ForeColor = System.Drawing.Color.Black;
            this.lblIdContrato.Location = new System.Drawing.Point(187, 55);
            this.lblIdContrato.Text = "ID Contrato:";
            this.txtIdContrato.Location = new System.Drawing.Point(190, 75);
            this.txtIdContrato.Size = new System.Drawing.Size(155, 28);
            this.txtIdContrato.BorderRadius = 10;

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(12, 115);
            this.lblFecha.Text = "Fecha:";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 135);
            this.dtpFecha.Size = new System.Drawing.Size(155, 28);

            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblEntrada.ForeColor = System.Drawing.Color.Black;
            this.lblEntrada.Location = new System.Drawing.Point(187, 115);
            this.lblEntrada.Text = "Entrada:";
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.ShowUpDown = true;
            this.dtpEntrada.Location = new System.Drawing.Point(190, 135);
            this.dtpEntrada.Size = new System.Drawing.Size(155, 28);

            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblSalida.ForeColor = System.Drawing.Color.Black;
            this.lblSalida.Location = new System.Drawing.Point(12, 175);
            this.lblSalida.Text = "Salida:";
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.ShowUpDown = true;
            this.dtpSalida.Location = new System.Drawing.Point(15, 195);
            this.dtpSalida.Size = new System.Drawing.Size(100, 28);

            this.chkSalidaNula.AutoSize = true;
            this.chkSalidaNula.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.chkSalidaNula.ForeColor = System.Drawing.Color.Black;
            this.chkSalidaNula.Location = new System.Drawing.Point(75, 174);
            this.chkSalidaNula.Text = "Sin salida";
            this.chkSalidaNula.CheckedChanged += new System.EventHandler(this.chkSalidaNula_CheckedChanged);

            this.lblHorasExtra.AutoSize = true;
            this.lblHorasExtra.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblHorasExtra.ForeColor = System.Drawing.Color.Black;
            this.lblHorasExtra.Location = new System.Drawing.Point(187, 175);
            this.lblHorasExtra.Text = "Horas Extra:";
            this.txtHorasExtra.Location = new System.Drawing.Point(190, 195);
            this.txtHorasExtra.Size = new System.Drawing.Size(155, 28);
            this.txtHorasExtra.Text = "0";
            this.txtHorasExtra.BorderRadius = 10;

            // Botones Auditoria
            this.btnCrearJornada.Location = new System.Drawing.Point(15, 255);
            this.btnCrearJornada.Size = new System.Drawing.Size(155, 38);
            this.btnCrearJornada.Text = "Crear";
            this.btnCrearJornada.BorderRadius = 10;
            this.btnCrearJornada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnCrearJornada.ForeColor = System.Drawing.Color.White;
            this.btnCrearJornada.Click += new System.EventHandler(this.btnCrearJornada_Click);

            this.btnModificarJornada.Location = new System.Drawing.Point(190, 255);
            this.btnModificarJornada.Size = new System.Drawing.Size(155, 38);
            this.btnModificarJornada.Text = "Modificar";
            this.btnModificarJornada.BorderRadius = 10;
            this.btnModificarJornada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnModificarJornada.ForeColor = System.Drawing.Color.White;
            this.btnModificarJornada.Click += new System.EventHandler(this.btnModificarJornada_Click);

            this.btnEliminarJornada.Location = new System.Drawing.Point(15, 305);
            this.btnEliminarJornada.Size = new System.Drawing.Size(155, 38);
            this.btnEliminarJornada.Text = "Eliminar";
            this.btnEliminarJornada.BorderRadius = 10;
            this.btnEliminarJornada.FillColor = System.Drawing.Color.IndianRed;
            this.btnEliminarJornada.ForeColor = System.Drawing.Color.White;
            this.btnEliminarJornada.Click += new System.EventHandler(this.btnEliminarJornada_Click);

            this.btnLimpiarJornada.Location = new System.Drawing.Point(190, 305);
            this.btnLimpiarJornada.Size = new System.Drawing.Size(155, 38);
            this.btnLimpiarJornada.Text = "Limpiar";
            this.btnLimpiarJornada.BorderRadius = 10;
            this.btnLimpiarJornada.FillColor = System.Drawing.Color.DimGray;
            this.btnLimpiarJornada.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarJornada.Click += new System.EventHandler(this.btnLimpiarJornada_Click);

            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvAuditoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAuditoria.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAuditoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuditoria.Location = new System.Drawing.Point(395, 22);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.Size = new System.Drawing.Size(558, 460);
            this.dgvAuditoria.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvAuditoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvAuditoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuditoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvAuditoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvAuditoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAuditoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvAuditoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAuditoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuditoria.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvAuditoria.ThemeStyle.ReadOnly = true;
            this.dgvAuditoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuditoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvAuditoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAuditoria.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAuditoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAuditoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.SelectionChanged += new System.EventHandler(this.dgvAuditoria_SelectionChanged);

            // 
            // tbpHorasExtra
            // 
            this.tbpHorasExtra.BackColor = System.Drawing.Color.White;
            this.tbpHorasExtra.Controls.Add(this.gbxFiltroHoras);
            this.tbpHorasExtra.Controls.Add(this.dgvHorasExtra);
            this.tbpHorasExtra.Location = new System.Drawing.Point(4, 44);
            this.tbpHorasExtra.Name = "tbpHorasExtra";
            this.tbpHorasExtra.Size = new System.Drawing.Size(968, 505);
            this.tbpHorasExtra.Text = "Gestión de Horas Extra";
            // 
            // gbxFiltroHoras
            // 
            this.gbxFiltroHoras.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxFiltroHoras.BorderRadius = 10;
            this.gbxFiltroHoras.BorderThickness = 2;
            this.gbxFiltroHoras.Controls.Add(this.lblFiltroInicio);
            this.gbxFiltroHoras.Controls.Add(this.dtpFiltroInicio);
            this.gbxFiltroHoras.Controls.Add(this.lblFiltroFin);
            this.gbxFiltroHoras.Controls.Add(this.dtpFiltroFin);
            this.gbxFiltroHoras.Controls.Add(this.btnBuscarHoras);
            this.gbxFiltroHoras.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxFiltroHoras.FillColor = System.Drawing.Color.Transparent;
            this.gbxFiltroHoras.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbxFiltroHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.gbxFiltroHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltroHoras.Location = new System.Drawing.Point(15, 20);
            this.gbxFiltroHoras.Name = "gbxFiltroHoras";
            this.gbxFiltroHoras.Size = new System.Drawing.Size(938, 120);
            this.gbxFiltroHoras.Text = "Filtro de Búsqueda";

            this.lblFiltroInicio.AutoSize = true;
            this.lblFiltroInicio.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblFiltroInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroInicio.Location = new System.Drawing.Point(17, 45);
            this.lblFiltroInicio.Text = "Fecha Inicio:";
            this.dtpFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroInicio.Location = new System.Drawing.Point(20, 70);
            this.dtpFiltroInicio.Size = new System.Drawing.Size(180, 28);

            this.lblFiltroFin.AutoSize = true;
            this.lblFiltroFin.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblFiltroFin.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroFin.Location = new System.Drawing.Point(217, 45);
            this.lblFiltroFin.Text = "Fecha Fin:";
            this.dtpFiltroFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFin.Location = new System.Drawing.Point(220, 70);
            this.dtpFiltroFin.Size = new System.Drawing.Size(180, 28);

            this.btnBuscarHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarHoras.Location = new System.Drawing.Point(723, 65);
            this.btnBuscarHoras.Size = new System.Drawing.Size(200, 38);
            this.btnBuscarHoras.Text = "Buscar Horas Extra";
            this.btnBuscarHoras.BorderRadius = 10;
            this.btnBuscarHoras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnBuscarHoras.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHoras.Click += new System.EventHandler(this.btnBuscarHoras_Click);

            // 
            // dgvHorasExtra
            // 
            this.dgvHorasExtra.AllowUserToAddRows = false;
            this.dgvHorasExtra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHorasExtra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHorasExtra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHorasExtra.ColumnHeadersHeight = 32;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHorasExtra.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHorasExtra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHorasExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorasExtra.Location = new System.Drawing.Point(15, 160);
            this.dgvHorasExtra.Name = "dgvHorasExtra";
            this.dgvHorasExtra.ReadOnly = true;
            this.dgvHorasExtra.RowHeadersVisible = false;
            this.dgvHorasExtra.Size = new System.Drawing.Size(938, 320);
            this.dgvHorasExtra.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvHorasExtra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHorasExtra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHorasExtra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHorasExtra.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvHorasExtra.ThemeStyle.ReadOnly = true;
            this.dgvHorasExtra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHorasExtra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHorasExtra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.dgvHorasExtra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHorasExtra.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHorasExtra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvHorasExtra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHorasExtra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorasExtra.RowTemplate.Height = 24;

            // 
            // UC_Presencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcPresencia);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_Presencia";
            this.Size = new System.Drawing.Size(1030, 648);
            this.Load += new System.EventHandler(this.UC_Presencia_Load);

            this.tbcPresencia.ResumeLayout(false);
            this.tbpMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();
            this.tbpAuditoria.ResumeLayout(false);
            this.gbxFormularioAuditoria.ResumeLayout(false);
            this.gbxFormularioAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.tbpHorasExtra.ResumeLayout(false);
            this.gbxFiltroHoras.ResumeLayout(false);
            this.gbxFiltroHoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TabControl tbcPresencia;

        private System.Windows.Forms.TabPage tbpMonitor;
        private System.Windows.Forms.Label lblMonitor;
        private Guna.UI2.WinForms.Guna2Button btnRefrescarMonitor;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonitor;

        private System.Windows.Forms.TabPage tbpAuditoria;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFormularioAuditoria;
        private System.Windows.Forms.Label lblIdJornada;
        private Guna.UI2.WinForms.Guna2TextBox txtIdJornada;
        private System.Windows.Forms.Label lblIdContrato;
        private Guna.UI2.WinForms.Guna2TextBox txtIdContrato;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.CheckBox chkSalidaNula;
        private System.Windows.Forms.Label lblHorasExtra;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasExtra;

        private Guna.UI2.WinForms.Guna2Button btnCrearJornada;
        private Guna.UI2.WinForms.Guna2Button btnModificarJornada;
        private Guna.UI2.WinForms.Guna2Button btnEliminarJornada;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarJornada;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAuditoria;

        private System.Windows.Forms.TabPage tbpHorasExtra;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFiltroHoras;
        private System.Windows.Forms.Label lblFiltroInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroInicio;
        private System.Windows.Forms.Label lblFiltroFin;
        private System.Windows.Forms.DateTimePicker dtpFiltroFin;
        private Guna.UI2.WinForms.Guna2Button btnBuscarHoras;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHorasExtra;
    }
}
