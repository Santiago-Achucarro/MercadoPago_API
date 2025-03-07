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
    public class stkArtiUMActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public String CodigoBarra {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["CodigoBarra"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].CodigoBarra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].CodigoBarra = value;
               }
	          }
        public bool IsCodigoBarraNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsCodigoBarraNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkArtiUMDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkArtiUMDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkArtiUMDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkArtiUMDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkArtiUMDS );
     }
     public stkArtiUMActionExchange() : base( "stkArtiUM" ) {
     }

     public stkArtiUMActionExchange(stkArtiUMActionEnum.EnumstkArtiUMAction pAccion) : base(stkArtiUMActionEnum.GetAccionstkArtiUMAction(pAccion)) {
     }

     public stkArtiUMActionExchange(stkArtiUMActionEnum.EnumstkArtiUMAction pAccion, StockCommon.stkArtiUMDS pdsParam) : base(stkArtiUMActionEnum.GetAccionstkArtiUMAction(pAccion), pdsParam) {
     }

     public stkArtiUMActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkArtiUMDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkArtiUMDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkArtiUMDS)mParam;
	        }
     }
  }
}
