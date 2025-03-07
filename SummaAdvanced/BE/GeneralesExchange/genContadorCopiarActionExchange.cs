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
    public class genContadorCopiarActionExchange : Framework.Core.Exchange{

        public String SucursalOrigen {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["SucursalOrigen"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalOrigen = value;
               }
	          }
        public bool IsSucursalOrigenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsSucursalOrigenNull();
             }
	        }
        public String DescripcionOrigen {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["DescripcionOrigen"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionOrigen = value;
               }
	          }
        public bool IsDescripcionOrigenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsDescripcionOrigenNull();
             }
	        }
        public String SucursalDestinoDesde {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["SucursalDestinoDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalDestinoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalDestinoDesde = value;
               }
	          }
        public bool IsSucursalDestinoDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsSucursalDestinoDesdeNull();
             }
	        }
        public String DescripcionDestinoDesde {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["DescripcionDestinoDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionDestinoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionDestinoDesde = value;
               }
	          }
        public bool IsDescripcionDestinoDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsDescripcionDestinoDesdeNull();
             }
	        }
        public String SucursalDestinoHasta {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["SucursalDestinoHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalDestinoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].SucursalDestinoHasta = value;
               }
	          }
        public bool IsSucursalDestinoHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsSucursalDestinoHastaNull();
             }
	        }
        public String DescripcionDestinoHasta {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["DescripcionDestinoHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionDestinoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].DescripcionDestinoHasta = value;
               }
	          }
        public bool IsDescripcionDestinoHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsDescripcionDestinoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genContadorCopiarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genContadorCopiarDS );
     }
     public genContadorCopiarActionExchange() : base( "genContadorCopiar" ) {
     }

     public genContadorCopiarActionExchange(genContadorCopiarActionEnum.EnumgenContadorCopiarAction pAccion) : base(genContadorCopiarActionEnum.GetAcciongenContadorCopiarAction(pAccion)) {
     }

     public genContadorCopiarActionExchange(genContadorCopiarActionEnum.EnumgenContadorCopiarAction pAccion, GeneralesCommon.genContadorCopiarDS pdsParam) : base(genContadorCopiarActionEnum.GetAcciongenContadorCopiarAction(pAccion), pdsParam) {
     }

     public genContadorCopiarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genContadorCopiarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genContadorCopiarDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genContadorCopiarDS)mParam;
	        }
     }
  }
}
