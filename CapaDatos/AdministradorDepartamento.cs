using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.OleDb;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class AdministradorDepartamento : DatosConexion
    {
        public int abmDepartamento(string accion, Departamento objDepartamento)
        {

            int resultado = -1; // controlo si se realizo la operacion con exito
            string orden = string.Empty; // Se cargan consultas al SQL

            if (accion == "Alta")//Departamento Nuevo

                orden = $"insert into Departamento values ('{objDepartamento.departamento}')";
                    //$"('{objDepartamento.id}'," +
                    //$"'{objDepartamento.NomDepartamento}')";

            if (accion == "Modificar")
                orden = $"update Departamento set nombreDepartamento = '{objDepartamento.departamento}' ";

            if (accion == "Borrar")
                orden = $"delete from Departamento where nombreDepartamento = '{objDepartamento.departamento}'";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error al tratar de guardar,borrar o modificar {objDepartamento} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listaDepartamento(string id) // para uno o todos los datos segun el codigo
        {
            string orden = string.Empty;
            if (id != "Todos")
                orden = $"select * from Departamento where id_departamento = {int.Parse(id)};";
            else
                orden = "select * from Departamento;";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                return ds = null;
                throw new Exception("Error al listar Departamentos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            //return ds;
        }

		public List<Departamento> ObtenerDepartamento()
		{
			List<Departamento> lista = new List<Departamento>();

			string OrdenEjecucion = "Select id_departamento, nombreDepartamento from Departamento";

			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{


					string codigo = dataReader.GetString(1);
					string idDepa = $"{codigo}";

					Departamento departamento = new Departamento();

					departamento.departamento = codigo;

					lista.Add(departamento);

				}
			}
			catch (Exception e)
			{

				throw new Exception("Error al obtener la lista de departamentos", e);
			}

			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}

			return lista;
		}

		public List<Departamento> ObtenerId(string nombre)
		{
			List<Departamento> lista = new List<Departamento>();

			string OrdenEjecucion = $"Select id_departamento from Departamento where nombreDepartamento = '{nombre}'";

			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{


					int codigo = dataReader.GetInt32(0);
					//int idDepa = $"{codigo}";

					Departamento departamento = new Departamento();

					departamento.id = codigo;

					lista.Add(departamento);

				}
			}
			catch (Exception e)
			{

				throw new Exception("Error al obtener el id de departamento", e);

			}

			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}

			return lista;
		}

		public bool HayEmpleadosAsociados(string nombreDepartamento)
		{
			//int resultado = -1;
			string consulta = "SELECT COUNT(*) FROM Empleado WHERE id_depto = (SELECT top 1 id_departamento FROM Departamento WHERE nombreDepartamento = @NombreDepartamento)";
			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@NombreDepartamento", nombreDepartamento);
			try
			{
				Abrirconexion();
				int cantidadEmpleados = (int)cmd.ExecuteScalar();
				return cantidadEmpleados > 0;
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de obtener empleados asociados ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			
			
			
		}

	}
}
