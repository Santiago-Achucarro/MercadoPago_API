using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovProvxClaveFiscalActionExchange : Framework.Core.Exchange{

        public String Comprobante {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["Comprobante"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Comprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Comprobante = value;
               }
	          }
        public bool IsComprobanteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsComprobanteNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String ClaveFiscal {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["ClaveFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].ClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].ClaveFiscal = value;
               }
	          }
        public bool IsClaveFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsClaveFiscalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvxClaveFiscalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvxClaveFiscalDS );
     }
     public comMovProvxClaveFiscalActionExchange() : base( "comMovProvxClaveFiscal" ) {
     }

     public comMovProvxClaveFiscalActionExchange(comMovProvxClaveFiscalActionEnum.EnumcomMovProvxClaveFiscalAction pAccion) : base(comMovProvxClaveFiscalActionEnum.GetAccioncomMovProvxClaveFiscalAction(pAccion)) {
     }

     public comMovProvxClaveFiscalActionExchange(comMovProvxClaveFiscalActionEnum.EnumcomMovProvxClaveFiscalAction pAccion, ComprasCommon.comMovProvxClaveFiscalDS pdsParam) : base(comMovProvxClaveFiscalActionEnum.GetAccioncomMovProvxClaveFiscalAction(pAccion), pdsParam) {
     }

     public comMovProvxClaveFiscalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvxClaveFiscalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvxClaveFiscalDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvxClaveFiscalDS)mParam;
	        }
     }
  }
}
