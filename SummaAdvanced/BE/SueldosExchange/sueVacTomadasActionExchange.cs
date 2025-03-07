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
    public class sueVacTomadasActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueVacTomadasDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.sueVacTomadasDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueVacTomadasDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVacTomadasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVacTomadasDS );
     }
     public sueVacTomadasActionExchange() : base( "sueVacTomadas" ) {
     }

     public sueVacTomadasActionExchange(sueVacTomadasActionEnum.EnumsueVacTomadasAction pAccion) : base(sueVacTomadasActionEnum.GetAccionsueVacTomadasAction(pAccion)) {
     }

     public sueVacTomadasActionExchange(sueVacTomadasActionEnum.EnumsueVacTomadasAction pAccion, SueldosCommon.sueVacTomadasDS pdsParam) : base(sueVacTomadasActionEnum.GetAccionsueVacTomadasAction(pAccion), pdsParam) {
     }

     public sueVacTomadasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVacTomadasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVacTomadasDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVacTomadasDS)mParam;
	        }
     }
  }
}
