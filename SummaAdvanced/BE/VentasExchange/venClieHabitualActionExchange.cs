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
    public class venClieHabitualActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String Cliente_Id_Nueva {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Cliente_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cliente_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cliente_Id_Nueva = value;
               }
	          }
        public bool IsCliente_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCliente_Id_NuevaNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String CUIT {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Int32 SucursalPredeter {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["SucursalPredeter"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].SucursalPredeter;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].SucursalPredeter = value;
               }
	          }
        public bool IsSucursalPredeterNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsSucursalPredeterNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public String MonedaLimCred {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["MonedaLimCred"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MonedaLimCred;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MonedaLimCred = value;
               }
	          }
        public bool IsMonedaLimCredNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsMonedaLimCredNull();
             }
	        }
        public String CategCred_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CategCred_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CategCred_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CategCred_Id = value;
               }
	          }
        public bool IsCategCred_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCategCred_IdNull();
             }
	        }
        public String DescripcionCategCredito {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCategCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCategCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCategCredito = value;
               }
	          }
        public bool IsDescripcionCategCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCategCreditoNull();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Boolean Puntual {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Puntual"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Puntual;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Puntual = value;
               }
	          }
        public bool IsPuntualNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsPuntualNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionClieEstados {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionClieEstados"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionClieEstados;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionClieEstados = value;
               }
	          }
        public bool IsDescripcionClieEstadosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionClieEstadosNull();
             }
	        }
        public Boolean GeneraDebito {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["GeneraDebito"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].GeneraDebito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].GeneraDebito = value;
               }
	          }
        public bool IsGeneraDebitoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsGeneraDebitoNull();
             }
	        }
        public Boolean Siempre {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Siempre"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Siempre;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Siempre = value;
               }
	          }
        public bool IsSiempreNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsSiempreNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public String IBrutos {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["IBrutos"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IBrutos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IBrutos = value;
               }
	          }
        public bool IsIBrutosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsIBrutosNull();
             }
	        }
        public String Situacion {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Situacion"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Situacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Situacion = value;
               }
	          }
        public bool IsSituacionNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsSituacionNull();
             }
	        }
        public Boolean FacturaCredito {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["FacturaCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FacturaCredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FacturaCredito = value;
               }
	          }
        public bool IsFacturaCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFacturaCreditoNull();
             }
	        }
        public Decimal MontoFacturaCredito {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["MontoFacturaCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MontoFacturaCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MontoFacturaCredito = value;
               }
	          }
        public bool IsMontoFacturaCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsMontoFacturaCreditoNull();
             }
	        }
        public String CbuBanco {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CbuBanco"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CbuBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CbuBanco = value;
               }
	          }
        public bool IsCbuBancoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCbuBancoNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String Direccion1_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Direccion1_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion1_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion1_Fact = value;
               }
	          }
        public bool IsDireccion1_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDireccion1_FactNull();
             }
	        }
        public String Direccion2_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Direccion2_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion2_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion2_Fact = value;
               }
	          }
        public bool IsDireccion2_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDireccion2_FactNull();
             }
	        }
        public String Localidad_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Localidad_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Localidad_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Localidad_Fact = value;
               }
	          }
        public bool IsLocalidad_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLocalidad_FactNull();
             }
	        }
        public String CodPostal_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CodPostal_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CodPostal_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CodPostal_Fact = value;
               }
	          }
        public bool IsCodPostal_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCodPostal_FactNull();
             }
	        }
        public String Provincia_Id_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Provincia_Id_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Provincia_Id_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Provincia_Id_Fact = value;
               }
	          }
        public bool IsProvincia_Id_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsProvincia_Id_FactNull();
             }
	        }
        public String DescripcionProvincia_Id_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionProvincia_Id_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionProvincia_Id_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionProvincia_Id_Fact = value;
               }
	          }
        public bool IsDescripcionProvincia_Id_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionProvincia_Id_FactNull();
             }
	        }
        public Int16 Pais_Id_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Pais_Id_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Pais_Id_Fact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Pais_Id_Fact = value;
               }
	          }
        public bool IsPais_Id_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsPais_Id_FactNull();
             }
	        }
        public String DescripcionPais_Id_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionPais_Id_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionPais_Id_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionPais_Id_Fact = value;
               }
	          }
        public bool IsDescripcionPais_Id_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionPais_Id_FactNull();
             }
	        }
        public String Telefonos {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Telefonos"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Telefonos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Telefonos = value;
               }
	          }
        public bool IsTelefonosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsTelefonosNull();
             }
	        }
        public String Fax {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Fax"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Fax;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Fax = value;
               }
	          }
        public bool IsFaxNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFaxNull();
             }
	        }
        public String EMail {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["EMail"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].EMail;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].EMail = value;
               }
	          }
        public bool IsEMailNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsEMailNull();
             }
	        }
        public String Direccion1_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Direccion1_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion1_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion1_Entr = value;
               }
	          }
        public bool IsDireccion1_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDireccion1_EntrNull();
             }
	        }
        public String Direccion2_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Direccion2_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion2_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Direccion2_Entr = value;
               }
	          }
        public bool IsDireccion2_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDireccion2_EntrNull();
             }
	        }
        public String Localidad_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Localidad_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Localidad_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Localidad_Entr = value;
               }
	          }
        public bool IsLocalidad_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLocalidad_EntrNull();
             }
	        }
        public String CodPostal_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CodPostal_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CodPostal_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CodPostal_Entr = value;
               }
	          }
        public bool IsCodPostal_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCodPostal_EntrNull();
             }
	        }
        public String Provincia_Id_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Provincia_Id_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Provincia_Id_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Provincia_Id_Entr = value;
               }
	          }
        public bool IsProvincia_Id_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsProvincia_Id_EntrNull();
             }
	        }
        public String DescripcionProvincia_Id_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionProvincia_Id_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionProvincia_Id_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionProvincia_Id_Entr = value;
               }
	          }
        public bool IsDescripcionProvincia_Id_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionProvincia_Id_EntrNull();
             }
	        }
        public Int16 Pais_Id_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Pais_Id_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Pais_Id_Entr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Pais_Id_Entr = value;
               }
	          }
        public bool IsPais_Id_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsPais_Id_EntrNull();
             }
	        }
        public String DescripcionPais_Id_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionPais_Id_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionPais_Id_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionPais_Id_Entr = value;
               }
	          }
        public bool IsDescripcionPais_Id_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionPais_Id_EntrNull();
             }
	        }
        public String TipoClie_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["TipoClie_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].TipoClie_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].TipoClie_Id = value;
               }
	          }
        public bool IsTipoClie_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsTipoClie_IdNull();
             }
	        }
        public String DescripcionTiposClie {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionTiposClie"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionTiposClie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionTiposClie = value;
               }
	          }
        public bool IsDescripcionTiposClieNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionTiposClieNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobradores {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCobradores"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCobradores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCobradores = value;
               }
	          }
        public bool IsDescripcionCobradoresNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCobradoresNull();
             }
	        }
        public String Zona_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Zona_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Zona_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Zona_Id = value;
               }
	          }
        public bool IsZona_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsZona_IdNull();
             }
	        }
        public String DescripcionZona {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionZona"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionZona;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionZona = value;
               }
	          }
        public bool IsDescripcionZonaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionZonaNull();
             }
	        }
        public String Region_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Region_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Region_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Region_Id = value;
               }
	          }
        public bool IsRegion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsRegion_IdNull();
             }
	        }
        public String DescripcionRegion {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionRegion"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionRegion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionRegion = value;
               }
	          }
        public bool IsDescripcionRegionNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionRegionNull();
             }
	        }
        public String Contactos {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Contactos"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Contactos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Contactos = value;
               }
	          }
        public bool IsContactosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsContactosNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaAlta {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["FechaAlta"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaAlta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaAlta = value;
               }
	          }
        public bool IsFechaAltaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFechaAltaNull();
             }
	        }
        public DateTime FechaUltContacto {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["FechaUltContacto"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaUltContacto;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaUltContacto = value;
               }
	          }
        public bool IsFechaUltContactoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFechaUltContactoNull();
             }
	        }
        public DateTime FechaModificacion {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["FechaModificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaModificacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].FechaModificacion = value;
               }
	          }
        public bool IsFechaModificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsFechaModificacionNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal BonificacionS1 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["BonificacionS1"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS1 = value;
               }
	          }
        public bool IsBonificacionS1Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacionS1Null();
             }
	        }
        public Decimal BonificacionS2 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["BonificacionS2"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS2 = value;
               }
	          }
        public bool IsBonificacionS2Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacionS2Null();
             }
	        }
        public Decimal BonificacionS3 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["BonificacionS3"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].BonificacionS3 = value;
               }
	          }
        public bool IsBonificacionS3Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsBonificacionS3Null();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String ClieConsolida {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["ClieConsolida"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].ClieConsolida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].ClieConsolida = value;
               }
	          }
        public bool IsClieConsolidaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsClieConsolidaNull();
             }
	        }
        public String DescripcionClieConsolida {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["DescripcionClieConsolida"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionClieConsolida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].DescripcionClieConsolida = value;
               }
	          }
        public bool IsDescripcionClieConsolidaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDescripcionClieConsolidaNull();
             }
	        }
        public String NroExterior_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NroExterior_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroExterior_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroExterior_Fact = value;
               }
	          }
        public bool IsNroExterior_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNroExterior_FactNull();
             }
	        }
        public String NroInterior_Fact {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NroInterior_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroInterior_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroInterior_Fact = value;
               }
	          }
        public bool IsNroInterior_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNroInterior_FactNull();
             }
	        }
        public String NroExterior_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NroExterior_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroExterior_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroExterior_Entr = value;
               }
	          }
        public bool IsNroExterior_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNroExterior_EntrNull();
             }
	        }
        public String NroInterior_Entr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NroInterior_Entr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroInterior_Entr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NroInterior_Entr = value;
               }
	          }
        public bool IsNroInterior_EntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNroInterior_EntrNull();
             }
	        }
        public String Reclamos {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Reclamos"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Reclamos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Reclamos = value;
               }
	          }
        public bool IsReclamosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsReclamosNull();
             }
	        }
        public String MetodoDePago {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["MetodoDePago"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MetodoDePago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].MetodoDePago = value;
               }
	          }
        public bool IsMetodoDePagoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsMetodoDePagoNull();
             }
	        }
        public String NumCuenta {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["NumCuenta"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NumCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].NumCuenta = value;
               }
	          }
        public bool IsNumCuentaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsNumCuentaNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String C_UsoCFDI {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["C_UsoCFDI"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].C_UsoCFDI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].C_UsoCFDI = value;
               }
	          }
        public bool IsC_UsoCFDINull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsC_UsoCFDINull();
             }
	        }
        public String N_MetodoPago {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["N_MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].N_MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].N_MetodoPago = value;
               }
	          }
        public bool IsN_MetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsN_MetodoPagoNull();
             }
	        }
        public Boolean UsaComplementoINE {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["UsaComplementoINE"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].UsaComplementoINE;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].UsaComplementoINE = value;
               }
	          }
        public bool IsUsaComplementoINENull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsUsaComplementoINENull();
             }
	        }
        public Decimal LimiteCredito1 {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["LimiteCredito1"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LimiteCredito1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LimiteCredito1 = value;
               }
	          }
        public bool IsLimiteCredito1Null {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLimiteCredito1Null();
             }
	        }
        public Decimal LatitudGPS {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["LatitudGPS"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LatitudGPS;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LatitudGPS = value;
               }
	          }
        public bool IsLatitudGPSNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLatitudGPSNull();
             }
	        }
        public Decimal LongitudGPS {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["LongitudGPS"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LongitudGPS;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].LongitudGPS = value;
               }
	          }
        public bool IsLongitudGPSNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsLongitudGPSNull();
             }
	        }
        public String c_ColoniaEntr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["c_ColoniaEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_ColoniaEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_ColoniaEntr = value;
               }
	          }
        public bool Isc_ColoniaEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Isc_ColoniaEntrNull();
             }
	        }
        public String c_LocalidadEntr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["c_LocalidadEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_LocalidadEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_LocalidadEntr = value;
               }
	          }
        public bool Isc_LocalidadEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Isc_LocalidadEntrNull();
             }
	        }
        public String c_MunicipioEntr {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["c_MunicipioEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_MunicipioEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].c_MunicipioEntr = value;
               }
	          }
        public bool Isc_MunicipioEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Isc_MunicipioEntrNull();
             }
	        }
        public String Regimen {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Regimen"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Regimen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Regimen = value;
               }
	          }
        public bool IsRegimenNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsRegimenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClieHabitualDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieHabitualDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClieHabitualDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClieHabitualDS );
     }
     public venClieHabitualActionExchange() : base( "venClieHabitual" ) {
     }

     public venClieHabitualActionExchange(venClieHabitualActionEnum.EnumvenClieHabitualAction pAccion) : base(venClieHabitualActionEnum.GetAccionvenClieHabitualAction(pAccion)) {
     }

     public venClieHabitualActionExchange(venClieHabitualActionEnum.EnumvenClieHabitualAction pAccion, VentasCommon.venClieHabitualDS pdsParam) : base(venClieHabitualActionEnum.GetAccionvenClieHabitualAction(pAccion), pdsParam) {
     }

     public venClieHabitualActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClieHabitualDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venClieHabitualActionExchange(VentasCommon.venClieHabitualDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venClieHabitualDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClieHabitualDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClieHabitualDS)mParam;
	        }
     }
  }
}
