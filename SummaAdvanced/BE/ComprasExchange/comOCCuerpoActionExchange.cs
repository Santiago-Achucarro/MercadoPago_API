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
    public class comOCCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Cantidad_Recibida {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Cantidad_Recibida"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Recibida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Recibida = value;
               }
	          }
        public bool IsCantidad_RecibidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidad_RecibidaNull();
             }
	        }
        public Decimal Cantidad_Embarcada {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Cantidad_Embarcada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Embarcada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Embarcada = value;
               }
	          }
        public bool IsCantidad_EmbarcadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidad_EmbarcadaNull();
             }
	        }
        public Decimal Cantidad_Facturada {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Cantidad_Facturada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Facturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Facturada = value;
               }
	          }
        public bool IsCantidad_FacturadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidad_FacturadaNull();
             }
	        }
        public DateTime Fecha_Entrega {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Fecha_Entrega"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Fecha_Entrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Fecha_Entrega = value;
               }
	          }
        public bool IsFecha_EntregaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsFecha_EntregaNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Decimal Cantidad_Creditos {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Cantidad_Creditos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Creditos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Cantidad_Creditos = value;
               }
	          }
        public bool IsCantidad_CreditosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidad_CreditosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Int32 comOrdencomp {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["comOrdencomp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].comOrdencomp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].comOrdencomp = value;
               }
	          }
        public bool IscomOrdencompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IscomOrdencompNull();
             }
	        }
        public Decimal CantidadConsignada {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["CantidadConsignada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].CantidadConsignada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].CantidadConsignada = value;
               }
	          }
        public bool IsCantidadConsignadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsCantidadConsignadaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOCCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOCCuerpoDS );
     }
     public comOCCuerpoActionExchange() : base( "comOCCuerpo" ) {
     }

     public comOCCuerpoActionExchange(comOCCuerpoActionEnum.EnumcomOCCuerpoAction pAccion) : base(comOCCuerpoActionEnum.GetAccioncomOCCuerpoAction(pAccion)) {
     }

     public comOCCuerpoActionExchange(comOCCuerpoActionEnum.EnumcomOCCuerpoAction pAccion, ComprasCommon.comOCCuerpoDS pdsParam) : base(comOCCuerpoActionEnum.GetAccioncomOCCuerpoAction(pAccion), pdsParam) {
     }

     public comOCCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOCCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOCCuerpoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOCCuerpoDS)mParam;
	        }
     }
  }
}
