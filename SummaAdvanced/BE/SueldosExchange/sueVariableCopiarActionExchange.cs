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
    public class sueVariableCopiarActionExchange : Framework.Core.Exchange{

        public Int32 Legajo_Origen {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Legajo_Origen"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Origen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Origen = value;
               }
	          }
        public bool IsLegajo_OrigenNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsLegajo_OrigenNull();
             }
	        }
        public Int32 Legajo_Desde {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Legajo_Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Desde = value;
               }
	          }
        public bool IsLegajo_DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsLegajo_DesdeNull();
             }
	        }
        public Int32 Legajo_Hasta {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Legajo_Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Legajo_Hasta = value;
               }
	          }
        public bool IsLegajo_HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsLegajo_HastaNull();
             }
	        }
        public Int32 Concepto_Desde {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Concepto_Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Concepto_Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Concepto_Desde = value;
               }
	          }
        public bool IsConcepto_DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsConcepto_DesdeNull();
             }
	        }
        public Int32 Concepto_Hasta {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Concepto_Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Concepto_Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Concepto_Hasta = value;
               }
	          }
        public bool IsConcepto_HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsConcepto_HastaNull();
             }
	        }
        public Int32 Grupo_Desde {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Grupo_Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Grupo_Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Grupo_Desde = value;
               }
	          }
        public bool IsGrupo_DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsGrupo_DesdeNull();
             }
	        }
        public Int32 Grupo_Hasta {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Grupo_Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Grupo_Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Grupo_Hasta = value;
               }
	          }
        public bool IsGrupo_HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsGrupo_HastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableCopiarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVariableCopiarDS );
     }
     public sueVariableCopiarActionExchange() : base( "sueVariableCopiar" ) {
     }

     public sueVariableCopiarActionExchange(sueVariableCopiarActionEnum.EnumsueVariableCopiarAction pAccion) : base(sueVariableCopiarActionEnum.GetAccionsueVariableCopiarAction(pAccion)) {
     }

     public sueVariableCopiarActionExchange(sueVariableCopiarActionEnum.EnumsueVariableCopiarAction pAccion, SueldosCommon.sueVariableCopiarDS pdsParam) : base(sueVariableCopiarActionEnum.GetAccionsueVariableCopiarAction(pAccion), pdsParam) {
     }

     public sueVariableCopiarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVariableCopiarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVariableCopiarDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVariableCopiarDS)mParam;
	        }
     }
  }
}
