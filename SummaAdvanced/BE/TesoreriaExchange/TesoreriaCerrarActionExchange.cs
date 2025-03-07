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
    public class TesoreriaCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesoreriaCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.TesoreriaCerrarDS );
     }
     public TesoreriaCerrarActionExchange() : base( "TesoreriaCerrar" ) {
     }

     public TesoreriaCerrarActionExchange(TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction pAccion) : base(TesoreriaCerrarActionEnum.GetAccionTesoreriaCerrarAction(pAccion)) {
     }

     public TesoreriaCerrarActionExchange(TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction pAccion, TesoreriaCommon.TesoreriaCerrarDS pdsParam) : base(TesoreriaCerrarActionEnum.GetAccionTesoreriaCerrarAction(pAccion), pdsParam) {
     }

     public TesoreriaCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.TesoreriaCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.TesoreriaCerrarDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.TesoreriaCerrarDS)mParam;
	        }
     }
  }
}
