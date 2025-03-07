using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesT3PromocionesCuotasActionExchange : Framework.Core.Exchange{

        public Int32 Promocion_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["Promocion_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Promocion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Promocion_Id = value;
               }
	          }
        public bool IsPromocion_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsPromocion_IdNull();
             }
	        }
        public String DescripcionT3Promociones {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["DescripcionT3Promociones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].DescripcionT3Promociones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].DescripcionT3Promociones = value;
               }
	          }
        public bool IsDescripcionT3PromocionesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsDescripcionT3PromocionesNull();
             }
	        }
        public Int32 Cuota {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["Cuota"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Cuota;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Cuota = value;
               }
	          }
        public bool IsCuotaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsCuotaNull();
             }
	        }
        public Decimal Coeficiente {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["Coeficiente"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Coeficiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Coeficiente = value;
               }
	          }
        public bool IsCoeficienteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsCoeficienteNull();
             }
	        }
        public Decimal Total {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesCuotasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesT3PromocionesCuotasDS );
     }
     public tesT3PromocionesCuotasActionExchange() : base( "tesT3PromocionesCuotas" ) {
     }

     public tesT3PromocionesCuotasActionExchange(tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction pAccion) : base(tesT3PromocionesCuotasActionEnum.GetAcciontesT3PromocionesCuotasAction(pAccion)) {
     }

     public tesT3PromocionesCuotasActionExchange(tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction pAccion, TesoreriaCommon.tesT3PromocionesCuotasDS pdsParam) : base(tesT3PromocionesCuotasActionEnum.GetAcciontesT3PromocionesCuotasAction(pAccion), pdsParam) {
     }

     public tesT3PromocionesCuotasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesT3PromocionesCuotasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesT3PromocionesCuotasActionExchange(TesoreriaCommon.tesT3PromocionesCuotasDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesT3PromocionesCuotasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesT3PromocionesCuotasDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesT3PromocionesCuotasDS)mParam;
	        }
     }
  }
}
