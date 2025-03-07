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
    public class stkMoviDespaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviDespaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviDespaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviDespaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviDespaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviDespaDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviDespaDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((StockCommon.stkMoviDespaDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviDespaDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviDespaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviDespaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviDespaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviDespaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviDespaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviDespaDS );
     }
     public stkMoviDespaActionExchange() : base( "stkMoviDespa" ) {
     }

     public stkMoviDespaActionExchange(stkMoviDespaActionEnum.EnumstkMoviDespaAction pAccion) : base(stkMoviDespaActionEnum.GetAccionstkMoviDespaAction(pAccion)) {
     }

     public stkMoviDespaActionExchange(stkMoviDespaActionEnum.EnumstkMoviDespaAction pAccion, StockCommon.stkMoviDespaDS pdsParam) : base(stkMoviDespaActionEnum.GetAccionstkMoviDespaAction(pAccion), pdsParam) {
     }

     public stkMoviDespaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviDespaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviDespaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviDespaDS)mParam;
	        }
     }
  }
}
