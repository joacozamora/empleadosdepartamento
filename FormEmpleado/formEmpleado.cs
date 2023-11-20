using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Security.Cryptography;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using iTextSharp.text.pdf.parser;

namespace FormEmpleado
{
    public partial class formEmpleado : Form
    {
        
        
        
        bool nuevo = true;
        int fila;

        

        public formEmpleado()
        {
            InitializeComponent();
            //tabla empleado
            dgvEmpleado.ColumnCount = 7;
            dgvEmpleado.Columns[0].HeaderText = "Nombre";
            dgvEmpleado.Columns[1].HeaderText = "Primer Apellido";
            dgvEmpleado.Columns[2].HeaderText = "Segundo Apellido";
            dgvEmpleado.Columns[3].HeaderText = "DNI";
            dgvEmpleado.Columns[4].HeaderText = "Email";
            dgvEmpleado.Columns[5].HeaderText = "Departamento";
            dgvEmpleado.Columns[6].HeaderText = "Fecha Nacimiento";

            //tabla departamento
            dgvDepa.ColumnCount = 2;
            dgvDepa.Columns[0].HeaderText = "Id";
            dgvDepa.Columns[1].HeaderText = "Nombre Departamento";

            //Cargar datos a las tablas

            LlenarDGVEmpleado();
            LlenarDGVDepartamento();
            LlenarCombo();
            MostrarId();
			dgvEmpleado.CellClick += new DataGridViewCellEventHandler(dgvEmpleado_CellClick);
			dgvDepa.CellClick += new DataGridViewCellEventHandler(dgvDepa_CellClick);
			comDep.SelectedIndexChanged += (sender, e) => MostrarId();


		}

		public NegEmpleado objNegEmpleado = new NegEmpleado();
		public NegDepartamento objNegDepartamento = new NegDepartamento();

		public Empleado objEntEmpleado = new Empleado();
		public Departamento objEntDepartamento = new Departamento();


		#region Llenar DGV

		private void LlenarDGVEmpleado()
        {
            dgvEmpleado.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegEmpleado.listaEmpleado("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvEmpleado.Rows.Add(dr[1], dr[2], dr[3], dr[7], dr[4].ToString(),
                        dr[5].ToString(), dr[6].ToString());
                }
            }

