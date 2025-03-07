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
    public class tesChequerasActionExchange : Framework.Core.Exchange{

        public Int32 Chequera_id {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Chequera_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Chequera_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Chequera_id = value;
               }
	          }
        public bool IsChequera_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsChequera_idNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Empresa_id {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Empresa_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Empresa_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Empresa_id = value;
               }
	          }
        public bool IsEmpresa_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsEmpresa_idNull();
             }
	        }
        public String DescripcionCartera {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["DescripcionCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionCartera = value;
               }
	          }
        public bool IsDescripcionCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsDescripcionCarteraNull();
             }
	        }
        public String TipoChequera {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["TipoChequera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].TipoChequera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].TipoChequera = value;
               }
	          }
        public bool IsTipoChequeraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsTipoChequeraNull();
             }
	        }
        public String Estado_id {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Estado_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Estado_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Estado_id = value;
               }
	          }
        public bool IsEstado_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsEstado_idNull();
             }
	        }
        public String DescripcionChequerasEstado {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["DescripcionChequerasEstado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionChequerasEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionChequerasEstado = value;
               }
	          }
        public bool IsDescripcionChequerasEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsDescripcionChequerasEstadoNull();
             }
	        }
        public Int32 Desde {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Desde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Desde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Desde = value;
               }
	          }
        public bool IsDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsDesdeNull();
             }
	        }
        public Int32 Hasta {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Hasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Hasta = value;
               }
	          }
        public bool IsHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsHastaNull();
             }
	        }
        public Int32 Proximo {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Proximo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Proximo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Proximo = value;
               }
	          }
        public bool IsProximoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsProximoNull();
             }
	        }
        public DateTime FechaAlta {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["FechaAlta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].FechaAlta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].FechaAlta = value;
               }
	          }
        public bool IsFechaAltaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsFechaAltaNull();
             }
	        }
        public DateTime FechaBaja {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["FechaBaja"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].FechaBaja;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].FechaBaja = value;
               }
	          }
        public bool IsFechaBajaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsFechaBajaNull();
             }
	        }
        public String MotivoBaja {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["MotivoBaja"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].MotivoBaja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].MotivoBaja = value;
               }
	          }
        public bool IsMotivoBajaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsMotivoBajaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesChequerasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesChequerasDS );
     }
     public tesChequerasActionExchange() : base( "tesChequeras" ) {
     }

     public tesChequerasActionExchange(tesChequerasActionEnum.EnumtesChequerasAction pAccion) : base(tesChequerasActionEnum.GetAcciontesChequerasAction(pAccion)) {
     }

     public tesChequerasActionExchange(tesChequerasActionEnum.EnumtesChequerasAction pAccion, TesoreriaCommon.tesChequerasDS pdsParam) : base(tesChequerasActionEnum.GetAcciontesChequerasAction(pAccion), pdsParam) {
     }

     public tesChequerasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesChequerasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesChequerasDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesChequerasDS)mParam;
	        }
     }
  }
}
