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
    public class stkExistenciaDespaActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaDespaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaDespaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaDespaDS );
     }
     public stkExistenciaDespaActionExchange() : base( "stkExistenciaDespa" ) {
     }

     public stkExistenciaDespaActionExchange(stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction pAccion) : base(stkExistenciaDespaActionEnum.GetAccionstkExistenciaDespaAction(pAccion)) {
     }

     public stkExistenciaDespaActionExchange(stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction pAccion, StockCommon.stkExistenciaDespaDS pdsParam) : base(stkExistenciaDespaActionEnum.GetAccionstkExistenciaDespaAction(pAccion), pdsParam) {
     }

     public stkExistenciaDespaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaDespaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaDespaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaDespaDS)mParam;
	        }
     }
  }
}
