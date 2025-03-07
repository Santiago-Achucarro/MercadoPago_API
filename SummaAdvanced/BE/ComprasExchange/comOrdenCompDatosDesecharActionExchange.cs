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
    public class comOrdenCompDatosDesecharActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedores {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionProveedores"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionProveedores = value;
               }
	          }
        public bool IsDescripcionProveedoresNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionProveedoresNull();
             }
	        }
        public String TipoPermi_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["TipoPermi_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].TipoPermi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].TipoPermi_Id = value;
               }
	          }
        public bool IsTipoPermi_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsTipoPermi_IdNull();
             }
	        }
        public String DescripcionTipoPermi {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionTipoPermi"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionTipoPermi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionTipoPermi = value;
               }
	          }
        public bool IsDescripcionTipoPermiNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionTipoPermiNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Int32 NroUsuAuto {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["NroUsuAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].NroUsuAuto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].NroUsuAuto = value;
               }
	          }
        public bool IsNroUsuAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsNroUsuAutoNull();
             }
	        }
        public String Autorizo {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Autorizo"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Autorizo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Autorizo = value;
               }
	          }
        public bool IsAutorizoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsAutorizoNull();
             }
	        }
        public String DescripcionUsuarioAutorizo {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionUsuarioAutorizo"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionUsuarioAutorizo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionUsuarioAutorizo = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionUsuarioAutorizoNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String DescripcionConPago {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionConPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionConPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionConPago = value;
               }
	          }
        public bool IsDescripcionConPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionConPagoNull();
             }
	        }
        public Boolean Impreso {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Impreso"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Impreso;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Impreso = value;
               }
	          }
        public bool IsImpresoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsImpresoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionOcEstados {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionOcEstados"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionOcEstados;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionOcEstados = value;
               }
	          }
        public bool IsDescripcionOcEstadosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionOcEstadosNull();
             }
	        }
        public Decimal Saldo_Anticipo {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Saldo_Anticipo"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Saldo_Anticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Saldo_Anticipo = value;
               }
	          }
        public bool IsSaldo_AnticipoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSaldo_AnticipoNull();
             }
	        }
        public Decimal ImporteImpuestos {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["ImporteImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].ImporteImpuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].ImporteImpuestos = value;
               }
	          }
        public bool IsImporteImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsImporteImpuestosNull();
             }
	        }
        public Decimal Saldo_NC {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Saldo_NC"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Saldo_NC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Saldo_NC = value;
               }
	          }
        public bool IsSaldo_NCNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSaldo_NCNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String TipoCuerpo {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["TipoCuerpo"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].TipoCuerpo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].TipoCuerpo = value;
               }
	          }
        public bool IsTipoCuerpoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsTipoCuerpoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal Total {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public DateTime FechaNueva {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["FechaNueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].FechaNueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].FechaNueva = value;
               }
	          }
        public bool IsFechaNuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsFechaNuevaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDatosConsDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompDatosConsDS );
     }
     public comOrdenCompDatosDesecharActionExchange() : base( "comOrdenCompDatosDesechar" ) {
     }

     public comOrdenCompDatosDesecharActionExchange(comOrdenCompDatosDesecharActionEnum.EnumcomOrdenCompDatosDesecharAction pAccion) : base(comOrdenCompDatosDesecharActionEnum.GetAccioncomOrdenCompDatosDesecharAction(pAccion)) {
     }

     public comOrdenCompDatosDesecharActionExchange(comOrdenCompDatosDesecharActionEnum.EnumcomOrdenCompDatosDesecharAction pAccion, ComprasCommon.comOrdenCompDatosConsDS pdsParam) : base(comOrdenCompDatosDesecharActionEnum.GetAccioncomOrdenCompDatosDesecharAction(pAccion), pdsParam) {
     }

     public comOrdenCompDatosDesecharActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompDatosConsDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompDatosConsDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompDatosConsDS)mParam;
	        }
     }
  }
}
