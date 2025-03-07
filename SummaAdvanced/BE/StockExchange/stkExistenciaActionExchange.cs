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
    public class stkExistenciaActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadReservada {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["CantidadReservada"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].CantidadReservada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].CantidadReservada = value;
               }
	          }
        public bool IsCantidadReservadaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsCantidadReservadaNull();
             }
	        }
        public Decimal CantidadAlterna {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["CantidadAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].CantidadAlterna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].CantidadAlterna = value;
               }
	          }
        public bool IsCantidadAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsCantidadAlternaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaDS );
     }
     public stkExistenciaActionExchange() : base( "stkExistencia" ) {
     }

     public stkExistenciaActionExchange(stkExistenciaActionEnum.EnumstkExistenciaAction pAccion) : base(stkExistenciaActionEnum.GetAccionstkExistenciaAction(pAccion)) {
     }

     public stkExistenciaActionExchange(stkExistenciaActionEnum.EnumstkExistenciaAction pAccion, StockCommon.stkExistenciaDS pdsParam) : base(stkExistenciaActionEnum.GetAccionstkExistenciaAction(pAccion), pdsParam) {
     }

     public stkExistenciaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaDS)mParam;
	        }
     }
  }
}
