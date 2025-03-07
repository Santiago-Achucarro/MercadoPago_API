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
    public class sueGruposActionExchange : Framework.Core.Exchange{

        public Int32 sueGrupos {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["sueGrupos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].sueGrupos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].sueGrupos = value;
               }
	          }
        public bool IssueGruposNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IssueGruposNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Grupo_Id_Nueva {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Grupo_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Grupo_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Grupo_Id_Nueva = value;
               }
	          }
        public bool IsGrupo_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsGrupo_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String DescripcionSegmento {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["DescripcionSegmento"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionSegmento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionSegmento = value;
               }
	          }
        public bool IsDescripcionSegmentoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsDescripcionSegmentoNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String DescripcionPeriodo {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["DescripcionPeriodo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionPeriodo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionPeriodo = value;
               }
	          }
        public bool IsDescripcionPeriodoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsDescripcionPeriodoNull();
             }
	        }
        public String CtaSueldoAPagar {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["CtaSueldoAPagar"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].CtaSueldoAPagar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].CtaSueldoAPagar = value;
               }
	          }
        public bool IsCtaSueldoAPagarNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsCtaSueldoAPagarNull();
             }
	        }
        public String DescripcionCtaSueldoAPagar {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["DescripcionCtaSueldoAPagar"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionCtaSueldoAPagar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].DescripcionCtaSueldoAPagar = value;
               }
	          }
        public bool IsDescripcionCtaSueldoAPagarNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsDescripcionCtaSueldoAPagarNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueGruposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGruposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGruposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGruposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueGruposDS );
     }
     public sueGruposActionExchange() : base( "sueGrupos" ) {
     }

     public sueGruposActionExchange(sueGruposActionEnum.EnumsueGruposAction pAccion) : base(sueGruposActionEnum.GetAccionsueGruposAction(pAccion)) {
     }

     public sueGruposActionExchange(sueGruposActionEnum.EnumsueGruposAction pAccion, SueldosCommon.sueGruposDS pdsParam) : base(sueGruposActionEnum.GetAccionsueGruposAction(pAccion), pdsParam) {
     }

     public sueGruposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueGruposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueGruposDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueGruposDS)mParam;
	        }
     }
  }
}
