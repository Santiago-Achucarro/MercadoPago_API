using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comConsEdoCtaOcEmbActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public String SegmentoSTR {
            get {
                if(((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0]["SegmentoSTR"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].SegmentoSTR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].SegmentoSTR = value;
               }
	          }
        public bool IsSegmentoSTRNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].IsSegmentoSTRNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaOcEmbDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comConsEdoCtaOcEmbDS );
     }
     public comConsEdoCtaOcEmbActionExchange() : base( "comConsEdoCtaOcEmb" ) {
     }

     public comConsEdoCtaOcEmbActionExchange(comConsEdoCtaOcEmbActionEnum.EnumcomConsEdoCtaOcEmbAction pAccion) : base(comConsEdoCtaOcEmbActionEnum.GetAccioncomConsEdoCtaOcEmbAction(pAccion)) {
     }

     public comConsEdoCtaOcEmbActionExchange(comConsEdoCtaOcEmbActionEnum.EnumcomConsEdoCtaOcEmbAction pAccion, ComprasCommon.comConsEdoCtaOcEmbDS pdsParam) : base(comConsEdoCtaOcEmbActionEnum.GetAccioncomConsEdoCtaOcEmbAction(pAccion), pdsParam) {
     }

     public comConsEdoCtaOcEmbActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comConsEdoCtaOcEmbDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comConsEdoCtaOcEmbDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comConsEdoCtaOcEmbDS)mParam;
	        }
     }
  }
}
