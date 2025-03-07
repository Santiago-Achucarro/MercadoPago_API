using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proOrdenProdSerieActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        
        public String Serie {
            get {
                if(((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenProdSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenProdSerieDS );
     }
     public proOrdenProdSerieActionExchange() : base( "proOrdenProdSerie" ) {
     }

     public proOrdenProdSerieActionExchange(proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction pAccion) : base(proOrdenProdSerieActionEnum.GetAccionproOrdenProdSerieAction(pAccion)) {
     }

     public proOrdenProdSerieActionExchange(proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction pAccion, ProduccionCommon.proOrdenProdSerieDS pdsParam) : base(proOrdenProdSerieActionEnum.GetAccionproOrdenProdSerieAction(pAccion), pdsParam) {
     }

     public proOrdenProdSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenProdSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenProdSerieDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenProdSerieDS)mParam;
	        }
     }
  }
}
