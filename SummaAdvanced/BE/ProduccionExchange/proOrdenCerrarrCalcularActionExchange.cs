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
    public class proOrdenCerrarrCalcularActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrCalcularDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenCerrarrCalcularDS );
     }
     public proOrdenCerrarrCalcularActionExchange() : base( "proOrdenCerrarrCalcular" ) {
     }

     public proOrdenCerrarrCalcularActionExchange(proOrdenCerrarrCalcularActionEnum.EnumproOrdenCerrarrCalcularAction pAccion) : base(proOrdenCerrarrCalcularActionEnum.GetAccionproOrdenCerrarrCalcularAction(pAccion)) {
     }

     public proOrdenCerrarrCalcularActionExchange(proOrdenCerrarrCalcularActionEnum.EnumproOrdenCerrarrCalcularAction pAccion, ProduccionCommon.proOrdenCerrarrCalcularDS pdsParam) : base(proOrdenCerrarrCalcularActionEnum.GetAccionproOrdenCerrarrCalcularAction(pAccion), pdsParam) {
     }

     public proOrdenCerrarrCalcularActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenCerrarrCalcularDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenCerrarrCalcularDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenCerrarrCalcularDS)mParam;
	        }
     }
  }
}
