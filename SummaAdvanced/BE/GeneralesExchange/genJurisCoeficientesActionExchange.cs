using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genJurisCoeficientesActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String Juris_Id {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["Juris_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Juris_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Juris_Id = value;
               }
	          }
        public bool IsJuris_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsJuris_IdNull();
             }
	        }
        public String DescripcionJurisdicciones {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["DescripcionJurisdicciones"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].DescripcionJurisdicciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].DescripcionJurisdicciones = value;
               }
	          }
        public bool IsDescripcionJurisdiccionesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsDescripcionJurisdiccionesNull();
             }
	        }
        public String Situacion {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["Situacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Situacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Situacion = value;
               }
	          }
        public bool IsSituacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsSituacionNull();
             }
	        }
        public Decimal Coeficiente {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["Coeficiente"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Coeficiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Coeficiente = value;
               }
	          }
        public bool IsCoeficienteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsCoeficienteNull();
             }
	        }
        public Decimal Exencion {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["Exencion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Exencion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Exencion = value;
               }
	          }
        public bool IsExencionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsExencionNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genJurisCoeficientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genJurisCoeficientesDS );
     }
     public genJurisCoeficientesActionExchange() : base( "genJurisCoeficientes" ) {
     }

     public genJurisCoeficientesActionExchange(genJurisCoeficientesActionEnum.EnumgenJurisCoeficientesAction pAccion) : base(genJurisCoeficientesActionEnum.GetAcciongenJurisCoeficientesAction(pAccion)) {
     }

     public genJurisCoeficientesActionExchange(genJurisCoeficientesActionEnum.EnumgenJurisCoeficientesAction pAccion, GeneralesCommon.genJurisCoeficientesDS pdsParam) : base(genJurisCoeficientesActionEnum.GetAcciongenJurisCoeficientesAction(pAccion), pdsParam) {
     }

     public genJurisCoeficientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genJurisCoeficientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genJurisCoeficientesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genJurisCoeficientesDS)mParam;
	        }
     }
  }
}
