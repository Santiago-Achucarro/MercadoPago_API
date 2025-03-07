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
    public class stkExistenciaXSerieXUbiActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String TipoSerieUni {
            get {
                if(((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0]["TipoSerieUni"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].TipoSerieUni;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].TipoSerieUni = value;
               }
	          }
        public bool IsTipoSerieUniNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].IsTipoSerieUniNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaXSerieXUbiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaXSerieXUbiDS );
     }
     public stkExistenciaXSerieXUbiActionExchange() : base( "stkExistenciaXSerieXUbi" ) {
     }

     public stkExistenciaXSerieXUbiActionExchange(stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction pAccion) : base(stkExistenciaXSerieXUbiActionEnum.GetAccionstkExistenciaXSerieXUbiAction(pAccion)) {
     }

     public stkExistenciaXSerieXUbiActionExchange(stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction pAccion, StockCommon.stkExistenciaXSerieXUbiDS pdsParam) : base(stkExistenciaXSerieXUbiActionEnum.GetAccionstkExistenciaXSerieXUbiAction(pAccion), pdsParam) {
     }

     public stkExistenciaXSerieXUbiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaXSerieXUbiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkExistenciaXSerieXUbiActionExchange(StockCommon.stkExistenciaXSerieXUbiDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkExistenciaXSerieXUbiDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaXSerieXUbiDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaXSerieXUbiDS)mParam;
	        }
     }
  }
}
