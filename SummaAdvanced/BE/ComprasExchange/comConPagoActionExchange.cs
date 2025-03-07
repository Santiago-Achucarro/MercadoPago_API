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
    public class comConPagoActionExchange : Framework.Core.Exchange{

        public Int32 comConPago {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["comConPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].comConPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].comConPago = value;
               }
	          }
        public bool IscomConPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IscomConPagoNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String CondPago_Id_Nueva {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["CondPago_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].CondPago_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].CondPago_Id_Nueva = value;
               }
	          }
        public bool IsCondPago_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsCondPago_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Desde {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Desde"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Desde = value;
               }
	          }
        public bool IsDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsDesdeNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Int32 CantidadCuotas {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["CantidadCuotas"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].CantidadCuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].CantidadCuotas = value;
               }
	          }
        public bool IsCantidadCuotasNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsCantidadCuotasNull();
             }
	        }
        public Boolean AplicaFactCredito {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["AplicaFactCredito"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].AplicaFactCredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].AplicaFactCredito = value;
               }
	          }
        public bool IsAplicaFactCreditoNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsAplicaFactCreditoNull();
             }
	        }
        public Boolean AdmiteFactPagoAdel {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["AdmiteFactPagoAdel"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].AdmiteFactPagoAdel;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].AdmiteFactPagoAdel = value;
               }
	          }
        public bool IsAdmiteFactPagoAdelNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsAdmiteFactPagoAdelNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comConPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comConPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comConPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comConPagoDS );
     }
     public comConPagoActionExchange() : base( "comConPago" ) {
     }

     public comConPagoActionExchange(comConPagoActionEnum.EnumcomConPagoAction pAccion) : base(comConPagoActionEnum.GetAccioncomConPagoAction(pAccion)) {
     }

     public comConPagoActionExchange(comConPagoActionEnum.EnumcomConPagoAction pAccion, ComprasCommon.comConPagoDS pdsParam) : base(comConPagoActionEnum.GetAccioncomConPagoAction(pAccion), pdsParam) {
     }

     public comConPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comConPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comConPagoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comConPagoDS)mParam;
	        }
     }
  }
}
