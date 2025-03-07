using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venLPTablaActionExchange : Framework.Core.Exchange{

        public Int32 Tabla_Id {
            get {
                if(((VentasCommon.venLPTablaDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTablaDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTablaDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTablaDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venLPTablaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTablaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTablaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTablaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLPTablaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLPTablaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLPTablaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLPTablaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLPTablaDS );
     }
     public venLPTablaActionExchange() : base( "venLPTabla" ) {
     }

     public venLPTablaActionExchange(venLPTablaActionEnum.EnumvenLPTablaAction pAccion) : base(venLPTablaActionEnum.GetAccionvenLPTablaAction(pAccion)) {
     }

     public venLPTablaActionExchange(venLPTablaActionEnum.EnumvenLPTablaAction pAccion, VentasCommon.venLPTablaDS pdsParam) : base(venLPTablaActionEnum.GetAccionvenLPTablaAction(pAccion), pdsParam) {
     }

     public venLPTablaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLPTablaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venLPTablaActionExchange(VentasCommon.venLPTablaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venLPTablaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLPTablaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLPTablaDS)mParam;
	        }
     }
  }
}
