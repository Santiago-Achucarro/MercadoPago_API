using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venListasPreciosActionExchange : Framework.Core.Exchange{

        public Int32 venListasPrecios {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["venListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].venListasPrecios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].venListasPrecios = value;
               }
	          }
        public bool IsvenListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsvenListasPreciosNull();
             }
	        }
        public String ListaPrecio_Id_Nueva {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["ListaPrecio_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].ListaPrecio_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].ListaPrecio_Id_Nueva = value;
               }
	          }
        public bool IsListaPrecio_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsListaPrecio_Id_NuevaNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Boolean LlevaImpuestoInclu {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["LlevaImpuestoInclu"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].LlevaImpuestoInclu;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].LlevaImpuestoInclu = value;
               }
	          }
        public bool IsLlevaImpuestoIncluNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsLlevaImpuestoIncluNull();
             }
	        }
        public String UsuarioAutorizado {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["UsuarioAutorizado"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].UsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].UsuarioAutorizado = value;
               }
	          }
        public bool IsUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsUsuarioAutorizadoNull();
             }
	        }
        public String DescripcionUsuarioAutorizado {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["DescripcionUsuarioAutorizado"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionUsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionUsuarioAutorizado = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsDescripcionUsuarioAutorizadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Excel {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Excel"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Excel;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Excel = value;
               }
	          }
        public bool IsExcelNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsExcelNull();
             }
	        }
        public Int32 DecimalesPu {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["DecimalesPu"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DecimalesPu;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].DecimalesPu = value;
               }
	          }
        public bool IsDecimalesPuNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsDecimalesPuNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public DateTime VigenciaDesde {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["VigenciaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].VigenciaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].VigenciaDesde = value;
               }
	          }
        public bool IsVigenciaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsVigenciaDesdeNull();
             }
	        }
        public DateTime VigenciaHasta {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["VigenciaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].VigenciaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].VigenciaHasta = value;
               }
	          }
        public bool IsVigenciaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsVigenciaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasPreciosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasPreciosDS );
     }
     public venListasPreciosActionExchange() : base( "venListasPrecios" ) {
     }

     public venListasPreciosActionExchange(venListasPreciosActionEnum.EnumvenListasPreciosAction pAccion) : base(venListasPreciosActionEnum.GetAccionvenListasPreciosAction(pAccion)) {
     }

     public venListasPreciosActionExchange(venListasPreciosActionEnum.EnumvenListasPreciosAction pAccion, VentasCommon.venListasPreciosDS pdsParam) : base(venListasPreciosActionEnum.GetAccionvenListasPreciosAction(pAccion), pdsParam) {
     }

     public venListasPreciosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasPreciosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasPreciosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasPreciosDS)mParam;
	        }
     }
  }
}
