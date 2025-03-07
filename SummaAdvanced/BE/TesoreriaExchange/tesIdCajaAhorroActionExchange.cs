using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesIdCajaAhorroActionExchange : Framework.Core.Exchange{

        public Int32 tesIdentifica {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["tesIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].tesIdentifica;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].tesIdentifica = value;
               }
	          }
        public bool IstesIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IstesIdentificaNull();
             }
	        }
        public String Cartera_id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Cartera_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cartera_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cartera_id = value;
               }
	          }
        public bool IsCartera_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCartera_idNull();
             }
	        }
        public String Cartera_id_Nueva {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Cartera_id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cartera_id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cartera_id_Nueva = value;
               }
	          }
        public bool IsCartera_id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCartera_id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpreas {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["PTodasEmpreas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].PTodasEmpreas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].PTodasEmpreas = value;
               }
	          }
        public bool IsPTodasEmpreasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsPTodasEmpreasNull();
             }
	        }
        public String TipoCartera {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["TipoCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].TipoCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].TipoCartera = value;
               }
	          }
        public bool IsTipoCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsTipoCarteraNull();
             }
	        }
        public String DescripcionTiposId {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionTiposId"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionTiposId;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionTiposId = value;
               }
	          }
        public bool IsDescripcionTiposIdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionTiposIdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String UsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["UsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].UsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].UsuarioAmo = value;
               }
	          }
        public bool IsUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsUsuarioAmoNull();
             }
	        }
        public String DescripcionUsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionUsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionUsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionUsuarioAmo = value;
               }
	          }
        public bool IsDescripcionUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionUsuarioAmoNull();
             }
	        }
        public Boolean ModiCent1 {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["ModiCent1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].ModiCent1;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].ModiCent1 = value;
               }
	          }
        public bool IsModiCent1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsModiCent1Null();
             }
	        }
        public Boolean ModiCent2 {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["ModiCent2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].ModiCent2;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].ModiCent2 = value;
               }
	          }
        public bool IsModiCent2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsModiCent2Null();
             }
	        }
        public String CtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["CtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].CtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].CtaValEnTransito = value;
               }
	          }
        public bool IsCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsCtaValEnTransitoNull();
             }
	        }
        public String DescripcionCtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionCtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionCtaValEnTransito = value;
               }
	          }
        public bool IsDescripcionCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionCtaValEnTransitoNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public Boolean VaAlCashFlow {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["VaAlCashFlow"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].VaAlCashFlow;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].VaAlCashFlow = value;
               }
	          }
        public bool IsVaAlCashFlowNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsVaAlCashFlowNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String numCuenta {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["numCuenta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].numCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].numCuenta = value;
               }
	          }
        public bool IsnumCuentaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsnumCuentaNull();
             }
	        }
        public Int32 topeExtraccion {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["topeExtraccion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].topeExtraccion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].topeExtraccion = value;
               }
	          }
        public bool IstopeExtraccionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IstopeExtraccionNull();
             }
	        }
        public Decimal InteresPorc {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["InteresPorc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].InteresPorc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].InteresPorc = value;
               }
	          }
        public bool IsInteresPorcNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsInteresPorcNull();
             }
	        }
        public String FormaDePagoP {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["FormaDePagoP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].FormaDePagoP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].FormaDePagoP = value;
               }
	          }
        public bool IsFormaDePagoPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsFormaDePagoPNull();
             }
	        }
        public Int32 OrdenPtoVta {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["OrdenPtoVta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].OrdenPtoVta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].OrdenPtoVta = value;
               }
	          }
        public bool IsOrdenPtoVtaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsOrdenPtoVtaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdCajaAhorroDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdCajaAhorroDS );
     }
     public tesIdCajaAhorroActionExchange() : base( "tesIdCajaAhorro" ) {
     }

     public tesIdCajaAhorroActionExchange(tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction pAccion) : base(tesIdCajaAhorroActionEnum.GetAcciontesIdCajaAhorroAction(pAccion)) {
     }

     public tesIdCajaAhorroActionExchange(tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction pAccion, TesoreriaCommon.tesIdCajaAhorroDS pdsParam) : base(tesIdCajaAhorroActionEnum.GetAcciontesIdCajaAhorroAction(pAccion), pdsParam) {
     }

     public tesIdCajaAhorroActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdCajaAhorroDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesIdCajaAhorroActionExchange(TesoreriaCommon.tesIdCajaAhorroDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesIdCajaAhorroDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdCajaAhorroDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdCajaAhorroDS)mParam;
	        }
     }
  }
}
