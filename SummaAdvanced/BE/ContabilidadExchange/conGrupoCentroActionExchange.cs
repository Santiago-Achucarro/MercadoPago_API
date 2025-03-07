using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conGrupoCentroActionExchange : Framework.Core.Exchange{

        public Int32 conGruposCont {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["conGruposCont"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].conGruposCont;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].conGruposCont = value;
               }
	          }
        public bool IsconGruposContNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsconGruposContNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionconCentro1 {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["DescripcionconCentro1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].DescripcionconCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].DescripcionconCentro1 = value;
               }
	          }
        public bool IsDescripcionconCentro1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsDescripcionconCentro1Null();
             }
	        }
        public String DescripcionconCentro2 {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["DescripcionconCentro2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].DescripcionconCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].DescripcionconCentro2 = value;
               }
	          }
        public bool IsDescripcionconCentro2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsDescripcionconCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGrupoCentroDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conGrupoCentroDS );
     }
     public conGrupoCentroActionExchange() : base( "conGrupoCentro" ) {
     }

     public conGrupoCentroActionExchange(conGrupoCentroActionEnum.EnumconGrupoCentroAction pAccion) : base(conGrupoCentroActionEnum.GetAccionconGrupoCentroAction(pAccion)) {
     }

     public conGrupoCentroActionExchange(conGrupoCentroActionEnum.EnumconGrupoCentroAction pAccion, ContabilidadCommon.conGrupoCentroDS pdsParam) : base(conGrupoCentroActionEnum.GetAccionconGrupoCentroAction(pAccion), pdsParam) {
     }

     public conGrupoCentroActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conGrupoCentroDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conGrupoCentroDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conGrupoCentroDS)mParam;
	        }
     }
  }
}
