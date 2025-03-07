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
    public class venGraVentasActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venGraVentasDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraVentasDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraVentasDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraVentasDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venGraVentasDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraVentasDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraVentasDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraVentasDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venGraVentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venGraVentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraVentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venGraVentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venGraVentasDS );
     }
     public venGraVentasActionExchange() : base( "venGraVentas" ) {
     }

     public venGraVentasActionExchange(venGraVentasActionEnum.EnumvenGraVentasAction pAccion) : base(venGraVentasActionEnum.GetAccionvenGraVentasAction(pAccion)) {
     }

     public venGraVentasActionExchange(venGraVentasActionEnum.EnumvenGraVentasAction pAccion, VentasCommon.venGraVentasDS pdsParam) : base(venGraVentasActionEnum.GetAccionvenGraVentasAction(pAccion), pdsParam) {
     }

     public venGraVentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venGraVentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venGraVentasActionExchange(VentasCommon.venGraVentasDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venGraVentasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venGraVentasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venGraVentasDS)mParam;
	        }
     }
  }
}
