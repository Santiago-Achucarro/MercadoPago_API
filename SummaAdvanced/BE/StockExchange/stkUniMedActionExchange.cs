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
    public class stkUniMedActionExchange : Framework.Core.Exchange{

        public Int32 stkUniMed {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["stkUniMed"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].stkUniMed;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].stkUniMed = value;
               }
	          }
        public bool IsstkUniMedNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsstkUniMedNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String Medida_Id_Nueva {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Medida_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Medida_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Medida_Id_Nueva = value;
               }
	          }
        public bool IsMedida_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsMedida_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Decimales {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public String Mascara {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Mascara"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Mascara;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Mascara = value;
               }
	          }
        public bool IsMascaraNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsMascaraNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String UniExpor {
            get {
                if(((StockCommon.stkUniMedDS)mParam).Principal[0]["UniExpor"] != DBNull.Value  ){
                    return ((StockCommon.stkUniMedDS)mParam).Principal[0].UniExpor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUniMedDS)mParam).Principal[0].UniExpor = value;
               }
	          }
        public bool IsUniExporNull {
             get {
                 return mParam==null || ((StockCommon.stkUniMedDS)mParam).Principal[0].IsUniExporNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkUniMedDS );
     }
     public stkUniMedActionExchange() : base( "stkUniMed" ) {
     }

     public stkUniMedActionExchange(stkUniMedActionEnum.EnumstkUniMedAction pAccion) : base(stkUniMedActionEnum.GetAccionstkUniMedAction(pAccion)) {
     }

     public stkUniMedActionExchange(stkUniMedActionEnum.EnumstkUniMedAction pAccion, StockCommon.stkUniMedDS pdsParam) : base(stkUniMedActionEnum.GetAccionstkUniMedAction(pAccion), pdsParam) {
     }

     public stkUniMedActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkUniMedDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkUniMedDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkUniMedDS)mParam;
	        }
     }
  }
}
