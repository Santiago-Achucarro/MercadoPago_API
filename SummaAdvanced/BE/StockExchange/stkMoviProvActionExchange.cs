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
    public class stkMoviProvActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedores {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["DescripcionProveedores"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].DescripcionProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].DescripcionProveedores = value;
               }
	          }
        public bool IsDescripcionProveedoresNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsDescripcionProveedoresNull();
             }
	        }
        public String RemitoProv {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["RemitoProv"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].RemitoProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].RemitoProv = value;
               }
	          }
        public bool IsRemitoProvNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsRemitoProvNull();
             }
	        }
        public DateTime FechaRemito {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["FechaRemito"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].FechaRemito;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].FechaRemito = value;
               }
	          }
        public bool IsFechaRemitoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsFechaRemitoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviProvDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviProvDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviProvDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviProvDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviProvDS );
     }
     public stkMoviProvActionExchange() : base( "stkMoviProv" ) {
     }

     public stkMoviProvActionExchange(stkMoviProvActionEnum.EnumstkMoviProvAction pAccion) : base(stkMoviProvActionEnum.GetAccionstkMoviProvAction(pAccion)) {
     }

     public stkMoviProvActionExchange(stkMoviProvActionEnum.EnumstkMoviProvAction pAccion, StockCommon.stkMoviProvDS pdsParam) : base(stkMoviProvActionEnum.GetAccionstkMoviProvAction(pAccion), pdsParam) {
     }

     public stkMoviProvActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviProvDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviProvDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviProvDS)mParam;
	        }
     }
  }
}
