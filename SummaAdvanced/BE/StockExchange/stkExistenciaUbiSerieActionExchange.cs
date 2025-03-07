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
    public class stkExistenciaUbiSerieActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public DateTime Vencimiento {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Vencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Vencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Vencimiento = value;
               }
	          }
        public bool IsVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsVencimientoNull();
             }
	        }
        public String Ubicacion_Id {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Ubicacion_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Ubicacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Ubicacion_Id = value;
               }
	          }
        public bool IsUbicacion_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsUbicacion_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaUbiSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaUbiSerieDS );
     }
     public stkExistenciaUbiSerieActionExchange() : base( "stkExistenciaUbiSerie" ) {
     }

     public stkExistenciaUbiSerieActionExchange(stkExistenciaUbiSerieActionEnum.EnumstkExistenciaUbiSerieAction pAccion) : base(stkExistenciaUbiSerieActionEnum.GetAccionstkExistenciaUbiSerieAction(pAccion)) {
     }

     public stkExistenciaUbiSerieActionExchange(stkExistenciaUbiSerieActionEnum.EnumstkExistenciaUbiSerieAction pAccion, StockCommon.stkExistenciaUbiSerieDS pdsParam) : base(stkExistenciaUbiSerieActionEnum.GetAccionstkExistenciaUbiSerieAction(pAccion), pdsParam) {
     }

     public stkExistenciaUbiSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaUbiSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaUbiSerieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaUbiSerieDS)mParam;
	        }
     }
  }
}
