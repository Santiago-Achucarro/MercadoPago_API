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
    public class stkSubTipoMovActionExchange : Framework.Core.Exchange{

        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Consumo {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["Consumo"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Consumo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Consumo = value;
               }
	          }
        public bool IsConsumoNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsConsumoNull();
             }
	        }
        public Int16 CantCopias {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["CantCopias"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].CantCopias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].CantCopias = value;
               }
	          }
        public bool IsCantCopiasNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsCantCopiasNull();
             }
	        }
        public String TipoMov {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String DescripcionTiposMov {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["DescripcionTiposMov"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].DescripcionTiposMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].DescripcionTiposMov = value;
               }
	          }
        public bool IsDescripcionTiposMovNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsDescripcionTiposMovNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String DescripcionReporte {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["DescripcionReporte"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].DescripcionReporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].DescripcionReporte = value;
               }
	          }
        public bool IsDescripcionReporteNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsDescripcionReporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkSubTipoMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkSubTipoMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkSubTipoMovDS );
     }
     public stkSubTipoMovActionExchange() : base( "stkSubTipoMov" ) {
     }

     public stkSubTipoMovActionExchange(stkSubTipoMovActionEnum.EnumstkSubTipoMovAction pAccion) : base(stkSubTipoMovActionEnum.GetAccionstkSubTipoMovAction(pAccion)) {
     }

     public stkSubTipoMovActionExchange(stkSubTipoMovActionEnum.EnumstkSubTipoMovAction pAccion, StockCommon.stkSubTipoMovDS pdsParam) : base(stkSubTipoMovActionEnum.GetAccionstkSubTipoMovAction(pAccion), pdsParam) {
     }

     public stkSubTipoMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkSubTipoMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkSubTipoMovDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkSubTipoMovDS)mParam;
	        }
     }
  }
}
