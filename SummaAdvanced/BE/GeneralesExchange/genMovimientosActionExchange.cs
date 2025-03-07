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
    public class genMovimientosActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int64 genEntidades {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public Int16 CantCuotas {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["CantCuotas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].CantCuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].CantCuotas = value;
               }
	          }
        public bool IsCantCuotasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsCantCuotasNull();
             }
	        }
        public String ClieProv {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["ClieProv"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].ClieProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].ClieProv = value;
               }
	          }
        public bool IsClieProvNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsClieProvNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public String ClieProv_Id {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["ClieProv_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].ClieProv_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].ClieProv_Id = value;
               }
	          }
        public bool IsClieProv_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsClieProv_IdNull();
             }
	        }
        public Int32 Segmento_Id {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMovimientosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovimientosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMovimientosDS );
     }
     public genMovimientosActionExchange() : base( "genMovimientos" ) {
     }

     public genMovimientosActionExchange(genMovimientosActionEnum.EnumgenMovimientosAction pAccion) : base(genMovimientosActionEnum.GetAcciongenMovimientosAction(pAccion)) {
     }

     public genMovimientosActionExchange(genMovimientosActionEnum.EnumgenMovimientosAction pAccion, GeneralesCommon.genMovimientosDS pdsParam) : base(genMovimientosActionEnum.GetAcciongenMovimientosAction(pAccion), pdsParam) {
     }

     public genMovimientosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMovimientosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMovimientosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMovimientosDS)mParam;
	        }
     }
  }
}
