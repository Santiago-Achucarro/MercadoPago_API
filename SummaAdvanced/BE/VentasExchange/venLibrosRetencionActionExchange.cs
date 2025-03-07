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
    public class venLibrosRetencionActionExchange : Framework.Core.Exchange{

        public Int32 venLibros {
            get {
                if(((VentasCommon.venLibrosRetencionDS)mParam).Principal[0]["venLibros"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].venLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].venLibros = value;
               }
	          }
        public bool IsvenLibrosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].IsvenLibrosNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((VentasCommon.venLibrosRetencionDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((VentasCommon.venLibrosRetencionDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdentifica {
            get {
                if(((VentasCommon.venLibrosRetencionDS)mParam).Principal[0]["DescripcionIdentifica"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].DescripcionIdentifica;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].DescripcionIdentifica = value;
               }
	          }
        public bool IsDescripcionIdentificaNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].IsDescripcionIdentificaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLibrosRetencionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosRetencionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLibrosRetencionDS );
     }
     public venLibrosRetencionActionExchange() : base( "venLibrosRetencion" ) {
     }

     public venLibrosRetencionActionExchange(venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction pAccion) : base(venLibrosRetencionActionEnum.GetAccionvenLibrosRetencionAction(pAccion)) {
     }

     public venLibrosRetencionActionExchange(venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction pAccion, VentasCommon.venLibrosRetencionDS pdsParam) : base(venLibrosRetencionActionEnum.GetAccionvenLibrosRetencionAction(pAccion), pdsParam) {
     }

     public venLibrosRetencionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLibrosRetencionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLibrosRetencionDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLibrosRetencionDS)mParam;
	        }
     }
  }
}
