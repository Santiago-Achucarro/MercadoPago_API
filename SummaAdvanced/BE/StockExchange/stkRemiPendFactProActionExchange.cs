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
    public class stkRemiPendFactProActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkRemiPendFactProDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkRemiPendFactProDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Decimal CantidadPendiente {
            get {
                if(((StockCommon.stkRemiPendFactProDS)mParam).Principal[0]["CantidadPendiente"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].CantidadPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].CantidadPendiente = value;
               }
	          }
        public bool IsCantidadPendienteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].IsCantidadPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemiPendFactProDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactProDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemiPendFactProDS );
     }
     public stkRemiPendFactProActionExchange() : base( "stkRemiPendFactPro" ) {
     }

     public stkRemiPendFactProActionExchange(stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction pAccion) : base(stkRemiPendFactProActionEnum.GetAccionstkRemiPendFactProAction(pAccion)) {
     }

     public stkRemiPendFactProActionExchange(stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction pAccion, StockCommon.stkRemiPendFactProDS pdsParam) : base(stkRemiPendFactProActionEnum.GetAccionstkRemiPendFactProAction(pAccion), pdsParam) {
     }

     public stkRemiPendFactProActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemiPendFactProDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemiPendFactProDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemiPendFactProDS)mParam;
	        }
     }
  }
}
