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
    public class comOrigenesFiscalesActionExchange : Framework.Core.Exchange{

        public Int32 comOrigenesFiscales {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["comOrigenesFiscales"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].comOrigenesFiscales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].comOrigenesFiscales = value;
               }
	          }
        public bool IscomOrigenesFiscalesNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IscomOrigenesFiscalesNull();
             }
	        }
        public Int16 Origen_Id {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["Origen_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Origen_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Origen_Id = value;
               }
	          }
        public bool IsOrigen_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsOrigen_IdNull();
             }
	        }
        public Int16 Origen_Id_Nueva {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["Origen_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Origen_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Origen_Id_Nueva = value;
               }
	          }
        public bool IsOrigen_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsOrigen_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String DescripcionDominios {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["DescripcionDominios"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].DescripcionDominios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].DescripcionDominios = value;
               }
	          }
        public bool IsDescripcionDominiosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsDescripcionDominiosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrigenesFiscalesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrigenesFiscalesDS );
     }
     public comOrigenesFiscalesActionExchange() : base( "comOrigenesFiscales" ) {
     }

     public comOrigenesFiscalesActionExchange(comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction pAccion) : base(comOrigenesFiscalesActionEnum.GetAccioncomOrigenesFiscalesAction(pAccion)) {
     }

     public comOrigenesFiscalesActionExchange(comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction pAccion, ComprasCommon.comOrigenesFiscalesDS pdsParam) : base(comOrigenesFiscalesActionEnum.GetAccioncomOrigenesFiscalesAction(pAccion), pdsParam) {
     }

     public comOrigenesFiscalesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrigenesFiscalesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrigenesFiscalesDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrigenesFiscalesDS)mParam;
	        }
     }
  }
}
