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
    public class espstkTalleKSKActionExchange : Framework.Core.Exchange{

        public Int32 espstkTalleKSK {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["espstkTalleKSK"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].espstkTalleKSK;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].espstkTalleKSK = value;
               }
	          }
        public bool IsespstkTalleKSKNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsespstkTalleKSKNull();
             }
	        }
        public String Talle_Id {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Talle_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Talle_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Talle_Id = value;
               }
	          }
        public bool IsTalle_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsTalle_IdNull();
             }
	        }
        public String Talle_Id_Nueva {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Talle_Id_Nueva"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Talle_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Talle_Id_Nueva = value;
               }
	          }
        public bool IsTalle_Id_NuevaNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsTalle_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espstkTalleKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espstkTalleKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espstkTalleKSKDS );
     }
     public espstkTalleKSKActionExchange() : base( "espstkTalleKSK" ) {
     }

     public espstkTalleKSKActionExchange(espstkTalleKSKActionEnum.EnumespstkTalleKSKAction pAccion) : base(espstkTalleKSKActionEnum.GetAccionespstkTalleKSKAction(pAccion)) {
     }

     public espstkTalleKSKActionExchange(espstkTalleKSKActionEnum.EnumespstkTalleKSKAction pAccion, KSKCommon.espstkTalleKSKDS pdsParam) : base(espstkTalleKSKActionEnum.GetAccionespstkTalleKSKAction(pAccion), pdsParam) {
     }

     public espstkTalleKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espstkTalleKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espstkTalleKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espstkTalleKSKDS)mParam;
	        }
     }
  }
}
