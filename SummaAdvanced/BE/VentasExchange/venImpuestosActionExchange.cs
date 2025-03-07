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
    public class venImpuestosActionExchange : Framework.Core.Exchange{

        public Int32 venImpuestos {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["venImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].venImpuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].venImpuestos = value;
               }
	          }
        public bool IsvenImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsvenImpuestosNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String Impuesto_Id_Nueva {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Impuesto_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva = value;
               }
	          }
        public bool IsImpuesto_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsImpuesto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 TipoImpuesto {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["TipoImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].TipoImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].TipoImpuesto = value;
               }
	          }
        public bool IsTipoImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsTipoImpuestoNull();
             }
	        }
        public String DescripcionTipoImpuesto {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["DescripcionTipoImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto = value;
               }
	          }
        public bool IsDescripcionTipoImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionTipoImpuestoNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public Boolean UsaFormula {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["UsaFormula"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].UsaFormula;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].UsaFormula = value;
               }
	          }
        public bool IsUsaFormulaNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsUsaFormulaNull();
             }
	        }
        public String Formulacalc {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Formulacalc"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Formulacalc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Formulacalc = value;
               }
	          }
        public bool IsFormulacalcNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsFormulacalcNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public DateTime Fecha_Desde {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Fecha_Desde"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Fecha_Desde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Fecha_Desde = value;
               }
	          }
        public bool IsFecha_DesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsFecha_DesdeNull();
             }
	        }
        public DateTime Fecha_Hasta {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Fecha_Hasta"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Fecha_Hasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Fecha_Hasta = value;
               }
	          }
        public bool IsFecha_HastaNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsFecha_HastaNull();
             }
	        }
        public String Depende_de {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Depende_de"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Depende_de;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Depende_de = value;
               }
	          }
        public bool IsDepende_deNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDepende_deNull();
             }
	        }
        public Boolean PorVencimiento {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["PorVencimiento"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].PorVencimiento;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].PorVencimiento = value;
               }
	          }
        public bool IsPorVencimientoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsPorVencimientoNull();
             }
	        }
        public String CtaReversion {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["CtaReversion"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].CtaReversion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].CtaReversion = value;
               }
	          }
        public bool IsCtaReversionNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsCtaReversionNull();
             }
	        }
        public String DescripcionCtaReversion {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["DescripcionCtaReversion"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCtaReversion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCtaReversion = value;
               }
	          }
        public bool IsDescripcionCtaReversionNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionCtaReversionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String CtaDifCambio {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["CtaDifCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].CtaDifCambio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].CtaDifCambio = value;
               }
	          }
        public bool IsCtaDifCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsCtaDifCambioNull();
             }
	        }
        public String DescripcionCtaDifCambio {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["DescripcionCtaDifCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCtaDifCambio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionCtaDifCambio = value;
               }
	          }
        public bool IsDescripcionCtaDifCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionCtaDifCambioNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean ImpuestoXProducto {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["ImpuestoXProducto"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].ImpuestoXProducto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].ImpuestoXProducto = value;
               }
	          }
        public bool IsImpuestoXProductoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsImpuestoXProductoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venImpuestosDS );
     }
     public venImpuestosActionExchange() : base( "venImpuestos" ) {
     }

     public venImpuestosActionExchange(venImpuestosActionEnum.EnumvenImpuestosAction pAccion) : base(venImpuestosActionEnum.GetAccionvenImpuestosAction(pAccion)) {
     }

     public venImpuestosActionExchange(venImpuestosActionEnum.EnumvenImpuestosAction pAccion, VentasCommon.venImpuestosDS pdsParam) : base(venImpuestosActionEnum.GetAccionvenImpuestosAction(pAccion), pdsParam) {
     }

     public venImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venImpuestosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venImpuestosDS)mParam;
	        }
     }
  }
}
