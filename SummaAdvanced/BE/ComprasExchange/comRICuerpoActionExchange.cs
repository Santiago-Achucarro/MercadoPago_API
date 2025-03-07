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
    public class comRICuerpoActionExchange : Framework.Core.Exchange{

        public Int32 Renglon_RI {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Renglon_RI"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Renglon_RI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Renglon_RI = value;
               }
	          }
        public bool IsRenglon_RINull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsRenglon_RINull();
             }
	        }
        public DateTime FechaNecesidad {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["FechaNecesidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].FechaNecesidad;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].FechaNecesidad = value;
               }
	          }
        public bool IsFechaNecesidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsFechaNecesidadNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Decimal CantidadRecibida {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["CantidadRecibida"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].CantidadRecibida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].CantidadRecibida = value;
               }
	          }
        public bool IsCantidadRecibidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsCantidadRecibidaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Int32 comReqInterno {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["comReqInterno"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].comReqInterno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].comReqInterno = value;
               }
	          }
        public bool IscomReqInternoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IscomReqInternoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comRICuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRICuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRICuerpoDS );
     }
     public comRICuerpoActionExchange() : base( "comRICuerpo" ) {
     }

     public comRICuerpoActionExchange(comRICuerpoActionEnum.EnumcomRICuerpoAction pAccion) : base(comRICuerpoActionEnum.GetAccioncomRICuerpoAction(pAccion)) {
     }

     public comRICuerpoActionExchange(comRICuerpoActionEnum.EnumcomRICuerpoAction pAccion, ComprasCommon.comRICuerpoDS pdsParam) : base(comRICuerpoActionEnum.GetAccioncomRICuerpoAction(pAccion), pdsParam) {
     }

     public comRICuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRICuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRICuerpoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRICuerpoDS)mParam;
	        }
     }
  }
}
