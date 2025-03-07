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
    public class tesAperturaCajaMonedasActionExchange : Framework.Core.Exchange{

        public DateTime FechaActual {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["FechaActual"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].FechaActual;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].FechaActual = value;
               }
	          }
        public bool IsFechaActualNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsFechaActualNull();
             }
	        }
        public DateTime FechaNueva {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["FechaNueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].FechaNueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].FechaNueva = value;
               }
	          }
        public bool IsFechaNuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsFechaNuevaNull();
             }
	        }
        public Boolean EsCentral {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["EsCentral"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].EsCentral;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].EsCentral = value;
               }
	          }
        public bool IsEsCentralNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsEsCentralNull();
             }
	        }
        public String Sucursal {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursal {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["DescripcionSucursal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].DescripcionSucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].DescripcionSucursal = value;
               }
	          }
        public bool IsDescripcionSucursalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsDescripcionSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAperturaCajaMonedasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAperturaCajaMonedasDS );
     }
     public tesAperturaCajaMonedasActionExchange() : base( "tesAperturaCajaMonedas" ) {
     }

     public tesAperturaCajaMonedasActionExchange(tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction pAccion) : base(tesAperturaCajaMonedasActionEnum.GetAcciontesAperturaCajaMonedasAction(pAccion)) {
     }

     public tesAperturaCajaMonedasActionExchange(tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction pAccion, TesoreriaCommon.tesAperturaCajaMonedasDS pdsParam) : base(tesAperturaCajaMonedasActionEnum.GetAcciontesAperturaCajaMonedasAction(pAccion), pdsParam) {
     }

     public tesAperturaCajaMonedasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAperturaCajaMonedasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAperturaCajaMonedasDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAperturaCajaMonedasDS)mParam;
	        }
     }
  }
}
