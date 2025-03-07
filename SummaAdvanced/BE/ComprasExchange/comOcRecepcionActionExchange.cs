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
    public class comOcRecepcionActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String DescripcionFormulario {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["DescripcionFormulario"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionFormulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].DescripcionFormulario = value;
               }
	          }
        public bool IsDescripcionFormularioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsDescripcionFormularioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Especial {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Especial"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Especial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Especial = value;
               }
	          }
        public bool IsEspecialNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsEspecialNull();
             }
	        }
        public String Sucursal {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOcRecepcionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcRecepcionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOcRecepcionDS );
     }
     public comOcRecepcionActionExchange() : base( "comOcRecepcion" ) {
     }

     public comOcRecepcionActionExchange(comOcRecepcionActionEnum.EnumcomOcRecepcionAction pAccion) : base(comOcRecepcionActionEnum.GetAccioncomOcRecepcionAction(pAccion)) {
     }

     public comOcRecepcionActionExchange(comOcRecepcionActionEnum.EnumcomOcRecepcionAction pAccion, ComprasCommon.comOcRecepcionDS pdsParam) : base(comOcRecepcionActionEnum.GetAccioncomOcRecepcionAction(pAccion), pdsParam) {
     }

     public comOcRecepcionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOcRecepcionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOcRecepcionDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOcRecepcionDS)mParam;
	        }
     }
  }
}
