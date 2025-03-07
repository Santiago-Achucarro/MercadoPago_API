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
    public class comAsiSegmentosAnulActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Empresa_Id1 {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Empresa_Id1"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Empresa_Id1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Empresa_Id1 = value;
               }
	          }
        public bool IsEmpresa_Id1Null {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsEmpresa_Id1Null();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public String DescripciongenSegmentos {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["DescripciongenSegmentos"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].DescripciongenSegmentos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].DescripciongenSegmentos = value;
               }
	          }
        public bool IsDescripciongenSegmentosNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsDescripciongenSegmentosNull();
             }
	        }
        public DateTime FechaAnulacion {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["FechaAnulacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].FechaAnulacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].FechaAnulacion = value;
               }
	          }
        public bool IsFechaAnulacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsFechaAnulacionNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiSegmentosAnulDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comAsiSegmentosAnulDS );
     }
     public comAsiSegmentosAnulActionExchange() : base( "comAsiSegmentosAnul" ) {
     }

     public comAsiSegmentosAnulActionExchange(comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction pAccion) : base(comAsiSegmentosAnulActionEnum.GetAccioncomAsiSegmentosAnulAction(pAccion)) {
     }

     public comAsiSegmentosAnulActionExchange(comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction pAccion, ComprasCommon.comAsiSegmentosAnulDS pdsParam) : base(comAsiSegmentosAnulActionEnum.GetAccioncomAsiSegmentosAnulAction(pAccion), pdsParam) {
     }

     public comAsiSegmentosAnulActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comAsiSegmentosAnulDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comAsiSegmentosAnulDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comAsiSegmentosAnulDS)mParam;
	        }
     }
  }
}
