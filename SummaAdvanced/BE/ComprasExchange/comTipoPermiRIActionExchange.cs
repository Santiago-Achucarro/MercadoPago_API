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
    public class comTipoPermiRIActionExchange : Framework.Core.Exchange{

        public Int32 comTipoPermiRI {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["comTipoPermiRI"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].comTipoPermiRI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].comTipoPermiRI = value;
               }
	          }
        public bool IscomTipoPermiRINull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IscomTipoPermiRINull();
             }
	        }
        public String TipoPermiRI_Id {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["TipoPermiRI_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoPermiRI_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoPermiRI_Id = value;
               }
	          }
        public bool IsTipoPermiRI_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsTipoPermiRI_IdNull();
             }
	        }
        public String TipoPermiRI_Id_Nueva {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["TipoPermiRI_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoPermiRI_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoPermiRI_Id_Nueva = value;
               }
	          }
        public bool IsTipoPermiRI_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsTipoPermiRI_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String EsquemaAuto_Id {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String DescripcionEsquemaAuto {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["DescripcionEsquemaAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionEsquemaAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionEsquemaAuto = value;
               }
	          }
        public bool IsDescripcionEsquemaAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsDescripcionEsquemaAutoNull();
             }
	        }
        public String TipoCuerpo {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["TipoCuerpo"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoCuerpo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoCuerpo = value;
               }
	          }
        public bool IsTipoCuerpoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsTipoCuerpoNull();
             }
	        }
        public String TipoRI {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["TipoRI"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoRI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].TipoRI = value;
               }
	          }
        public bool IsTipoRINull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsTipoRINull();
             }
	        }
        public String UsuarioAutoriz {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["UsuarioAutoriz"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].UsuarioAutoriz;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].UsuarioAutoriz = value;
               }
	          }
        public bool IsUsuarioAutorizNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsUsuarioAutorizNull();
             }
	        }
        public String DescripcionUsuarioAutoriz {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["DescripcionUsuarioAutoriz"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionUsuarioAutoriz;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionUsuarioAutoriz = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsDescripcionUsuarioAutorizNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String DescripcionReporte {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["DescripcionReporte"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionReporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].DescripcionReporte = value;
               }
	          }
        public bool IsDescripcionReporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsDescripcionReporteNull();
             }
	        }
        public Boolean GeneraOC {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["GeneraOC"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].GeneraOC;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].GeneraOC = value;
               }
	          }
        public bool IsGeneraOCNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsGeneraOCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comTipoPermiRIDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comTipoPermiRIDS );
     }
     public comTipoPermiRIActionExchange() : base( "comTipoPermiRI" ) {
     }

     public comTipoPermiRIActionExchange(comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction pAccion) : base(comTipoPermiRIActionEnum.GetAccioncomTipoPermiRIAction(pAccion)) {
     }

     public comTipoPermiRIActionExchange(comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction pAccion, ComprasCommon.comTipoPermiRIDS pdsParam) : base(comTipoPermiRIActionEnum.GetAccioncomTipoPermiRIAction(pAccion), pdsParam) {
     }

     public comTipoPermiRIActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comTipoPermiRIDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comTipoPermiRIDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comTipoPermiRIDS)mParam;
	        }
     }
  }
}
