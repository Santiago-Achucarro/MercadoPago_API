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
    public class comListaNegraMXActionExchange : Framework.Core.Exchange{

        public String RFC {
            get {
                if(((ComprasCommon.comListaNegraMXDS)mParam).Principal[0]["RFC"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].RFC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].RFC = value;
               }
	          }
        public bool IsRFCNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].IsRFCNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comListaNegraMXDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Situacion {
            get {
                if(((ComprasCommon.comListaNegraMXDS)mParam).Principal[0]["Situacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].Situacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].Situacion = value;
               }
	          }
        public bool IsSituacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].IsSituacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comListaNegraMXDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraMXDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comListaNegraMXDS );
     }
     public comListaNegraMXActionExchange() : base( "comListaNegraMX" ) {
     }

     public comListaNegraMXActionExchange(comListaNegraMXActionEnum.EnumcomListaNegraMXAction pAccion) : base(comListaNegraMXActionEnum.GetAccioncomListaNegraMXAction(pAccion)) {
     }

     public comListaNegraMXActionExchange(comListaNegraMXActionEnum.EnumcomListaNegraMXAction pAccion, ComprasCommon.comListaNegraMXDS pdsParam) : base(comListaNegraMXActionEnum.GetAccioncomListaNegraMXAction(pAccion), pdsParam) {
     }

     public comListaNegraMXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comListaNegraMXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comListaNegraMXDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comListaNegraMXDS)mParam;
	        }
     }
  }
}
