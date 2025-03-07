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
    public class comPagosAnticipoActionExchange : Framework.Core.Exchange{

        public String Proveed_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Decimal ImporteHabilitado {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["ImporteHabilitado"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].ImporteHabilitado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].ImporteHabilitado = value;
               }
	          }
        public bool IsImporteHabilitadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsImporteHabilitadoNull();
             }
	        }
        public Int32 TipoCtaProv {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["TipoCtaProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].TipoCtaProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].TipoCtaProv = value;
               }
	          }
        public bool IsTipoCtaProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsTipoCtaProvNull();
             }
	        }
        public String DescripcionProveedoresTipoPasivo {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["DescripcionProveedoresTipoPasivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo = value;
               }
	          }
        public bool IsDescripcionProveedoresTipoPasivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsDescripcionProveedoresTipoPasivoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public Int64 comPagosAnticipo {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["comPagosAnticipo"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].comPagosAnticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].comPagosAnticipo = value;
               }
	          }
        public bool IscomPagosAnticipoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IscomPagosAnticipoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosAnticipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comPagosAnticipoDS );
     }
     public comPagosAnticipoActionExchange() : base( "comPagosAnticipo" ) {
     }

     public comPagosAnticipoActionExchange(comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction pAccion) : base(comPagosAnticipoActionEnum.GetAccioncomPagosAnticipoAction(pAccion)) {
     }

     public comPagosAnticipoActionExchange(comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction pAccion, ComprasCommon.comPagosAnticipoDS pdsParam) : base(comPagosAnticipoActionEnum.GetAccioncomPagosAnticipoAction(pAccion), pdsParam) {
     }

     public comPagosAnticipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comPagosAnticipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comPagosAnticipoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comPagosAnticipoDS)mParam;
	        }
     }
  }
}
