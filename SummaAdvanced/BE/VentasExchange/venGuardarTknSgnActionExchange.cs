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
    public class venGuardarTknSgnActionExchange : Framework.Core.Exchange{

        public String Token {
            get {
                if(((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0]["Token"] != DBNull.Value  ){
                    return ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Token;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Token = value;
               }
	          }
        public bool IsTokenNull {
             get {
                 return mParam==null || ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].IsTokenNull();
             }
	        }
        public String Sign {
            get {
                if(((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0]["Sign"] != DBNull.Value  ){
                    return ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Sign;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Sign = value;
               }
	          }
        public bool IsSignNull {
             get {
                 return mParam==null || ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].IsSignNull();
             }
	        }
        public String WS {
            get {
                if(((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0]["WS"] != DBNull.Value  ){
                    return ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].WS;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].WS = value;
               }
	          }
        public bool IsWSNull {
             get {
                 return mParam==null || ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].IsWSNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venGuardarTknSgnDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venGuardarTknSgnDS );
     }
     public venGuardarTknSgnActionExchange() : base( "venGuardarTknSgn" ) {
     }

     public venGuardarTknSgnActionExchange(venGuardarTknSgnActionEnum.EnumvenGuardarTknSgnAction pAccion) : base(venGuardarTknSgnActionEnum.GetAccionvenGuardarTknSgnAction(pAccion)) {
     }

     public venGuardarTknSgnActionExchange(venGuardarTknSgnActionEnum.EnumvenGuardarTknSgnAction pAccion, VentasCommon.venGuardarTknSgnDS pdsParam) : base(venGuardarTknSgnActionEnum.GetAccionvenGuardarTknSgnAction(pAccion), pdsParam) {
     }

     public venGuardarTknSgnActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venGuardarTknSgnDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venGuardarTknSgnActionExchange(VentasCommon.venGuardarTknSgnDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venGuardarTknSgnDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venGuardarTknSgnDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venGuardarTknSgnDS)mParam;
	        }
     }
  }
}
