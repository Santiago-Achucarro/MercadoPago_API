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
    public class proOrdenStockCostoActionExchange : Framework.Core.Exchange{

        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal PorcentajeCosto {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["PorcentajeCosto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].PorcentajeCosto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].PorcentajeCosto = value;
               }
	          }
        public bool IsPorcentajeCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsPorcentajeCostoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockCostoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenStockCostoDS );
     }
     public proOrdenStockCostoActionExchange() : base( "proOrdenStockCosto" ) {
     }

     public proOrdenStockCostoActionExchange(proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction pAccion) : base(proOrdenStockCostoActionEnum.GetAccionproOrdenStockCostoAction(pAccion)) {
     }

     public proOrdenStockCostoActionExchange(proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction pAccion, ProduccionCommon.proOrdenStockCostoDS pdsParam) : base(proOrdenStockCostoActionEnum.GetAccionproOrdenStockCostoAction(pAccion), pdsParam) {
     }

     public proOrdenStockCostoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenStockCostoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenStockCostoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenStockCostoDS)mParam;
	        }
     }
  }
}
