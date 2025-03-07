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
    public class espPVAutorizarPendientesKSKActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espPVAutorizarPendientesKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espPVAutorizarPendientesKSKDS );
     }
     public espPVAutorizarPendientesKSKActionExchange() : base( "espPVAutorizarPendientesKSK" ) {
     }

     public espPVAutorizarPendientesKSKActionExchange(espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction pAccion) : base(espPVAutorizarPendientesKSKActionEnum.GetAccionespPVAutorizarPendientesKSKAction(pAccion)) {
     }

     public espPVAutorizarPendientesKSKActionExchange(espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction pAccion, KSKCommon.espPVAutorizarPendientesKSKDS pdsParam) : base(espPVAutorizarPendientesKSKActionEnum.GetAccionespPVAutorizarPendientesKSKAction(pAccion), pdsParam) {
     }

     public espPVAutorizarPendientesKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espPVAutorizarPendientesKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espPVAutorizarPendientesKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espPVAutorizarPendientesKSKDS)mParam;
	        }
     }
  }
}
