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
    public class VentasCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((VentasCommon.VentasCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((VentasCommon.VentasCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VentasCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((VentasCommon.VentasCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((VentasCommon.VentasCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((VentasCommon.VentasCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VentasCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((VentasCommon.VentasCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.VentasCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.VentasCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VentasCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.VentasCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.VentasCerrarDS );
     }
     public VentasCerrarActionExchange() : base( "VentasCerrar" ) {
     }

     public VentasCerrarActionExchange(VentasCerrarActionEnum.EnumVentasCerrarAction pAccion) : base(VentasCerrarActionEnum.GetAccionVentasCerrarAction(pAccion)) {
     }

     public VentasCerrarActionExchange(VentasCerrarActionEnum.EnumVentasCerrarAction pAccion, VentasCommon.VentasCerrarDS pdsParam) : base(VentasCerrarActionEnum.GetAccionVentasCerrarAction(pAccion), pdsParam) {
     }

     public VentasCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.VentasCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.VentasCerrarDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.VentasCerrarDS)mParam;
	        }
     }
  }
}
