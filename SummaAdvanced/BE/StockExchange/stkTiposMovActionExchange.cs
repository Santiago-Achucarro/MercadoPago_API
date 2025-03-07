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
    public class stkTiposMovActionExchange : Framework.Core.Exchange{

        public String TipoMov {
            get {
                if(((StockCommon.stkTiposMovDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((StockCommon.stkTiposMovDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkTiposMovDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((StockCommon.stkTiposMovDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkTiposMovDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkTiposMovDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkTiposMovDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkTiposMovDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((StockCommon.stkTiposMovDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((StockCommon.stkTiposMovDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkTiposMovDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((StockCommon.stkTiposMovDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkTiposMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkTiposMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkTiposMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkTiposMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkTiposMovDS );
     }
     public stkTiposMovActionExchange() : base( "stkTiposMov" ) {
     }

     public stkTiposMovActionExchange(stkTiposMovActionEnum.EnumstkTiposMovAction pAccion) : base(stkTiposMovActionEnum.GetAccionstkTiposMovAction(pAccion)) {
     }

     public stkTiposMovActionExchange(stkTiposMovActionEnum.EnumstkTiposMovAction pAccion, StockCommon.stkTiposMovDS pdsParam) : base(stkTiposMovActionEnum.GetAccionstkTiposMovAction(pAccion), pdsParam) {
     }

     public stkTiposMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkTiposMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkTiposMovDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkTiposMovDS)mParam;
	        }
     }
  }
}
