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
    public class venCategCreditoActionExchange : Framework.Core.Exchange{

        public Int32 venCategCredito {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["venCategCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].venCategCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].venCategCredito = value;
               }
	          }
        public bool IsvenCategCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsvenCategCreditoNull();
             }
	        }
        public String CategCred_Id {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["CategCred_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].CategCred_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].CategCred_Id = value;
               }
	          }
        public bool IsCategCred_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsCategCred_IdNull();
             }
	        }
        public String CategCred_Id_Nueva {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["CategCred_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].CategCred_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].CategCred_Id_Nueva = value;
               }
	          }
        public bool IsCategCred_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsCategCred_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 MaxDiasAtraso {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["MaxDiasAtraso"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].MaxDiasAtraso;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].MaxDiasAtraso = value;
               }
	          }
        public bool IsMaxDiasAtrasoNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsMaxDiasAtrasoNull();
             }
	        }
        public Decimal PorcenDeudaVenci {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["PorcenDeudaVenci"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].PorcenDeudaVenci;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].PorcenDeudaVenci = value;
               }
	          }
        public bool IsPorcenDeudaVenciNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsPorcenDeudaVenciNull();
             }
	        }
        public Decimal TipoCredito {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["TipoCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].TipoCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].TipoCredito = value;
               }
	          }
        public bool IsTipoCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsTipoCreditoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCategCreditoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCategCreditoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCategCreditoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCategCreditoDS );
     }
     public venCategCreditoActionExchange() : base( "venCategCredito" ) {
     }

     public venCategCreditoActionExchange(venCategCreditoActionEnum.EnumvenCategCreditoAction pAccion) : base(venCategCreditoActionEnum.GetAccionvenCategCreditoAction(pAccion)) {
     }

     public venCategCreditoActionExchange(venCategCreditoActionEnum.EnumvenCategCreditoAction pAccion, VentasCommon.venCategCreditoDS pdsParam) : base(venCategCreditoActionEnum.GetAccionvenCategCreditoAction(pAccion), pdsParam) {
     }

     public venCategCreditoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCategCreditoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCategCreditoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCategCreditoDS)mParam;
	        }
     }
  }
}
