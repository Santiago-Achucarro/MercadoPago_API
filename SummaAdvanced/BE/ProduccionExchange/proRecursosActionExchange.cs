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
    public class proRecursosActionExchange : Framework.Core.Exchange{

        public Int32 proRecursos {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["proRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].proRecursos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].proRecursos = value;
               }
	          }
        public bool IsproRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsproRecursosNull();
             }
	        }
        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String Recurso_Id_Nueva {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Recurso_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Recurso_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Recurso_Id_Nueva = value;
               }
	          }
        public bool IsRecurso_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsRecurso_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal Capacidad {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Capacidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Capacidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Capacidad = value;
               }
	          }
        public bool IsCapacidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsCapacidadNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public Boolean UsaSubRecurso {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["UsaSubRecurso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].UsaSubRecurso;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].UsaSubRecurso = value;
               }
	          }
        public bool IsUsaSubRecursoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsUsaSubRecursoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecursosDS );
     }
     public proRecursosActionExchange() : base( "proRecursos" ) {
     }

     public proRecursosActionExchange(proRecursosActionEnum.EnumproRecursosAction pAccion) : base(proRecursosActionEnum.GetAccionproRecursosAction(pAccion)) {
     }

     public proRecursosActionExchange(proRecursosActionEnum.EnumproRecursosAction pAccion, ProduccionCommon.proRecursosDS pdsParam) : base(proRecursosActionEnum.GetAccionproRecursosAction(pAccion), pdsParam) {
     }

     public proRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecursosDS)mParam;
	        }
     }
  }
}
