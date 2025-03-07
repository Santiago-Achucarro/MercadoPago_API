using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ActivoFijoExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class AfiRubrosActionExchange : Framework.Core.Exchange{

        public Int32 AfiRubros {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["AfiRubros"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].AfiRubros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].AfiRubros = value;
               }
	          }
        public bool IsAfiRubrosNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsAfiRubrosNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String Rubro_Id_Nueva {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Rubro_Id_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Rubro_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Rubro_Id_Nueva = value;
               }
	          }
        public bool IsRubro_Id_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsRubro_Id_NuevaNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 VidaUtil {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["VidaUtil"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].VidaUtil;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].VidaUtil = value;
               }
	          }
        public bool IsVidaUtilNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsVidaUtilNull();
             }
	        }
        public Int32 VidaUtilFiscal {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["VidaUtilFiscal"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].VidaUtilFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].VidaUtilFiscal = value;
               }
	          }
        public bool IsVidaUtilFiscalNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsVidaUtilFiscalNull();
             }
	        }
        public String CtaValorOrigen {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["CtaValorOrigen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaValorOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaValorOrigen = value;
               }
	          }
        public bool IsCtaValorOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsCtaValorOrigenNull();
             }
	        }
        public String DescripcionCtaValorOrigen {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["DescripcionCtaValorOrigen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaValorOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaValorOrigen = value;
               }
	          }
        public bool IsDescripcionCtaValorOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsDescripcionCtaValorOrigenNull();
             }
	        }
        public String CtaAmortAcum_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["CtaAmortAcum_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaAmortAcum_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaAmortAcum_Id = value;
               }
	          }
        public bool IsCtaAmortAcum_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsCtaAmortAcum_IdNull();
             }
	        }
        public String DescripcionCtaAmortAcum_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["DescripcionCtaAmortAcum_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaAmortAcum_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaAmortAcum_Id = value;
               }
	          }
        public bool IsDescripcionCtaAmortAcum_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsDescripcionCtaAmortAcum_IdNull();
             }
	        }
        public String CtaAmortizacion_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["CtaAmortizacion_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaAmortizacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].CtaAmortizacion_Id = value;
               }
	          }
        public bool IsCtaAmortizacion_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsCtaAmortizacion_IdNull();
             }
	        }
        public String DescripcionCtaAmortizacion_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["DescripcionCtaAmortizacion_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaAmortizacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].DescripcionCtaAmortizacion_Id = value;
               }
	          }
        public bool IsDescripcionCtaAmortizacion_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsDescripcionCtaAmortizacion_IdNull();
             }
	        }
        public String Tipo {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Int16 Digitos {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Digitos"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Digitos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Digitos = value;
               }
	          }
        public bool IsDigitosNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsDigitosNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiRubrosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiRubrosDS );
     }
     public AfiRubrosActionExchange() : base( "AfiRubros" ) {
     }

     public AfiRubrosActionExchange(AfiRubrosActionEnum.EnumAfiRubrosAction pAccion) : base(AfiRubrosActionEnum.GetAccionAfiRubrosAction(pAccion)) {
     }

     public AfiRubrosActionExchange(AfiRubrosActionEnum.EnumAfiRubrosAction pAccion, ActivoFijoCommon.AfiRubrosDS pdsParam) : base(AfiRubrosActionEnum.GetAccionAfiRubrosAction(pAccion), pdsParam) {
     }

     public AfiRubrosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiRubrosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiRubrosDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiRubrosDS)mParam;
	        }
     }
  }
}
