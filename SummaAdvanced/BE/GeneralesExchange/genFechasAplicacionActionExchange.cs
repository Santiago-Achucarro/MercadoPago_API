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
    public class genFechasAplicacionActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime Fecha_Ap {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Fecha_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Fecha_Ap;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Fecha_Ap = value;
               }
	          }
        public bool IsFecha_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsFecha_ApNull();
             }
	        }
        public DateTime FechaCierreCompras {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["FechaCierreCompras"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].FechaCierreCompras;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].FechaCierreCompras = value;
               }
	          }
        public bool IsFechaCierreComprasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsFechaCierreComprasNull();
             }
	        }
        public DateTime FechaCierreVentas {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["FechaCierreVentas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].FechaCierreVentas;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].FechaCierreVentas = value;
               }
	          }
        public bool IsFechaCierreVentasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsFechaCierreVentasNull();
             }
	        }
        public String EsCompras {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["EsCompras"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsCompras;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsCompras = value;
               }
	          }
        public bool IsEsComprasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsEsComprasNull();
             }
	        }
        public String EsVentas {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["EsVentas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsVentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsVentas = value;
               }
	          }
        public bool IsEsVentasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsEsVentasNull();
             }
	        }
        public String EsCompras_Ap {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["EsCompras_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsCompras_Ap;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsCompras_Ap = value;
               }
	          }
        public bool IsEsCompras_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsEsCompras_ApNull();
             }
	        }
        public String EsVentas_AP {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["EsVentas_AP"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsVentas_AP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].EsVentas_AP = value;
               }
	          }
        public bool IsEsVentas_APNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsEsVentas_APNull();
             }
	        }
        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int64 Asiento_Id_Ap {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Asiento_Id_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Asiento_Id_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Asiento_Id_Ap = value;
               }
	          }
        public bool IsAsiento_Id_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsAsiento_Id_ApNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal Cambio_Ap {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Cambio_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Cambio_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Cambio_Ap = value;
               }
	          }
        public bool IsCambio_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsCambio_ApNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genFechasAplicacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genFechasAplicacionDS );
     }
     public genFechasAplicacionActionExchange() : base( "genFechasAplicacion" ) {
     }

     public genFechasAplicacionActionExchange(genFechasAplicacionActionEnum.EnumgenFechasAplicacionAction pAccion) : base(genFechasAplicacionActionEnum.GetAcciongenFechasAplicacionAction(pAccion)) {
     }

     public genFechasAplicacionActionExchange(genFechasAplicacionActionEnum.EnumgenFechasAplicacionAction pAccion, GeneralesCommon.genFechasAplicacionDS pdsParam) : base(genFechasAplicacionActionEnum.GetAcciongenFechasAplicacionAction(pAccion), pdsParam) {
     }

     public genFechasAplicacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genFechasAplicacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genFechasAplicacionDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genFechasAplicacionDS)mParam;
	        }
     }
  }
}
