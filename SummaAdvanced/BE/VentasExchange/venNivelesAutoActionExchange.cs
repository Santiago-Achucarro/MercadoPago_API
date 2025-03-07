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
    public class venNivelesAutoActionExchange : Framework.Core.Exchange{

        public Int32 venNivelesAuto {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["venNivelesAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].venNivelesAuto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].venNivelesAuto = value;
               }
	          }
        public bool IsvenNivelesAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsvenNivelesAutoNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String NivelAuto_Id_Nueva {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["NivelAuto_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].NivelAuto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].NivelAuto_Id_Nueva = value;
               }
	          }
        public bool IsNivelAuto_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsNivelAuto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venNivelesAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venNivelesAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venNivelesAutoDS );
     }
     public venNivelesAutoActionExchange() : base( "venNivelesAuto" ) {
     }

     public venNivelesAutoActionExchange(venNivelesAutoActionEnum.EnumvenNivelesAutoAction pAccion) : base(venNivelesAutoActionEnum.GetAccionvenNivelesAutoAction(pAccion)) {
     }

     public venNivelesAutoActionExchange(venNivelesAutoActionEnum.EnumvenNivelesAutoAction pAccion, VentasCommon.venNivelesAutoDS pdsParam) : base(venNivelesAutoActionEnum.GetAccionvenNivelesAutoAction(pAccion), pdsParam) {
     }

     public venNivelesAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venNivelesAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venNivelesAutoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venNivelesAutoDS)mParam;
	        }
     }
  }
}
