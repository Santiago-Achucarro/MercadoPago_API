using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class esptesTarjetas3KSKActionExchange : Framework.Core.Exchange{

        public Int64 tesTarjetas3 {
            get {
                if(((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0]["tesTarjetas3"] != DBNull.Value  ){
                    return ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].tesTarjetas3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].tesTarjetas3 = value;
               }
	          }
        public bool IstesTarjetas3Null {
             get {
                 return mParam==null || ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].IstesTarjetas3Null();
             }
	        }
        public Int32 Promocion_Id {
            get {
                if(((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0]["Promocion_Id"] != DBNull.Value  ){
                    return ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Promocion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Promocion_Id = value;
               }
	          }
        public bool IsPromocion_IdNull {
             get {
                 return mParam==null || ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].IsPromocion_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.esptesTarjetas3KSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.esptesTarjetas3KSKDS );
     }
     public esptesTarjetas3KSKActionExchange() : base( "esptesTarjetas3KSK" ) {
     }

     public esptesTarjetas3KSKActionExchange(esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction pAccion) : base(esptesTarjetas3KSKActionEnum.GetAccionesptesTarjetas3KSKAction(pAccion)) {
     }

     public esptesTarjetas3KSKActionExchange(esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction pAccion, KSKCommon.esptesTarjetas3KSKDS pdsParam) : base(esptesTarjetas3KSKActionEnum.GetAccionesptesTarjetas3KSKAction(pAccion), pdsParam) {
     }

     public esptesTarjetas3KSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.esptesTarjetas3KSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public esptesTarjetas3KSKActionExchange(KSKCommon.esptesTarjetas3KSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.esptesTarjetas3KSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.esptesTarjetas3KSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.esptesTarjetas3KSKDS)mParam;
	        }
     }
  }
}
