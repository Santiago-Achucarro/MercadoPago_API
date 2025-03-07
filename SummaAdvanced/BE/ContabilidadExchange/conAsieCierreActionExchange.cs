using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conAsieCierreActionExchange : Framework.Core.Exchange{

        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public String CtaResEjer {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["CtaResEjer"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].CtaResEjer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].CtaResEjer = value;
               }
	          }
        public bool IsCtaResEjerNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsCtaResEjerNull();
             }
	        }
        public String DescripcionCtaResEjer {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["DescripcionCtaResEjer"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].DescripcionCtaResEjer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].DescripcionCtaResEjer = value;
               }
	          }
        public bool IsDescripcionCtaResEjerNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsDescripcionCtaResEjerNull();
             }
	        }
        public String CtaResAcum {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["CtaResAcum"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].CtaResAcum;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].CtaResAcum = value;
               }
	          }
        public bool IsCtaResAcumNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsCtaResAcumNull();
             }
	        }
        public String DescripcionCtaResAcum {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["DescripcionCtaResAcum"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].DescripcionCtaResAcum;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].DescripcionCtaResAcum = value;
               }
	          }
        public bool IsDescripcionCtaResAcumNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsDescripcionCtaResAcumNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsieCierreDS );
     }
     public conAsieCierreActionExchange() : base( "conAsieCierre" ) {
     }

     public conAsieCierreActionExchange(conAsieCierreActionEnum.EnumconAsieCierreAction pAccion) : base(conAsieCierreActionEnum.GetAccionconAsieCierreAction(pAccion)) {
     }

     public conAsieCierreActionExchange(conAsieCierreActionEnum.EnumconAsieCierreAction pAccion, ContabilidadCommon.conAsieCierreDS pdsParam) : base(conAsieCierreActionEnum.GetAccionconAsieCierreAction(pAccion), pdsParam) {
     }

     public conAsieCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsieCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsieCierreDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsieCierreDS)mParam;
	        }
     }
  }
}
