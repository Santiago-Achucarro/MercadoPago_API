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
    public class tesIdBancoPropioActionExchange : Framework.Core.Exchange{

        public Int32 tesIdentifica {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["tesIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].tesIdentifica;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].tesIdentifica = value;
               }
	          }
        public bool IstesIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IstesIdentificaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String Cartera_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Cartera_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cartera_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cartera_Id_Nueva = value;
               }
	          }
        public bool IsCartera_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCartera_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpreas {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["PTodasEmpreas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].PTodasEmpreas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].PTodasEmpreas = value;
               }
	          }
        public bool IsPTodasEmpreasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsPTodasEmpreasNull();
             }
	        }
        public String TipoCartera {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["TipoCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TipoCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TipoCartera = value;
               }
	          }
        public bool IsTipoCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsTipoCarteraNull();
             }
	        }
        public String DescripcionTiposId {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionTiposId"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionTiposId;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionTiposId = value;
               }
	          }
        public bool IsDescripcionTiposIdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionTiposIdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String UsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["UsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].UsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].UsuarioAmo = value;
               }
	          }
        public bool IsUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsUsuarioAmoNull();
             }
	        }
        public String DescripcionUsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionUsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionUsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionUsuarioAmo = value;
               }
	          }
        public bool IsDescripcionUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionUsuarioAmoNull();
             }
	        }
        public Boolean ModiCent1 {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["ModiCent1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ModiCent1;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ModiCent1 = value;
               }
	          }
        public bool IsModiCent1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsModiCent1Null();
             }
	        }
        public Boolean ModiCent2 {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["ModiCent2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ModiCent2;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ModiCent2 = value;
               }
	          }
        public bool IsModiCent2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsModiCent2Null();
             }
	        }
        public String CtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["CtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaValEnTransito = value;
               }
	          }
        public bool IsCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCtaValEnTransitoNull();
             }
	        }
        public String DescripcionCtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionCtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCtaValEnTransito = value;
               }
	          }
        public bool IsDescripcionCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionCtaValEnTransitoNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public Boolean VaAlCashFlow {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["VaAlCashFlow"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].VaAlCashFlow;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].VaAlCashFlow = value;
               }
	          }
        public bool IsVaAlCashFlowNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsVaAlCashFlowNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 ChequeraPredeter {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["ChequeraPredeter"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ChequeraPredeter;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ChequeraPredeter = value;
               }
	          }
        public bool IsChequeraPredeterNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsChequeraPredeterNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public Int32 CantRenglones {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["CantRenglones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CantRenglones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CantRenglones = value;
               }
	          }
        public bool IsCantRenglonesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCantRenglonesNull();
             }
	        }
        public String numCuenta {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["numCuenta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].numCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].numCuenta = value;
               }
	          }
        public bool IsnumCuentaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsnumCuentaNull();
             }
	        }
        public String CtaContDiferido {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["CtaContDiferido"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaContDiferido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaContDiferido = value;
               }
	          }
        public bool IsCtaContDiferidoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCtaContDiferidoNull();
             }
	        }
        public String DescripcionCtaContDiferido {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["DescripcionCtaContDiferido"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCtaContDiferido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].DescripcionCtaContDiferido = value;
               }
	          }
        public bool IsDescripcionCtaContDiferidoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsDescripcionCtaContDiferidoNull();
             }
	        }
        public Decimal MaximoLibrado {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["MaximoLibrado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].MaximoLibrado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].MaximoLibrado = value;
               }
	          }
        public bool IsMaximoLibradoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsMaximoLibradoNull();
             }
	        }
        public Decimal ValorComision {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["ValorComision"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ValorComision;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].ValorComision = value;
               }
	          }
        public bool IsValorComisionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsValorComisionNull();
             }
	        }
        public Decimal LimCredVtaCheques {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["LimCredVtaCheques"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].LimCredVtaCheques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].LimCredVtaCheques = value;
               }
	          }
        public bool IsLimCredVtaChequesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsLimCredVtaChequesNull();
             }
	        }
        public Decimal CtaCorto {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["CtaCorto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaCorto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].CtaCorto = value;
               }
	          }
        public bool IsCtaCortoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsCtaCortoNull();
             }
	        }
        public Int32 Formulario_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String Referencia {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String RepoCheq_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["RepoCheq_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].RepoCheq_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].RepoCheq_Id = value;
               }
	          }
        public bool IsRepoCheq_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsRepoCheq_IdNull();
             }
	        }
        public String TituloRepoCheq {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["TituloRepoCheq"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TituloRepoCheq;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TituloRepoCheq = value;
               }
	          }
        public bool IsTituloRepoCheqNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsTituloRepoCheqNull();
             }
	        }
        public String RepoCheqDif_Id {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["RepoCheqDif_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].RepoCheqDif_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].RepoCheqDif_Id = value;
               }
	          }
        public bool IsRepoCheqDif_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsRepoCheqDif_IdNull();
             }
	        }
        public String TituloRepoCheqDif {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["TituloRepoCheqDif"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TituloRepoCheqDif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].TituloRepoCheqDif = value;
               }
	          }
        public bool IsTituloRepoCheqDifNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsTituloRepoCheqDifNull();
             }
	        }
        public String FormaDePagoP {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["FormaDePagoP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].FormaDePagoP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].FormaDePagoP = value;
               }
	          }
        public bool IsFormaDePagoPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsFormaDePagoPNull();
             }
	        }
        public Int32 OrdenPtoVta {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["OrdenPtoVta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].OrdenPtoVta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].OrdenPtoVta = value;
               }
	          }
        public bool IsOrdenPtoVtaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsOrdenPtoVtaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdBancoPropioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdBancoPropioDS );
     }
     public tesIdBancoPropioActionExchange() : base( "tesIdBancoPropio" ) {
     }

     public tesIdBancoPropioActionExchange(tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction pAccion) : base(tesIdBancoPropioActionEnum.GetAcciontesIdBancoPropioAction(pAccion)) {
     }

     public tesIdBancoPropioActionExchange(tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction pAccion, TesoreriaCommon.tesIdBancoPropioDS pdsParam) : base(tesIdBancoPropioActionEnum.GetAcciontesIdBancoPropioAction(pAccion), pdsParam) {
     }

     public tesIdBancoPropioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdBancoPropioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesIdBancoPropioActionExchange(TesoreriaCommon.tesIdBancoPropioDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesIdBancoPropioDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdBancoPropioDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdBancoPropioDS)mParam;
	        }
     }
  }
}
