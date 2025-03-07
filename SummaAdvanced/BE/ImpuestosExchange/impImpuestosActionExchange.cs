using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impImpuestosActionExchange : Framework.Core.Exchange{

        public Int32 impImpuestos {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["impImpuestos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].impImpuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].impImpuestos = value;
               }
	          }
        public bool IsimpImpuestosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsimpImpuestosNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String Impuesto_Id_Nueva {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Impuesto_Id_Nueva"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva = value;
               }
	          }
        public bool IsImpuesto_Id_NuevaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsImpuesto_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String TipoVencimiento {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["TipoVencimiento"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].TipoVencimiento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].TipoVencimiento = value;
               }
	          }
        public bool IsTipoVencimientoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsTipoVencimientoNull();
             }
	        }
        public Int16 DiaMesVence {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["DiaMesVence"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DiaMesVence;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DiaMesVence = value;
               }
	          }
        public bool IsDiaMesVenceNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsDiaMesVenceNull();
             }
	        }
        public Int16 AvisarNDias {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["AvisarNDias"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].AvisarNDias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].AvisarNDias = value;
               }
	          }
        public bool IsAvisarNDiasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsAvisarNDiasNull();
             }
	        }
        public DateTime ProximoVencimiento {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["ProximoVencimiento"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].ProximoVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].ProximoVencimiento = value;
               }
	          }
        public bool IsProximoVencimientoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsProximoVencimientoNull();
             }
	        }
        public String CuentaHaber {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["CuentaHaber"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].CuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].CuentaHaber = value;
               }
	          }
        public bool IsCuentaHaberNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsCuentaHaberNull();
             }
	        }
        public String DescripcionCuentaHaber {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["DescripcionCuentaHaber"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DescripcionCuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DescripcionCuentaHaber = value;
               }
	          }
        public bool IsDescripcionCuentaHaberNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsDescripcionCuentaHaberNull();
             }
	        }
        public String CuentaDebe {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["CuentaDebe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].CuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].CuentaDebe = value;
               }
	          }
        public bool IsCuentaDebeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsCuentaDebeNull();
             }
	        }
        public String DescripcionCuentaDebe {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["DescripcionCuentaDebe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DescripcionCuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].DescripcionCuentaDebe = value;
               }
	          }
        public bool IsDescripcionCuentaDebeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsDescripcionCuentaDebeNull();
             }
	        }
        public Boolean PagoAnticipado {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["PagoAnticipado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].PagoAnticipado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].PagoAnticipado = value;
               }
	          }
        public bool IsPagoAnticipadoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsPagoAnticipadoNull();
             }
	        }
        public Boolean SePaga {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["SePaga"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].SePaga;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].SePaga = value;
               }
	          }
        public bool IsSePagaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsSePagaNull();
             }
	        }
        public Boolean VaAlCashFlow {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["VaAlCashFlow"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].VaAlCashFlow;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].VaAlCashFlow = value;
               }
	          }
        public bool IsVaAlCashFlowNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsVaAlCashFlowNull();
             }
	        }
        public DateTime LiquidadoHasta {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["LiquidadoHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].LiquidadoHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].LiquidadoHasta = value;
               }
	          }
        public bool IsLiquidadoHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsLiquidadoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impImpuestosDS );
     }
     public impImpuestosActionExchange() : base( "impImpuestos" ) {
     }

     public impImpuestosActionExchange(impImpuestosActionEnum.EnumimpImpuestosAction pAccion) : base(impImpuestosActionEnum.GetAccionimpImpuestosAction(pAccion)) {
     }

     public impImpuestosActionExchange(impImpuestosActionEnum.EnumimpImpuestosAction pAccion, ImpuestosCommon.impImpuestosDS pdsParam) : base(impImpuestosActionEnum.GetAccionimpImpuestosAction(pAccion), pdsParam) {
     }

     public impImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impImpuestosDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impImpuestosDS)mParam;
	        }
     }
  }
}
