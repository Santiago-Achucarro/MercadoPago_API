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
    public class tesFlujoActionExchange : Framework.Core.Exchange{

        public Int64 tesFlujoFondo {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["tesFlujoFondo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].tesFlujoFondo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].tesFlujoFondo = value;
               }
	          }
        public bool IstesFlujoFondoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IstesFlujoFondoNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean DetallaClientes {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["DetallaClientes"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].DetallaClientes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].DetallaClientes = value;
               }
	          }
        public bool IsDetallaClientesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsDetallaClientesNull();
             }
	        }
        public Boolean DetallaProveedores {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["DetallaProveedores"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].DetallaProveedores;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].DetallaProveedores = value;
               }
	          }
        public bool IsDetallaProveedoresNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsDetallaProveedoresNull();
             }
	        }
        public String Periodo {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Periodo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Periodo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Periodo = value;
               }
	          }
        public bool IsPeriodoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsPeriodoNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesFlujoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesFlujoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesFlujoDS );
     }
     public tesFlujoActionExchange() : base( "tesFlujo" ) {
     }

     public tesFlujoActionExchange(tesFlujoActionEnum.EnumtesFlujoAction pAccion) : base(tesFlujoActionEnum.GetAcciontesFlujoAction(pAccion)) {
     }

     public tesFlujoActionExchange(tesFlujoActionEnum.EnumtesFlujoAction pAccion, TesoreriaCommon.tesFlujoDS pdsParam) : base(tesFlujoActionEnum.GetAcciontesFlujoAction(pAccion), pdsParam) {
     }

     public tesFlujoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesFlujoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesFlujoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesFlujoDS)mParam;
	        }
     }
  }
}
