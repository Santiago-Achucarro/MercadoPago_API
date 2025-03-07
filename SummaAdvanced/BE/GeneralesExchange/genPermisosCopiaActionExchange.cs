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
    public class genPermisosCopiaActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_Y_Nombres {
            get {
                if(((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0]["Apellido_Y_Nombres"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Apellido_Y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Apellido_Y_Nombres = value;
               }
	          }
        public bool IsApellido_Y_NombresNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].IsApellido_Y_NombresNull();
             }
	        }
        public String UsuarioAp_Id {
            get {
                if(((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0]["UsuarioAp_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].UsuarioAp_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].UsuarioAp_Id = value;
               }
	          }
        public bool IsUsuarioAp_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].IsUsuarioAp_IdNull();
             }
	        }
        public String Apellido_Y_NombresAp {
            get {
                if(((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0]["Apellido_Y_NombresAp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Apellido_Y_NombresAp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].Apellido_Y_NombresAp = value;
               }
	          }
        public bool IsApellido_Y_NombresApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosCopiaDS)mParam).Principal[0].IsApellido_Y_NombresApNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genPermisosCopiaDS );
     }
     public genPermisosCopiaActionExchange() : base( "genPermisosCopia" ) {
     }

     public genPermisosCopiaActionExchange(genPermisosCopiaActionEnum.EnumgenPermisosCopiaAction pAccion) : base(genPermisosCopiaActionEnum.GetAcciongenPermisosCopiaAction(pAccion)) {
     }

     public genPermisosCopiaActionExchange(genPermisosCopiaActionEnum.EnumgenPermisosCopiaAction pAccion, GeneralesCommon.genPermisosCopiaDS pdsParam) : base(genPermisosCopiaActionEnum.GetAcciongenPermisosCopiaAction(pAccion), pdsParam) {
     }

     public genPermisosCopiaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genPermisosCopiaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genPermisosCopiaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genPermisosCopiaDS)mParam;
	        }
     }
  }
}
