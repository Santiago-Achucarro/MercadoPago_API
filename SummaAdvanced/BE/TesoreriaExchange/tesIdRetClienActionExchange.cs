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
    public class tesIdRetClienActionExchange : Framework.Core.Exchange{

        public Int32 tesIdentifica {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["tesIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].tesIdentifica;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].tesIdentifica = value;
               }
	          }
        public bool IstesIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IstesIdentificaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String Cartera_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Cartera_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cartera_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cartera_Id_Nueva = value;
               }
	          }
        public bool IsCartera_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCartera_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpreas {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["PTodasEmpreas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].PTodasEmpreas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].PTodasEmpreas = value;
               }
	          }
        public bool IsPTodasEmpreasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsPTodasEmpreasNull();
             }
	        }
        public String TipoCartera {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["TipoCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].TipoCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].TipoCartera = value;
               }
	          }
        public bool IsTipoCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsTipoCarteraNull();
             }
	        }
        public String DescripcionTiposId {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionTiposId"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionTiposId;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionTiposId = value;
               }
	          }
        public bool IsDescripcionTiposIdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionTiposIdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String UsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["UsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].UsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].UsuarioAmo = value;
               }
	          }
        public bool IsUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsUsuarioAmoNull();
             }
	        }
        public String DescripcionUsuarioAmo {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionUsuarioAmo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionUsuarioAmo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionUsuarioAmo = value;
               }
	          }
        public bool IsDescripcionUsuarioAmoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionUsuarioAmoNull();
             }
	        }
        public Boolean ModiCent1 {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["ModiCent1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].ModiCent1;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].ModiCent1 = value;
               }
	          }
        public bool IsModiCent1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsModiCent1Null();
             }
	        }
        public Boolean ModiCent2 {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["ModiCent2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].ModiCent2;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].ModiCent2 = value;
               }
	          }
        public bool IsModiCent2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsModiCent2Null();
             }
	        }
        public String CtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["CtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].CtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].CtaValEnTransito = value;
               }
	          }
        public bool IsCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsCtaValEnTransitoNull();
             }
	        }
        public String DescripcionCtaValEnTransito {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionCtaValEnTransito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCtaValEnTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionCtaValEnTransito = value;
               }
	          }
        public bool IsDescripcionCtaValEnTransitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionCtaValEnTransitoNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public Boolean VaAlCashFlow {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["VaAlCashFlow"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].VaAlCashFlow;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].VaAlCashFlow = value;
               }
	          }
        public bool IsVaAlCashFlowNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsVaAlCashFlowNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean vaSubDiarioVta {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["vaSubDiarioVta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].vaSubDiarioVta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].vaSubDiarioVta = value;
               }
	          }
        public bool IsvaSubDiarioVtaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsvaSubDiarioVtaNull();
             }
	        }
        public Int32 TipoImpuesto {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["TipoImpuesto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].TipoImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].TipoImpuesto = value;
               }
	          }
        public bool IsTipoImpuestoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsTipoImpuestoNull();
             }
	        }
        public String DescripcionTipoImpuesto {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["DescripcionTipoImpuesto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionTipoImpuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].DescripcionTipoImpuesto = value;
               }
	          }
        public bool IsDescripcionTipoImpuestoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsDescripcionTipoImpuestoNull();
             }
	        }
        public Decimal NroResSicore {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["NroResSicore"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].NroResSicore;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].NroResSicore = value;
               }
	          }
        public bool IsNroResSicoreNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsNroResSicoreNull();
             }
	        }
        public String FormaDePagoP {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["FormaDePagoP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].FormaDePagoP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].FormaDePagoP = value;
               }
	          }
        public bool IsFormaDePagoPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsFormaDePagoPNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdRetClienDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdRetClienDS );
     }
     public tesIdRetClienActionExchange() : base( "tesIdRetClien" ) {
     }

     public tesIdRetClienActionExchange(tesIdRetClienActionEnum.EnumtesIdRetClienAction pAccion) : base(tesIdRetClienActionEnum.GetAcciontesIdRetClienAction(pAccion)) {
     }

     public tesIdRetClienActionExchange(tesIdRetClienActionEnum.EnumtesIdRetClienAction pAccion, TesoreriaCommon.tesIdRetClienDS pdsParam) : base(tesIdRetClienActionEnum.GetAcciontesIdRetClienAction(pAccion), pdsParam) {
     }

     public tesIdRetClienActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdRetClienDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdRetClienDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdRetClienDS)mParam;
	        }
     }
  }
}
