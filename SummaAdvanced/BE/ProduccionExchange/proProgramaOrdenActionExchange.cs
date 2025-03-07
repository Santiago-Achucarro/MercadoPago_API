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
    public class proProgramaOrdenActionExchange : Framework.Core.Exchange{

        public Int32 proProgramas {
            get {
                if(((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0]["proProgramas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].proProgramas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].proProgramas = value;
               }
	          }
        public bool IsproProgramasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].IsproProgramasNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaOrdenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramaOrdenDS );
     }
     public proProgramaOrdenActionExchange() : base( "proProgramaOrden" ) {
     }

     public proProgramaOrdenActionExchange(proProgramaOrdenActionEnum.EnumproProgramaOrdenAction pAccion) : base(proProgramaOrdenActionEnum.GetAccionproProgramaOrdenAction(pAccion)) {
     }

     public proProgramaOrdenActionExchange(proProgramaOrdenActionEnum.EnumproProgramaOrdenAction pAccion, ProduccionCommon.proProgramaOrdenDS pdsParam) : base(proProgramaOrdenActionEnum.GetAccionproProgramaOrdenAction(pAccion), pdsParam) {
     }

     public proProgramaOrdenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramaOrdenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramaOrdenDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramaOrdenDS)mParam;
	        }
     }
  }
}
