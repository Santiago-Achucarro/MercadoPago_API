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
    public class stkExistenciaSerieActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaSerieDS );
     }
     public stkExistenciaSerieActionExchange() : base( "stkExistenciaSerie" ) {
     }

     public stkExistenciaSerieActionExchange(stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction pAccion) : base(stkExistenciaSerieActionEnum.GetAccionstkExistenciaSerieAction(pAccion)) {
     }

     public stkExistenciaSerieActionExchange(stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction pAccion, StockCommon.stkExistenciaSerieDS pdsParam) : base(stkExistenciaSerieActionEnum.GetAccionstkExistenciaSerieAction(pAccion), pdsParam) {
     }

     public stkExistenciaSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaSerieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaSerieDS)mParam;
	        }
     }
  }
}
