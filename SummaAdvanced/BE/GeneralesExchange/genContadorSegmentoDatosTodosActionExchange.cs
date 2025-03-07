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
    public class genContadorSegmentoDatosTodosActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genContadorSegmentoDatosTodosDS );
     }
     public genContadorSegmentoDatosTodosActionExchange() : base( "genContadorSegmentoDatosTodos" ) {
     }

     public genContadorSegmentoDatosTodosActionExchange(genContadorSegmentoDatosTodosActionEnum.EnumgenContadorSegmentoDatosTodosAction pAccion) : base(genContadorSegmentoDatosTodosActionEnum.GetAcciongenContadorSegmentoDatosTodosAction(pAccion)) {
     }

     public genContadorSegmentoDatosTodosActionExchange(genContadorSegmentoDatosTodosActionEnum.EnumgenContadorSegmentoDatosTodosAction pAccion, GeneralesCommon.genContadorSegmentoDatosTodosDS pdsParam) : base(genContadorSegmentoDatosTodosActionEnum.GetAcciongenContadorSegmentoDatosTodosAction(pAccion), pdsParam) {
     }

     public genContadorSegmentoDatosTodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genContadorSegmentoDatosTodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genContadorSegmentoDatosTodosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genContadorSegmentoDatosTodosDS)mParam;
	        }
     }
  }
}
