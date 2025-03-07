using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venAsiCierreActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public DateTime Fecha1 {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Fecha1"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Fecha1;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Fecha1 = value;
               }
	          }
        public bool IsFecha1Null {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsFecha1Null();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venAsiCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venAsiCierreDS );
     }
     public venAsiCierreActionExchange() : base( "venAsiCierre" ) {
     }

     public venAsiCierreActionExchange(venAsiCierreActionEnum.EnumvenAsiCierreAction pAccion) : base(venAsiCierreActionEnum.GetAccionvenAsiCierreAction(pAccion)) {
     }

     public venAsiCierreActionExchange(venAsiCierreActionEnum.EnumvenAsiCierreAction pAccion, VentasCommon.venAsiCierreDS pdsParam) : base(venAsiCierreActionEnum.GetAccionvenAsiCierreAction(pAccion), pdsParam) {
     }

     public venAsiCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venAsiCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venAsiCierreDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venAsiCierreDS)mParam;
	        }
     }
  }
}
