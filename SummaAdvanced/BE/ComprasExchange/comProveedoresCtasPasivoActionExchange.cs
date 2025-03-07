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
    public class comProveedoresCtasPasivoActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public Int32 TipoCtaProv {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["TipoCtaProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].TipoCtaProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].TipoCtaProv = value;
               }
	          }
        public bool IsTipoCtaProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsTipoCtaProvNull();
             }
	        }
        public String DescripcionProveedoresTipoPasivo {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["DescripcionProveedoresTipoPasivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo = value;
               }
	          }
        public bool IsDescripcionProveedoresTipoPasivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsDescripcionProveedoresTipoPasivoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String ctaPagoXAdelantado {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["ctaPagoXAdelantado"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].ctaPagoXAdelantado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].ctaPagoXAdelantado = value;
               }
	          }
        public bool IsctaPagoXAdelantadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsctaPagoXAdelantadoNull();
             }
	        }
        public String DescripcionctaPagoXAdelantado {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["DescripcionctaPagoXAdelantado"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionctaPagoXAdelantado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionctaPagoXAdelantado = value;
               }
	          }
        public bool IsDescripcionctaPagoXAdelantadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsDescripcionctaPagoXAdelantadoNull();
             }
	        }
        public String CtaAnticipo {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["CtaAnticipo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].CtaAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].CtaAnticipo = value;
               }
	          }
        public bool IsCtaAnticipoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsCtaAnticipoNull();
             }
	        }
        public String DescripcionCtaAnticipo {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["DescripcionCtaAnticipo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionCtaAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].DescripcionCtaAnticipo = value;
               }
	          }
        public bool IsDescripcionCtaAnticipoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsDescripcionCtaAnticipoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresCtasPasivoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresCtasPasivoDS );
     }
     public comProveedoresCtasPasivoActionExchange() : base( "comProveedoresCtasPasivo" ) {
     }

     public comProveedoresCtasPasivoActionExchange(comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction pAccion) : base(comProveedoresCtasPasivoActionEnum.GetAccioncomProveedoresCtasPasivoAction(pAccion)) {
     }

     public comProveedoresCtasPasivoActionExchange(comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction pAccion, ComprasCommon.comProveedoresCtasPasivoDS pdsParam) : base(comProveedoresCtasPasivoActionEnum.GetAccioncomProveedoresCtasPasivoAction(pAccion), pdsParam) {
     }

     public comProveedoresCtasPasivoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresCtasPasivoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresCtasPasivoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresCtasPasivoDS)mParam;
	        }
     }
  }
}
