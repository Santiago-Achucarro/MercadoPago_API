using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueLegajoFamiliaresActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String ApellidoPaterno {
            get {
                if(((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0]["ApellidoPaterno"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].ApellidoPaterno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].ApellidoPaterno = value;
               }
	          }
        public bool IsApellidoPaternoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].IsApellidoPaternoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLegajoFamiliaresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLegajoFamiliaresDS );
     }
     public sueLegajoFamiliaresActionExchange() : base( "sueLegajoFamiliares" ) {
     }

     public sueLegajoFamiliaresActionExchange(sueLegajoFamiliaresActionEnum.EnumsueLegajoFamiliaresAction pAccion) : base(sueLegajoFamiliaresActionEnum.GetAccionsueLegajoFamiliaresAction(pAccion)) {
     }

     public sueLegajoFamiliaresActionExchange(sueLegajoFamiliaresActionEnum.EnumsueLegajoFamiliaresAction pAccion, SueldosCommon.sueLegajoFamiliaresDS pdsParam) : base(sueLegajoFamiliaresActionEnum.GetAccionsueLegajoFamiliaresAction(pAccion), pdsParam) {
     }

     public sueLegajoFamiliaresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLegajoFamiliaresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLegajoFamiliaresDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLegajoFamiliaresDS)mParam;
	        }
     }
  }
}
