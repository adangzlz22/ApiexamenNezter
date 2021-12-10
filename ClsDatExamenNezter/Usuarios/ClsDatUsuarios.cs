using ClsModFlotillas.Usuarios;
using ClsModHarodoor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using ClsModExamenNezter.Usuarios;

namespace ClsDatFlotillas.Usuarios
{
    public class ClsDatUsuarios
    {
        Conexion obtenerCadena = new Conexion();
        public ClsModUsuarios Login(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            ClsModUsuarios obj = new ClsModUsuarios();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spLoginUsuario";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@UserName", objModel.UserName, DbType.String);
                lstParametros.Add("@PassName", objModel.PassName, DbType.String);
                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModUsuarios>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).Select(y => new ClsModUsuarios
                    {
                        idUsuario = y.idUsuario,
                        Usuario = y.Usuario,
                        UserName = y.UserName,
                        PassName = y.PassName,
                        Nombre = y.Nombre,
                        Direccion = y.Direccion,
                        Telefono = y.Telefono,
                        CodigoPostal = y.CodigoPostal,
                        TipoUsuario = y.TipoUsuario,
                    }).FirstOrDefault();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }

            return obj;
        }
        public List<ClsModUsuarios> ObtenerUsuarios(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            List<ClsModUsuarios> lst = new List<ClsModUsuarios>();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spObtenerUsuarios";
                DynamicParameters lstParametros = new DynamicParameters();
                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    lst = db.Query<ClsModUsuarios>(sql, null, null, true, 300, CommandType.StoredProcedure).Select(y => new ClsModUsuarios
                    {
                        idUsuario = y.idUsuario,
                        Usuario = y.Usuario,
                        UserName = y.UserName,
                        PassName = y.PassName,
                        Nombre = y.Nombre,
                        Direccion = y.Direccion,
                        Telefono = y.Telefono,
                        CodigoPostal = y.CodigoPostal,
                        TipoUsuario = y.TipoUsuario,
                        idPais = y.idPais,
                        Pais = y.Pais,
                        idEstado = y.idEstado,
                        Estado = y.Estado,
                        idCiudad = y.idCiudad,
                        Municipio = y.Municipio,
                    }).ToList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return lst;
        }
        public ClsModUsuarios CrearUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            ClsModUsuarios obj = new ClsModUsuarios();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spCrearUsuario";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@Usuario", objModel.Usuario, DbType.String);
                lstParametros.Add("@UserName", objModel.UserName, DbType.String);
                lstParametros.Add("@PassName", objModel.PassName, DbType.String);
                lstParametros.Add("@Nombre", objModel.Nombre, DbType.String);
                lstParametros.Add("@Direccion", objModel.Direccion, DbType.String);
                lstParametros.Add("@Telefono", objModel.Telefono, DbType.String);
                lstParametros.Add("@CodigoPostal", objModel.CodigoPostal, DbType.String);
                lstParametros.Add("@TipoUsuario", objModel.TipoUsuario, DbType.Int32);
                lstParametros.Add("@idPais", objModel.idPais, DbType.Int32);
                lstParametros.Add("@idEstado", objModel.idEstado, DbType.Int32);
                lstParametros.Add("@idCiudad", objModel.idCiudad, DbType.Int32);

                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModUsuarios>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).FirstOrDefault();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return obj;
        }
        public ClsModUsuarios EditarUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            ClsModUsuarios obj = new ClsModUsuarios();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spCrearUsuario";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@idUsuario", objModel.Usuario, DbType.Int32);
                lstParametros.Add("@Usuario", objModel.Usuario, DbType.String);
                lstParametros.Add("@UserName", objModel.UserName, DbType.String);
                lstParametros.Add("@PassName", objModel.PassName, DbType.String);
                lstParametros.Add("@Nombre", objModel.Nombre, DbType.String);
                lstParametros.Add("@Direccion", objModel.Direccion, DbType.String);
                lstParametros.Add("@Telefono", objModel.Telefono, DbType.String);
                lstParametros.Add("@CodigoPostal", objModel.CodigoPostal, DbType.String);
                lstParametros.Add("@TipoUsuario", objModel.TipoUsuario, DbType.Int32);
                lstParametros.Add("@idPais", objModel.idPais, DbType.Int32);
                lstParametros.Add("@idEstado", objModel.idEstado, DbType.Int32);
                lstParametros.Add("@idCiudad", objModel.idCiudad, DbType.Int32);

                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModUsuarios>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).FirstOrDefault();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return obj;
        }
        public ClsModUsuarios EliminarUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            ClsModUsuarios obj = new ClsModUsuarios();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spEliminarUsuario";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@idUsuario", objModel.idUsuario, DbType.Int32);
                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModUsuarios>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).FirstOrDefault();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return obj;
        }
        public List<ClsModCombo> cboEstado(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            List<ClsModCombo> obj = new List<ClsModCombo>();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spObtenerEstado";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@idPais", objModel.idPais, DbType.Int32);
                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModCombo>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).ToList().Select(y => new ClsModCombo
                    {
                        value = y.value,
                        text = y.text,
                    }).ToList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return obj;
        }
        public List<ClsModCombo> cboMunicipio(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            List<ClsModCombo> obj = new List<ClsModCombo>();
            objClsModResultado = new ClsModResultado();
            try
            {
                string sql = @"spObtenerMunicipios";
                DynamicParameters lstParametros = new DynamicParameters();
                lstParametros.Add("@idEstado", objModel.idEstado, DbType.Int32);
                using (var db = new SqlConnection(Conexion.conectarExamenNezter()))
                {
                    db.Open();
                    obj = db.Query<ClsModCombo>(sql, lstParametros, null, true, 300, CommandType.StoredProcedure).ToList().Select(y => new ClsModCombo
                    {
                        value = y.value,
                        text = y.text,
                    }).ToList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                objClsModResultado.MsgError = "ERROR EN LA APLICACION";
            }
            return obj;
        }
    }
}
