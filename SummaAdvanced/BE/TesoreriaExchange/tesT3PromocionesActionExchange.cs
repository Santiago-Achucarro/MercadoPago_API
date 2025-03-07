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
    public class tesT3PromocionesActionExchange : Framework.Core.Exchange{

        public Int32 tesT3Promociones {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["tesT3Promociones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].tesT3Promociones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].tesT3Promociones = value;
               }
	          }
        public bool IstesT3PromocionesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IstesT3PromocionesNull();
             }
	        }
        public Int32 Promocion_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Promocion_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Promocion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Promocion_Id = value;
               }
	          }
        public bool IsPromocion_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsPromocion_IdNull();
             }
	        }
        public Int32 Promocion_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Promocion_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Promocion_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Promocion_Id_Nueva = value;
               }
	          }
        public bool IsPromocion_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsPromocion_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public DateTime VigenciaDesde {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["VigenciaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].VigenciaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].VigenciaDesde = value;
               }
	          }
        public bool IsVigenciaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsVigenciaDesdeNull();
             }
	        }
        public DateTime VigenciaHasta {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["VigenciaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].VigenciaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].VigenciaHasta = value;
               }
	          }
        public bool IsVigenciaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsVigenciaHastaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesT3PromocionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesT3PromocionesDS );
     }
     public tesT3PromocionesActionExchange() : base( "tesT3Promociones" ) {
     }

     public tesT3PromocionesActionExchange(tesT3PromocionesActionEnum.EnumtesT3PromocionesAction pAccion) : base(tesT3PromocionesActionEnum.GetAcciontesT3PromocionesAction(pAccion)) {
     }

     public tesT3PromocionesActionExchange(tesT3PromocionesActionEnum.EnumtesT3PromocionesAction pAccion, TesoreriaCommon.tesT3PromocionesDS pdsParam) : base(tesT3PromocionesActionEnum.GetAcciontesT3PromocionesAction(pAccion), pdsParam) {
     }

     public tesT3PromocionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesT3PromocionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesT3PromocionesActionExchange(TesoreriaCommon.tesT3PromocionesDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesT3PromocionesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesT3PromocionesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesT3PromocionesDS)mParam;
	        }
     }
  }
}
