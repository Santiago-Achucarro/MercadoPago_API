using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesFFPagosProvedoresActionExchange : Framework.Core.Exchange{

        public Int64 tesFlujoFondo {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["tesFlujoFondo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].tesFlujoFondo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].tesFlujoFondo = value;
               }
	          }
        public bool IstesFlujoFondoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IstesFlujoFondoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFPagosProvedoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesFFPagosProvedoresDS );
     }
     public tesFFPagosProvedoresActionExchange() : base( "tesFFPagosProvedores" ) {
     }

     public tesFFPagosProvedoresActionExchange(tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction pAccion) : base(tesFFPagosProvedoresActionEnum.GetAcciontesFFPagosProvedoresAction(pAccion)) {
     }

     public tesFFPagosProvedoresActionExchange(tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction pAccion, TesoreriaCommon.tesFFPagosProvedoresDS pdsParam) : base(tesFFPagosProvedoresActionEnum.GetAcciontesFFPagosProvedoresAction(pAccion), pdsParam) {
     }

     public tesFFPagosProvedoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesFFPagosProvedoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesFFPagosProvedoresDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesFFPagosProvedoresDS)mParam;
	        }
     }
  }
}
