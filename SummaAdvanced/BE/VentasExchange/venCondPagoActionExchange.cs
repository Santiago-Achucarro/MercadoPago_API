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
    public class venCondPagoActionExchange : Framework.Core.Exchange{

        public Int32 venCondPago {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["venCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].venCondPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].venCondPago = value;
               }
	          }
        public bool IsvenCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsvenCondPagoNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String CondPagoCli_Id_Nueva {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["CondPagoCli_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].CondPagoCli_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].CondPagoCli_Id_Nueva = value;
               }
	          }
        public bool IsCondPagoCli_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsCondPagoCli_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 CantCuotas {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["CantCuotas"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].CantCuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].CantCuotas = value;
               }
	          }
        public bool IsCantCuotasNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsCantCuotasNull();
             }
	        }
        public String TipoVencimiento {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["TipoVencimiento"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].TipoVencimiento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].TipoVencimiento = value;
               }
	          }
        public bool IsTipoVencimientoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsTipoVencimientoNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Int16 DiasVencimiento {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["DiasVencimiento"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].DiasVencimiento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].DiasVencimiento = value;
               }
	          }
        public bool IsDiasVencimientoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDiasVencimientoNull();
             }
	        }
        public Int16 DiasDescFinanc {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["DiasDescFinanc"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].DiasDescFinanc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].DiasDescFinanc = value;
               }
	          }
        public bool IsDiasDescFinancNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDiasDescFinancNull();
             }
	        }
        public Decimal DescFinanc {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["DescFinanc"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].DescFinanc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].DescFinanc = value;
               }
	          }
        public bool IsDescFinancNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDescFinancNull();
             }
	        }
        public Boolean ImpPrimCuota {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["ImpPrimCuota"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].ImpPrimCuota;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].ImpPrimCuota = value;
               }
	          }
        public bool IsImpPrimCuotaNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsImpPrimCuotaNull();
             }
	        }
        public Boolean EditaCuotas {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["EditaCuotas"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].EditaCuotas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].EditaCuotas = value;
               }
	          }
        public bool IsEditaCuotasNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsEditaCuotasNull();
             }
	        }
        public Boolean FactCredito {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["FactCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].FactCredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].FactCredito = value;
               }
	          }
        public bool IsFactCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsFactCreditoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String TipoFiscal {
            get {
                if(((VentasCommon.venCondPagoDS)mParam).Principal[0]["TipoFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCondPagoDS)mParam).Principal[0].TipoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondPagoDS)mParam).Principal[0].TipoFiscal = value;
               }
	          }
        public bool IsTipoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCondPagoDS)mParam).Principal[0].IsTipoFiscalNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCondPagoDS );
     }
     public venCondPagoActionExchange() : base( "venCondPago" ) {
     }

     public venCondPagoActionExchange(venCondPagoActionEnum.EnumvenCondPagoAction pAccion) : base(venCondPagoActionEnum.GetAccionvenCondPagoAction(pAccion)) {
     }

     public venCondPagoActionExchange(venCondPagoActionEnum.EnumvenCondPagoAction pAccion, VentasCommon.venCondPagoDS pdsParam) : base(venCondPagoActionEnum.GetAccionvenCondPagoAction(pAccion), pdsParam) {
     }

     public venCondPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCondPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCondPagoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCondPagoDS)mParam;
	        }
     }
  }
}
