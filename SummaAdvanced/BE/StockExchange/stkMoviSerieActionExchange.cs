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
    public class stkMoviSerieActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public DateTime Vencimiento {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["Vencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Vencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Vencimiento = value;
               }
	          }
        public bool IsVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsVencimientoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviSerieDS );
     }
     public stkMoviSerieActionExchange() : base( "stkMoviSerie" ) {
     }

     public stkMoviSerieActionExchange(stkMoviSerieActionEnum.EnumstkMoviSerieAction pAccion) : base(stkMoviSerieActionEnum.GetAccionstkMoviSerieAction(pAccion)) {
     }

     public stkMoviSerieActionExchange(stkMoviSerieActionEnum.EnumstkMoviSerieAction pAccion, StockCommon.stkMoviSerieDS pdsParam) : base(stkMoviSerieActionEnum.GetAccionstkMoviSerieAction(pAccion), pdsParam) {
     }

     public stkMoviSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviSerieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviSerieDS)mParam;
	        }
     }
  }
}
