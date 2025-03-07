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
    public class genContadorSegmentoActionExchange : Framework.Core.Exchange{

        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String DescripcionSegmentos {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["DescripcionSegmentos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].DescripcionSegmentos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].DescripcionSegmentos = value;
               }
	          }
        public bool IsDescripcionSegmentosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsDescripcionSegmentosNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 PrimerNumero {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["PrimerNumero"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].PrimerNumero;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].PrimerNumero = value;
               }
	          }
        public bool IsPrimerNumeroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsPrimerNumeroNull();
             }
	        }
        public String Cai {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Cai"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Cai;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Cai = value;
               }
	          }
        public bool IsCaiNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsCaiNull();
             }
	        }
        public DateTime FechaCai {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["FechaCai"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaCai;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaCai = value;
               }
	          }
        public bool IsFechaCaiNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsFechaCaiNull();
             }
	        }
        public Int32 NumeroDesde {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["NumeroDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].NumeroDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].NumeroDesde = value;
               }
	          }
        public bool IsNumeroDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsNumeroDesdeNull();
             }
	        }
        public Int32 NumeroHasta {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["NumeroHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].NumeroHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].NumeroHasta = value;
               }
	          }
        public bool IsNumeroHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsNumeroHastaNull();
             }
	        }
        public DateTime FechaAutoSRI {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["FechaAutoSRI"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaAutoSRI;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaAutoSRI = value;
               }
	          }
        public bool IsFechaAutoSRINull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsFechaAutoSRINull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorSegmentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genContadorSegmentoDS );
     }
     public genContadorSegmentoActionExchange() : base( "genContadorSegmento" ) {
     }

     public genContadorSegmentoActionExchange(genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction pAccion) : base(genContadorSegmentoActionEnum.GetAcciongenContadorSegmentoAction(pAccion)) {
     }

     public genContadorSegmentoActionExchange(genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction pAccion, GeneralesCommon.genContadorSegmentoDS pdsParam) : base(genContadorSegmentoActionEnum.GetAcciongenContadorSegmentoAction(pAccion), pdsParam) {
     }

     public genContadorSegmentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genContadorSegmentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genContadorSegmentoDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genContadorSegmentoDS)mParam;
	        }
     }
  }
}
