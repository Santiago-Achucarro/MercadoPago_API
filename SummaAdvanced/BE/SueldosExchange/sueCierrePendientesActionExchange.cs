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
    public class sueCierrePendientesActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public DateTime ProximoCierre_Nueva {
            get {
                if(((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0]["ProximoCierre_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].ProximoCierre_Nueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].ProximoCierre_Nueva = value;
               }
	          }
        public bool IsProximoCierre_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].IsProximoCierre_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierrePendientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueCierrePendientesDS );
     }
     public sueCierrePendientesActionExchange() : base( "sueCierrePendientes" ) {
     }

     public sueCierrePendientesActionExchange(sueCierrePendientesActionEnum.EnumsueCierrePendientesAction pAccion) : base(sueCierrePendientesActionEnum.GetAccionsueCierrePendientesAction(pAccion)) {
     }

     public sueCierrePendientesActionExchange(sueCierrePendientesActionEnum.EnumsueCierrePendientesAction pAccion, SueldosCommon.sueCierrePendientesDS pdsParam) : base(sueCierrePendientesActionEnum.GetAccionsueCierrePendientesAction(pAccion), pdsParam) {
     }

     public sueCierrePendientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueCierrePendientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueCierrePendientesDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueCierrePendientesDS)mParam;
	        }
     }
  }
}
