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
    public class genFavoritosUsuariosActionExchange : Framework.Core.Exchange{

        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFavoritosUsuariosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genFavoritosUsuariosDS );
     }
     public genFavoritosUsuariosActionExchange() : base( "genFavoritosUsuarios" ) {
     }

     public genFavoritosUsuariosActionExchange(genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction pAccion) : base(genFavoritosUsuariosActionEnum.GetAcciongenFavoritosUsuariosAction(pAccion)) {
     }

     public genFavoritosUsuariosActionExchange(genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction pAccion, GeneralesCommon.genFavoritosUsuariosDS pdsParam) : base(genFavoritosUsuariosActionEnum.GetAcciongenFavoritosUsuariosAction(pAccion), pdsParam) {
     }

     public genFavoritosUsuariosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genFavoritosUsuariosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genFavoritosUsuariosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genFavoritosUsuariosDS)mParam;
	        }
     }
  }
}
