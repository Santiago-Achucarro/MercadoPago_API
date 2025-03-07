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
    public class genDiasFestivosFechaActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDiasFestivosFechaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genDiasFestivosFechaDS );
     }
     public genDiasFestivosFechaActionExchange() : base( "genDiasFestivosFecha" ) {
     }

     public genDiasFestivosFechaActionExchange(genDiasFestivosFechaActionEnum.EnumgenDiasFestivosFechaAction pAccion) : base(genDiasFestivosFechaActionEnum.GetAcciongenDiasFestivosFechaAction(pAccion)) {
     }

     public genDiasFestivosFechaActionExchange(genDiasFestivosFechaActionEnum.EnumgenDiasFestivosFechaAction pAccion, GeneralesCommon.genDiasFestivosFechaDS pdsParam) : base(genDiasFestivosFechaActionEnum.GetAcciongenDiasFestivosFechaAction(pAccion), pdsParam) {
     }

     public genDiasFestivosFechaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genDiasFestivosFechaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genDiasFestivosFechaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genDiasFestivosFechaDS)mParam;
	        }
     }
  }
}
