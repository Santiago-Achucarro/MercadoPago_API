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
    public class sueConceptosPropActionExchange : Framework.Core.Exchange{

        public Int32 sueConceptosProp {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["sueConceptosProp"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].sueConceptosProp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].sueConceptosProp = value;
               }
	          }
        public bool IssueConceptosPropNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IssueConceptosPropNull();
             }
	        }
        public String Propiedad {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["Propiedad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Propiedad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Propiedad = value;
               }
	          }
        public bool IsPropiedadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IsPropiedadNull();
             }
	        }
        public Int32 Orden {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Agrupamiento {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["Agrupamiento"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Agrupamiento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Agrupamiento = value;
               }
	          }
        public bool IsAgrupamientoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IsAgrupamientoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConceptosPropDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConceptosPropDS );
     }
     public sueConceptosPropActionExchange() : base( "sueConceptosProp" ) {
     }

     public sueConceptosPropActionExchange(sueConceptosPropActionEnum.EnumsueConceptosPropAction pAccion) : base(sueConceptosPropActionEnum.GetAccionsueConceptosPropAction(pAccion)) {
     }

     public sueConceptosPropActionExchange(sueConceptosPropActionEnum.EnumsueConceptosPropAction pAccion, SueldosCommon.sueConceptosPropDS pdsParam) : base(sueConceptosPropActionEnum.GetAccionsueConceptosPropAction(pAccion), pdsParam) {
     }

     public sueConceptosPropActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConceptosPropDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueConceptosPropActionExchange(SueldosCommon.sueConceptosPropDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueConceptosPropDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConceptosPropDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConceptosPropDS)mParam;
	        }
     }
  }
}
