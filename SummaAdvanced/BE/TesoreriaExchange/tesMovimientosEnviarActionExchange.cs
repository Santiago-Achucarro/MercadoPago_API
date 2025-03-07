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
    public class tesMovimientosEnviarActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosEnviarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesMovimientosEnviarDS );
     }
     public tesMovimientosEnviarActionExchange() : base( "tesMovimientosEnviar" ) {
     }

     public tesMovimientosEnviarActionExchange(tesMovimientosEnviarActionEnum.EnumtesMovimientosEnviarAction pAccion) : base(tesMovimientosEnviarActionEnum.GetAcciontesMovimientosEnviarAction(pAccion)) {
     }

     public tesMovimientosEnviarActionExchange(tesMovimientosEnviarActionEnum.EnumtesMovimientosEnviarAction pAccion, TesoreriaCommon.tesMovimientosEnviarDS pdsParam) : base(tesMovimientosEnviarActionEnum.GetAcciontesMovimientosEnviarAction(pAccion), pdsParam) {
     }

     public tesMovimientosEnviarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesMovimientosEnviarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesMovimientosEnviarActionExchange(TesoreriaCommon.tesMovimientosEnviarDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesMovimientosEnviarDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesMovimientosEnviarDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesMovimientosEnviarDS)mParam;
	        }
     }
  }
}
