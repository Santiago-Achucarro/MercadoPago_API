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
    public class comPagosHabilitadosActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public String SegmentoSTR {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["SegmentoSTR"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].SegmentoSTR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].SegmentoSTR = value;
               }
	          }
        public bool IsSegmentoSTRNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsSegmentoSTRNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Int16 CuotaNro {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["CuotaNro"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].CuotaNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].CuotaNro = value;
               }
	          }
        public bool IsCuotaNroNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsCuotaNroNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Decimal SaldoOri {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["SaldoOri"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].SaldoOri;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].SaldoOri = value;
               }
	          }
        public bool IsSaldoOriNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsSaldoOriNull();
             }
	        }
        public Int32 Secuencia {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public Int32 TipoCtaProv {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["TipoCtaProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].TipoCtaProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].TipoCtaProv = value;
               }
	          }
        public bool IsTipoCtaProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsTipoCtaProvNull();
             }
	        }
        public DateTime Fecha_CCP {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Fecha_CCP"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Fecha_CCP;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Fecha_CCP = value;
               }
	          }
        public bool IsFecha_CCPNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsFecha_CCPNull();
             }
	        }
        public DateTime FechaHabilitacion {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["FechaHabilitacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].FechaHabilitacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].FechaHabilitacion = value;
               }
	          }
        public bool IsFechaHabilitacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsFechaHabilitacionNull();
             }
	        }
        public Decimal ImporteHabilitado {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["ImporteHabilitado"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].ImporteHabilitado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].ImporteHabilitado = value;
               }
	          }
        public bool IsImporteHabilitadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsImporteHabilitadoNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Decimal CambioPago {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["CambioPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].CambioPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].CambioPago = value;
               }
	          }
        public bool IsCambioPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsCambioPagoNull();
             }
	        }
        public Decimal Importe1 {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Importe1"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe1 = value;
               }
	          }
        public bool IsImporte1Null {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsImporte1Null();
             }
	        }
        public Decimal Importe2 {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Importe2"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe2 = value;
               }
	          }
        public bool IsImporte2Null {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsImporte2Null();
             }
	        }
        public Decimal Importe3 {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Importe3"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Importe3 = value;
               }
	          }
        public bool IsImporte3Null {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsImporte3Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comPagosHabilitadosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comPagosHabilitadosDS );
     }
     public comPagosHabilitadosActionExchange() : base( "comPagosHabilitados" ) {
     }

     public comPagosHabilitadosActionExchange(comPagosHabilitadosActionEnum.EnumcomPagosHabilitadosAction pAccion) : base(comPagosHabilitadosActionEnum.GetAccioncomPagosHabilitadosAction(pAccion)) {
     }

     public comPagosHabilitadosActionExchange(comPagosHabilitadosActionEnum.EnumcomPagosHabilitadosAction pAccion, ComprasCommon.comPagosHabilitadosDS pdsParam) : base(comPagosHabilitadosActionEnum.GetAccioncomPagosHabilitadosAction(pAccion), pdsParam) {
     }

     public comPagosHabilitadosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comPagosHabilitadosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comPagosHabilitadosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comPagosHabilitadosDS)mParam;
	        }
     }
  }
}
