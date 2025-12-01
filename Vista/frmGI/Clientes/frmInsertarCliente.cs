using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace Vista.frmGI.Clientes
{
    public partial class frmInsertarCliente : Form
    {
        private L_Cliente logicaCliente = new L_Cliente();
        private readonly HttpClient httpClient = new HttpClient();

        // Clases simples para manejar datos
        private class Provincia { public string id { get; set; } public string nombre { get; set; } }
        private class Localidad { public string id { get; set; } public string nombre { get; set; } }

        public frmInsertarCliente()
        {
            InitializeComponent();
        }

        private async void frmInsertarCliente_Load(object sender, EventArgs e)
        {
            // ensure secure protocols
            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            }
            catch { }

            cmbFormaPago.Items.Clear();
            cmbFormaPago.Items.AddRange(new object[] { "Contado", "Crédito", "Transferencia" });
            cmbFormaPago.SelectedIndex = 0;

            // set combobox styles for consistent UX
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;

            // placeholder for localidad until a province is selected
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Items.Add("Primero elegí provincia");
            cmbLocalidad.SelectedIndex = 0;
            cmbLocalidad.Enabled = false;

            // Input restrictions: set maxlengths
            // DNI (textBox5) -> 8 dígitos
            textBox5.MaxLength = 8;
            // Nombre razon social
            txtRazonSocial.MaxLength = 150;
            // Telefono
            txtTelefono.MaxLength = 50;
            // Horario (números sólo) - masked textbox will enforce format
            txtHorario.MaxLength = 5; // HH:mm
            // Emails
            txtEmail.MaxLength = 150;
            txtEmailContacto.MaxLength = 150;

            // Subscribe to events to block chars at input time
            textBox5.KeyPress += TxtDni_KeyPress;
            textBox5.TextChanged += TxtDni_TextChanged;

            txtRazonSocial.KeyPress += TxtNombre_KeyPress;
            txtRazonSocial.TextChanged += TxtNombre_TextChanged;

            txtTelefono.KeyPress += TxtTelefono_KeyPress;
            txtTelefono.TextChanged += TxtTelefono_TextChanged;

            // Note: no KeyPress/TextChanged subscription for txtHorario because it's a MaskedTextBox

            await CargarProvincias();
            txtCodigo.Focus();
        }

        // DNI handlers
        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys and digits only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            string cleaned = Regex.Replace(tb.Text, "[^0-9]", "");
            if (cleaned.Length > 8) cleaned = cleaned.Substring(0, 8);
            if (cleaned != tb.Text)
            {
                int sel = tb.SelectionStart - (tb.Text.Length - cleaned.Length);
                tb.Text = cleaned;
                tb.SelectionStart = Math.Max(0, sel);
            }
        }

        // Nombre handlers
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, control, spaces, hyphen and apostrophe
            char c = e.KeyChar;
            if (char.IsControl(c) || char.IsWhiteSpace(c) || char.IsLetter(c) || c == '-' || c == '\'')
            {
                // allow
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            string pattern = @"[^A-Za-zÁÉÍÓÚÜÑáéíóúüñ\s\-']";
            string cleaned = Regex.Replace(tb.Text, pattern, "");
            if (cleaned != tb.Text)
            {
                int sel = tb.SelectionStart - (tb.Text.Length - cleaned.Length);
                tb.Text = cleaned;
                tb.SelectionStart = Math.Max(0, sel);
            }
        }

        // Telefono handlers
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsControl(c) || char.IsDigit(c) || c == '+' || c == '-' || c == '(' || c == ')' || char.IsWhiteSpace(c))
            {
                // allow
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            string cleaned = Regex.Replace(tb.Text, @"[^0-9\+\-\(\)\s]", "");
            if (cleaned != tb.Text)
            {
                int sel = tb.SelectionStart - (tb.Text.Length - cleaned.Length);
                tb.Text = cleaned;
                tb.SelectionStart = Math.Max(0, sel);
            }
        }

        private List<Provincia> ParseProvincias(string json)
        {
            var result = new List<Provincia>();
            if (string.IsNullOrEmpty(json)) return result;

            try
            {
                var serializer = new JavaScriptSerializer();
                var dict = serializer.Deserialize<Dictionary<string, object>>(json);
                if (dict != null && dict.ContainsKey("provincias"))
                {
                    var arr = dict["provincias"] as ArrayList;
                    if (arr != null)
                    {
                        foreach (var item in arr)
                        {
                            var map = item as Dictionary<string, object>;
                            if (map != null)
                            {
                                string id = map.ContainsKey("id") ? (map["id"] ?? "").ToString() : "";
                                string nombre = map.ContainsKey("nombre") ? (map["nombre"] ?? "").ToString() : "";
                                result.Add(new Provincia { id = id, nombre = nombre });
                            }
                        }
                    }
                }
            }
            catch { }

            return result;
        }

        private List<Localidad> ParseLocalidades(string json)
        {
            var result = new List<Localidad>();
            if (string.IsNullOrEmpty(json)) return result;

            try
            {
                var serializer = new JavaScriptSerializer();
                var dict = serializer.Deserialize<Dictionary<string, object>>(json);
                if (dict != null && dict.ContainsKey("localidades"))
                {
                    var arr = dict["localidades"] as ArrayList;
                    if (arr != null)
                    {
                        foreach (var item in arr)
                        {
                            var map = item as Dictionary<string, object>;
                            if (map != null)
                            {
                                string id = map.ContainsKey("id") ? (map["id"] ?? "").ToString() : "";
                                string nombre = map.ContainsKey("nombre") ? (map["nombre"] ?? "").ToString() : "";
                                result.Add(new Localidad { id = id, nombre = nombre });
                            }
                        }
                    }
                }
            }
            catch { }

            return result;
        }

        private async Task CargarProvincias()
        {
            try
            {
                string url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre&orden=nombre";
                string json = await httpClient.GetStringAsync(url);

                var provincias = ParseProvincias(json);

                cmbProvincia.Items.Clear();
                cmbProvincia.Items.Add(new { id = "", nombre = "Seleccioná provincia" });

                if (provincias != null && provincias.Count > 0)
                {
                    foreach (var p in provincias)
                    {
                        cmbProvincia.Items.Add(new { id = p.id, nombre = p.nombre });
                    }

                    cmbProvincia.DisplayMember = "nombre";
                    cmbProvincia.ValueMember = "id";
                    cmbProvincia.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener provincias o la respuesta fue vacía.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProvincia.Items.Add("Sin datos");
                    cmbProvincia.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar provincias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProvincia.Items.Clear();
                cmbProvincia.Items.Add("Error al cargar");
                cmbProvincia.SelectedIndex = 0;
            }
        }

        private async void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cmbProvincia.SelectedItem as dynamic;

            if (item == null || string.IsNullOrEmpty(item.id))
            {
                cmbLocalidad.Items.Clear();
                cmbLocalidad.Items.Add("Primero elegí provincia");
                cmbLocalidad.SelectedIndex = 0;
                cmbLocalidad.Enabled = false;
                return;
            }

            await CargarLocalidades(item.id);
        }

        private async Task CargarLocalidades(string provinciaId)
        {
            cmbLocalidad.Enabled = false;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Items.Add("Cargando...");
            cmbLocalidad.SelectedIndex = 0;

            try
            {
                string url = $"https://apis.datos.gob.ar/georef/api/localidades?provincia={provinciaId}&campos=id,nombre&max=5000&orden=nombre";
                string json = await httpClient.GetStringAsync(url);

                var localidades = ParseLocalidades(json);

                cmbLocalidad.Items.Clear();
                cmbLocalidad.Items.Add(new { id = "", nombre = "Seleccioná localidad" });

                if (localidades != null && localidades.Count > 0)
                {
                    foreach (var l in localidades)
                    {
                        cmbLocalidad.Items.Add(new { id = l.id, nombre = l.nombre });
                    }

                    cmbLocalidad.DisplayMember = "nombre";
                    cmbLocalidad.ValueMember = "id";
                    cmbLocalidad.SelectedIndex = 0;
                    cmbLocalidad.Enabled = true;
                }
                else
                {
                    cmbLocalidad.Items.Clear();
                    cmbLocalidad.Items.Add("Sin localidades");
                    cmbLocalidad.SelectedIndex = 0;
                    cmbLocalidad.Enabled = false;
                }
            }
            catch
            {
                cmbLocalidad.Items.Clear();
                cmbLocalidad.Items.Add("Error al cargar localidades");
                cmbLocalidad.SelectedIndex = 0;
                cmbLocalidad.Enabled = false;
            }
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            InsertarCliente();
        }

        private void InsertarCliente()
        {
            try
            {
                if (!ValidarCamposObligatorios())
                    return;

                // Obtenemos los nombres seleccionados (no los IDs)
                string provincia = (cmbProvincia.SelectedItem as dynamic)?.nombre ?? "";
                string localidad = (cmbLocalidad.SelectedItem as dynamic)?.nombre ?? "";

                bool resultado = logicaCliente.Insertar(
                    txtCodigo.Text.Trim(),
                    txtRazonSocial.Text.Trim(),
                    txtEmail.Text.Trim(),
                    cmbFormaPago.Text.Trim(),
                    nudDescuento.Value,
                    nudLimiteCredito.Value,
                    txtDireccion.Text.Trim(),
                    localidad,           // ← ahora viene del combo
                    provincia,           // ← ahora viene del combo
                    txtTelefono.Text.Trim(),
                    txtContacto.Text.Trim(),
                    txtSector.Text.Trim(),
                    txtHorario.Text.Trim(),
                    txtEmailContacto.Text.Trim(),
                    out string mensaje
                );

                if (resultado)
                {
                    MessageBox.Show($"Éxito: {mensaje}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show($"Error al insertar: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            // ... (todas las validaciones que ya tenías) ...

            // Eliminamos las validaciones de txtLocalidad y txtProvincia
            // y agregamos que al menos haya seleccionado provincia (opcional o obligatorio según tu regla)
            if (cmbProvincia.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una provincia", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProvincia.Focus();
                return false;
            }

            // Si querés que localidad también sea obligatoria:
            // if (cmbLocalidad.SelectedIndex <= 0)
            // {
            //     MessageBox.Show("Debe seleccionar una localidad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     cmbLocalidad.Focus();
            //     return false;
            // }

            return true;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtRazonSocial.Clear();
            txtEmail.Clear();
            cmbFormaPago.SelectedIndex = 0;
            nudDescuento.Value = 0;
            nudLimiteCredito.Value = 0;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            txtSector.Clear();
            txtHorario.Clear();
            txtEmailContacto.Clear();

            cmbProvincia.SelectedIndex = 0;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Items.Add("Primero elegí provincia");
            cmbLocalidad.Enabled = false;

            txtCodigo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}