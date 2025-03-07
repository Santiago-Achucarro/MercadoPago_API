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
    public class tesFFCobClientesActionExchange : Framework.Core.Exchange{

        public Int64 tesFlujoFondo {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["tesFlujoFondo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].tesFlujoFondo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].tesFlujoFondo = value;
               }
	          }
        public bool IstesFlujoFondoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IstesFlujoFondoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFFCobClientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesFFCobClientesDS );
     }
     public tesFFCobClientesActionExchange() : base( "tesFFCobClientes" ) {
     }

     public tesFFCobClientesActionExchange(tesFFCobClientesActionEnum.EnumtesFFCobClientesAction pAccion) : base(tesFFCobClientesActionEnum.GetAcciontesFFCobClientesAction(pAccion)) {
     }

     public tesFFCobClientesActionExchange(tesFFCobClientesActionEnum.EnumtesFFCobClientesAction pAccion, TesoreriaCommon.tesFFCobClientesDS pdsParam) : base(tesFFCobClientesActionEnum.GetAcciontesFFCobClientesAction(pAccion), pdsParam) {
     }

     public tesFFCobClientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesFFCobClientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesFFCobClientesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesFFCobClientesDS)mParam;
	        }
     }
  }
}
