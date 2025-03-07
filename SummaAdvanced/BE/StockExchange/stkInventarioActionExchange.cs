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
    public class stkInventarioActionExchange : Framework.Core.Exchange{

        public Int32 stkInventarios {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["stkInventarios"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].stkInventarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].stkInventarios = value;
               }
	          }
        public bool IsstkInventariosNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsstkInventariosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime FechaInventario {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["FechaInventario"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaInventario;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaInventario = value;
               }
	          }
        public bool IsFechaInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsFechaInventarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public DateTime FechaAutorizo {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["FechaAutorizo"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaAutorizo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].FechaAutorizo = value;
               }
	          }
        public bool IsFechaAutorizoNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsFechaAutorizoNull();
             }
	        }
        public Int32 UsuarioAutorizo {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["UsuarioAutorizo"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].UsuarioAutorizo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].UsuarioAutorizo = value;
               }
	          }
        public bool IsUsuarioAutorizoNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsUsuarioAutorizoNull();
             }
	        }
        public String UsuRespo_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["UsuRespo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].UsuRespo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].UsuRespo_Id = value;
               }
	          }
        public bool IsUsuRespo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsUsuRespo_IdNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Desde {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Desde"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Desde = value;
               }
	          }
        public bool IsDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsDesdeNull();
             }
	        }
        public String Hasta {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Hasta"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Hasta = value;
               }
	          }
        public bool IsHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsHastaNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String DescripcionDeposito {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["DescripcionDeposito"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].DescripcionDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].DescripcionDeposito = value;
               }
	          }
        public bool IsDescripcionDepositoNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsDescripcionDepositoNull();
             }
	        }
        public String ExtencionArchivo {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["ExtencionArchivo"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].ExtencionArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].ExtencionArchivo = value;
               }
	          }
        public bool IsExtencionArchivoNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsExtencionArchivoNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro1Descripcion {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Centro1Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro1Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro1Descripcion = value;
               }
	          }
        public bool IsCentro1DescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsCentro1DescripcionNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String Centro2Descripcion {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Centro2Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro2Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Centro2Descripcion = value;
               }
	          }
        public bool IsCentro2DescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsCentro2DescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkInventarioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkInventarioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventarioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkInventarioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkInventarioDS );
     }
     public stkInventarioActionExchange() : base( "stkInventario" ) {
     }

     public stkInventarioActionExchange(stkInventarioActionEnum.EnumstkInventarioAction pAccion) : base(stkInventarioActionEnum.GetAccionstkInventarioAction(pAccion)) {
     }

     public stkInventarioActionExchange(stkInventarioActionEnum.EnumstkInventarioAction pAccion, StockCommon.stkInventarioDS pdsParam) : base(stkInventarioActionEnum.GetAccionstkInventarioAction(pAccion), pdsParam) {
     }

     public stkInventarioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkInventarioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkInventarioActionExchange(StockCommon.stkInventarioDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkInventarioDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkInventarioDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkInventarioDS)mParam;
	        }
     }
  }
}
