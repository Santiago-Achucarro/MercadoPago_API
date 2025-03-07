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
    public class sueVariablesMasivoActionExchange : Framework.Core.Exchange{

        public Int32 Legajo_Desde {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Legajo_Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Legajo_Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Legajo_Desde = value;
               }
	          }
        public bool IsLegajo_DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsLegajo_DesdeNull();
             }
	        }
        public Int32 Legajo_Hasta {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Legajo_Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Legajo_Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Legajo_Hasta = value;
               }
	          }
        public bool IsLegajo_HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsLegajo_HastaNull();
             }
	        }
        public Int32 Concepto_Desde {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Concepto_Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Concepto_Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Concepto_Desde = value;
               }
	          }
        public bool IsConcepto_DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsConcepto_DesdeNull();
             }
	        }
        public Int32 Concepto_Hasta {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Concepto_Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Concepto_Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Concepto_Hasta = value;
               }
	          }
        public bool IsConcepto_HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsConcepto_HastaNull();
             }
	        }
        public Int32 Grupo_Fuente {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Grupo_Fuente"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Grupo_Fuente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Grupo_Fuente = value;
               }
	          }
        public bool IsGrupo_FuenteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsGrupo_FuenteNull();
             }
	        }
        public Int32 Grupo_Destino {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Grupo_Destino"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Grupo_Destino;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Grupo_Destino = value;
               }
	          }
        public bool IsGrupo_DestinoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsGrupo_DestinoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariablesMasivoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVariablesMasivoDS );
     }
     public sueVariablesMasivoActionExchange() : base( "sueVariablesMasivo" ) {
     }

     public sueVariablesMasivoActionExchange(sueVariablesMasivoActionEnum.EnumsueVariablesMasivoAction pAccion) : base(sueVariablesMasivoActionEnum.GetAccionsueVariablesMasivoAction(pAccion)) {
     }

     public sueVariablesMasivoActionExchange(sueVariablesMasivoActionEnum.EnumsueVariablesMasivoAction pAccion, SueldosCommon.sueVariablesMasivoDS pdsParam) : base(sueVariablesMasivoActionEnum.GetAccionsueVariablesMasivoAction(pAccion), pdsParam) {
     }

     public sueVariablesMasivoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVariablesMasivoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVariablesMasivoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVariablesMasivoDS)mParam;
	        }
     }
  }
}
