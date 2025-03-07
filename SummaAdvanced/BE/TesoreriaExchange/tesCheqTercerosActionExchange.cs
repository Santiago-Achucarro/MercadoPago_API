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
    public class tesCheqTercerosActionExchange : Framework.Core.Exchange{

        public Int32 tesCheqTerceros {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["tesCheqTerceros"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].tesCheqTerceros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].tesCheqTerceros = value;
               }
	          }
        public bool IstesCheqTercerosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IstesCheqTercerosNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdentifica {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["DescripcionIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionIdentifica;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionIdentifica = value;
               }
	          }
        public bool IsDescripcionIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsDescripcionIdentificaNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public String Clearing {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Clearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Clearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Clearing = value;
               }
	          }
        public bool IsClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsClearingNull();
             }
	        }
        public String DescripcionClearing {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["DescripcionClearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionClearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionClearing = value;
               }
	          }
        public bool IsDescripcionClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsDescripcionClearingNull();
             }
	        }
        public Int16 SecuenciaActual {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["SecuenciaActual"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].SecuenciaActual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].SecuenciaActual = value;
               }
	          }
        public bool IsSecuenciaActualNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsSecuenciaActualNull();
             }
	        }
        public Int16 ClearingDias {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["ClearingDias"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].ClearingDias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].ClearingDias = value;
               }
	          }
        public bool IsClearingDiasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsClearingDiasNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public DateTime FechaAcreditacion {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["FechaAcreditacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaAcreditacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaAcreditacion = value;
               }
	          }
        public bool IsFechaAcreditacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsFechaAcreditacionNull();
             }
	        }
        public DateTime FechaConciliacion {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["FechaConciliacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaConciliacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].FechaConciliacion = value;
               }
	          }
        public bool IsFechaConciliacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsFechaConciliacionNull();
             }
	        }
        public String sucBanco {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["sucBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].sucBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].sucBanco = value;
               }
	          }
        public bool IssucBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IssucBancoNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionCheqTerEstado {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["DescripcionCheqTerEstado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionCheqTerEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionCheqTerEstado = value;
               }
	          }
        public bool IsDescripcionCheqTerEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsDescripcionCheqTerEstadoNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String DescripcionClientes {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["DescripcionClientes"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionClientes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].DescripcionClientes = value;
               }
	          }
        public bool IsDescripcionClientesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsDescripcionClientesNull();
             }
	        }
        public String cuentaBanco {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["cuentaBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].cuentaBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].cuentaBanco = value;
               }
	          }
        public bool IscuentaBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IscuentaBancoNull();
             }
	        }
        public String BancoConc {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["BancoConc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].BancoConc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].BancoConc = value;
               }
	          }
        public bool IsBancoConcNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsBancoConcNull();
             }
	        }
        public Int32 NumeroConc {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["NumeroConc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].NumeroConc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].NumeroConc = value;
               }
	          }
        public bool IsNumeroConcNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsNumeroConcNull();
             }
	        }
        public String BancoConcVta {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["BancoConcVta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].BancoConcVta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].BancoConcVta = value;
               }
	          }
        public bool IsBancoConcVtaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsBancoConcVtaNull();
             }
	        }
        public Int32 NumeroConcVta {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["NumeroConcVta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].NumeroConcVta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].NumeroConcVta = value;
               }
	          }
        public bool IsNumeroConcVtaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsNumeroConcVtaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqTercerosDS );
     }
     public tesCheqTercerosActionExchange() : base( "tesCheqTerceros" ) {
     }

     public tesCheqTercerosActionExchange(tesCheqTercerosActionEnum.EnumtesCheqTercerosAction pAccion) : base(tesCheqTercerosActionEnum.GetAcciontesCheqTercerosAction(pAccion)) {
     }

     public tesCheqTercerosActionExchange(tesCheqTercerosActionEnum.EnumtesCheqTercerosAction pAccion, TesoreriaCommon.tesCheqTercerosDS pdsParam) : base(tesCheqTercerosActionEnum.GetAcciontesCheqTercerosAction(pAccion), pdsParam) {
     }

     public tesCheqTercerosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqTercerosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqTercerosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqTercerosDS)mParam;
	        }
     }
  }
}
