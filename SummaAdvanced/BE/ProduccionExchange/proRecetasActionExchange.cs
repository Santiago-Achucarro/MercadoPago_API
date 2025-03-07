using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proRecetasActionExchange : Framework.Core.Exchange{

        public Int32 proRecetas {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["proRecetas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].proRecetas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].proRecetas = value;
               }
	          }
        public bool IsproRecetasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsproRecetasNull();
             }
	        }
        public String Receta_Id {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String Receta_Id_Nueva {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Receta_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Receta_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Receta_Id_Nueva = value;
               }
	          }
        public bool IsReceta_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsReceta_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String CtroProd_Id {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["CtroProd_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].CtroProd_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].CtroProd_Id = value;
               }
	          }
        public bool IsCtroProd_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsCtroProd_IdNull();
             }
	        }
        public String descripcionCentroProd {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["descripcionCentroProd"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].descripcionCentroProd;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].descripcionCentroProd = value;
               }
	          }
        public bool IsdescripcionCentroProdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsdescripcionCentroProdNull();
             }
	        }
        public Decimal TamBatch {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["TamBatch"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].TamBatch;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].TamBatch = value;
               }
	          }
        public bool IsTamBatchNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsTamBatchNull();
             }
	        }
        public Boolean Agrupa {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Agrupa"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Agrupa;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Agrupa = value;
               }
	          }
        public bool IsAgrupaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsAgrupaNull();
             }
	        }
        public Boolean Corte {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Corte"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Corte;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Corte = value;
               }
	          }
        public bool IsCorteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsCorteNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String ParaPegar {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["ParaPegar"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].ParaPegar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].ParaPegar = value;
               }
	          }
        public bool IsParaPegarNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsParaPegarNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasDS );
     }
     public proRecetasActionExchange() : base( "proRecetas" ) {
     }

     public proRecetasActionExchange(proRecetasActionEnum.EnumproRecetasAction pAccion) : base(proRecetasActionEnum.GetAccionproRecetasAction(pAccion)) {
     }

     public proRecetasActionExchange(proRecetasActionEnum.EnumproRecetasAction pAccion, ProduccionCommon.proRecetasDS pdsParam) : base(proRecetasActionEnum.GetAccionproRecetasAction(pAccion), pdsParam) {
     }

     public proRecetasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public proRecetasActionExchange(ProduccionCommon.proRecetasDS pDS) : base() {
     this.Action = "";
     this.mParam = new ProduccionCommon.proRecetasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasDS)mParam;
	        }
     }
  }
}
