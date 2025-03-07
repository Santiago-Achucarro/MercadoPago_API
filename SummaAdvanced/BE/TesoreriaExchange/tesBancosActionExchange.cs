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
    public class tesBancosActionExchange : Framework.Core.Exchange{

        public Int32 tesBancos {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["tesBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].tesBancos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].tesBancos = value;
               }
	          }
        public bool IstesBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IstesBancosNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String Banco_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Banco_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Banco_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Banco_Id_Nueva = value;
               }
	          }
        public bool IsBanco_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsBanco_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpreas {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["PTodasEmpreas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].PTodasEmpreas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].PTodasEmpreas = value;
               }
	          }
        public bool IsPTodasEmpreasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsPTodasEmpreasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String RFC {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["RFC"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].RFC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].RFC = value;
               }
	          }
        public bool IsRFCNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsRFCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesBancosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBancosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesBancosDS );
     }
     public tesBancosActionExchange() : base( "tesBancos" ) {
     }

     public tesBancosActionExchange(tesBancosActionEnum.EnumtesBancosAction pAccion) : base(tesBancosActionEnum.GetAcciontesBancosAction(pAccion)) {
     }

     public tesBancosActionExchange(tesBancosActionEnum.EnumtesBancosAction pAccion, TesoreriaCommon.tesBancosDS pdsParam) : base(tesBancosActionEnum.GetAcciontesBancosAction(pAccion), pdsParam) {
     }

     public tesBancosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesBancosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesBancosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesBancosDS)mParam;
	        }
     }
  }
}
