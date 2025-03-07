using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genPaisesActionExchange : Framework.Core.Exchange{

        public Int32 genPaises {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["genPaises"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].genPaises;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].genPaises = value;
               }
	          }
        public bool IsgenPaisesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsgenPaisesNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public Int16 Pais_Id_Nueva {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Pais_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Pais_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Pais_Id_Nueva = value;
               }
	          }
        public bool IsPais_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsPais_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String CodFiscal {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["CodFiscal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].CodFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].CodFiscal = value;
               }
	          }
        public bool IsCodFiscalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsCodFiscalNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String DescripcionDominios {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["DescripcionDominios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].DescripcionDominios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].DescripcionDominios = value;
               }
	          }
        public bool IsDescripcionDominiosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsDescripcionDominiosNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genPaisesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPaisesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPaisesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genPaisesDS );
     }
     public genPaisesActionExchange() : base( "genPaises" ) {
     }

     public genPaisesActionExchange(genPaisesActionEnum.EnumgenPaisesAction pAccion) : base(genPaisesActionEnum.GetAcciongenPaisesAction(pAccion)) {
     }

     public genPaisesActionExchange(genPaisesActionEnum.EnumgenPaisesAction pAccion, GeneralesCommon.genPaisesDS pdsParam) : base(genPaisesActionEnum.GetAcciongenPaisesAction(pAccion), pdsParam) {
     }

     public genPaisesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genPaisesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genPaisesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genPaisesDS)mParam;
	        }
     }
  }
}
