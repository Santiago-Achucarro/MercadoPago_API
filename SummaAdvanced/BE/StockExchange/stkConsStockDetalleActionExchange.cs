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
    public class stkConsStockDetalleActionExchange : Framework.Core.Exchange{

        public String Entidad_Id {
            get {
                if(((StockCommon.stkConsStockDetalleDS)mParam).Principal[0]["Entidad_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Entidad_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Entidad_Id = value;
               }
	          }
        public bool IsEntidad_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].IsEntidad_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkConsStockDetalleDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkConsStockDetalleDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String SegmentoSTR {
            get {
                if(((StockCommon.stkConsStockDetalleDS)mParam).Principal[0]["SegmentoSTR"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].SegmentoSTR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].SegmentoSTR = value;
               }
	          }
        public bool IsSegmentoSTRNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].IsSegmentoSTRNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkConsStockDetalleDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDetalleDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkConsStockDetalleDS );
     }
     public stkConsStockDetalleActionExchange() : base( "stkConsStockDetalle" ) {
     }

     public stkConsStockDetalleActionExchange(stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction pAccion) : base(stkConsStockDetalleActionEnum.GetAccionstkConsStockDetalleAction(pAccion)) {
     }

     public stkConsStockDetalleActionExchange(stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction pAccion, StockCommon.stkConsStockDetalleDS pdsParam) : base(stkConsStockDetalleActionEnum.GetAccionstkConsStockDetalleAction(pAccion), pdsParam) {
     }

     public stkConsStockDetalleActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkConsStockDetalleDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkConsStockDetalleDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkConsStockDetalleDS)mParam;
	        }
     }
  }
}
