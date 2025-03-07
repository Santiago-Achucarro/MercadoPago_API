using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesSubTiposMovActionExchange : Framework.Core.Exchange{

        public Int32 tesSubTiposMov {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["tesSubTiposMov"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].tesSubTiposMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].tesSubTiposMov = value;
               }
	          }
        public bool IstesSubTiposMovNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IstesSubTiposMovNull();
             }
	        }
        public String SubTipo_Id {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["SubTipo_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].SubTipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].SubTipo_Id = value;
               }
	          }
        public bool IsSubTipo_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsSubTipo_IdNull();
             }
	        }
        public String SubTipo_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["SubTipo_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].SubTipo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].SubTipo_Id_Nueva = value;
               }
	          }
        public bool IsSubTipo_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsSubTipo_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 CantCopias {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["CantCopias"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].CantCopias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].CantCopias = value;
               }
	          }
        public bool IsCantCopiasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsCantCopiasNull();
             }
	        }
        public String Tipomov {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String Titulo {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSubTiposMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesSubTiposMovDS );
     }
     public tesSubTiposMovActionExchange() : base( "tesSubTiposMov" ) {
     }

     public tesSubTiposMovActionExchange(tesSubTiposMovActionEnum.EnumtesSubTiposMovAction pAccion) : base(tesSubTiposMovActionEnum.GetAcciontesSubTiposMovAction(pAccion)) {
     }

     public tesSubTiposMovActionExchange(tesSubTiposMovActionEnum.EnumtesSubTiposMovAction pAccion, TesoreriaCommon.tesSubTiposMovDS pdsParam) : base(tesSubTiposMovActionEnum.GetAcciontesSubTiposMovAction(pAccion), pdsParam) {
     }

     public tesSubTiposMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesSubTiposMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesSubTiposMovDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesSubTiposMovDS)mParam;
	        }
     }
  }
}
