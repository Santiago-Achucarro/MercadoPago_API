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
    public class comMovImpAcreditaActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 RenglonDebe {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["RenglonDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenglonDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenglonDebe = value;
               }
	          }
        public bool IsRenglonDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsRenglonDebeNull();
             }
	        }
        public Int32 RenglonHaber {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["RenglonHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenglonHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenglonHaber = value;
               }
	          }
        public bool IsRenglonHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsRenglonHaberNull();
             }
	        }
        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdentifica {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["DescripcionIdentifica"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DescripcionIdentifica;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DescripcionIdentifica = value;
               }
	          }
        public bool IsDescripcionIdentificaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsDescripcionIdentificaNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Decimal TotalPago {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["TotalPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].TotalPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].TotalPago = value;
               }
	          }
        public bool IsTotalPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsTotalPagoNull();
             }
	        }
        public String Origen {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Origen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public Decimal DifCambio {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["DifCambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DifCambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].DifCambio = value;
               }
	          }
        public bool IsDifCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsDifCambioNull();
             }
	        }
        public Int32 RenDifCambio {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["RenDifCambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenDifCambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].RenDifCambio = value;
               }
	          }
        public bool IsRenDifCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsRenDifCambioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpAcreditaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovImpAcreditaDS );
     }
     public comMovImpAcreditaActionExchange() : base( "comMovImpAcredita" ) {
     }

     public comMovImpAcreditaActionExchange(comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction pAccion) : base(comMovImpAcreditaActionEnum.GetAccioncomMovImpAcreditaAction(pAccion)) {
     }

     public comMovImpAcreditaActionExchange(comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction pAccion, ComprasCommon.comMovImpAcreditaDS pdsParam) : base(comMovImpAcreditaActionEnum.GetAccioncomMovImpAcreditaAction(pAccion), pdsParam) {
     }

     public comMovImpAcreditaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovImpAcreditaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovImpAcreditaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovImpAcreditaDS)mParam;
	        }
     }
  }
}
