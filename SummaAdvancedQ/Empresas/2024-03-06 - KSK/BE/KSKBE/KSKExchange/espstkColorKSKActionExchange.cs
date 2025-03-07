using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espstkColorKSKActionExchange : Framework.Core.Exchange{

        public Int32 espstkColorKSK {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["espstkColorKSK"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].espstkColorKSK;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].espstkColorKSK = value;
               }
	          }
        public bool IsespstkColorKSKNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsespstkColorKSKNull();
             }
	        }
        public String Color_Id {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Color_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Color_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Color_Id = value;
               }
	          }
        public bool IsColor_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsColor_IdNull();
             }
	        }
        public String Color_Id_Nueva {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Color_Id_Nueva"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Color_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Color_Id_Nueva = value;
               }
	          }
        public bool IsColor_Id_NuevaNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsColor_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espstkColorKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espstkColorKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espstkColorKSKDS );
     }
     public espstkColorKSKActionExchange() : base( "espstkColorKSK" ) {
     }

     public espstkColorKSKActionExchange(espstkColorKSKActionEnum.EnumespstkColorKSKAction pAccion) : base(espstkColorKSKActionEnum.GetAccionespstkColorKSKAction(pAccion)) {
     }

     public espstkColorKSKActionExchange(espstkColorKSKActionEnum.EnumespstkColorKSKAction pAccion, KSKCommon.espstkColorKSKDS pdsParam) : base(espstkColorKSKActionEnum.GetAccionespstkColorKSKAction(pAccion), pdsParam) {
     }

     public espstkColorKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espstkColorKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espstkColorKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espstkColorKSKDS)mParam;
	        }
     }
  }
}
