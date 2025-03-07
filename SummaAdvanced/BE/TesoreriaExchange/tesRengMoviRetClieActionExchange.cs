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
    public class tesRengMoviRetClieActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String SucursalRet {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["SucursalRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].SucursalRet;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].SucursalRet = value;
               }
	          }
        public bool IsSucursalRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsSucursalRetNull();
             }
	        }
        public Int32 ComprobanteRet {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["ComprobanteRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].ComprobanteRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].ComprobanteRet = value;
               }
	          }
        public bool IsComprobanteRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsComprobanteRetNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetClieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengMoviRetClieDS );
     }
     public tesRengMoviRetClieActionExchange() : base( "tesRengMoviRetClie" ) {
     }

     public tesRengMoviRetClieActionExchange(tesRengMoviRetClieActionEnum.EnumtesRengMoviRetClieAction pAccion) : base(tesRengMoviRetClieActionEnum.GetAcciontesRengMoviRetClieAction(pAccion)) {
     }

     public tesRengMoviRetClieActionExchange(tesRengMoviRetClieActionEnum.EnumtesRengMoviRetClieAction pAccion, TesoreriaCommon.tesRengMoviRetClieDS pdsParam) : base(tesRengMoviRetClieActionEnum.GetAcciontesRengMoviRetClieAction(pAccion), pdsParam) {
     }

     public tesRengMoviRetClieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengMoviRetClieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengMoviRetClieDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengMoviRetClieDS)mParam;
	        }
     }
  }
}
