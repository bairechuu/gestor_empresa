using gestor_empresa;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace gestorempresa.Views.Admin
{
    public partial class UCPersonal : UserControl
{
    private int idEmpleadoSeleccionado = -1;
    private int idEmpresaSeleccionada = -1;

    public UCPersonal()
    {
        InitializeComponent();

        btnLimpiarEmpleado.Click += btnLimpiarEmpleado_Click;
        btnLimpiarEmpresa.Click += btnLimpiarEmpresa_Click;
    }

    private void UCPersonal_Load(object sender, EventArgs e)
    {
        ConfigurarGrids();
        CargarEmpleados();
        CargarEmpresas();
        LimpiarFormularioEmpleado();
        LimpiarFormularioEmpresa();
    }

    private void ConfigurarGrids()
    {
        dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmpleados.MultiSelect = false;
        dgvEmpleados.ReadOnly = true;

        dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmpresas.MultiSelect = false;
        dgvEmpresas.ReadOnly = true;
    }

    private void CargarEmpleados()
    {
        string sql = @"
                SELECT 
                    e.idempleado AS ID,
                    e.nif AS NIF,
                    e.nombre AS Nombre,
                    e.apellidos AS Apellidos,
                    e.rol AS Rol
                FROM empleado e
                ORDER BY e.apellidos, e.nombre";

        DataTable tabla = Database.Consulta(sql);

        if (tabla != null)
        {
            dgvEmpleados.DataSource = tabla;
        }
        else
        {
            MessageBox.Show("Error al cargar empleados: " + Database.Error);
        }
    }

    private void CargarEmpresas()
    {
        string sql = @"
                SELECT 
                    idempresa AS ID,
                    nombre AS Nombre,
                    cif AS CIF
                FROM empresa
                ORDER BY nombre";

        DataTable tabla = Database.Consulta(sql);

        if (tabla != null)
        {
            dgvEmpresas.DataSource = tabla;
        }
        else
        {
            MessageBox.Show("Error al cargar empresas: " + Database.Error);
        }
    }

    private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
    {
        string texto = txtBuscarEmpleado.Text.Trim();

        string sql = @"
                SELECT 
                    e.idempleado AS ID,
                    e.nif AS NIF,
                    e.nombre AS Nombre,
                    e.apellidos AS Apellidos,
                    e.rol AS Rol
                FROM empleado e
                WHERE e.nif LIKE @texto
                   OR e.nombre LIKE @texto
                   OR e.apellidos LIKE @texto
                ORDER BY e.apellidos, e.nombre";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@texto", "%" + texto + "%")
            };

        DataTable tabla = Database.Consulta(sql, parametros);

        if (tabla != null)
        {
            dgvEmpleados.DataSource = tabla;
        }
    }

    private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow == null || dgvEmpleados.CurrentRow.Index < 0)
            return;

        if (dgvEmpleados.CurrentRow.Cells["ID"].Value == null)
            return;

        idEmpleadoSeleccionado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["ID"].Value);
        txtNif.Text = dgvEmpleados.CurrentRow.Cells["NIF"].Value?.ToString() ?? "";
        txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
        txtApellidos.Text = dgvEmpleados.CurrentRow.Cells["Apellidos"].Value?.ToString() ?? "";
        cmbRol.SelectedItem = dgvEmpleados.CurrentRow.Cells["Rol"].Value?.ToString() ?? "empleado";
    }

    private void dgvEmpresas_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvEmpresas.CurrentRow == null || dgvEmpresas.CurrentRow.Index < 0)
            return;

        if (dgvEmpresas.CurrentRow.Cells["ID"].Value == null)
            return;

        idEmpresaSeleccionada = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells["ID"].Value);
        txtNombreEmpresa.Text = dgvEmpresas.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
        txtCif.Text = dgvEmpresas.CurrentRow.Cells["CIF"].Value?.ToString() ?? "";
    }

    private void btnCrearEmpleado_Click(object sender, EventArgs e)
    {
        if (!ValidarEmpleado(true))
            return;

        string sql = @"
                INSERT INTO empleado (nif, nombre, apellidos, password, rol)
                VALUES (@nif, @nombre, @apellidos, @password, @rol)";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@nif", txtNif.Text.Trim()),
                new MySqlParameter("@nombre", txtNombre.Text.Trim()),
                new MySqlParameter("@apellidos", txtApellidos.Text.Trim()),
                new MySqlParameter("@password", txtPassword.Text.Trim()),
                new MySqlParameter("@rol", cmbRol.SelectedItem?.ToString() ?? "empleado")
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empleado creado correctamente.");
            CargarEmpleados();
            LimpiarFormularioEmpleado();
        }
        else
        {
            MessageBox.Show("No se pudo crear el empleado. " + Database.Error);
        }
    }

    private void btnModificarEmpleado_Click(object sender, EventArgs e)
    {
        if (idEmpleadoSeleccionado <= 0)
        {
            MessageBox.Show("Selecciona un empleado.");
            return;
        }

        if (!ValidarEmpleado(false))
            return;

        string sql = @"
                UPDATE empleado
                SET nif = @nif,
                    nombre = @nombre,
                    apellidos = @apellidos
                WHERE idempleado = @idEmpleado";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@nif", txtNif.Text.Trim()),
                new MySqlParameter("@nombre", txtNombre.Text.Trim()),
                new MySqlParameter("@apellidos", txtApellidos.Text.Trim()),
                new MySqlParameter("@idEmpleado", idEmpleadoSeleccionado)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empleado modificado correctamente.");
            CargarEmpleados();
            LimpiarFormularioEmpleado();
        }
        else
        {
            MessageBox.Show("No se pudo modificar el empleado. " + Database.Error);
        }
    }

    private void btnDarBajaEmpleado_Click(object sender, EventArgs e)
    {
        if (idEmpleadoSeleccionado <= 0)
        {
            MessageBox.Show("Selecciona un empleado.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "Se marcará como inactivo el último contrato activo del empleado. ¿Continuar?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta != DialogResult.Yes)
            return;

        string sql = @"
                UPDATE contrato
                SET estado = 'inactivo',
                    fechafin = CURDATE()
                WHERE idempleado = @idEmpleado
                  AND estado = 'activo'
                ORDER BY idcontrato DESC
                LIMIT 1";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@idEmpleado", idEmpleadoSeleccionado)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empleado dado de baja correctamente.");
            CargarEmpleados();
            LimpiarFormularioEmpleado();
        }
        else
        {
            MessageBox.Show("No se pudo dar de baja al empleado. " + Database.Error);
        }
    }

    private void btnCambiarRol_Click(object sender, EventArgs e)
    {
        if (idEmpleadoSeleccionado <= 0)
        {
            MessageBox.Show("Selecciona un empleado.");
            return;
        }

        if (cmbRol.SelectedItem == null)
        {
            MessageBox.Show("Selecciona un rol.");
            return;
        }

        string sql = @"
                UPDATE empleado
                SET rol = @rol
                WHERE idempleado = @idEmpleado";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@rol", cmbRol.SelectedItem.ToString()),
                new MySqlParameter("@idEmpleado", idEmpleadoSeleccionado)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Rol actualizado correctamente.");
            CargarEmpleados();
        }
        else
        {
            MessageBox.Show("No se pudo actualizar el rol. " + Database.Error);
        }
    }

    private void btnResetPassword_Click(object sender, EventArgs e)
    {
        if (idEmpleadoSeleccionado <= 0)
        {
            MessageBox.Show("Selecciona un empleado.");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MessageBox.Show("Introduce una nueva contraseña.");
            return;
        }

        string sql = @"
                UPDATE empleado
                SET password = @password
                WHERE idempleado = @idEmpleado";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@password", txtPassword.Text.Trim()),
                new MySqlParameter("@idEmpleado", idEmpleadoSeleccionado)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Contraseña actualizada correctamente.");
            txtPassword.Clear();
        }
        else
        {
            MessageBox.Show("No se pudo actualizar la contraseña. " + Database.Error);
        }
    }

    private void btnCrearEmpresa_Click(object sender, EventArgs e)
    {
        if (!ValidarEmpresa())
            return;

        string sql = @"
                INSERT INTO empresa (nombre, cif)
                VALUES (@nombre, @cif)";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@nombre", txtNombreEmpresa.Text.Trim()),
                new MySqlParameter("@cif", txtCif.Text.Trim())
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empresa creada correctamente.");
            CargarEmpresas();
            LimpiarFormularioEmpresa();
        }
        else
        {
            MessageBox.Show("No se pudo crear la empresa. " + Database.Error);
        }
    }

    private void btnModificarEmpresa_Click(object sender, EventArgs e)
    {
        if (idEmpresaSeleccionada <= 0)
        {
            MessageBox.Show("Selecciona una empresa.");
            return;
        }

        if (!ValidarEmpresa())
            return;

        string sql = @"
                UPDATE empresa
                SET nombre = @nombre,
                    cif = @cif
                WHERE idempresa = @idEmpresa";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@nombre", txtNombreEmpresa.Text.Trim()),
                new MySqlParameter("@cif", txtCif.Text.Trim()),
                new MySqlParameter("@idEmpresa", idEmpresaSeleccionada)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empresa modificada correctamente.");
            CargarEmpresas();
            LimpiarFormularioEmpresa();
        }
        else
        {
            MessageBox.Show("No se pudo modificar la empresa. " + Database.Error);
        }
    }

    private void btnEliminarEmpresa_Click(object sender, EventArgs e)
    {
        if (idEmpresaSeleccionada <= 0)
        {
            MessageBox.Show("Selecciona una empresa.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Seguro que quieres eliminar la empresa seleccionada?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (respuesta != DialogResult.Yes)
            return;

        string sql = "DELETE FROM empresa WHERE idempresa = @idEmpresa";

        MySqlParameter[] parametros =
        {
                new MySqlParameter("@idEmpresa", idEmpresaSeleccionada)
            };

        int resultado = Database.Modificacion(sql, parametros);

        if (resultado > 0)
        {
            MessageBox.Show("Empresa eliminada correctamente.");
            CargarEmpresas();
            LimpiarFormularioEmpresa();
        }
        else
        {
            MessageBox.Show("No se pudo eliminar la empresa. Puede tener contratos asociados. " + Database.Error);
        }
    }

    private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
    {
        LimpiarFormularioEmpleado();
    }

    private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
    {
        LimpiarFormularioEmpresa();
    }

    private void LimpiarFormularioEmpleado()
    {
        idEmpleadoSeleccionado = -1;
        txtNif.Clear();
        txtNombre.Clear();
        txtApellidos.Clear();
        txtPassword.Clear();
        cmbRol.SelectedIndex = 0;
        dgvEmpleados.ClearSelection();
    }

    private void LimpiarFormularioEmpresa()
    {
        idEmpresaSeleccionada = -1;
        txtNombreEmpresa.Clear();
        txtCif.Clear();
        dgvEmpresas.ClearSelection();
    }

    private bool ValidarEmpleado(bool validarPassword)
    {
        if (string.IsNullOrWhiteSpace(txtNif.Text))
        {
            MessageBox.Show("El NIF es obligatorio.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("El nombre es obligatorio.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtApellidos.Text))
        {
            MessageBox.Show("Los apellidos son obligatorios.");
            return false;
        }

        if (cmbRol.SelectedItem == null)
        {
            MessageBox.Show("Selecciona un rol.");
            return false;
        }

        if (validarPassword && string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MessageBox.Show("La contraseña es obligatoria al crear el empleado.");
            return false;
        }

        return true;
    }

    private bool ValidarEmpresa()
    {
        if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
        {
            MessageBox.Show("El nombre de la empresa es obligatorio.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtCif.Text))
        {
            MessageBox.Show("El CIF es obligatorio.");
            return false;
        }

        return true;
    }
}
}