            else
                MessageBox.Show("No hay empleados cargado en el sistema");
        }

        private void LlenarDGVDepartamento()
        {
            dgvDepa.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegDepartamento.listaDepartamento("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvDepa.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }

            //else { 
            //MessageBox.Show("No hay departamentos cargado en el sistema");
            //    }
        }

        private void LimpiarEmpleado()
        {
            txtNom.Text = string.Empty;
            txtAp.Text = string.Empty;
            txt2ap.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtCor.Text = string.Empty;
            FechaNacEmpleado.Value = DateTime.Now;
            
            

        }

        private void LimpiarDepartamento()
        {
            
            txtNombreDepartamento.Text = string.Empty;
            

        }
        //falta el limpiar

        #endregion

        #region Boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposEmpleado();
            int nGrabados = -1;
            string dni = txtDni.Text;

            DataSet ds = objNegEmpleado.listaEmpleado(dni);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Ya existe un empleado con ese DNI");
            }
            else
            {
                if (validar == true)
                {
                    Txt_a_ObjEmpleado();
                    nGrabados = objNegEmpleado.abmEmpleado("Alta", objEntEmpleado);
                    if (nGrabados == -1)
                    {
                        MessageBox.Show("error al agregar nuevo empleado");
                    }
                    else
                    {
                        MessageBox.Show("se agrego correctamente al empleado ");
                        LlenarDGVEmpleado();
                        //falta limpiar
                        
                        //tabControl1.SelectTab(tabControl1);
                    }
                }
            }

            
        }

        private void button4_Click(object sender, EventArgs e) //boton agregar departamento
        {
            bool validar = ValidacionCamposDepartamento();
            int nGrabados = -1;
            //string cod = txtNombreDepartamento.Text;

            //DataSet ds = objNegDepartamento.listaDepartamento(cod);

            /*if (ds.Tables[0].Rows.Count > 0)
            {

                MessageBox.Show("Ya existe un departamento con este Nombre.");
            }
            else
            {*/
                if (validar == true)
                {
                    Txt_a_ObjDepartamento();
                    nGrabados = objNegDepartamento.abmDepartamento("Alta", objEntDepartamento);
                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se logró agregar el departamento al sistema");
                    }
                    else
                    {
                        MessageBox.Show("Se logró agregar el departamento con éxito");
                        LlenarDGVDepartamento();
                        LimpiarDepartamento();
                        LlenarCombo();
                        //tabControl1.SelectTab(tabMateria);
                    }
                }
            //}

        }
        #endregion

        #region Validacion

        public bool ValidacionCamposEmpleado()
        {
            //DNI

            if(txtDni.Text == string.Empty)
            {
                MessageBox.Show("ingresar Dni", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtDni.Text.Length > 8 || txtDni.Text.Length < 7)
            {
                MessageBox.Show("Solo se permiten DNI entre 7 y 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Nombre

            if (txtNom.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNom.Text.Length > 50 || txtNom.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Apellido

            if (txtAp.Text == string.Empty)
            {
                MessageBox.Show("Ingrese apellido del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtAp.Text.Length > 50 || txtNom.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Segundo Apellido

            //if (txt2ap.Text == string.Empty)
            //{
            //    MessageBox.Show("Ingrese segundo apellido del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}
            //else if (txt2ap.Text.Length > 50 || txtNom.Text.Length < 2)
            //{
            //    MessageBox.Show("Solo se permiten apellido de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}

            //Email

            if (txtCor.Text == string.Empty)
            {
                MessageBox.Show("Ingrese email del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCor.Text.Length > 50 || txtNom.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten correo de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;


            

            


        }

        public bool ValidacionCamposDepartamento()
        {
            if (txtNombreDepartamento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre valido para el departamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreDepartamento.Text.Length > 50 || txtNombreDepartamento.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 10 y 15 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        #endregion

        #region metodos texto a objeto
        private void Txt_a_ObjEmpleado()
        {
            objEntEmpleado.dni = int.Parse(txtDni.Text);
            objEntEmpleado.nombre = txtNom.Text;
            objEntEmpleado.primerapellido = txtAp.Text;
            objEntEmpleado.segundoapellido = txt2ap.Text;
            objEntEmpleado.correo = txtCor.Text;
            objEntEmpleado.departamento = comDep.SelectedValue.ToString();
            objEntEmpleado.id_depto = MostrarId();

            DateTime fechaNacEmpleado;
            if (DateTime.TryParse(FechaNacEmpleado.Value.ToString(), out fechaNacEmpleado))
            {
                objEntEmpleado.Fechanacimiento = fechaNacEmpleado;
            }
            else
            {
                MessageBox.Show("Fecha ingresada no valida");
            }

        }

       
        private void Txt_a_ObjDepartamento()
        {
            objEntDepartamento.departamento = txtNombreDepartamento.Text;
            
        }

        #endregion

        #region Modificar
        private void btnModEmp_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposEmpleado();
            int nResultado = -1;
            if (validar == true)
            {
                Txt_a_ObjEmpleado();
                nResultado = objNegEmpleado.abmEmpleado("Modificar", objEntEmpleado);
                if (nResultado != -1)
                {
                    MessageBox.Show("el empleado fue modificado con éxito");
                    LimpiarEmpleado();
                    LlenarDGVEmpleado();
                    //LlenarCombos();

                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar al empleado");
                }
            }
        }

       

        private void btnModDep_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposDepartamento();
            int nResultado = -1;
            if (validar == true)
            {
                Txt_a_ObjDepartamento();
                nResultado = objNegDepartamento.abmDepartamento("Modificar", objEntDepartamento);
                if (nResultado != -1)
                {
                    MessageBox.Show("el Departamento fue modificado con éxito");
                    LimpiarEmpleado();
                    LlenarDGVEmpleado();
                    //LlenarCombos();

                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el departamento");
                }
            }
        }
        #endregion

        #region Llenar combos
        private void LlenarCombo()
        {
            comDep.DataSource = objNegDepartamento.ObtenerDepartamento();
            comDep.DisplayMember = "nombreDepartamento";
            comDep.ValueMember = "departamento";

		}

		private int MostrarId()
		{
            int id = -1;
            try
            {
				string nomdepto = comDep.SelectedValue?.ToString();

				if (string.IsNullOrEmpty(nomdepto))
				{
					//id_depa.Text = "Ningun depto cargado";

				}
				else
				{
					List<Departamento> listaDepartamentos = objNegDepartamento.ObtenerId(nomdepto);

					if (listaDepartamentos.Count > 0)
					{
						int idDepartamento = listaDepartamentos[0].id;
						//id_depa.Text = idDepartamento.ToString();
                        id = idDepartamento;
					}
					else
					{
						//id_depa.Text = "No se encontró ningún departamento con el nombre seleccionado";
					}
				}
                return id;
			}

            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar el Id del departamento: {ex.Message}");
            }


            return id;

			
            


		}
		private void dgvDepa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvDepa.Rows[e.RowIndex];
				txtNombreDepartamento.Text = fila.Cells[1].Value.ToString();
				//txb_NomApAlumno.Text = fila.Cells[1].Value.ToString();
				//FechaNacAlumno.Value = Convert.ToDateTime(fila.Cells[2].Value);
				//txb_email.Text = fila.Cells[3].Value.ToString();
				//chbx_analitico.Checked = Convert.ToBoolean(fila.Cells[4].Value);
				//btn_ModificarAlumno.Visible = true;
			}
		}
		#endregion

		private void btn_BorrarDepa_Click(object sender, EventArgs e)
		{
			string nombreDepartamentoSeleccionado = comDep.SelectedValue.ToString();
            if (objNegDepartamento.HayEmpleadosAsociados(nombreDepartamentoSeleccionado))
            {
                MessageBox.Show("No se puede eliminar el departamento. Hay empleados asociados.");
                return; // No continúes con la eliminación
            }
            else
            {

                DataRow DepAEliminar = null;
                DataSet ds = objNegDepartamento.listaDepartamento("Todos");

                string nomDep = txtNombreDepartamento.Text;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr[1].ToString() == nomDep)
                    {
                        DepAEliminar = dr;
                        break;
                    }
                }

                if (DepAEliminar != null)
                {
                    string nom = DepAEliminar[1].ToString();
                    Departamento departamento = new Departamento(0, nom); // Ajusta los valores adecuados en el constructor de Productos

                    int resultado = objNegDepartamento.abmDepartamento("Borrar", departamento);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Departamento eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Departamento");
                    }
                }
                else
                {
                    MessageBox.Show("El Departamento no se encontró en la lista");
                }

            }
				LlenarDGVDepartamento();
			
			
		}

		private void ActualizarEstadoBotonBorrar()
		{
			string nombreDepartamentoSeleccionado = comDep.SelectedValue.ToString();

			if (objNegDepartamento.HayEmpleadosAsociados(nombreDepartamentoSeleccionado))
			{
				// Hay empleados asociados, deshabilita el botón
				btn_BorrarDepa.Enabled = false;
			}
			else
			{
				// No hay empleados asociados, habilita el botón
				btn_BorrarDepa.Enabled = true;
			}
		}

		// Este evento se ejecuta cuando cambia la selección en tu ComboBox
		private void comDep_SelectedIndexChanged(object sender, EventArgs e)
		{
			ActualizarEstadoBotonBorrar();
		}

		private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvEmpleado.Rows[e.RowIndex];
				txtNom.Text = fila.Cells[0].Value.ToString();
				txtAp.Text = fila.Cells[1].Value.ToString();
				txt2ap.Text = fila.Cells[2].Value.ToString();
				txtDni.Text = fila.Cells[3].Value.ToString();
				txtCor.Text = fila.Cells[4].Value.ToString();
				
				FechaNacEmpleado.Value = Convert.ToDateTime(fila.Cells[6].Value);

				object depaValue = dgvEmpleado.Rows[e.RowIndex].Cells[5].Value;
				int index = comDep.FindStringExact(depaValue.ToString());

				if (index != -1)
				{
					comDep.SelectedIndex = index;
				}
			}
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{

			DataRow EmpAEliminar = null;
			DataSet ds = objNegEmpleado.listaEmpleado("Todos");
			DateTime fechaNacimiento = DateTime.MinValue;
			string dniEmpleado = txtDni.Text.ToString();

			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[7].ToString() == dniEmpleado)
				{
					EmpAEliminar = dr;
					break;
				}
			}

			if (EmpAEliminar != null)
			{ //public Empleado(int id, string nombreempleado, string primerapellido, string segundoapellido, string departamento, string correo, DateTime fechanacimiento, int dni)

				int dni = int.Parse(EmpAEliminar[7].ToString());
				Empleado empleado = new Empleado(0, null, null, null, null, null, fechaNacimiento, dni, 0); // Ajusta los valores adecuados en el constructor de Productos

				int resultado = objNegEmpleado.abmEmpleado("Borrar", empleado);

				if (resultado > 0)
				{
					MessageBox.Show("Empleado eliminado correctamente");
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Empleado");
				}
			}
			else
			{
				MessageBox.Show("El Empleado no se encontró en la lista");
			}
            LlenarDGVEmpleado();
            LimpiarDepartamento();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Document doc = new Document();
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			string pdfPath = Path.Combine(desktopPath, "Reporte.pdf");

			PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
			doc.Open();

			AddDataToPDF(doc, dgvEmpleado, "Datos de Empleados");
			AddDataToPDF(doc, dgvDepa, "Datos de Departamentos");
			

			doc.Close();
			writer.Close();

			MessageBox.Show("PDF generado correctamente en el escritorio.");
		}

		



		private void AddDataToPDF(Document doc, DataGridView dgv, string title)
		{
			PdfPTable table = new PdfPTable(dgv.ColumnCount);
			table.WidthPercentage = 100;


			PdfPCell cell = new PdfPCell(new Phrase(title));
			cell.Colspan = dgv.ColumnCount;
			cell.HorizontalAlignment = 1;
			table.AddCell(cell);


			foreach (DataGridViewColumn column in dgv.Columns)
			{
				table.AddCell(column.HeaderText);
			}


			foreach (DataGridViewRow row in dgv.Rows)
			{
				foreach (DataGridViewCell cell2 in row.Cells)
				{
					if (cell2.Value != null)
					{
						table.AddCell(cell2.Value.ToString());
					}
					else
					{
						table.AddCell("");
					}
				}
			}

			doc.Add(table);
		}
	}

	


}

