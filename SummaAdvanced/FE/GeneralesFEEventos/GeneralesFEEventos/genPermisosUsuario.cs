using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesFEEventos
{
    public class genPermisosUsuario
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string VerTipoOpcion(GeneralesCommon.genPermisosUsuarioDS exch,
    GeneralesCommon.genPermisosUsuarioDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return exchNoPost.Permisos[0].Tipo;
            //{
            //    GeneralesExchange.genPermisosUsuarioActionExchange exchGPU = new GeneralesExchange.genPermisosUsuarioActionExchange(GeneralesExchange.genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction.AsignarHijos);

            //    exchGPU.Param.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);
            //    exchGPU.Param.Principal[0].Delete();
            //    exchGPU.Param.AcceptChanges();

            //    exchGPU.Param.Permisos[pIndice].Actualizar = exchNoPost.Permisos[0].Actualizar;
            //    exchGPU.Param.Permisos[pIndice].Borrar = exchNoPost.Permisos[0].Borrar;
            //    exchGPU.Param.Permisos[pIndice].Consultar = exchNoPost.Permisos[0].Consultar;
            //    exchGPU.Param.Permisos[pIndice].ModificaCodigos = exchNoPost.Permisos[0].ModificaCodigos;
            //    exchGPU.Param.Permisos[pIndice].ParaTodasLasEmpresas = exchNoPost.Permisos[0].ParaTodasLasEmpresas;
            //    exchGPU.Param.Permisos[pIndice].Postear = exchNoPost.Permisos[0].Postear;

            //    exchGPU = new GeneralesExchange.genPermisosUsuarioActionExchange(Generalidades.QBI.WrapperExecuteAction(exchGPU, cmd.Usuario_Id, cmd.Empresa_Id, cmd.Dominio_Id, cmd.MonedaBase, cmd.Formulario, cmd.Instalacion, cmd.CodigoConsulta));

            //    exchNoPost.Clear();
            //    exchNoPost.Merge(exchGPU.Param, false, System.Data.MissingSchemaAction.Ignore);
            //}

            //return exchNoPost;

        }
    }
}
