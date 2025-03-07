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
    public class genMenusActionExchange : Framework.Core.Exchange{

        public String Orden {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Orden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String Tipo {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Opcion {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Opcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Opcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Opcion = value;
               }
	          }
        public bool IsOpcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsOpcionNull();
             }
	        }
        public String Formulario_id {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Formulario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Formulario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Formulario_id = value;
               }
	          }
        public bool IsFormulario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsFormulario_idNull();
             }
	        }
        public String FrmEspecial {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["FrmEspecial"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].FrmEspecial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].FrmEspecial = value;
               }
	          }
        public bool IsFrmEspecialNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsFrmEspecialNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String Orientacion {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Orientacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Orientacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Orientacion = value;
               }
	          }
        public bool IsOrientacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsOrientacionNull();
             }
	        }
        public String Pais {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Pais"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Pais;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Pais = value;
               }
	          }
        public bool IsPaisNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsPaisNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMenusDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMenusDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMenusDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMenusDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMenusDS );
     }
     public genMenusActionExchange() : base( "genMenus" ) {
     }

     public genMenusActionExchange(genMenusActionEnum.EnumgenMenusAction pAccion) : base(genMenusActionEnum.GetAcciongenMenusAction(pAccion)) {
     }

     public genMenusActionExchange(genMenusActionEnum.EnumgenMenusAction pAccion, GeneralesCommon.genMenusDS pdsParam) : base(genMenusActionEnum.GetAcciongenMenusAction(pAccion), pdsParam) {
     }

     public genMenusActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMenusDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMenusDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMenusDS)mParam;
	        }
     }
  }
}
