using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkFamiliasActionExchange : Framework.Core.Exchange{

        public Int32 stkFamilias {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["stkFamilias"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].stkFamilias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].stkFamilias = value;
               }
	          }
        public bool IsstkFamiliasNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsstkFamiliasNull();
             }
	        }
        public String Familia_Id {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Familia_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Familia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Familia_Id = value;
               }
	          }
        public bool IsFamilia_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsFamilia_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Familia_Id_Nueva {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Familia_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Familia_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Familia_Id_Nueva = value;
               }
	          }
        public bool IsFamilia_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsFamilia_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkFamiliasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkFamiliasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkFamiliasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkFamiliasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkFamiliasDS );
     }
     public stkFamiliasActionExchange() : base( "stkFamilias" ) {
     }

     public stkFamiliasActionExchange(stkFamiliasActionEnum.EnumstkFamiliasAction pAccion) : base(stkFamiliasActionEnum.GetAccionstkFamiliasAction(pAccion)) {
     }

     public stkFamiliasActionExchange(stkFamiliasActionEnum.EnumstkFamiliasAction pAccion, StockCommon.stkFamiliasDS pdsParam) : base(stkFamiliasActionEnum.GetAccionstkFamiliasAction(pAccion), pdsParam) {
     }

     public stkFamiliasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkFamiliasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkFamiliasDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkFamiliasDS)mParam;
	        }
     }
  }
}
