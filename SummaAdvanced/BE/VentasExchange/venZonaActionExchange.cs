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
    public class venZonaActionExchange : Framework.Core.Exchange{

        public Int32 venZona {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["venZona"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].venZona;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].venZona = value;
               }
	          }
        public bool IsvenZonaNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsvenZonaNull();
             }
	        }
        public String Zona_Id {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Zona_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Zona_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Zona_Id = value;
               }
	          }
        public bool IsZona_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsZona_IdNull();
             }
	        }
        public String Zona_Id_Nueva {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Zona_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Zona_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Zona_Id_Nueva = value;
               }
	          }
        public bool IsZona_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsZona_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venZonaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venZonaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venZonaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venZonaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venZonaDS );
     }
     public venZonaActionExchange() : base( "venZona" ) {
     }

     public venZonaActionExchange(venZonaActionEnum.EnumvenZonaAction pAccion) : base(venZonaActionEnum.GetAccionvenZonaAction(pAccion)) {
     }

     public venZonaActionExchange(venZonaActionEnum.EnumvenZonaAction pAccion, VentasCommon.venZonaDS pdsParam) : base(venZonaActionEnum.GetAccionvenZonaAction(pAccion), pdsParam) {
     }

     public venZonaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venZonaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venZonaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venZonaDS)mParam;
	        }
     }
  }
}
