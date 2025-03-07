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
    public class tesCheqPropEstadoActionExchange : Framework.Core.Exchange{

        public String Estado_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropEstadoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqPropEstadoDS );
     }
     public tesCheqPropEstadoActionExchange() : base( "tesCheqPropEstado" ) {
     }

     public tesCheqPropEstadoActionExchange(tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction pAccion) : base(tesCheqPropEstadoActionEnum.GetAcciontesCheqPropEstadoAction(pAccion)) {
     }

     public tesCheqPropEstadoActionExchange(tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction pAccion, TesoreriaCommon.tesCheqPropEstadoDS pdsParam) : base(tesCheqPropEstadoActionEnum.GetAcciontesCheqPropEstadoAction(pAccion), pdsParam) {
     }

     public tesCheqPropEstadoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqPropEstadoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqPropEstadoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqPropEstadoDS)mParam;
	        }
     }
  }
}
