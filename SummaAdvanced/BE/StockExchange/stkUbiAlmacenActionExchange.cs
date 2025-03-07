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
    public class stkUbiAlmacenActionExchange : Framework.Core.Exchange{

        public String Deposito_Id {
            get {
                if(((StockCommon.stkUbiAlmacenDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkUbiAlmacenDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String ParaPegar {
            get {
                if(((StockCommon.stkUbiAlmacenDS)mParam).Principal[0]["ParaPegar"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].ParaPegar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].ParaPegar = value;
               }
	          }
        public bool IsParaPegarNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].IsParaPegarNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkUbiAlmacenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkUbiAlmacenDS );
     }
     public stkUbiAlmacenActionExchange() : base( "stkUbiAlmacen" ) {
     }

     public stkUbiAlmacenActionExchange(stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction pAccion) : base(stkUbiAlmacenActionEnum.GetAccionstkUbiAlmacenAction(pAccion)) {
     }

     public stkUbiAlmacenActionExchange(stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction pAccion, StockCommon.stkUbiAlmacenDS pdsParam) : base(stkUbiAlmacenActionEnum.GetAccionstkUbiAlmacenAction(pAccion), pdsParam) {
     }

     public stkUbiAlmacenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkUbiAlmacenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkUbiAlmacenActionExchange(StockCommon.stkUbiAlmacenDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkUbiAlmacenDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkUbiAlmacenDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkUbiAlmacenDS)mParam;
	        }
     }
  }
}
