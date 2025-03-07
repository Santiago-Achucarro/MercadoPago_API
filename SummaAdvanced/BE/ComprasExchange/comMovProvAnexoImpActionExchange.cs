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
    public class comMovProvAnexoImpActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Base_Imponible {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Base_Imponible"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Base_Imponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Base_Imponible = value;
               }
	          }
        public bool IsBase_ImponibleNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsBase_ImponibleNull();
             }
	        }
        public Decimal Importe_Impuesto {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Importe_Impuesto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Importe_Impuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Importe_Impuesto = value;
               }
	          }
        public bool IsImporte_ImpuestoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsImporte_ImpuestoNull();
             }
	        }
        public String Cuenta_id {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Cuenta_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Cuenta_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Cuenta_id = value;
               }
	          }
        public bool IsCuenta_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsCuenta_idNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_id {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Centro1_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Centro1_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Centro1_id = value;
               }
	          }
        public bool IsCentro1_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsCentro1_idNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_id {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Centro2_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Centro2_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Centro2_id = value;
               }
	          }
        public bool IsCentro2_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsCentro2_idNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvAnexoImpDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvAnexoImpDS );
     }
     public comMovProvAnexoImpActionExchange() : base( "comMovProvAnexoImp" ) {
     }

     public comMovProvAnexoImpActionExchange(comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction pAccion) : base(comMovProvAnexoImpActionEnum.GetAccioncomMovProvAnexoImpAction(pAccion)) {
     }

     public comMovProvAnexoImpActionExchange(comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction pAccion, ComprasCommon.comMovProvAnexoImpDS pdsParam) : base(comMovProvAnexoImpActionEnum.GetAccioncomMovProvAnexoImpAction(pAccion), pdsParam) {
     }

     public comMovProvAnexoImpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvAnexoImpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvAnexoImpDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvAnexoImpDS)mParam;
	        }
     }
  }
}
