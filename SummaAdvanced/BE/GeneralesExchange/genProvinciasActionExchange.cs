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
    public class genProvinciasActionExchange : Framework.Core.Exchange{

        public Int32 genProvincias {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["genProvincias"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].genProvincias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].genProvincias = value;
               }
	          }
        public bool IsgenProvinciasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsgenProvinciasNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String Provincia_Id_Nueva {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Provincia_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Provincia_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Provincia_Id_Nueva = value;
               }
	          }
        public bool IsProvincia_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsProvincia_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String CodFiscal {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["CodFiscal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].CodFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].CodFiscal = value;
               }
	          }
        public bool IsCodFiscalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsCodFiscalNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genProvinciasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genProvinciasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genProvinciasDS );
     }
     public genProvinciasActionExchange() : base( "genProvincias" ) {
     }

     public genProvinciasActionExchange(genProvinciasActionEnum.EnumgenProvinciasAction pAccion) : base(genProvinciasActionEnum.GetAcciongenProvinciasAction(pAccion)) {
     }

     public genProvinciasActionExchange(genProvinciasActionEnum.EnumgenProvinciasAction pAccion, GeneralesCommon.genProvinciasDS pdsParam) : base(genProvinciasActionEnum.GetAcciongenProvinciasAction(pAccion), pdsParam) {
     }

     public genProvinciasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genProvinciasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genProvinciasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genProvinciasDS)mParam;
	        }
     }
  }
}
