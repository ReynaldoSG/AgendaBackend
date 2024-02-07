using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using marcatel_api.DataContext;
using marcatel_api.Models;
using System.Collections;

namespace marcatel_api.Services
{
    public class ContactosService
    {
        private string connection;
        public ContactosService(IMarcatelDatabaseSetting settings)
        {
            connection = settings.ConnectionString;
        }

        public int InsertContacto(InsertContactoModel contacto)
        {
            ArrayList parametros = new ArrayList();
            ConexionDataAccess dac = new ConexionDataAccess(connection);
            var lista = new List<InsertContactoModel>();

            try
            {
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = SqlDbType.VarChar, Value = contacto.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pApPaterno", SqlDbType = SqlDbType.VarChar, Value = contacto.ApPaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pApMaterno", SqlDbType = SqlDbType.VarChar, Value = contacto.ApMaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pAlias", SqlDbType = SqlDbType.VarChar, Value = contacto.Alias });
                parametros.Add(new SqlParameter { ParameterName = "@pDireccion", SqlDbType = SqlDbType.VarChar, Value = contacto.Direccion });
                parametros.Add(new SqlParameter { ParameterName = "@pNumMovil", SqlDbType = SqlDbType.VarChar, Value = contacto.NumMovil });
                parametros.Add(new SqlParameter { ParameterName = "@pNumCasa", SqlDbType = SqlDbType.VarChar, Value = contacto.NumCasa });
                parametros.Add(new SqlParameter { ParameterName = "@pCorreo", SqlDbType = SqlDbType.VarChar, Value = contacto.Correo });
                parametros.Add(new SqlParameter { ParameterName = "@pNumEm", SqlDbType = SqlDbType.VarChar, Value = contacto.NumEmergencia });
                parametros.Add(new SqlParameter { ParameterName = "@pEmpresa", SqlDbType = SqlDbType.VarChar, Value = contacto.Empresa });
                parametros.Add(new SqlParameter { ParameterName = "@pDept", SqlDbType = SqlDbType.VarChar, Value = contacto.Departamento });
                parametros.Add(new SqlParameter { ParameterName = "@pPuesto", SqlDbType = SqlDbType.VarChar, Value = contacto.Puesto });
                DataSet ds = dac.Fill("sp_InsertPersonas", parametros);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lista.Add(new InsertContactoModel
                        {
                            Nombre = row["Nombre"].ToString(),
                            ApPaterno = row["ApPaterno"].ToString(),
                            ApMaterno = row["ApMaterno"].ToString(),
                            Alias = row["Alias"].ToString(),
                            Direccion = row["Direccion"].ToString(),
                            NumMovil = row["Numero"].ToString(),
                            NumCasa = row["Numero"].ToString(),
                            Correo = row["Correo"].ToString(),
                            NumEmergencia = row["Numero"].ToString(),
                            Empresa = row["Nombre"].ToString(),
                            Departamento = row["Nombre"].ToString(),
                            Puesto = row["Nombre"].ToString()
                        });
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }

        public List<GetContactoModel> GetContacto()
        {
            ArrayList parametros = new ArrayList();
            ConexionDataAccess dac = new ConexionDataAccess(connection);
            var lista = new List<GetContactoModel>();
            try
            {
                DataSet ds = dac.Fill("sp_GetPersonas", parametros);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lista.Add(new GetContactoModel
                        {
                            // Id = int.Parse(row["Id"].ToString()),
                            Nombre = row["Nombre"].ToString(),
                            ApPaterno = row["apPaterno"].ToString(),
                            ApMaterno = row["apMaterno"].ToString(),
                            Alias = row["Alias"].ToString(),
                            Direccion = row["Direccion"].ToString(),
                            NumMovil = row["NumMovil"].ToString(),
                            NumCasa = row["NumCasa"].ToString(),
                            Correo = row["Correo"].ToString(),
                            NumEmergencia = row["NumEmergencia"].ToString(),
                            Empresa = row["NombreEmpresa"].ToString(),
                            Departamento = row["NombreDepartamento"].ToString(),
                            Puesto = row["NombrePuesto"].ToString()
                        });
                    }
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public int UpdateContacto(UpdateContactoModel contacto)
        {
            ArrayList parametros = new ArrayList();
            ConexionDataAccess dac = new ConexionDataAccess(connection);
            var lista = new List<UpdateContactoModel>();

            try
            {
                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = SqlDbType.VarChar, Value = contacto.Id });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = SqlDbType.VarChar, Value = contacto.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pApPaterno", SqlDbType = SqlDbType.VarChar, Value = contacto.ApPaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pApMaterno", SqlDbType = SqlDbType.VarChar, Value = contacto.ApMaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pAlias", SqlDbType = SqlDbType.VarChar, Value = contacto.Alias });
                parametros.Add(new SqlParameter { ParameterName = "@pDireccion", SqlDbType = SqlDbType.VarChar, Value = contacto.Direccion });
                parametros.Add(new SqlParameter { ParameterName = "@pNumMovil", SqlDbType = SqlDbType.VarChar, Value = contacto.NumMovil });
                parametros.Add(new SqlParameter { ParameterName = "@pNumCasa", SqlDbType = SqlDbType.VarChar, Value = contacto.NumCasa });
                parametros.Add(new SqlParameter { ParameterName = "@pCorreo", SqlDbType = SqlDbType.VarChar, Value = contacto.Correo });
                parametros.Add(new SqlParameter { ParameterName = "@pNumEm", SqlDbType = SqlDbType.VarChar, Value = contacto.NumEmergencia });
                parametros.Add(new SqlParameter { ParameterName = "@pEmpresa", SqlDbType = SqlDbType.VarChar, Value = contacto.Empresa });
                parametros.Add(new SqlParameter { ParameterName = "@pDept", SqlDbType = SqlDbType.VarChar, Value = contacto.Departamento });
                parametros.Add(new SqlParameter { ParameterName = "@pPuesto", SqlDbType = SqlDbType.VarChar, Value = contacto.Puesto });
                DataSet ds = dac.Fill("sp_UpdatePersonas", parametros);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lista.Add(new UpdateContactoModel
                        {
                            Id = int.Parse(row["Id"].ToString()),
                            Nombre = row["Nombre"].ToString(),
                            ApPaterno = row["ApPaterno"].ToString(),
                            ApMaterno = row["ApMaterno"].ToString(),
                            Alias = row["Alias"].ToString(),
                            Direccion = row["Direccion"].ToString(),
                            NumMovil = row["Numero"].ToString(),
                            NumCasa = row["Numero"].ToString(),
                            Correo = row["Correo"].ToString(),
                            NumEmergencia = row["Numero"].ToString(),
                            Empresa = row["Nombre"].ToString(),
                            Departamento = row["Nombre"].ToString(),
                            Puesto = row["Nombre"].ToString()
                        });
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }

        public int DeleteContacto(DeleteContactoModel contacto)
        {
            ArrayList parametros = new ArrayList();
            ConexionDataAccess dac = new ConexionDataAccess(connection);
            var lista = new List<DeleteContactoModel>();

            try
            {
                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = SqlDbType.Int, Value = contacto.Id });
                DataSet ds = dac.Fill("sp_DeletePersonas", parametros);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lista.Add(new DeleteContactoModel
                        {
                            Id = int.Parse(row["Id"].ToString())
                        });
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }


    }
}
