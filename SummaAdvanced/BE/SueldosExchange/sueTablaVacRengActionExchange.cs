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
    public class sueTablaVacRengActionExchange : Framework.Core.Exchange{

        public String TablaVac_Id {
            get {
                if(((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0]["TablaVac_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].TablaVac_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].TablaVac_Id = value;
               }
	          }
        public bool IsTablaVac_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].IsTablaVac_IdNull();
             }
	        }
        public String DescripcionTablaVacacion {
            get {
                if(((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0]["DescripcionTablaVacacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].DescripcionTablaVacacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].DescripcionTablaVacacion = value;
               }
	          }
        public bool IsDescripcionTablaVacacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].IsDescripcionTablaVacacionNull();
             }
	        }
        public Int32 Antiguedad {
            get {
                if(((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0]["Antiguedad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Antiguedad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Antiguedad = value;
               }
	          }
        public bool IsAntiguedadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].IsAntiguedadNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTablaVacRengDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTablaVacRengDS );
     }
     public sueTablaVacRengActionExchange() : base( "sueTablaVacReng" ) {
     }

     public sueTablaVacRengActionExchange(sueTablaVacRengActionEnum.EnumsueTablaVacRengAction pAccion) : base(sueTablaVacRengActionEnum.GetAccionsueTablaVacRengAction(pAccion)) {
     }

     public sueTablaVacRengActionExchange(sueTablaVacRengActionEnum.EnumsueTablaVacRengAction pAccion, SueldosCommon.sueTablaVacRengDS pdsParam) : base(sueTablaVacRengActionEnum.GetAccionsueTablaVacRengAction(pAccion), pdsParam) {
     }

     public sueTablaVacRengActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTablaVacRengDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTablaVacRengDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTablaVacRengDS)mParam;
	        }
     }
  }
}
