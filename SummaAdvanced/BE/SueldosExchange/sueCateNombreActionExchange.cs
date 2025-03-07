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
    public class sueCateNombreActionExchange : Framework.Core.Exchange{

        public Int32 CateNombre_Id {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["CateNombre_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].CateNombre_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].CateNombre_Id = value;
               }
	          }
        public bool IsCateNombre_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsCateNombre_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean PorEmpresa {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["PorEmpresa"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].PorEmpresa;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].PorEmpresa = value;
               }
	          }
        public bool IsPorEmpresaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsPorEmpresaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueCateNombreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCateNombreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueCateNombreDS );
     }
     public sueCateNombreActionExchange() : base( "sueCateNombre" ) {
     }

     public sueCateNombreActionExchange(sueCateNombreActionEnum.EnumsueCateNombreAction pAccion) : base(sueCateNombreActionEnum.GetAccionsueCateNombreAction(pAccion)) {
     }

     public sueCateNombreActionExchange(sueCateNombreActionEnum.EnumsueCateNombreAction pAccion, SueldosCommon.sueCateNombreDS pdsParam) : base(sueCateNombreActionEnum.GetAccionsueCateNombreAction(pAccion), pdsParam) {
     }

     public sueCateNombreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueCateNombreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueCateNombreDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueCateNombreDS)mParam;
	        }
     }
  }
}
