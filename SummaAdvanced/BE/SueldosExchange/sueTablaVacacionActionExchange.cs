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
    public class sueTablaVacacionActionExchange : Framework.Core.Exchange{

        public Int32 sueTablaVacacion {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["sueTablaVacacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].sueTablaVacacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].sueTablaVacacion = value;
               }
	          }
        public bool IssueTablaVacacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IssueTablaVacacionNull();
             }
	        }
        public String TablaVac_Id {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["TablaVac_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].TablaVac_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].TablaVac_Id = value;
               }
	          }
        public bool IsTablaVac_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsTablaVac_IdNull();
             }
	        }
        public String TablaVac_Id_Nueva {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["TablaVac_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].TablaVac_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].TablaVac_Id_Nueva = value;
               }
	          }
        public bool IsTablaVac_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsTablaVac_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTablaVacacionDS );
     }
     public sueTablaVacacionActionExchange() : base( "sueTablaVacacion" ) {
     }

     public sueTablaVacacionActionExchange(sueTablaVacacionActionEnum.EnumsueTablaVacacionAction pAccion) : base(sueTablaVacacionActionEnum.GetAccionsueTablaVacacionAction(pAccion)) {
     }

     public sueTablaVacacionActionExchange(sueTablaVacacionActionEnum.EnumsueTablaVacacionAction pAccion, SueldosCommon.sueTablaVacacionDS pdsParam) : base(sueTablaVacacionActionEnum.GetAccionsueTablaVacacionAction(pAccion), pdsParam) {
     }

     public sueTablaVacacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTablaVacacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTablaVacacionDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTablaVacacionDS)mParam;
	        }
     }
  }
}
