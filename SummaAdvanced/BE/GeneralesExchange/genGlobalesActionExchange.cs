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
    public class genGlobalesActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Nombre_Var {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Nombre_Var"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Nombre_Var;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Nombre_Var = value;
               }
	          }
        public bool IsNombre_VarNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsNombre_VarNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Tipo {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Int16 Longitud {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Longitud"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Longitud;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Longitud = value;
               }
	          }
        public bool IsLongitudNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsLongitudNull();
             }
	        }
        public Decimal Decimales {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public Decimal nValor {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["nValor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].nValor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].nValor = value;
               }
	          }
        public bool IsnValorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsnValorNull();
             }
	        }
        public String cValor {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["cValor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].cValor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].cValor = value;
               }
	          }
        public bool IscValorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IscValorNull();
             }
	        }
        public DateTime fValor {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["fValor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].fValor;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].fValor = value;
               }
	          }
        public bool IsfValorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsfValorNull();
             }
	        }
        public String mValor {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["mValor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].mValor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].mValor = value;
               }
	          }
        public bool IsmValorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsmValorNull();
             }
	        }
        public String SubSistema {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["SubSistema"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].SubSistema;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].SubSistema = value;
               }
	          }
        public bool IsSubSistemaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsSubSistemaNull();
             }
	        }
        public Boolean SoloLectura {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["SoloLectura"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].SoloLectura;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].SoloLectura = value;
               }
	          }
        public bool IsSoloLecturaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsSoloLecturaNull();
             }
	        }
        public String lupIdentidad {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["lupIdentidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].lupIdentidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].lupIdentidad = value;
               }
	          }
        public bool IslupIdentidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IslupIdentidadNull();
             }
	        }
        public String WhereF10 {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["WhereF10"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].WhereF10;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].WhereF10 = value;
               }
	          }
        public bool IsWhereF10Null {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsWhereF10Null();
             }
	        }
        public String DescripcionEmpresa {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["DescripcionEmpresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].DescripcionEmpresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].DescripcionEmpresa = value;
               }
	          }
        public bool IsDescripcionEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsDescripcionEmpresaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genGlobalesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGlobalesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genGlobalesDS );
     }
     public genGlobalesActionExchange() : base( "genGlobales" ) {
     }

     public genGlobalesActionExchange(genGlobalesActionEnum.EnumgenGlobalesAction pAccion) : base(genGlobalesActionEnum.GetAcciongenGlobalesAction(pAccion)) {
     }

     public genGlobalesActionExchange(genGlobalesActionEnum.EnumgenGlobalesAction pAccion, GeneralesCommon.genGlobalesDS pdsParam) : base(genGlobalesActionEnum.GetAcciongenGlobalesAction(pAccion), pdsParam) {
     }

     public genGlobalesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genGlobalesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genGlobalesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genGlobalesDS)mParam;
	        }
     }
  }
}
