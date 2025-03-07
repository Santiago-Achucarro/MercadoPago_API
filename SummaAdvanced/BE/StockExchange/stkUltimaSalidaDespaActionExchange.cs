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
    public class stkUltimaSalidaDespaActionExchange : Framework.Core.Exchange{

        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkUltimaSalidaDespaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkUltimaSalidaDespaDS );
     }
     public stkUltimaSalidaDespaActionExchange() : base( "stkUltimaSalidaDespa" ) {
     }

     public stkUltimaSalidaDespaActionExchange(stkUltimaSalidaDespaActionEnum.EnumstkUltimaSalidaDespaAction pAccion) : base(stkUltimaSalidaDespaActionEnum.GetAccionstkUltimaSalidaDespaAction(pAccion)) {
     }

     public stkUltimaSalidaDespaActionExchange(stkUltimaSalidaDespaActionEnum.EnumstkUltimaSalidaDespaAction pAccion, StockCommon.stkUltimaSalidaDespaDS pdsParam) : base(stkUltimaSalidaDespaActionEnum.GetAccionstkUltimaSalidaDespaAction(pAccion), pdsParam) {
     }

     public stkUltimaSalidaDespaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkUltimaSalidaDespaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkUltimaSalidaDespaActionExchange(StockCommon.stkUltimaSalidaDespaDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkUltimaSalidaDespaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkUltimaSalidaDespaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkUltimaSalidaDespaDS)mParam;
	        }
     }
  }
}
