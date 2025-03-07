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
    public class stkExistenciaDespaXFifoActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaXFifoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaDespaXFifoDS );
     }
     public stkExistenciaDespaXFifoActionExchange() : base( "stkExistenciaDespaXFifo" ) {
     }

     public stkExistenciaDespaXFifoActionExchange(stkExistenciaDespaXFifoActionEnum.EnumstkExistenciaDespaXFifoAction pAccion) : base(stkExistenciaDespaXFifoActionEnum.GetAccionstkExistenciaDespaXFifoAction(pAccion)) {
     }

     public stkExistenciaDespaXFifoActionExchange(stkExistenciaDespaXFifoActionEnum.EnumstkExistenciaDespaXFifoAction pAccion, StockCommon.stkExistenciaDespaXFifoDS pdsParam) : base(stkExistenciaDespaXFifoActionEnum.GetAccionstkExistenciaDespaXFifoAction(pAccion), pdsParam) {
     }

     public stkExistenciaDespaXFifoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaDespaXFifoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaDespaXFifoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaDespaXFifoDS)mParam;
	        }
     }
  }
}
