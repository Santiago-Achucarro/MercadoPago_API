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
    public class sueVacCorrespondenActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Int32 Saldo {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacCorrespondenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVacCorrespondenDS );
     }
     public sueVacCorrespondenActionExchange() : base( "sueVacCorresponden" ) {
     }

     public sueVacCorrespondenActionExchange(sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction pAccion) : base(sueVacCorrespondenActionEnum.GetAccionsueVacCorrespondenAction(pAccion)) {
     }

     public sueVacCorrespondenActionExchange(sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction pAccion, SueldosCommon.sueVacCorrespondenDS pdsParam) : base(sueVacCorrespondenActionEnum.GetAccionsueVacCorrespondenAction(pAccion), pdsParam) {
     }

     public sueVacCorrespondenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVacCorrespondenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVacCorrespondenDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVacCorrespondenDS)mParam;
	        }
     }
  }
}
