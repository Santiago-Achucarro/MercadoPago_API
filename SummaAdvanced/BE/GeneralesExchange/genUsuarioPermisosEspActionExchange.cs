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
    public class genUsuarioPermisosEspActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Permiso_Id {
            get {
                if(((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0]["Permiso_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Permiso_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Permiso_Id = value;
               }
	          }
        public bool IsPermiso_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].IsPermiso_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioPermisosEspDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuarioPermisosEspDS );
     }
     public genUsuarioPermisosEspActionExchange() : base( "genUsuarioPermiosEsp" ) {
     }

     public genUsuarioPermisosEspActionExchange(genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction pAccion) : base(genUsuarioPermisosEspActionEnum.GetAcciongenUsuarioPermiosEspAction(pAccion)) {
     }

     public genUsuarioPermisosEspActionExchange(genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction pAccion, GeneralesCommon.genUsuarioPermisosEspDS pdsParam) : base(genUsuarioPermisosEspActionEnum.GetAcciongenUsuarioPermiosEspAction(pAccion), pdsParam) {
     }

     public genUsuarioPermisosEspActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuarioPermisosEspDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuarioPermisosEspDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuarioPermisosEspDS)mParam;
	        }
     }
  }
}
