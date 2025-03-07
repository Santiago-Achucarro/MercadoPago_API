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
    public class genCancSaldosCuentaActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Int64 Asiento_Id_Ap {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Asiento_Id_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Asiento_Id_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Asiento_Id_Ap = value;
               }
	          }
        public bool IsAsiento_Id_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsAsiento_Id_ApNull();
             }
	        }
        public Decimal CambioAp {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["CambioAp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].CambioAp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].CambioAp = value;
               }
	          }
        public bool IsCambioApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsCambioApNull();
             }
	        }
        public DateTime FechaAp {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["FechaAp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].FechaAp;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].FechaAp = value;
               }
	          }
        public bool IsFechaApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsFechaApNull();
             }
	        }
        public String Moneda_IdAP {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Moneda_IdAP"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Moneda_IdAP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Moneda_IdAP = value;
               }
	          }
        public bool IsMoneda_IdAPNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsMoneda_IdAPNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancSaldosCuentaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCancSaldosCuentaDS );
     }
     public genCancSaldosCuentaActionExchange() : base( "genCancSaldosCuenta" ) {
     }

     public genCancSaldosCuentaActionExchange(genCancSaldosCuentaActionEnum.EnumgenCancSaldosCuentaAction pAccion) : base(genCancSaldosCuentaActionEnum.GetAcciongenCancSaldosCuentaAction(pAccion)) {
     }

     public genCancSaldosCuentaActionExchange(genCancSaldosCuentaActionEnum.EnumgenCancSaldosCuentaAction pAccion, GeneralesCommon.genCancSaldosCuentaDS pdsParam) : base(genCancSaldosCuentaActionEnum.GetAcciongenCancSaldosCuentaAction(pAccion), pdsParam) {
     }

     public genCancSaldosCuentaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCancSaldosCuentaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCancSaldosCuentaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCancSaldosCuentaDS)mParam;
	        }
     }
  }
}
