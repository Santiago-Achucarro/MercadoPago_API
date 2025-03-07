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
    public class tesCheqPropActionExchange : Framework.Core.Exchange{

        public Int32 tesCheqProp {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["tesCheqProp"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].tesCheqProp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].tesCheqProp = value;
               }
	          }
        public bool IstesCheqPropNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IstesCheqPropNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdBancoPropio {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["DescripcionIdBancoPropio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionIdBancoPropio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionIdBancoPropio = value;
               }
	          }
        public bool IsDescripcionIdBancoPropioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsDescripcionIdBancoPropioNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public Int32 numCheque_Nueva {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["numCheque_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].numCheque_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].numCheque_Nueva = value;
               }
	          }
        public bool IsnumCheque_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsnumCheque_NuevaNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public DateTime FechaDebito {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["FechaDebito"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].FechaDebito;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].FechaDebito = value;
               }
	          }
        public bool IsFechaDebitoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsFechaDebitoNull();
             }
	        }
        public String aLaOrden {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["aLaOrden"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].aLaOrden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].aLaOrden = value;
               }
	          }
        public bool IsaLaOrdenNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsaLaOrdenNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionCheqPropEstado {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["DescripcionCheqPropEstado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionCheqPropEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionCheqPropEstado = value;
               }
	          }
        public bool IsDescripcionCheqPropEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsDescripcionCheqPropEstadoNull();
             }
	        }
        public Int16 SecuenciaActual {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["SecuenciaActual"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].SecuenciaActual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].SecuenciaActual = value;
               }
	          }
        public bool IsSecuenciaActualNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsSecuenciaActualNull();
             }
	        }
        public String Cuit {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String CuentaDestino {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["CuentaDestino"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].CuentaDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].CuentaDestino = value;
               }
	          }
        public bool IsCuentaDestinoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsCuentaDestinoNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public String BancoDestinoExt {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["BancoDestinoExt"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].BancoDestinoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].BancoDestinoExt = value;
               }
	          }
        public bool IsBancoDestinoExtNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsBancoDestinoExtNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqPropDS );
     }
     public tesCheqPropActionExchange() : base( "tesCheqProp" ) {
     }

     public tesCheqPropActionExchange(tesCheqPropActionEnum.EnumtesCheqPropAction pAccion) : base(tesCheqPropActionEnum.GetAcciontesCheqPropAction(pAccion)) {
     }

     public tesCheqPropActionExchange(tesCheqPropActionEnum.EnumtesCheqPropAction pAccion, TesoreriaCommon.tesCheqPropDS pdsParam) : base(tesCheqPropActionEnum.GetAcciontesCheqPropAction(pAccion), pdsParam) {
     }

     public tesCheqPropActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqPropDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqPropDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqPropDS)mParam;
	        }
     }
  }
}
