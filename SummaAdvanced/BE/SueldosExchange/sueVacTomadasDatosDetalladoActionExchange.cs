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
    public class sueVacTomadasDatosDetalladoActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Antiguedad {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Antiguedad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Antiguedad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Antiguedad = value;
               }
	          }
        public bool IsAntiguedadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsAntiguedadNull();
             }
	        }
        public DateTime FechaIngreso {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["FechaIngreso"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].FechaIngreso;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].FechaIngreso = value;
               }
	          }
        public bool IsFechaIngresoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsFechaIngresoNull();
             }
	        }
        public String Convenio_Id {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Convenio_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Convenio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Convenio_Id = value;
               }
	          }
        public bool IsConvenio_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsConvenio_IdNull();
             }
	        }
        public String DescripcionConvenio {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["DescripcionConvenio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].DescripcionConvenio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].DescripcionConvenio = value;
               }
	          }
        public bool IsDescripcionConvenioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsDescripcionConvenioNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Int32 Saldo {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVacTomadasDatosDetalladoDS );
     }
     public sueVacTomadasDatosDetalladoActionExchange() : base( "sueVacTomadasDatosDetallado" ) {
     }

     public sueVacTomadasDatosDetalladoActionExchange(sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction pAccion) : base(sueVacTomadasDatosDetalladoActionEnum.GetAccionsueVacTomadasDatosDetalladoAction(pAccion)) {
     }

     public sueVacTomadasDatosDetalladoActionExchange(sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction pAccion, SueldosCommon.sueVacTomadasDatosDetalladoDS pdsParam) : base(sueVacTomadasDatosDetalladoActionEnum.GetAccionsueVacTomadasDatosDetalladoAction(pAccion), pdsParam) {
     }

     public sueVacTomadasDatosDetalladoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVacTomadasDatosDetalladoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVacTomadasDatosDetalladoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVacTomadasDatosDetalladoDS)mParam;
	        }
     }
  }
}
