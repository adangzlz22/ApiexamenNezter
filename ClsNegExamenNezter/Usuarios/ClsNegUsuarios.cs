using ClsDatFlotillas;
using ClsDatFlotillas.Usuarios;
using ClsModExamenNezter.Usuarios;
using ClsModFlotillas.Usuarios;
using ClsModHarodoor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsNegFlotillas.Usuarios
{
   public  class ClsNegUsuarios
    {
        public ClsModUsuarios Login(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            ClsModUsuarios objUsuarios = new ClsModUsuarios();

            try
            {
                objUsuarios = new ClsDatUsuarios().Login(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {

                throw;
            }
          
            return objUsuarios;
        }
        public List<ClsModUsuarios> ObtenerUsuarios(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            List<ClsModUsuarios> objUsuarios = new List<ClsModUsuarios>();

            try
            {
                objUsuarios = new ClsDatUsuarios().ObtenerUsuarios(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {

                throw;
            }

            return objUsuarios;
        }
        public ClsModUsuarios CrearUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            ClsModUsuarios objUsuarios = new ClsModUsuarios();
            try
            {
                objUsuarios = new ClsDatUsuarios().CrearUsuario(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuarios;
        }
        public ClsModUsuarios EditarUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            ClsModUsuarios objUsuarios = new ClsModUsuarios();
            try
            {
                objUsuarios = new ClsDatUsuarios().EditarUsuario(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuarios;
        }
        public ClsModUsuarios EliminarUsuario(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            ClsModUsuarios objUsuarios = new ClsModUsuarios();
            try
            {
                objUsuarios = new ClsDatUsuarios().EliminarUsuario(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuarios;
        }


        public List<ClsModCombo> cboEstado(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            List<ClsModCombo> objUsuarios = new List<ClsModCombo>();
            try
            {
                objUsuarios = new ClsDatUsuarios().cboEstado(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuarios;
        }


        public List<ClsModCombo> cboMunicipio(ClsModParametrosUsuarios objModel, out ClsModResultado objClsModResultado)
        {
            objClsModResultado = new ClsModResultado();
            List<ClsModCombo> objUsuarios = new List<ClsModCombo>();
            try
            {
                objUsuarios = new ClsDatUsuarios().cboMunicipio(objModel, out objClsModResultado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuarios;
        }




    }
}
