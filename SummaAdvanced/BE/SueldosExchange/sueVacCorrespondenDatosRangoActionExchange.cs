using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueVacCorrespondenDatosRangoActionExchange : Framework.Core.Exchange{

        public Int32 Anio {
            get {
                if(((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVacCorrespondenDatosRangoDS );
     }
     public sueVacCorrespondenDatosRangoActionExchange() : base( "sueVacCorrespondenDatosRango" ) {
     }

     public sueVacCorrespondenDatosRangoActionExchange(sueVacCorrespondenDatosRangoActionEnum.EnumsueVacCorrespondenDatosRangoAction pAccion) : base(sueVacCorrespondenDatosRangoActionEnum.GetAccionsueVacCorrespondenDatosRangoAction(pAccion)) {
     }

     public sueVacCorrespondenDatosRangoActionExchange(sueVacCorrespondenDatosRangoActionEnum.EnumsueVacCorrespondenDatosRangoAction pAccion, SueldosCommon.sueVacCorrespondenDatosRangoDS pdsParam) : base(sueVacCorrespondenDatosRangoActionEnum.GetAccionsueVacCorrespondenDatosRangoAction(pAccion), pdsParam) {
     }

     public sueVacCorrespondenDatosRangoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVacCorrespondenDatosRangoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVacCorrespondenDatosRangoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVacCorrespondenDatosRangoDS)mParam;
	        }
     }
  }
}
