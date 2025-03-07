using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espvenComandasDatosKSKActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenComandasDatosKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espvenComandasDatosKSKDS );
     }
     public espvenComandasDatosKSKActionExchange() : base( "espvenComandasDatosKSK" ) {
     }

     public espvenComandasDatosKSKActionExchange(espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction pAccion) : base(espvenComandasDatosKSKActionEnum.GetAccionespvenComandasDatosKSKAction(pAccion)) {
     }

     public espvenComandasDatosKSKActionExchange(espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction pAccion, KSKCommon.espvenComandasDatosKSKDS pdsParam) : base(espvenComandasDatosKSKActionEnum.GetAccionespvenComandasDatosKSKAction(pAccion), pdsParam) {
     }

     public espvenComandasDatosKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espvenComandasDatosKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public espvenComandasDatosKSKActionExchange(KSKCommon.espvenComandasDatosKSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.espvenComandasDatosKSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espvenComandasDatosKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espvenComandasDatosKSKDS)mParam;
	        }
     }
  }
}
