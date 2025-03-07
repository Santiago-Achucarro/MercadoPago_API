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
    public class sueVezActivaActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quin {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Quin"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Quin;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Quin = value;
               }
	          }
        public bool IsQuinNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsQuinNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVezActivaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVezActivaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVezActivaDS );
     }
     public sueVezActivaActionExchange() : base( "sueVezActiva" ) {
     }

     public sueVezActivaActionExchange(sueVezActivaActionEnum.EnumsueVezActivaAction pAccion) : base(sueVezActivaActionEnum.GetAccionsueVezActivaAction(pAccion)) {
     }

     public sueVezActivaActionExchange(sueVezActivaActionEnum.EnumsueVezActivaAction pAccion, SueldosCommon.sueVezActivaDS pdsParam) : base(sueVezActivaActionEnum.GetAccionsueVezActivaAction(pAccion), pdsParam) {
     }

     public sueVezActivaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVezActivaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVezActivaDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVezActivaDS)mParam;
	        }
     }
  }
}
