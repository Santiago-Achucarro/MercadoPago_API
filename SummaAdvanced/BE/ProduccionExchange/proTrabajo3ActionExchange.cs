using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proTrabajo3ActionExchange : Framework.Core.Exchange{

        public Int32 proTrabajo3 {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["proTrabajo3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].proTrabajo3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].proTrabajo3 = value;
               }
	          }
        public bool IsproTrabajo3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsproTrabajo3Null();
             }
	        }
        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String Trabajo3_Id_Nueva {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Trabajo3_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Trabajo3_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Trabajo3_Id_Nueva = value;
               }
	          }
        public bool IsTrabajo3_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsTrabajo3_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proTrabajo3DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proTrabajo3DS );
     }
     public proTrabajo3ActionExchange() : base( "proTrabajo3" ) {
     }

     public proTrabajo3ActionExchange(proTrabajo3ActionEnum.EnumproTrabajo3Action pAccion) : base(proTrabajo3ActionEnum.GetAccionproTrabajo3Action(pAccion)) {
     }

     public proTrabajo3ActionExchange(proTrabajo3ActionEnum.EnumproTrabajo3Action pAccion, ProduccionCommon.proTrabajo3DS pdsParam) : base(proTrabajo3ActionEnum.GetAccionproTrabajo3Action(pAccion), pdsParam) {
     }

     public proTrabajo3ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proTrabajo3DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proTrabajo3DS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proTrabajo3DS)mParam;
	        }
     }
  }
}
