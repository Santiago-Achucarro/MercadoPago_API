using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proProgramasSegmentoActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 proProgramas {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["proProgramas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].proProgramas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].proProgramas = value;
               }
	          }
        public bool IsproProgramasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsproProgramasNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramasSegmentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramasSegmentoDS );
     }
     public proProgramasSegmentoActionExchange() : base( "proProgramasSegmento" ) {
     }

     public proProgramasSegmentoActionExchange(proProgramasSegmentoActionEnum.EnumproProgramasSegmentoAction pAccion) : base(proProgramasSegmentoActionEnum.GetAccionproProgramasSegmentoAction(pAccion)) {
     }

     public proProgramasSegmentoActionExchange(proProgramasSegmentoActionEnum.EnumproProgramasSegmentoAction pAccion, ProduccionCommon.proProgramasSegmentoDS pdsParam) : base(proProgramasSegmentoActionEnum.GetAccionproProgramasSegmentoAction(pAccion), pdsParam) {
     }

     public proProgramasSegmentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramasSegmentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramasSegmentoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramasSegmentoDS)mParam;
	        }
     }
  }
}
