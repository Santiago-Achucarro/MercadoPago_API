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
    public class stkEntradasCancRemiActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabeEntrada {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["stkMoviCabeEntrada"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].stkMoviCabeEntrada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].stkMoviCabeEntrada = value;
               }
	          }
        public bool IsstkMoviCabeEntradaNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsstkMoviCabeEntradaNull();
             }
	        }
        public Int32 RenglonEntrada {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["RenglonEntrada"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].RenglonEntrada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].RenglonEntrada = value;
               }
	          }
        public bool IsRenglonEntradaNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsRenglonEntradaNull();
             }
	        }
        public Int64 stkMoviCabeRemi {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["stkMoviCabeRemi"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].stkMoviCabeRemi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].stkMoviCabeRemi = value;
               }
	          }
        public bool IsstkMoviCabeRemiNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsstkMoviCabeRemiNull();
             }
	        }
        public Int32 RenglonRemi {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["RenglonRemi"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].RenglonRemi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].RenglonRemi = value;
               }
	          }
        public bool IsRenglonRemiNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsRenglonRemiNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasCancRemiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkEntradasCancRemiDS );
     }
     public stkEntradasCancRemiActionExchange() : base( "stkEntradasCancRemi" ) {
     }

     public stkEntradasCancRemiActionExchange(stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction pAccion) : base(stkEntradasCancRemiActionEnum.GetAccionstkEntradasCancRemiAction(pAccion)) {
     }

     public stkEntradasCancRemiActionExchange(stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction pAccion, StockCommon.stkEntradasCancRemiDS pdsParam) : base(stkEntradasCancRemiActionEnum.GetAccionstkEntradasCancRemiAction(pAccion), pdsParam) {
     }

     public stkEntradasCancRemiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkEntradasCancRemiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkEntradasCancRemiDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkEntradasCancRemiDS)mParam;
	        }
     }
  }
}
