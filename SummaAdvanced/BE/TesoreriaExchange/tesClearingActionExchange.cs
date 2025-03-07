using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesClearingActionExchange : Framework.Core.Exchange{

        public String Clearing {
            get {
                if(((TesoreriaCommon.tesClearingDS)mParam).Principal[0]["Clearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Clearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Clearing = value;
               }
	          }
        public bool IsClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].IsClearingNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesClearingDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((TesoreriaCommon.tesClearingDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public String cVariable {
            get {
                if(((TesoreriaCommon.tesClearingDS)mParam).Principal[0]["cVariable"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].cVariable;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].cVariable = value;
               }
	          }
        public bool IscVariableNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].IscVariableNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesClearingDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesClearingDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesClearingDS );
     }
     public tesClearingActionExchange() : base( "tesClearing" ) {
     }

     public tesClearingActionExchange(tesClearingActionEnum.EnumtesClearingAction pAccion) : base(tesClearingActionEnum.GetAcciontesClearingAction(pAccion)) {
     }

     public tesClearingActionExchange(tesClearingActionEnum.EnumtesClearingAction pAccion, TesoreriaCommon.tesClearingDS pdsParam) : base(tesClearingActionEnum.GetAcciontesClearingAction(pAccion), pdsParam) {
     }

     public tesClearingActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesClearingDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesClearingDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesClearingDS)mParam;
	        }
     }
  }
}
