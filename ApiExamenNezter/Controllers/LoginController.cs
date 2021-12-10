using ClsModExamenNezter.Usuarios;
using ClsModFlotillas.Usuarios;
using ClsModHarodoor.Common;
using ClsNegFlotillas.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebFlotillasTrack.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [ActionName("Logearse")]
        public ClsModResponse Logearse([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objModConteoFisico = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            ClsModUsuarios objUsuarios = new ClsNegUsuarios().Login(objModConteoFisico, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }
        [HttpPost]
        [AllowAnonymous]
        [ActionName("ObtenerUsuarios")]
        public ClsModResponse ObtenerUsuarios([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            List<ClsModUsuarios> objUsuarios = new ClsNegUsuarios().ObtenerUsuarios(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("CrearUsuario")]
        public ClsModResponse CrearUsuario([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            ClsModUsuarios objUsuarios = new ClsNegUsuarios().CrearUsuario(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("EditarUsuario")]
        public ClsModResponse EditarUsuario([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            ClsModUsuarios objUsuarios = new ClsNegUsuarios().EditarUsuario(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("EliminarUsuario")]
        public ClsModResponse EliminarUsuario([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            ClsModUsuarios objUsuarios = new ClsNegUsuarios().EliminarUsuario(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("cboEstado")]
        public ClsModResponse cboEstado([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            List<ClsModCombo> objUsuarios = new ClsNegUsuarios().cboEstado(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("cboMunicipio")]
        public ClsModResponse cboMunicipio([FromBody] ClsModRequest objModRequest)
        {
            ClsModParametrosUsuarios objUsuario = ClsObjectTransformation.Deserialize<ClsModParametrosUsuarios>(objModRequest.Model, objModRequest.Formato);
            ClsModResponse objModResponse = new ClsModResponse();
            ClsModResultado objModResultado = null;

            List<ClsModCombo> objUsuarios = new ClsNegUsuarios().cboMunicipio(objUsuario, out objModResultado);
            objModResponse.Model = ClsObjectTransformation.SerializeObjectToString<object>(objUsuarios, objModRequest.Formato);

            objModResponse.ObjModResultado = objModResultado;


            return objModResponse;
        }






    }
}
