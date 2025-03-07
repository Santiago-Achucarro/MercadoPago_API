using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkProductosCtasVentasActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Int32 Signo {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Exterior {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["Exterior"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Exterior;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Exterior = value;
               }
	          }
        public bool IsExteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsExteriorNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String CtaIngreso {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["CtaIngreso"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaIngreso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaIngreso = value;
               }
	          }
        public bool IsCtaIngresoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsCtaIngresoNull();
             }
	        }
        public String CtaDescuento {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["CtaDescuento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaDescuento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaDescuento = value;
               }
	          }
        public bool IsCtaDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsCtaDescuentoNull();
             }
	        }
        public String CtaCosto {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["CtaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].CtaCosto = value;
               }
	          }
        public bool IsCtaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsCtaCostoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCtasVentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosCtasVentasDS );
     }
     public stkProductosCtasVentasActionExchange() : base( "stkProductosCtasVentas" ) {
     }

     public stkProductosCtasVentasActionExchange(stkProductosCtasVentasActionEnum.EnumstkProductosCtasVentasAction pAccion) : base(stkProductosCtasVentasActionEnum.GetAccionstkProductosCtasVentasAction(pAccion)) {
     }

     public stkProductosCtasVentasActionExchange(stkProductosCtasVentasActionEnum.EnumstkProductosCtasVentasAction pAccion, StockCommon.stkProductosCtasVentasDS pdsParam) : base(stkProductosCtasVentasActionEnum.GetAccionstkProductosCtasVentasAction(pAccion), pdsParam) {
     }

     public stkProductosCtasVentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosCtasVentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkProductosCtasVentasActionExchange(StockCommon.stkProductosCtasVentasDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkProductosCtasVentasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosCtasVentasDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosCtasVentasDS)mParam;
	        }
     }
  }
}
