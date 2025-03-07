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
    public class comMovContCuentaActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String Clase {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Int32 Decimales {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovContCuentaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovContCuentaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovContCuentaDS );
     }
     public comMovContCuentaActionExchange() : base( "comMovContCuenta" ) {
     }

     public comMovContCuentaActionExchange(comMovContCuentaActionEnum.EnumcomMovContCuentaAction pAccion) : base(comMovContCuentaActionEnum.GetAccioncomMovContCuentaAction(pAccion)) {
     }

     public comMovContCuentaActionExchange(comMovContCuentaActionEnum.EnumcomMovContCuentaAction pAccion, ComprasCommon.comMovContCuentaDS pdsParam) : base(comMovContCuentaActionEnum.GetAccioncomMovContCuentaAction(pAccion), pdsParam) {
     }

     public comMovContCuentaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovContCuentaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovContCuentaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovContCuentaDS)mParam;
	        }
     }
  }
}
