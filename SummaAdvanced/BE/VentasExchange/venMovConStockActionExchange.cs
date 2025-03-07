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
    public class venMovConStockActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String TipoPrecioForm {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["TipoPrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].TipoPrecioForm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].TipoPrecioForm = value;
               }
	          }
        public bool IsTipoPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsTipoPrecioFormNull();
             }
	        }
        public Boolean LlevaImpuestoInclu {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["LlevaImpuestoInclu"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].LlevaImpuestoInclu;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].LlevaImpuestoInclu = value;
               }
	          }
        public bool IsLlevaImpuestoIncluNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsLlevaImpuestoIncluNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovConStockDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovConStockDS );
     }
     public venMovConStockActionExchange() : base( "venMovConStock" ) {
     }

     public venMovConStockActionExchange(venMovConStockActionEnum.EnumvenMovConStockAction pAccion) : base(venMovConStockActionEnum.GetAccionvenMovConStockAction(pAccion)) {
     }

     public venMovConStockActionExchange(venMovConStockActionEnum.EnumvenMovConStockAction pAccion, VentasCommon.venMovConStockDS pdsParam) : base(venMovConStockActionEnum.GetAccionvenMovConStockAction(pAccion), pdsParam) {
     }

     public venMovConStockActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovConStockDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovConStockDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovConStockDS)mParam;
	        }
     }
  }
}
