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
    public class tesTarjetasPromocionesActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdTarjetas3 {
            get {
                if(((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0]["DescripcionIdTarjetas3"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].DescripcionIdTarjetas3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].DescripcionIdTarjetas3 = value;
               }
	          }
        public bool IsDescripcionIdTarjetas3Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].IsDescripcionIdTarjetas3Null();
             }
	        }
        public Int32 Promocion_Id {
            get {
                if(((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0]["Promocion_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Promocion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Promocion_Id = value;
               }
	          }
        public bool IsPromocion_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].IsPromocion_IdNull();
             }
	        }
        public String DescripcionT3Promociones {
            get {
                if(((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0]["DescripcionT3Promociones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].DescripcionT3Promociones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].DescripcionT3Promociones = value;
               }
	          }
        public bool IsDescripcionT3PromocionesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].IsDescripcionT3PromocionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTarjetasPromocionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesTarjetasPromocionesDS );
     }
     public tesTarjetasPromocionesActionExchange() : base( "tesTarjetasPromociones" ) {
     }

     public tesTarjetasPromocionesActionExchange(tesTarjetasPromocionesActionEnum.EnumtesTarjetasPromocionesAction pAccion) : base(tesTarjetasPromocionesActionEnum.GetAcciontesTarjetasPromocionesAction(pAccion)) {
     }

     public tesTarjetasPromocionesActionExchange(tesTarjetasPromocionesActionEnum.EnumtesTarjetasPromocionesAction pAccion, TesoreriaCommon.tesTarjetasPromocionesDS pdsParam) : base(tesTarjetasPromocionesActionEnum.GetAcciontesTarjetasPromocionesAction(pAccion), pdsParam) {
     }

     public tesTarjetasPromocionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesTarjetasPromocionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesTarjetasPromocionesActionExchange(TesoreriaCommon.tesTarjetasPromocionesDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesTarjetasPromocionesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesTarjetasPromocionesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesTarjetasPromocionesDS)mParam;
	        }
     }
  }
}
