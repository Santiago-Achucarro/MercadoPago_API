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
    public class genSegmentoStrActionExchange : Framework.Core.Exchange{

        public String SegmentoSTR {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["SegmentoSTR"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].SegmentoSTR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].SegmentoSTR = value;
               }
	          }
        public bool IsSegmentoSTRNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmentoSTRNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentoStrDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSegmentoStrDS );
     }
     public genSegmentoStrActionExchange() : base( "genSegmentoStr" ) {
     }

     public genSegmentoStrActionExchange(genSegmentoStrActionEnum.EnumgenSegmentoStrAction pAccion) : base(genSegmentoStrActionEnum.GetAcciongenSegmentoStrAction(pAccion)) {
     }

     public genSegmentoStrActionExchange(genSegmentoStrActionEnum.EnumgenSegmentoStrAction pAccion, GeneralesCommon.genSegmentoStrDS pdsParam) : base(genSegmentoStrActionEnum.GetAcciongenSegmentoStrAction(pAccion), pdsParam) {
     }

     public genSegmentoStrActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSegmentoStrDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSegmentoStrDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSegmentoStrDS)mParam;
	        }
     }
  }
}
