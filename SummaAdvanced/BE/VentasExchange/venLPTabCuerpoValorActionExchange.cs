using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venLPTabCuerpoValorActionExchange : Framework.Core.Exchange{

        public Int32 Tabla_Id {
            get {
                if(((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public Decimal Hasta {
            get {
                if(((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0]["Hasta"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Hasta = value;
               }
	          }
        public bool IsHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].IsHastaNull();
             }
	        }
        public Decimal Valor {
            get {
                if(((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0]["Valor"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Valor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Valor = value;
               }
	          }
        public bool IsValorNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].IsValorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTabCuerpoValorDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLPTabCuerpoValorDS );
     }
     public venLPTabCuerpoValorActionExchange() : base( "venLPTabCuerpoValor" ) {
     }

     public venLPTabCuerpoValorActionExchange(venLPTabCuerpoValorActionEnum.EnumvenLPTabCuerpoValorAction pAccion) : base(venLPTabCuerpoValorActionEnum.GetAccionvenLPTabCuerpoValorAction(pAccion)) {
     }

     public venLPTabCuerpoValorActionExchange(venLPTabCuerpoValorActionEnum.EnumvenLPTabCuerpoValorAction pAccion, VentasCommon.venLPTabCuerpoValorDS pdsParam) : base(venLPTabCuerpoValorActionEnum.GetAccionvenLPTabCuerpoValorAction(pAccion), pdsParam) {
     }

     public venLPTabCuerpoValorActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLPTabCuerpoValorDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venLPTabCuerpoValorActionExchange(VentasCommon.venLPTabCuerpoValorDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venLPTabCuerpoValorDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLPTabCuerpoValorDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLPTabCuerpoValorDS)mParam;
	        }
     }
  }
}
