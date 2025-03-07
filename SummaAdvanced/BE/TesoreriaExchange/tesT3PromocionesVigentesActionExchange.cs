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
    public class tesT3PromocionesVigentesActionExchange : Framework.Core.Exchange{

        public Int32 Promocion_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0]["Promocion_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Promocion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Promocion_Id = value;
               }
	          }
        public bool IsPromocion_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].IsPromocion_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesVigentesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesT3PromocionesVigentesDS );
     }
     public tesT3PromocionesVigentesActionExchange() : base( "tesT3PromocionesVigentes" ) {
     }

     public tesT3PromocionesVigentesActionExchange(tesT3PromocionesVigentesActionEnum.EnumtesT3PromocionesVigentesAction pAccion) : base(tesT3PromocionesVigentesActionEnum.GetAcciontesT3PromocionesVigentesAction(pAccion)) {
     }

     public tesT3PromocionesVigentesActionExchange(tesT3PromocionesVigentesActionEnum.EnumtesT3PromocionesVigentesAction pAccion, TesoreriaCommon.tesT3PromocionesVigentesDS pdsParam) : base(tesT3PromocionesVigentesActionEnum.GetAcciontesT3PromocionesVigentesAction(pAccion), pdsParam) {
     }

     public tesT3PromocionesVigentesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesT3PromocionesVigentesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesT3PromocionesVigentesActionExchange(TesoreriaCommon.tesT3PromocionesVigentesDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesT3PromocionesVigentesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesT3PromocionesVigentesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesT3PromocionesVigentesDS)mParam;
	        }
     }
  }
}
