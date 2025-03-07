using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueArchivosTxtActionExchange : Framework.Core.Exchange{

        public Int32 sueArchivosTxt {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["sueArchivosTxt"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].sueArchivosTxt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].sueArchivosTxt = value;
               }
	          }
        public bool IssueArchivosTxtNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IssueArchivosTxtNull();
             }
	        }
        public String Archivo_id {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Archivo_id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Archivo_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Archivo_id = value;
               }
	          }
        public bool IsArchivo_idNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsArchivo_idNull();
             }
	        }
        public String Archivo_Id_Nueva {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Archivo_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Archivo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Archivo_Id_Nueva = value;
               }
	          }
        public bool IsArchivo_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsArchivo_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Res1Archivo_Id {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Res1Archivo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res1Archivo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res1Archivo_Id = value;
               }
	          }
        public bool IsRes1Archivo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsRes1Archivo_IdNull();
             }
	        }
        public String Res1Descripcion {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Res1Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res1Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res1Descripcion = value;
               }
	          }
        public bool IsRes1DescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsRes1DescripcionNull();
             }
	        }
        public String PosicionResumen1 {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["PosicionResumen1"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].PosicionResumen1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].PosicionResumen1 = value;
               }
	          }
        public bool IsPosicionResumen1Null {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsPosicionResumen1Null();
             }
	        }
        public String Res2Archivo_Id {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Res2Archivo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res2Archivo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res2Archivo_Id = value;
               }
	          }
        public bool IsRes2Archivo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsRes2Archivo_IdNull();
             }
	        }
        public String Res2Descripcion {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Res2Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res2Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Res2Descripcion = value;
               }
	          }
        public bool IsRes2DescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsRes2DescripcionNull();
             }
	        }
        public String PosicionResumen2 {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["PosicionResumen2"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].PosicionResumen2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].PosicionResumen2 = value;
               }
	          }
        public bool IsPosicionResumen2Null {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsPosicionResumen2Null();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueArchivosTxtDS );
     }
     public sueArchivosTxtActionExchange() : base( "sueArchivosTxt" ) {
     }

     public sueArchivosTxtActionExchange(sueArchivosTxtActionEnum.EnumsueArchivosTxtAction pAccion) : base(sueArchivosTxtActionEnum.GetAccionsueArchivosTxtAction(pAccion)) {
     }

     public sueArchivosTxtActionExchange(sueArchivosTxtActionEnum.EnumsueArchivosTxtAction pAccion, SueldosCommon.sueArchivosTxtDS pdsParam) : base(sueArchivosTxtActionEnum.GetAccionsueArchivosTxtAction(pAccion), pdsParam) {
     }

     public sueArchivosTxtActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueArchivosTxtDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueArchivosTxtDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueArchivosTxtDS)mParam;
	        }
     }
  }
}
