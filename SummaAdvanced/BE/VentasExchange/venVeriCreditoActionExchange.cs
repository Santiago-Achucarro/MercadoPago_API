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
    public class venVeriCreditoActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Decimal ImporteASumar {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["ImporteASumar"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].ImporteASumar;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].ImporteASumar = value;
               }
	          }
        public bool IsImporteASumarNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsImporteASumarNull();
             }
	        }
        public Decimal Disponible {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["Disponible"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Disponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Disponible = value;
               }
	          }
        public bool IsDisponibleNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsDisponibleNull();
             }
	        }
        public Decimal PorcDeudaVencida {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["PorcDeudaVencida"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].PorcDeudaVencida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].PorcDeudaVencida = value;
               }
	          }
        public bool IsPorcDeudaVencidaNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsPorcDeudaVencidaNull();
             }
	        }
        public Int32 Antiguedad {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["Antiguedad"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Antiguedad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].Antiguedad = value;
               }
	          }
        public bool IsAntiguedadNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsAntiguedadNull();
             }
	        }
        public Decimal TotalEnCtaCte {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["TotalEnCtaCte"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].TotalEnCtaCte;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].TotalEnCtaCte = value;
               }
	          }
        public bool IsTotalEnCtaCteNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsTotalEnCtaCteNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public String ClienteAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["ClienteAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].ClienteAnt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].ClienteAnt = value;
               }
	          }
        public bool IsClienteAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsClienteAntNull();
             }
	        }
        public Decimal SaldoCtaCteAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["SaldoCtaCteAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoCtaCteAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoCtaCteAnt = value;
               }
	          }
        public bool IsSaldoCtaCteAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsSaldoCtaCteAntNull();
             }
	        }
        public Boolean TieneMovimientosTipoAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["TieneMovimientosTipoAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].TieneMovimientosTipoAnt;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].TieneMovimientosTipoAnt = value;
               }
	          }
        public bool IsTieneMovimientosTipoAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsTieneMovimientosTipoAntNull();
             }
	        }
        public Decimal SaldoDocumentoAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["SaldoDocumentoAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoDocumentoAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoDocumentoAnt = value;
               }
	          }
        public bool IsSaldoDocumentoAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsSaldoDocumentoAntNull();
             }
	        }
        public Decimal SaldoCtaCteVencidaAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["SaldoCtaCteVencidaAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoCtaCteVencidaAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].SaldoCtaCteVencidaAnt = value;
               }
	          }
        public bool IsSaldoCtaCteVencidaAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsSaldoCtaCteVencidaAntNull();
             }
	        }
        public Int32 MaxAntiguedadAnt {
            get {
                if(((VentasCommon.venVeriCreditoDS)mParam).Principal[0]["MaxAntiguedadAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].MaxAntiguedadAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].MaxAntiguedadAnt = value;
               }
	          }
        public bool IsMaxAntiguedadAntNull {
             get {
                 return mParam==null || ((VentasCommon.venVeriCreditoDS)mParam).Principal[0].IsMaxAntiguedadAntNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venVeriCreditoDS );
     }
     public venVeriCreditoActionExchange() : base( "venVeriCredito" ) {
     }

     public venVeriCreditoActionExchange(venVeriCreditoActionEnum.EnumvenVeriCreditoAction pAccion) : base(venVeriCreditoActionEnum.GetAccionvenVeriCreditoAction(pAccion)) {
     }

     public venVeriCreditoActionExchange(venVeriCreditoActionEnum.EnumvenVeriCreditoAction pAccion, VentasCommon.venVeriCreditoDS pdsParam) : base(venVeriCreditoActionEnum.GetAccionvenVeriCreditoAction(pAccion), pdsParam) {
     }

     public venVeriCreditoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venVeriCreditoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venVeriCreditoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venVeriCreditoDS)mParam;
	        }
     }
  }
}
