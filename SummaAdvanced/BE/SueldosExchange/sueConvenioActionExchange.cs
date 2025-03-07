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
    public class sueConvenioActionExchange : Framework.Core.Exchange{

        public Int32 sueConvenio {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["sueConvenio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].sueConvenio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].sueConvenio = value;
               }
	          }
        public bool IssueConvenioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IssueConvenioNull();
             }
	        }
        public String Convenio_Id {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Convenio_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Convenio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Convenio_Id = value;
               }
	          }
        public bool IsConvenio_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsConvenio_IdNull();
             }
	        }
        public String Convenio_Id_Nueva {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Convenio_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Convenio_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Convenio_Id_Nueva = value;
               }
	          }
        public bool IsConvenio_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsConvenio_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String TablaVac_Id {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["TablaVac_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].TablaVac_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].TablaVac_Id = value;
               }
	          }
        public bool IsTablaVac_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsTablaVac_IdNull();
             }
	        }
        public String DescripcionVacacion {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["DescripcionVacacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].DescripcionVacacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].DescripcionVacacion = value;
               }
	          }
        public bool IsDescripcionVacacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsDescripcionVacacionNull();
             }
	        }
        public Boolean Sindicalizdo {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Sindicalizdo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Sindicalizdo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Sindicalizdo = value;
               }
	          }
        public bool IsSindicalizdoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsSindicalizdoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConvenioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConvenioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConvenioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConvenioDS );
     }
     public sueConvenioActionExchange() : base( "sueConvenio" ) {
     }

     public sueConvenioActionExchange(sueConvenioActionEnum.EnumsueConvenioAction pAccion) : base(sueConvenioActionEnum.GetAccionsueConvenioAction(pAccion)) {
     }

     public sueConvenioActionExchange(sueConvenioActionEnum.EnumsueConvenioAction pAccion, SueldosCommon.sueConvenioDS pdsParam) : base(sueConvenioActionEnum.GetAccionsueConvenioAction(pAccion), pdsParam) {
     }

     public sueConvenioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConvenioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConvenioDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConvenioDS)mParam;
	        }
     }
  }
}
