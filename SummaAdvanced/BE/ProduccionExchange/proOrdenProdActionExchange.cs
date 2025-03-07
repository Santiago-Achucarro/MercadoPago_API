using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proOrdenProdActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String EntradaSalida {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["EntradaSalida"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].EntradaSalida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].EntradaSalida = value;
               }
	          }
        public bool IsEntradaSalidaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsEntradaSalidaNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionMedida {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["DescripcionMedida"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionMedida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionMedida = value;
               }
	          }
        public bool IsDescripcionMedidaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsDescripcionMedidaNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal PorcentajeCosto {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["PorcentajeCosto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].PorcentajeCosto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].PorcentajeCosto = value;
               }
	          }
        public bool IsPorcentajeCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsPorcentajeCostoNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Boolean TomaDepoT3 {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["TomaDepoT3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].TomaDepoT3;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].TomaDepoT3 = value;
               }
	          }
        public bool IsTomaDepoT3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsTomaDepoT3Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenProdDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenProdDS );
     }
     public proOrdenProdActionExchange() : base( "proOrdenProd" ) {
     }

     public proOrdenProdActionExchange(proOrdenProdActionEnum.EnumproOrdenProdAction pAccion) : base(proOrdenProdActionEnum.GetAccionproOrdenProdAction(pAccion)) {
     }

     public proOrdenProdActionExchange(proOrdenProdActionEnum.EnumproOrdenProdAction pAccion, ProduccionCommon.proOrdenProdDS pdsParam) : base(proOrdenProdActionEnum.GetAccionproOrdenProdAction(pAccion), pdsParam) {
     }

     public proOrdenProdActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenProdDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenProdDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenProdDS)mParam;
	        }
     }
  }
}
