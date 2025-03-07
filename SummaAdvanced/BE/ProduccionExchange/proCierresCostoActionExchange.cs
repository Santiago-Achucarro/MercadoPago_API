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
    public class proCierresCostoActionExchange : Framework.Core.Exchange{

        public Int64 stkMovicabe {
            get {
                if(((ProduccionCommon.proCierresCostoDS)mParam).Principal[0]["stkMovicabe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].stkMovicabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].stkMovicabe = value;
               }
	          }
        public bool IsstkMovicabeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].IsstkMovicabeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proCierresCostoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCierresCostoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proCierresCostoDS );
     }
     public proCierresCostoActionExchange() : base( "proCierresCosto" ) {
     }

     public proCierresCostoActionExchange(proCierresCostoActionEnum.EnumproCierresCostoAction pAccion) : base(proCierresCostoActionEnum.GetAccionproCierresCostoAction(pAccion)) {
     }

     public proCierresCostoActionExchange(proCierresCostoActionEnum.EnumproCierresCostoAction pAccion, ProduccionCommon.proCierresCostoDS pdsParam) : base(proCierresCostoActionEnum.GetAccionproCierresCostoAction(pAccion), pdsParam) {
     }

     public proCierresCostoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proCierresCostoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proCierresCostoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proCierresCostoDS)mParam;
	        }
     }
  }
}
