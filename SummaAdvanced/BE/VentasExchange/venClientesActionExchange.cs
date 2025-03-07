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
    public class venClientesActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String CUIT {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String Cliente_Id_Nueva {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Cliente_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Cliente_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Cliente_Id_Nueva = value;
               }
	          }
        public bool IsCliente_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCliente_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Int32 SucursalPredeter {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["SucursalPredeter"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].SucursalPredeter;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].SucursalPredeter = value;
               }
	          }
        public bool IsSucursalPredeterNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsSucursalPredeterNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public String MonedaLimCred {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["MonedaLimCred"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].MonedaLimCred;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].MonedaLimCred = value;
               }
	          }
        public bool IsMonedaLimCredNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsMonedaLimCredNull();
             }
	        }
        public String CategCred_Id {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["CategCred_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].CategCred_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].CategCred_Id = value;
               }
	          }
        public bool IsCategCred_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCategCred_IdNull();
             }
	        }
        public String DescripcionCategCredito {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["DescripcionCategCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionCategCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionCategCredito = value;
               }
	          }
        public bool IsDescripcionCategCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsDescripcionCategCreditoNull();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Boolean Puntual {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Puntual"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Puntual;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Puntual = value;
               }
	          }
        public bool IsPuntualNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsPuntualNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionClieEstados {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["DescripcionClieEstados"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionClieEstados;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].DescripcionClieEstados = value;
               }
	          }
        public bool IsDescripcionClieEstadosNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsDescripcionClieEstadosNull();
             }
	        }
        public Boolean GeneraDebito {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["GeneraDebito"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].GeneraDebito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].GeneraDebito = value;
               }
	          }
        public bool IsGeneraDebitoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsGeneraDebitoNull();
             }
	        }
        public Boolean Siempre {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Siempre"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Siempre;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Siempre = value;
               }
	          }
        public bool IsSiempreNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsSiempreNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public String IBrutos {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["IBrutos"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].IBrutos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].IBrutos = value;
               }
	          }
        public bool IsIBrutosNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsIBrutosNull();
             }
	        }
        public String Situacion {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Situacion"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Situacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Situacion = value;
               }
	          }
        public bool IsSituacionNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsSituacionNull();
             }
	        }
        public Boolean FacturaCredito {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["FacturaCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].FacturaCredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].FacturaCredito = value;
               }
	          }
        public bool IsFacturaCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsFacturaCreditoNull();
             }
	        }
        public Decimal MontoFacturaCredito {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["MontoFacturaCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].MontoFacturaCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].MontoFacturaCredito = value;
               }
	          }
        public bool IsMontoFacturaCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsMontoFacturaCreditoNull();
             }
	        }
        public String CbuBanco {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["CbuBanco"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].CbuBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].CbuBanco = value;
               }
	          }
        public bool IsCbuBancoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsCbuBancoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Regimen {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Regimen"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Regimen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Regimen = value;
               }
	          }
        public bool IsRegimenNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsRegimenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClientesDS );
     }
     public venClientesActionExchange() : base( "venClientes" ) {
     }

     public venClientesActionExchange(venClientesActionEnum.EnumvenClientesAction pAccion) : base(venClientesActionEnum.GetAccionvenClientesAction(pAccion)) {
     }

     public venClientesActionExchange(venClientesActionEnum.EnumvenClientesAction pAccion, VentasCommon.venClientesDS pdsParam) : base(venClientesActionEnum.GetAccionvenClientesAction(pAccion), pdsParam) {
     }

     public venClientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venClientesActionExchange(VentasCommon.venClientesDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venClientesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClientesDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClientesDS)mParam;
	        }
     }
  }
}
