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
    public class genLogRequestDatosTodosActionExchange : Framework.Core.Exchange{

        public String Tipo {
            get {
                if(((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDatosTodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genLogRequestDatosTodosDS );
     }
     public genLogRequestDatosTodosActionExchange() : base( "genLogRequestDatosTodos" ) {
     }

     public genLogRequestDatosTodosActionExchange(genLogRequestDatosTodosActionEnum.EnumgenLogRequestDatosTodosAction pAccion) : base(genLogRequestDatosTodosActionEnum.GetAcciongenLogRequestDatosTodosAction(pAccion)) {
     }

     public genLogRequestDatosTodosActionExchange(genLogRequestDatosTodosActionEnum.EnumgenLogRequestDatosTodosAction pAccion, GeneralesCommon.genLogRequestDatosTodosDS pdsParam) : base(genLogRequestDatosTodosActionEnum.GetAcciongenLogRequestDatosTodosAction(pAccion), pdsParam) {
     }

     public genLogRequestDatosTodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genLogRequestDatosTodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genLogRequestDatosTodosActionExchange(GeneralesCommon.genLogRequestDatosTodosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genLogRequestDatosTodosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genLogRequestDatosTodosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genLogRequestDatosTodosDS)mParam;
	        }
     }
  }
}
