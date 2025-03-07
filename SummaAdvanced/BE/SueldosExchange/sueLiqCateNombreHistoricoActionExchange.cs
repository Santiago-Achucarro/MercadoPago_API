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
    public class sueLiqCateNombreHistoricoActionExchange : Framework.Core.Exchange{

        public String Categoria_Id {
            get {
                if(((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0]["Categoria_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].Categoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].Categoria_Id = value;
               }
	          }
        public bool IsCategoria_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].IsCategoria_IdNull();
             }
	        }
        public String DescripcionCate {
            get {
                if(((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0]["DescripcionCate"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].DescripcionCate;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].DescripcionCate = value;
               }
	          }
        public bool IsDescripcionCateNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].IsDescripcionCateNull();
             }
	        }
        public Int32 CateNombre_Id {
            get {
                if(((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0]["CateNombre_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].CateNombre_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].CateNombre_Id = value;
               }
	          }
        public bool IsCateNombre_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].IsCateNombre_IdNull();
             }
	        }
        public String DescripcionCateNombre {
            get {
                if(((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0]["DescripcionCateNombre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].DescripcionCateNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].DescripcionCateNombre = value;
               }
	          }
        public bool IsDescripcionCateNombreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].IsDescripcionCateNombreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqCateNombreHistoricoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqCateNombreHistoricoDS );
     }
     public sueLiqCateNombreHistoricoActionExchange() : base( "sueLiqCateNombreHistorico" ) {
     }

     public sueLiqCateNombreHistoricoActionExchange(sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction pAccion) : base(sueLiqCateNombreHistoricoActionEnum.GetAccionsueLiqCateNombreHistoricoAction(pAccion)) {
     }

     public sueLiqCateNombreHistoricoActionExchange(sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction pAccion, SueldosCommon.sueLiqCateNombreHistoricoDS pdsParam) : base(sueLiqCateNombreHistoricoActionEnum.GetAccionsueLiqCateNombreHistoricoAction(pAccion), pdsParam) {
     }

     public sueLiqCateNombreHistoricoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqCateNombreHistoricoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqCateNombreHistoricoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqCateNombreHistoricoDS)mParam;
	        }
     }
  }
}
