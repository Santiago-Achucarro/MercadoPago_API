using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genTipoCambioActionExchange : Framework.Core.Exchange{

        public String Moneda_Id {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String DescripcionMonedas_Nueva {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["DescripcionMonedas_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionMonedas_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionMonedas_Nueva = value;
               }
	          }
        public bool IsDescripcionMonedas_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsDescripcionMonedas_NuevaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Decimal CambioCompra {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["CambioCompra"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].CambioCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].CambioCompra = value;
               }
	          }
        public bool IsCambioCompraNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsCambioCompraNull();
             }
	        }
        public Decimal CambioVenta {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["CambioVenta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].CambioVenta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].CambioVenta = value;
               }
	          }
        public bool IsCambioVentaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsCambioVentaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genTipoCambioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTipoCambioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genTipoCambioDS );
     }
     public genTipoCambioActionExchange() : base( "genTipoCambio" ) {
     }

     public genTipoCambioActionExchange(genTipoCambioActionEnum.EnumgenTipoCambioAction pAccion) : base(genTipoCambioActionEnum.GetAcciongenTipoCambioAction(pAccion)) {
     }

     public genTipoCambioActionExchange(genTipoCambioActionEnum.EnumgenTipoCambioAction pAccion, GeneralesCommon.genTipoCambioDS pdsParam) : base(genTipoCambioActionEnum.GetAcciongenTipoCambioAction(pAccion), pdsParam) {
     }

     public genTipoCambioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genTipoCambioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genTipoCambioDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genTipoCambioDS)mParam;
	        }
     }
  }
}
