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
    public class genAlertasActionExchange : Framework.Core.Exchange{

        public Int32 AlertaId {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["AlertaId"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].AlertaId;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].AlertaId = value;
               }
	          }
        public bool IsAlertaIdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsAlertaIdNull();
             }
	        }
        public String Usuario_id {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaEmision {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["FechaEmision"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].FechaEmision;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].FechaEmision = value;
               }
	          }
        public bool IsFechaEmisionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsFechaEmisionNull();
             }
	        }
        public DateTime FechaLeido {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["FechaLeido"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].FechaLeido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].FechaLeido = value;
               }
	          }
        public bool IsFechaLeidoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsFechaLeidoNull();
             }
	        }
        public String Mensaje {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public String Liga {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["Liga"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Liga;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Liga = value;
               }
	          }
        public bool IsLigaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsLigaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAlertasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAlertasDS );
     }
     public genAlertasActionExchange() : base( "genAlertas" ) {
     }

     public genAlertasActionExchange(genAlertasActionEnum.EnumgenAlertasAction pAccion) : base(genAlertasActionEnum.GetAcciongenAlertasAction(pAccion)) {
     }

     public genAlertasActionExchange(genAlertasActionEnum.EnumgenAlertasAction pAccion, GeneralesCommon.genAlertasDS pdsParam) : base(genAlertasActionEnum.GetAcciongenAlertasAction(pAccion), pdsParam) {
     }

     public genAlertasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAlertasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAlertasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAlertasDS)mParam;
	        }
     }
  }
}
