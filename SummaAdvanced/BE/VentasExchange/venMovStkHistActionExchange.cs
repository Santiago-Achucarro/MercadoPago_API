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
    public class venMovStkHistActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String FacturaRemito {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["FacturaRemito"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].FacturaRemito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].FacturaRemito = value;
               }
	          }
        public bool IsFacturaRemitoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsFacturaRemitoNull();
             }
	        }
        public String Factura {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["Factura"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Factura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Factura = value;
               }
	          }
        public bool IsFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsFacturaNull();
             }
	        }
        public String Remito {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["Remito"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Remito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Remito = value;
               }
	          }
        public bool IsRemitoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsRemitoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovStkHistDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovStkHistDS );
     }
     public venMovStkHistActionExchange() : base( "venMovStkHist" ) {
     }

     public venMovStkHistActionExchange(venMovStkHistActionEnum.EnumvenMovStkHistAction pAccion) : base(venMovStkHistActionEnum.GetAccionvenMovStkHistAction(pAccion)) {
     }

     public venMovStkHistActionExchange(venMovStkHistActionEnum.EnumvenMovStkHistAction pAccion, VentasCommon.venMovStkHistDS pdsParam) : base(venMovStkHistActionEnum.GetAccionvenMovStkHistAction(pAccion), pdsParam) {
     }

     public venMovStkHistActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovStkHistDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovStkHistDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovStkHistDS)mParam;
	        }
     }
  }
}
