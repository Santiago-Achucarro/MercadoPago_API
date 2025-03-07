using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conInfDefiniblesActionExchange : Framework.Core.Exchange{

        public Int32 conInfDefinibles {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["conInfDefinibles"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].conInfDefinibles;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].conInfDefinibles = value;
               }
	          }
        public bool IsconInfDefiniblesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsconInfDefiniblesNull();
             }
	        }
        public String Informe_Id {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Informe_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Informe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Informe_Id = value;
               }
	          }
        public bool IsInforme_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsInforme_IdNull();
             }
	        }
        public String Informe_Id_Nueva {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Informe_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Informe_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Informe_Id_Nueva = value;
               }
	          }
        public bool IsInforme_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsInforme_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conInfDefiniblesDS );
     }
     public conInfDefiniblesActionExchange() : base( "conInfDefinibles" ) {
     }

     public conInfDefiniblesActionExchange(conInfDefiniblesActionEnum.EnumconInfDefiniblesAction pAccion) : base(conInfDefiniblesActionEnum.GetAccionconInfDefiniblesAction(pAccion)) {
     }

     public conInfDefiniblesActionExchange(conInfDefiniblesActionEnum.EnumconInfDefiniblesAction pAccion, ContabilidadCommon.conInfDefiniblesDS pdsParam) : base(conInfDefiniblesActionEnum.GetAccionconInfDefiniblesAction(pAccion), pdsParam) {
     }

     public conInfDefiniblesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conInfDefiniblesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conInfDefiniblesDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conInfDefiniblesDS)mParam;
	        }
     }
  }
}
