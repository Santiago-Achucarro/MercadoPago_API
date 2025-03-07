using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comTipoPermiActionExchange : Framework.Core.Exchange{

        public Int32 comTipoPermi {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["comTipoPermi"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].comTipoPermi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].comTipoPermi = value;
               }
	          }
        public bool IscomTipoPermiNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IscomTipoPermiNull();
             }
	        }
        public String TipoPermi_Id {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["TipoPermi_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoPermi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoPermi_Id = value;
               }
	          }
        public bool IsTipoPermi_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsTipoPermi_IdNull();
             }
	        }
        public String TipoPermi_Id_Nueva {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["TipoPermi_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoPermi_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoPermi_Id_Nueva = value;
               }
	          }
        public bool IsTipoPermi_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsTipoPermi_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String TipoCuerpo {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["TipoCuerpo"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoCuerpo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].TipoCuerpo = value;
               }
	          }
        public bool IsTipoCuerpoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsTipoCuerpoNull();
             }
	        }
        public Boolean RequiereAutorizacion {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["RequiereAutorizacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].RequiereAutorizacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].RequiereAutorizacion = value;
               }
	          }
        public bool IsRequiereAutorizacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsRequiereAutorizacionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Importaciones {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Importaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Importaciones;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Importaciones = value;
               }
	          }
        public bool IsImportacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsImportacionesNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String DescripcionReporte {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["DescripcionReporte"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionReporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionReporte = value;
               }
	          }
        public bool IsDescripcionReporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsDescripcionReporteNull();
             }
	        }
        public String EsquemaAuto_Id {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String DescripcionEsquemaAuto {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["DescripcionEsquemaAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionEsquemaAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].DescripcionEsquemaAuto = value;
               }
	          }
        public bool IsDescripcionEsquemaAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsDescripcionEsquemaAutoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comTipoPermiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comTipoPermiDS );
     }
     public comTipoPermiActionExchange() : base( "comTipoPermi" ) {
     }

     public comTipoPermiActionExchange(comTipoPermiActionEnum.EnumcomTipoPermiAction pAccion) : base(comTipoPermiActionEnum.GetAccioncomTipoPermiAction(pAccion)) {
     }

     public comTipoPermiActionExchange(comTipoPermiActionEnum.EnumcomTipoPermiAction pAccion, ComprasCommon.comTipoPermiDS pdsParam) : base(comTipoPermiActionEnum.GetAccioncomTipoPermiAction(pAccion), pdsParam) {
     }

     public comTipoPermiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comTipoPermiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comTipoPermiDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comTipoPermiDS)mParam;
	        }
     }
  }
}
