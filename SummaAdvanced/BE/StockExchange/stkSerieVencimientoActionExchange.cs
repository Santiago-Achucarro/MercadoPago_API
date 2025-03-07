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
    public class stkSerieVencimientoActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkSerieVencimientoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkSerieVencimientoDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public DateTime Vencimiento {
            get {
                if(((StockCommon.stkSerieVencimientoDS)mParam).Principal[0]["Vencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Vencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Vencimiento = value;
               }
	          }
        public bool IsVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].IsVencimientoNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkSerieVencimientoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkSerieVencimientoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkSerieVencimientoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkSerieVencimientoDS );
     }
     public stkSerieVencimientoActionExchange() : base( "stkSerieVencimiento" ) {
     }

     public stkSerieVencimientoActionExchange(stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction pAccion) : base(stkSerieVencimientoActionEnum.GetAccionstkSerieVencimientoAction(pAccion)) {
     }

     public stkSerieVencimientoActionExchange(stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction pAccion, StockCommon.stkSerieVencimientoDS pdsParam) : base(stkSerieVencimientoActionEnum.GetAccionstkSerieVencimientoAction(pAccion), pdsParam) {
     }

     public stkSerieVencimientoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkSerieVencimientoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkSerieVencimientoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkSerieVencimientoDS)mParam;
	        }
     }
  }
}
