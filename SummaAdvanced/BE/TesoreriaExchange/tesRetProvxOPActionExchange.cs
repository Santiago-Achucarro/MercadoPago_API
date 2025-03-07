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
    public class tesRetProvxOPActionExchange : Framework.Core.Exchange{

        public Int32 Segmento1N_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento1N_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento1N_OP;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento1N_OP = value;
               }
	          }
        public bool IsSegmento1N_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento1N_OPNull();
             }
	        }
        public Int32 Segmento2N_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento2N_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento2N_OP;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento2N_OP = value;
               }
	          }
        public bool IsSegmento2N_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento2N_OPNull();
             }
	        }
        public Int32 Segmento3N_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento3N_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento3N_OP;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento3N_OP = value;
               }
	          }
        public bool IsSegmento3N_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento3N_OPNull();
             }
	        }
        public Int32 Segmento4N_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento4N_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento4N_OP;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento4N_OP = value;
               }
	          }
        public bool IsSegmento4N_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento4N_OPNull();
             }
	        }
        public String Segmento1C_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento1C_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento1C_OP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento1C_OP = value;
               }
	          }
        public bool IsSegmento1C_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento1C_OPNull();
             }
	        }
        public String Segmento2C_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento2C_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento2C_OP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento2C_OP = value;
               }
	          }
        public bool IsSegmento2C_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento2C_OPNull();
             }
	        }
        public String Segmento3C_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento3C_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento3C_OP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento3C_OP = value;
               }
	          }
        public bool IsSegmento3C_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento3C_OPNull();
             }
	        }
        public String Segmento4C_OP {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Segmento4C_OP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento4C_OP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Segmento4C_OP = value;
               }
	          }
        public bool IsSegmento4C_OPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsSegmento4C_OPNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRetProvxOPDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRetProvxOPDS );
     }
     public tesRetProvxOPActionExchange() : base( "tesRetProvxOP" ) {
     }

     public tesRetProvxOPActionExchange(tesRetProvxOPActionEnum.EnumtesRetProvxOPAction pAccion) : base(tesRetProvxOPActionEnum.GetAcciontesRetProvxOPAction(pAccion)) {
     }

     public tesRetProvxOPActionExchange(tesRetProvxOPActionEnum.EnumtesRetProvxOPAction pAccion, TesoreriaCommon.tesRetProvxOPDS pdsParam) : base(tesRetProvxOPActionEnum.GetAcciontesRetProvxOPAction(pAccion), pdsParam) {
     }

     public tesRetProvxOPActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRetProvxOPDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRetProvxOPDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRetProvxOPDS)mParam;
	        }
     }
  }
}
