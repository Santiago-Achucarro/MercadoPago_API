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
    public class comMovImpuestosActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Base_Imponible {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Base_Imponible"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Base_Imponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Base_Imponible = value;
               }
	          }
        public bool IsBase_ImponibleNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsBase_ImponibleNull();
             }
	        }
        public Decimal Importe_Impuesto {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Importe_Impuesto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Importe_Impuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Importe_Impuesto = value;
               }
	          }
        public bool IsImporte_ImpuestoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsImporte_ImpuestoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal TipoMov {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Clase {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal ImporteContable {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["ImporteContable"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].ImporteContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].ImporteContable = value;
               }
	          }
        public bool IsImporteContableNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsImporteContableNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovImpuestosDS );
     }
     public comMovImpuestosActionExchange() : base( "comMovImpuestos" ) {
     }

     public comMovImpuestosActionExchange(comMovImpuestosActionEnum.EnumcomMovImpuestosAction pAccion) : base(comMovImpuestosActionEnum.GetAccioncomMovImpuestosAction(pAccion)) {
     }

     public comMovImpuestosActionExchange(comMovImpuestosActionEnum.EnumcomMovImpuestosAction pAccion, ComprasCommon.comMovImpuestosDS pdsParam) : base(comMovImpuestosActionEnum.GetAccioncomMovImpuestosAction(pAccion), pdsParam) {
     }

     public comMovImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovImpuestosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovImpuestosDS)mParam;
	        }
     }
  }
}
