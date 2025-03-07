using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genUltPaginasVisitadasUsuariosActionExchange : Framework.Core.Exchange{

        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUltPaginasVisitadasUsuariosDS );
     }
     public genUltPaginasVisitadasUsuariosActionExchange() : base( "genUltPaginasVisitadasUsuarios" ) {
     }

     public genUltPaginasVisitadasUsuariosActionExchange(genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction pAccion) : base(genUltPaginasVisitadasUsuariosActionEnum.GetAcciongenUltPaginasVisitadasUsuariosAction(pAccion)) {
     }

     public genUltPaginasVisitadasUsuariosActionExchange(genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction pAccion, GeneralesCommon.genUltPaginasVisitadasUsuariosDS pdsParam) : base(genUltPaginasVisitadasUsuariosActionEnum.GetAcciongenUltPaginasVisitadasUsuariosAction(pAccion), pdsParam) {
     }

     public genUltPaginasVisitadasUsuariosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUltPaginasVisitadasUsuariosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUltPaginasVisitadasUsuariosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUltPaginasVisitadasUsuariosDS)mParam;
	        }
     }
  }
}
