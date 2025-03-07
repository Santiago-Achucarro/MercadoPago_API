using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venRegionActionExchange : Framework.Core.Exchange{

        public Int32 venRegion {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["venRegion"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].venRegion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].venRegion = value;
               }
	          }
        public bool IsvenRegionNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsvenRegionNull();
             }
	        }
        public String Region_Id {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Region_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Region_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Region_Id = value;
               }
	          }
        public bool IsRegion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsRegion_IdNull();
             }
	        }
        public String Region_Id_Nueva {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Region_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Region_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Region_Id_Nueva = value;
               }
	          }
        public bool IsRegion_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsRegion_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRegionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRegionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRegionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRegionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRegionDS );
     }
     public venRegionActionExchange() : base( "venRegion" ) {
     }

     public venRegionActionExchange(venRegionActionEnum.EnumvenRegionAction pAccion) : base(venRegionActionEnum.GetAccionvenRegionAction(pAccion)) {
     }

     public venRegionActionExchange(venRegionActionEnum.EnumvenRegionAction pAccion, VentasCommon.venRegionDS pdsParam) : base(venRegionActionEnum.GetAccionvenRegionAction(pAccion), pdsParam) {
     }

     public venRegionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRegionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRegionDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRegionDS)mParam;
	        }
     }
  }
}
