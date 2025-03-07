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
    public class comNivelesAutoActionExchange : Framework.Core.Exchange{

        public Int32 ComNivelesAuto {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["ComNivelesAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].ComNivelesAuto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].ComNivelesAuto = value;
               }
	          }
        public bool IsComNivelesAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsComNivelesAutoNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String NivelAuto_Id_Nueva {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["NivelAuto_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].NivelAuto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].NivelAuto_Id_Nueva = value;
               }
	          }
        public bool IsNivelAuto_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsNivelAuto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comNivelesAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comNivelesAutoDS );
     }
     public comNivelesAutoActionExchange() : base( "comNivelesAuto" ) {
     }

     public comNivelesAutoActionExchange(comNivelesAutoActionEnum.EnumcomNivelesAutoAction pAccion) : base(comNivelesAutoActionEnum.GetAccioncomNivelesAutoAction(pAccion)) {
     }

     public comNivelesAutoActionExchange(comNivelesAutoActionEnum.EnumcomNivelesAutoAction pAccion, ComprasCommon.comNivelesAutoDS pdsParam) : base(comNivelesAutoActionEnum.GetAccioncomNivelesAutoAction(pAccion), pdsParam) {
     }

     public comNivelesAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comNivelesAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comNivelesAutoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comNivelesAutoDS)mParam;
	        }
     }
  }
}
