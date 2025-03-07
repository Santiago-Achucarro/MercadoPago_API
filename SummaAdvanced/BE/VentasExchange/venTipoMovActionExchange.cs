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
    public class venTipoMovActionExchange : Framework.Core.Exchange{

        public String venTipoMov {
            get {
                if(((VentasCommon.venTipoMovDS)mParam).Principal[0]["venTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venTipoMovDS)mParam).Principal[0].venTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTipoMovDS)mParam).Principal[0].venTipoMov = value;
               }
	          }
        public bool IsvenTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venTipoMovDS)mParam).Principal[0].IsvenTipoMovNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venTipoMovDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venTipoMovDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTipoMovDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venTipoMovDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((VentasCommon.venTipoMovDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((VentasCommon.venTipoMovDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTipoMovDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((VentasCommon.venTipoMovDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public String TipoMovResumido {
            get {
                if(((VentasCommon.venTipoMovDS)mParam).Principal[0]["TipoMovResumido"] != DBNull.Value  ){
                    return ((VentasCommon.venTipoMovDS)mParam).Principal[0].TipoMovResumido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTipoMovDS)mParam).Principal[0].TipoMovResumido = value;
               }
	          }
        public bool IsTipoMovResumidoNull {
             get {
                 return mParam==null || ((VentasCommon.venTipoMovDS)mParam).Principal[0].IsTipoMovResumidoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venTipoMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venTipoMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTipoMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venTipoMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venTipoMovDS );
     }
     public venTipoMovActionExchange() : base( "venTipoMov" ) {
     }

     public venTipoMovActionExchange(venTipoMovActionEnum.EnumvenTipoMovAction pAccion) : base(venTipoMovActionEnum.GetAccionvenTipoMovAction(pAccion)) {
     }

     public venTipoMovActionExchange(venTipoMovActionEnum.EnumvenTipoMovAction pAccion, VentasCommon.venTipoMovDS pdsParam) : base(venTipoMovActionEnum.GetAccionvenTipoMovAction(pAccion), pdsParam) {
     }

     public venTipoMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venTipoMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venTipoMovDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venTipoMovDS)mParam;
	        }
     }
  }
}
