namespace gestorempresa.Views.Admin
{
    partial class UCPersonal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcPersonal = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbpEmpleados = new System.Windows.Forms.TabPage();
            this.lblListadoEmpleados = new System.Windows.Forms.Label();
            this.gbxAccesos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarRol = new Guna.UI2.WinForms.Guna2Button();
            this.cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbxFormularioEmpleado = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnDarBajaEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnCrearEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNif = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.dgvEmpleados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBuscarEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbpEmpresas = new System.Windows.Forms.TabPage();
            this.lblListadoEmpresas = new System.Windows.Forms.Label();
            this.gbxFormularioEmpresa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCrearEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.txtCif = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCif = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.dgvEmpresas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbcPersonal.SuspendLayout();
            this.tbpEmpleados.SuspendLayout();
            this.gbxAccesos.SuspendLayout();
            this.gbxFormularioEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tbpEmpresas.SuspendLayout();
            this.gbxFormularioEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
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
            this.lblTitulo.Text = "Gestión de Personal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbcPersonal
            // 
            this.tbcPersonal.Controls.Add(this.tbpEmpleados);
            this.tbcPersonal.Controls.Add(this.tbpEmpresas);
            this.tbcPersonal.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcPersonal.Location = new System.Drawing.Point(27, 69);
            this.tbcPersonal.Name = "tbcPersonal";
            this.tbcPersonal.SelectedIndex = 0;
            this.tbcPersonal.Size = new System.Drawing.Size(976, 553);
            this.tbcPersonal.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbcPersonal.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.tbcPersonal.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcPersonal.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tbcPersonal.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.tbcPersonal.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbcPersonal.TabButtonIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbcPersonal.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcPersonal.TabButtonIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.tbcPersonal.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.tbcPersonal.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbcPersonal.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.tbcPersonal.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcPersonal.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcPersonal.TabButtonSelectedState.InnerColor = System.Drawing.Color.Transparent;
            this.tbcPersonal.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbcPersonal.TabIndex = 1;
            this.tbcPersonal.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            this.tbcPersonal.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbpEmpleados
            // 
            this.tbpEmpleados.BackColor = System.Drawing.Color.White;
            this.tbpEmpleados.Controls.Add(this.lblListadoEmpleados);
            this.tbpEmpleados.Controls.Add(this.gbxAccesos);
            this.tbpEmpleados.Controls.Add(this.gbxFormularioEmpleado);
            this.tbpEmpleados.Controls.Add(this.dgvEmpleados);
            this.tbpEmpleados.Controls.Add(this.txtBuscarEmpleado);
            this.tbpEmpleados.Location = new System.Drawing.Point(4, 44);
            this.tbpEmpleados.Name = "tbpEmpleados";
            this.tbpEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpleados.Size = new System.Drawing.Size(968, 505);
            this.tbpEmpleados.TabIndex = 0;
            this.tbpEmpleados.Text = "Empleados";
            // 
            // lblListadoEmpleados
            // 
            this.lblListadoEmpleados.AutoSize = true;
            this.lblListadoEmpleados.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblListadoEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblListadoEmpleados.Location = new System.Drawing.Point(493, 22);
            this.lblListadoEmpleados.Name = "lblListadoEmpleados";
            this.lblListadoEmpleados.Size = new System.Drawing.Size(184, 25);
            this.lblListadoEmpleados.TabIndex = 4;
            this.lblListadoEmpleados.Text = "Listado de empleados";
            // 
            // gbxAccesos
            // 
            this.gbxAccesos.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxAccesos.BorderRadius = 10;
            this.gbxAccesos.BorderThickness = 2;
            this.gbxAccesos.Controls.Add(this.btnResetPassword);
            this.gbxAccesos.Controls.Add(this.btnCambiarRol);
            this.gbxAccesos.Controls.Add(this.cmbRol);
            this.gbxAccesos.Controls.Add(this.lblRol);
            this.gbxAccesos.Controls.Add(this.lblPassword);
            this.gbxAccesos.Controls.Add(this.txtPassword);
            this.gbxAccesos.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxAccesos.FillColor = System.Drawing.Color.Transparent;
            this.gbxAccesos.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gbxAccesos.ForeColor = System.Drawing.Color.Black;
            this.gbxAccesos.Location = new System.Drawing.Point(20, 331);
            this.gbxAccesos.Name = "gbxAccesos";
            this.gbxAccesos.Size = new System.Drawing.Size(446, 156);
            this.gbxAccesos.TabIndex = 3;
            this.gbxAccesos.Text = "Gestión de accesos";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BorderRadius = 10;
            this.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(227, 101);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(193, 38);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Resetear contraseña";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.BorderRadius = 10;
            this.btnCambiarRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnCambiarRol.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnCambiarRol.ForeColor = System.Drawing.Color.White;
            this.btnCambiarRol.Location = new System.Drawing.Point(227, 47);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(193, 38);
            this.btnCambiarRol.TabIndex = 4;
            this.btnCambiarRol.Text = "Actualizar rol";
            this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderRadius = 10;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRol.ItemHeight = 30;
            this.cmbRol.Items.AddRange(new object[] {
            "empleado",
            "admin"});
            this.cmbRol.Location = new System.Drawing.Point(18, 103);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(191, 36);
            this.cmbRol.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblRol.Location = new System.Drawing.Point(14, 79);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 21);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblPassword.Location = new System.Drawing.Point(14, 24);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(18, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Nueva contraseña";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(191, 28);
            this.txtPassword.TabIndex = 0;
            // 
            // gbxFormularioEmpleado
            // 
            this.gbxFormularioEmpleado.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxFormularioEmpleado.BorderRadius = 10;
            this.gbxFormularioEmpleado.BorderThickness = 2;
            this.gbxFormularioEmpleado.Controls.Add(this.btnLimpiarEmpleado);
            this.gbxFormularioEmpleado.Controls.Add(this.btnDarBajaEmpleado);
            this.gbxFormularioEmpleado.Controls.Add(this.btnModificarEmpleado);
            this.gbxFormularioEmpleado.Controls.Add(this.btnCrearEmpleado);
            this.gbxFormularioEmpleado.Controls.Add(this.txtApellidos);
            this.gbxFormularioEmpleado.Controls.Add(this.txtNombre);
            this.gbxFormularioEmpleado.Controls.Add(this.txtNif);
            this.gbxFormularioEmpleado.Controls.Add(this.lblApellidos);
            this.gbxFormularioEmpleado.Controls.Add(this.lblNombre);
            this.gbxFormularioEmpleado.Controls.Add(this.lblNif);
            this.gbxFormularioEmpleado.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxFormularioEmpleado.FillColor = System.Drawing.Color.Transparent;
            this.gbxFormularioEmpleado.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gbxFormularioEmpleado.ForeColor = System.Drawing.Color.Black;
            this.gbxFormularioEmpleado.Location = new System.Drawing.Point(20, 22);
            this.gbxFormularioEmpleado.Name = "gbxFormularioEmpleado";
            this.gbxFormularioEmpleado.Size = new System.Drawing.Size(446, 292);
            this.gbxFormularioEmpleado.TabIndex = 2;
            this.gbxFormularioEmpleado.Text = "Mantenimiento de empleados";
            // 
            // btnLimpiarEmpleado
            // 
            this.btnLimpiarEmpleado.BorderRadius = 10;
            this.btnLimpiarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarEmpleado.FillColor = System.Drawing.Color.DimGray;
            this.btnLimpiarEmpleado.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnLimpiarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(227, 236);
            this.btnLimpiarEmpleado.Name = "btnLimpiarEmpleado";
            this.btnLimpiarEmpleado.Size = new System.Drawing.Size(193, 38);
            this.btnLimpiarEmpleado.TabIndex = 9;
            this.btnLimpiarEmpleado.Text = "Limpiar";
            // 
            // btnDarBajaEmpleado
            // 
            this.btnDarBajaEmpleado.BorderRadius = 10;
            this.btnDarBajaEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDarBajaEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDarBajaEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDarBajaEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDarBajaEmpleado.FillColor = System.Drawing.Color.IndianRed;
            this.btnDarBajaEmpleado.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnDarBajaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnDarBajaEmpleado.Location = new System.Drawing.Point(18, 236);
            this.btnDarBajaEmpleado.Name = "btnDarBajaEmpleado";
            this.btnDarBajaEmpleado.Size = new System.Drawing.Size(193, 38);
            this.btnDarBajaEmpleado.TabIndex = 8;
            this.btnDarBajaEmpleado.Text = "Dar de baja";
            this.btnDarBajaEmpleado.Click += new System.EventHandler(this.btnDarBajaEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BorderRadius = 10;
            this.btnModificarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnModificarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(227, 185);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(193, 38);
            this.btnModificarEmpleado.TabIndex = 7;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.BorderRadius = 10;
            this.btnCrearEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnCrearEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnCrearEmpleado.Location = new System.Drawing.Point(18, 185);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(193, 38);
            this.btnCrearEmpleado.TabIndex = 6;
            this.btnCrearEmpleado.Text = "Crear";
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderRadius = 10;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.DefaultText = "";
            this.txtApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.Location = new System.Drawing.Point(18, 142);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.Size = new System.Drawing.Size(402, 28);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(18, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(402, 28);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNif
            // 
            this.txtNif.BorderRadius = 10;
            this.txtNif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNif.DefaultText = "";
            this.txtNif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNif.Location = new System.Drawing.Point(18, 44);
            this.txtNif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.PlaceholderText = "NIF";
            this.txtNif.SelectedText = "";
            this.txtNif.Size = new System.Drawing.Size(402, 28);
            this.txtNif.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblApellidos.Location = new System.Drawing.Point(14, 118);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(76, 21);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblNombre.Location = new System.Drawing.Point(14, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblNif.Location = new System.Drawing.Point(14, 20);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(33, 21);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(498, 57);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(446, 430);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvEmpleados.ThemeStyle.ReadOnly = true;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.BorderRadius = 10;
            this.txtBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEmpleado.DefaultText = "";
            this.txtBuscarEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(498, 22);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PlaceholderText = "Buscar por NIF, nombre o apellidos";
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(446, 28);
            this.txtBuscarEmpleado.TabIndex = 0;
            this.txtBuscarEmpleado.TextChanged += new System.EventHandler(this.txtBuscarEmpleado_TextChanged);
            // 
            // tbpEmpresas
            // 
            this.tbpEmpresas.BackColor = System.Drawing.Color.White;
            this.tbpEmpresas.Controls.Add(this.lblListadoEmpresas);
            this.tbpEmpresas.Controls.Add(this.gbxFormularioEmpresa);
            this.tbpEmpresas.Controls.Add(this.dgvEmpresas);
            this.tbpEmpresas.Location = new System.Drawing.Point(4, 44);
            this.tbpEmpresas.Name = "tbpEmpresas";
            this.tbpEmpresas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpresas.Size = new System.Drawing.Size(968, 505);
            this.tbpEmpresas.TabIndex = 1;
            this.tbpEmpresas.Text = "Empresas";
            // 
            // lblListadoEmpresas
            // 
            this.lblListadoEmpresas.AutoSize = true;
            this.lblListadoEmpresas.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblListadoEmpresas.ForeColor = System.Drawing.Color.Black;
            this.lblListadoEmpresas.Location = new System.Drawing.Point(493, 22);
            this.lblListadoEmpresas.Name = "lblListadoEmpresas";
            this.lblListadoEmpresas.Size = new System.Drawing.Size(167, 25);
            this.lblListadoEmpresas.TabIndex = 3;
            this.lblListadoEmpresas.Text = "Catálogo empresas";
            // 
            // gbxFormularioEmpresa
            // 
            this.gbxFormularioEmpresa.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbxFormularioEmpresa.BorderRadius = 10;
            this.gbxFormularioEmpresa.BorderThickness = 2;
            this.gbxFormularioEmpresa.Controls.Add(this.btnLimpiarEmpresa);
            this.gbxFormularioEmpresa.Controls.Add(this.btnEliminarEmpresa);
            this.gbxFormularioEmpresa.Controls.Add(this.btnModificarEmpresa);
            this.gbxFormularioEmpresa.Controls.Add(this.btnCrearEmpresa);
            this.gbxFormularioEmpresa.Controls.Add(this.txtCif);
            this.gbxFormularioEmpresa.Controls.Add(this.txtNombreEmpresa);
            this.gbxFormularioEmpresa.Controls.Add(this.lblCif);
            this.gbxFormularioEmpresa.Controls.Add(this.lblNombreEmpresa);
            this.gbxFormularioEmpresa.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxFormularioEmpresa.FillColor = System.Drawing.Color.Transparent;
            this.gbxFormularioEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gbxFormularioEmpresa.ForeColor = System.Drawing.Color.Black;
            this.gbxFormularioEmpresa.Location = new System.Drawing.Point(20, 22);
            this.gbxFormularioEmpresa.Name = "gbxFormularioEmpresa";
            this.gbxFormularioEmpresa.Size = new System.Drawing.Size(446, 252);
            this.gbxFormularioEmpresa.TabIndex = 2;
            this.gbxFormularioEmpresa.Text = "Cartera de empresas";
            // 
            // btnLimpiarEmpresa
            // 
            this.btnLimpiarEmpresa.BorderRadius = 10;
            this.btnLimpiarEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarEmpresa.FillColor = System.Drawing.Color.DimGray;
            this.btnLimpiarEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnLimpiarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEmpresa.Location = new System.Drawing.Point(227, 184);
            this.btnLimpiarEmpresa.Name = "btnLimpiarEmpresa";
            this.btnLimpiarEmpresa.Size = new System.Drawing.Size(193, 38);
            this.btnLimpiarEmpresa.TabIndex = 7;
            this.btnLimpiarEmpresa.Text = "Limpiar";
            // 
            // btnEliminarEmpresa
            // 
            this.btnEliminarEmpresa.BorderRadius = 10;
            this.btnEliminarEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarEmpresa.FillColor = System.Drawing.Color.IndianRed;
            this.btnEliminarEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnEliminarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpresa.Location = new System.Drawing.Point(18, 184);
            this.btnEliminarEmpresa.Name = "btnEliminarEmpresa";
            this.btnEliminarEmpresa.Size = new System.Drawing.Size(193, 38);
            this.btnEliminarEmpresa.TabIndex = 6;
            this.btnEliminarEmpresa.Text = "Eliminar";
            this.btnEliminarEmpresa.Click += new System.EventHandler(this.btnEliminarEmpresa_Click);
            // 
            // btnModificarEmpresa
            // 
            this.btnModificarEmpresa.BorderRadius = 10;
            this.btnModificarEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarEmpresa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.btnModificarEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnModificarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnModificarEmpresa.Location = new System.Drawing.Point(227, 133);
            this.btnModificarEmpresa.Name = "btnModificarEmpresa";
            this.btnModificarEmpresa.Size = new System.Drawing.Size(193, 38);
            this.btnModificarEmpresa.TabIndex = 5;
            this.btnModificarEmpresa.Text = "Modificar";
            this.btnModificarEmpresa.Click += new System.EventHandler(this.btnModificarEmpresa_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.BorderRadius = 10;
            this.btnCrearEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearEmpresa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.btnCrearEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnCrearEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnCrearEmpresa.Location = new System.Drawing.Point(18, 133);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(193, 38);
            this.btnCrearEmpresa.TabIndex = 4;
            this.btnCrearEmpresa.Text = "Crear";
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // txtCif
            // 
            this.txtCif.BorderRadius = 10;
            this.txtCif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCif.DefaultText = "";
            this.txtCif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCif.Location = new System.Drawing.Point(18, 93);
            this.txtCif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCif.Name = "txtCif";
            this.txtCif.PlaceholderText = "CIF";
            this.txtCif.SelectedText = "";
            this.txtCif.Size = new System.Drawing.Size(402, 28);
            this.txtCif.TabIndex = 3;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BorderRadius = 10;
            this.txtNombreEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEmpresa.DefaultText = "";
            this.txtNombreEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(18, 44);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PlaceholderText = "Nombre empresa";
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(402, 28);
            this.txtNombreEmpresa.TabIndex = 2;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblCif.Location = new System.Drawing.Point(14, 69);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(31, 21);
            this.lblCif.TabIndex = 1;
            this.lblCif.Text = "CIF";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Yu Gothic UI", 9.5F);
            this.lblNombreEmpresa.Location = new System.Drawing.Point(14, 20);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(68, 21);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "Nombre";
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmpresas.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmpresas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvEmpresas.Location = new System.Drawing.Point(498, 57);
            this.dgvEmpresas.MultiSelect = false;
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.RowHeadersVisible = false;
            this.dgvEmpresas.RowHeadersWidth = 51;
            this.dgvEmpresas.RowTemplate.Height = 24;
            this.dgvEmpresas.Size = new System.Drawing.Size(446, 217);
            this.dgvEmpresas.TabIndex = 0;
            this.dgvEmpresas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvEmpresas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvEmpresas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpresas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpresas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpresas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpresas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpresas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvEmpresas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvEmpresas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpresas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvEmpresas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpresas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpresas.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvEmpresas.ThemeStyle.ReadOnly = true;
            this.dgvEmpresas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpresas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpresas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.dgvEmpresas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpresas.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmpresas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvEmpresas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmpresas.SelectionChanged += new System.EventHandler(this.dgvEmpresas_SelectionChanged);
            // 
            // UC_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcPersonal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_Personal";
            this.Size = new System.Drawing.Size(1030, 648);
            this.Load += new System.EventHandler(this.UCPersonal_Load);
            this.tbcPersonal.ResumeLayout(false);
            this.tbpEmpleados.ResumeLayout(false);
            this.tbpEmpleados.PerformLayout();
            this.gbxAccesos.ResumeLayout(false);
            this.gbxAccesos.PerformLayout();
            this.gbxFormularioEmpleado.ResumeLayout(false);
            this.gbxFormularioEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tbpEmpresas.ResumeLayout(false);
            this.tbpEmpresas.PerformLayout();
            this.gbxFormularioEmpresa.ResumeLayout(false);
            this.gbxFormularioEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TabControl tbcPersonal;
        private System.Windows.Forms.TabPage tbpEmpleados;
        private System.Windows.Forms.TabPage tbpEmpresas;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarEmpleado;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpleados;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFormularioEmpleado;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtNif;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private Guna.UI2.WinForms.Guna2Button btnCrearEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnModificarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnDarBajaEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarEmpleado;
        private Guna.UI2.WinForms.Guna2GroupBox gbxAccesos;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRol;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;
        private Guna.UI2.WinForms.Guna2Button btnCambiarRol;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
        private System.Windows.Forms.Label lblListadoEmpleados;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpresas;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFormularioEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblCif;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txtCif;
        private Guna.UI2.WinForms.Guna2Button btnCrearEmpresa;
        private Guna.UI2.WinForms.Guna2Button btnModificarEmpresa;
        private Guna.UI2.WinForms.Guna2Button btnEliminarEmpresa;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarEmpresa;
        private System.Windows.Forms.Label lblListadoEmpresas;
    }
}