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
    public class sueConceptosPropTodosActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosPropTodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConceptosPropTodosDS );
     }
     public sueConceptosPropTodosActionExchange() : base( "sueConceptosPropTodos" ) {
     }

     public sueConceptosPropTodosActionExchange(sueConceptosPropTodosActionEnum.EnumsueConceptosPropTodosAction pAccion) : base(sueConceptosPropTodosActionEnum.GetAccionsueConceptosPropTodosAction(pAccion)) {
     }

     public sueConceptosPropTodosActionExchange(sueConceptosPropTodosActionEnum.EnumsueConceptosPropTodosAction pAccion, SueldosCommon.sueConceptosPropTodosDS pdsParam) : base(sueConceptosPropTodosActionEnum.GetAccionsueConceptosPropTodosAction(pAccion), pdsParam) {
     }

     public sueConceptosPropTodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConceptosPropTodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueConceptosPropTodosActionExchange(SueldosCommon.sueConceptosPropTodosDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueConceptosPropTodosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConceptosPropTodosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConceptosPropTodosDS)mParam;
	        }
     }
  }
}
