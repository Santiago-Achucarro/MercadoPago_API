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
    public class FechaBaseActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((GeneralesCommon.FechaBaseDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.FechaBaseDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.FechaBaseDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.FechaBaseDS );
     }
     public FechaBaseActionExchange() : base( "FechaBase" ) {
     }

     public FechaBaseActionExchange(FechaBaseActionEnum.EnumFechaBaseAction pAccion) : base(FechaBaseActionEnum.GetAccionFechaBaseAction(pAccion)) {
     }

     public FechaBaseActionExchange(FechaBaseActionEnum.EnumFechaBaseAction pAccion, GeneralesCommon.FechaBaseDS pdsParam) : base(FechaBaseActionEnum.GetAccionFechaBaseAction(pAccion), pdsParam) {
     }

     public FechaBaseActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.FechaBaseDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public FechaBaseActionExchange(GeneralesCommon.FechaBaseDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.FechaBaseDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.FechaBaseDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.FechaBaseDS)mParam;
	        }
     }
  }
}
