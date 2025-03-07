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
    public class comMovpAnexoContActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoContDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovpAnexoContDS );
     }
     public comMovpAnexoContActionExchange() : base( "comMovpAnexoCont" ) {
     }

     public comMovpAnexoContActionExchange(comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction pAccion) : base(comMovpAnexoContActionEnum.GetAccioncomMovpAnexoContAction(pAccion)) {
     }

     public comMovpAnexoContActionExchange(comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction pAccion, ComprasCommon.comMovpAnexoContDS pdsParam) : base(comMovpAnexoContActionEnum.GetAccioncomMovpAnexoContAction(pAccion), pdsParam) {
     }

     public comMovpAnexoContActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovpAnexoContDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovpAnexoContDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovpAnexoContDS)mParam;
	        }
     }
  }
}
