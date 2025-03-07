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
    public class sueArchivosTxtCuerpoActionExchange : Framework.Core.Exchange{

        public String DescripcionCabecera {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["DescripcionCabecera"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].DescripcionCabecera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].DescripcionCabecera = value;
               }
	          }
        public bool IsDescripcionCabeceraNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsDescripcionCabeceraNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String Formula {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Formula"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Formula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Formula = value;
               }
	          }
        public bool IsFormulaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsFormulaNull();
             }
	        }
        public String Tipo {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Int16 Longitud {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Longitud"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Longitud;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Longitud = value;
               }
	          }
        public bool IsLongitudNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsLongitudNull();
             }
	        }
        public Int16 Decimales {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public String Relleno {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Relleno"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Relleno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Relleno = value;
               }
	          }
        public bool IsRellenoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsRellenoNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Orden {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public String Formato {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Formato"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Formato;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Formato = value;
               }
	          }
        public bool IsFormatoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsFormatoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivosTxtCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueArchivosTxtCuerpoDS );
     }
     public sueArchivosTxtCuerpoActionExchange() : base( "sueArchivosTxtCuerpo" ) {
     }

     public sueArchivosTxtCuerpoActionExchange(sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction pAccion) : base(sueArchivosTxtCuerpoActionEnum.GetAccionsueArchivosTxtCuerpoAction(pAccion)) {
     }

     public sueArchivosTxtCuerpoActionExchange(sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction pAccion, SueldosCommon.sueArchivosTxtCuerpoDS pdsParam) : base(sueArchivosTxtCuerpoActionEnum.GetAccionsueArchivosTxtCuerpoAction(pAccion), pdsParam) {
     }

     public sueArchivosTxtCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueArchivosTxtCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueArchivosTxtCuerpoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueArchivosTxtCuerpoDS)mParam;
	        }
     }
  }
}
