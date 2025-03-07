using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comRISegmentoActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento1N_Nueva {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento1N_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1N_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1N_Nueva = value;
               }
	          }
        public bool IsSegmento1N_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento1N_NuevaNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 comReqInterno {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["comReqInterno"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].comReqInterno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].comReqInterno = value;
               }
	          }
        public bool IscomReqInternoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IscomReqInternoNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comRISegmentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRISegmentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRISegmentoDS );
     }
     public comRISegmentoActionExchange() : base( "comRISegmento" ) {
     }

     public comRISegmentoActionExchange(comRISegmentoActionEnum.EnumcomRISegmentoAction pAccion) : base(comRISegmentoActionEnum.GetAccioncomRISegmentoAction(pAccion)) {
     }

     public comRISegmentoActionExchange(comRISegmentoActionEnum.EnumcomRISegmentoAction pAccion, ComprasCommon.comRISegmentoDS pdsParam) : base(comRISegmentoActionEnum.GetAccioncomRISegmentoAction(pAccion), pdsParam) {
     }

     public comRISegmentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRISegmentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRISegmentoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRISegmentoDS)mParam;
	        }
     }
  }
}
