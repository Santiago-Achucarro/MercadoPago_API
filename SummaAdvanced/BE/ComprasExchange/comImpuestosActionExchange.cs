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
    public class comImpuestosActionExchange : Framework.Core.Exchange{

        public Int32 comImpuestos {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["comImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].comImpuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].comImpuestos = value;
               }
	          }
        public bool IscomImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IscomImpuestosNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String Impuesto_Id_Nueva {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Impuesto_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Impuesto_Id_Nueva = value;
               }
	          }
        public bool IsImpuesto_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsImpuesto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 TipoImpuesto {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["TipoImpuesto"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].TipoImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].TipoImpuesto = value;
               }
	          }
        public bool IsTipoImpuestoNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsTipoImpuestoNull();
             }
	        }
        public String DescripcionTipoImpuesto {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["DescripcionTipoImpuesto"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto = value;
               }
	          }
        public bool IsDescripcionTipoImpuestoNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionTipoImpuestoNull();
             }
	        }
        public String Formulacalc {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Formulacalc"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Formulacalc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Formulacalc = value;
               }
	          }
        public bool IsFormulacalcNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsFormulacalcNull();
             }
	        }
        public String CtaDebe {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["CtaDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaDebe = value;
               }
	          }
        public bool IsCtaDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsCtaDebeNull();
             }
	        }
        public String DescripcionCtaDebe {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["DescripcionCtaDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaDebe = value;
               }
	          }
        public bool IsDescripcionCtaDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionCtaDebeNull();
             }
	        }
        public String CtaHaber {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["CtaHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaHaber = value;
               }
	          }
        public bool IsCtaHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsCtaHaberNull();
             }
	        }
        public String DescripcionCtaHaber {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["DescripcionCtaHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaHaber = value;
               }
	          }
        public bool IsDescripcionCtaHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionCtaHaberNull();
             }
	        }
        public String CtaReversion {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["CtaReversion"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaReversion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].CtaReversion = value;
               }
	          }
        public bool IsCtaReversionNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsCtaReversionNull();
             }
	        }
        public String DescripcionCtaReversion {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["DescripcionCtaReversion"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaReversion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionCtaReversion = value;
               }
	          }
        public bool IsDescripcionCtaReversionNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionCtaReversionNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public DateTime Fecha_Desde {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Fecha_Desde"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Fecha_Desde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Fecha_Desde = value;
               }
	          }
        public bool IsFecha_DesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsFecha_DesdeNull();
             }
	        }
        public DateTime Fecha_Hasta {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Fecha_Hasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Fecha_Hasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Fecha_Hasta = value;
               }
	          }
        public bool IsFecha_HastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsFecha_HastaNull();
             }
	        }
        public String Depende_de {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Depende_de"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Depende_de;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Depende_de = value;
               }
	          }
        public bool IsDepende_deNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDepende_deNull();
             }
	        }
        public Boolean VaAlCosto {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["VaAlCosto"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].VaAlCosto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].VaAlCosto = value;
               }
	          }
        public bool IsVaAlCostoNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsVaAlCostoNull();
             }
	        }
        public Boolean PorAcreditacion {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["PorAcreditacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].PorAcreditacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].PorAcreditacion = value;
               }
	          }
        public bool IsPorAcreditacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsPorAcreditacionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comImpuestosDS );
     }
     public comImpuestosActionExchange() : base( "comImpuestos" ) {
     }

     public comImpuestosActionExchange(comImpuestosActionEnum.EnumcomImpuestosAction pAccion) : base(comImpuestosActionEnum.GetAccioncomImpuestosAction(pAccion)) {
     }

     public comImpuestosActionExchange(comImpuestosActionEnum.EnumcomImpuestosAction pAccion, ComprasCommon.comImpuestosDS pdsParam) : base(comImpuestosActionEnum.GetAccioncomImpuestosAction(pAccion), pdsParam) {
     }

     public comImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comImpuestosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comImpuestosDS)mParam;
	        }
     }
  }
}
