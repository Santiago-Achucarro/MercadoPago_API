using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impPadronActionExchange : Framework.Core.Exchange{

        public Int32 impPadron {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["impPadron"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].impPadron;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].impPadron = value;
               }
	          }
        public bool IsimpPadronNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsimpPadronNull();
             }
	        }
        public String Padron_Id {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Padron_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Padron_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Padron_Id = value;
               }
	          }
        public bool IsPadron_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsPadron_IdNull();
             }
	        }
        public String Padron_Id_Nueva {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Padron_Id_Nueva"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Padron_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Padron_Id_Nueva = value;
               }
	          }
        public bool IsPadron_Id_NuevaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsPadron_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuit {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public DateTime FechaBusqueda {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["FechaBusqueda"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].FechaBusqueda;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].FechaBusqueda = value;
               }
	          }
        public bool IsFechaBusquedaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsFechaBusquedaNull();
             }
	        }
        public Decimal ValorRetorno {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ValorRetorno"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ValorRetorno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ValorRetorno = value;
               }
	          }
        public bool IsValorRetornoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsValorRetornoNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Tabla {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Tabla"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Tabla;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Tabla = value;
               }
	          }
        public bool IsTablaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsTablaNull();
             }
	        }
        public String Periodo {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Periodo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Periodo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Periodo = value;
               }
	          }
        public bool IsPeriodoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsPeriodoNull();
             }
	        }
        public String ColCuit {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColCuit"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColCuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColCuit = value;
               }
	          }
        public bool IsColCuitNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColCuitNull();
             }
	        }
        public String ColAnio {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColAnio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColAnio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColAnio = value;
               }
	          }
        public bool IsColAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColAnioNull();
             }
	        }
        public String ColPeriodo {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColPeriodo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColPeriodo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColPeriodo = value;
               }
	          }
        public bool IsColPeriodoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColPeriodoNull();
             }
	        }
        public String ColBusqueda {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColBusqueda"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColBusqueda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColBusqueda = value;
               }
	          }
        public bool IsColBusquedaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColBusquedaNull();
             }
	        }
        public String ColBusquedaValor {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColBusquedaValor"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColBusquedaValor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColBusquedaValor = value;
               }
	          }
        public bool IsColBusquedaValorNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColBusquedaValorNull();
             }
	        }
        public String ColDevolucion {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["ColDevolucion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColDevolucion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].ColDevolucion = value;
               }
	          }
        public bool IsColDevolucionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsColDevolucionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String StoreProcedure {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["StoreProcedure"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].StoreProcedure;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].StoreProcedure = value;
               }
	          }
        public bool IsStoreProcedureNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsStoreProcedureNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impPadronDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impPadronDS );
     }
     public impPadronActionExchange() : base( "impPadron" ) {
     }

     public impPadronActionExchange(impPadronActionEnum.EnumimpPadronAction pAccion) : base(impPadronActionEnum.GetAccionimpPadronAction(pAccion)) {
     }

     public impPadronActionExchange(impPadronActionEnum.EnumimpPadronAction pAccion, ImpuestosCommon.impPadronDS pdsParam) : base(impPadronActionEnum.GetAccionimpPadronAction(pAccion), pdsParam) {
     }

     public impPadronActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impPadronDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impPadronActionExchange(ImpuestosCommon.impPadronDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impPadronDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impPadronDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impPadronDS)mParam;
	        }
     }
  }
}
