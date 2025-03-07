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
    public class VenMoviFiscalVirtualActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((VentasCommon.VenMoviFiscalVirtualDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.VenMoviFiscalVirtualDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenMoviFiscalVirtualDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.VenMoviFiscalVirtualDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.VenMoviFiscalVirtualDS );
     }
     public VenMoviFiscalVirtualActionExchange() : base( "VenMoviFiscalVirtual" ) {
     }

     public VenMoviFiscalVirtualActionExchange(VenMoviFiscalVirtualActionEnum.EnumVenMoviFiscalVirtualAction pAccion) : base(VenMoviFiscalVirtualActionEnum.GetAccionVenMoviFiscalVirtualAction(pAccion)) {
     }

     public VenMoviFiscalVirtualActionExchange(VenMoviFiscalVirtualActionEnum.EnumVenMoviFiscalVirtualAction pAccion, VentasCommon.VenMoviFiscalVirtualDS pdsParam) : base(VenMoviFiscalVirtualActionEnum.GetAccionVenMoviFiscalVirtualAction(pAccion), pdsParam) {
     }

     public VenMoviFiscalVirtualActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.VenMoviFiscalVirtualDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.VenMoviFiscalVirtualDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.VenMoviFiscalVirtualDS)mParam;
	        }
     }
  }
}
