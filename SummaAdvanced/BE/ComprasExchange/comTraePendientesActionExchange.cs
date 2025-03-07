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
    public class comTraePendientesActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Proveee_id {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["Proveee_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Proveee_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Proveee_id = value;
               }
	          }
        public bool IsProveee_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IsProveee_idNull();
             }
	        }
        public Int32 Signo {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comTraePendientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTraePendientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comTraePendientesDS );
     }
     public comTraePendientesActionExchange() : base( "comTraePendientes" ) {
     }

     public comTraePendientesActionExchange(comTraePendientesActionEnum.EnumcomTraePendientesAction pAccion) : base(comTraePendientesActionEnum.GetAccioncomTraePendientesAction(pAccion)) {
     }

     public comTraePendientesActionExchange(comTraePendientesActionEnum.EnumcomTraePendientesAction pAccion, ComprasCommon.comTraePendientesDS pdsParam) : base(comTraePendientesActionEnum.GetAccioncomTraePendientesAction(pAccion), pdsParam) {
     }

     public comTraePendientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comTraePendientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comTraePendientesDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comTraePendientesDS)mParam;
	        }
     }
  }
}
