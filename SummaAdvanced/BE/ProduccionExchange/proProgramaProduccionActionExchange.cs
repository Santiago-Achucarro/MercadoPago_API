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
    public class proProgramaProduccionActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento1N_Nueva {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento1N_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1N_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1N_Nueva = value;
               }
	          }
        public bool IsSegmento1N_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento1N_NuevaNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 proProgramas {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["proProgramas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].proProgramas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].proProgramas = value;
               }
	          }
        public bool IsproProgramasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsproProgramasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public Boolean Lunes {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Lunes"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Lunes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Lunes = value;
               }
	          }
        public bool IsLunesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsLunesNull();
             }
	        }
        public Boolean Martes {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Martes"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Martes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Martes = value;
               }
	          }
        public bool IsMartesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsMartesNull();
             }
	        }
        public Boolean Miercoles {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Miercoles"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Miercoles;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Miercoles = value;
               }
	          }
        public bool IsMiercolesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsMiercolesNull();
             }
	        }
        public Boolean Jueves {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Jueves"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Jueves;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Jueves = value;
               }
	          }
        public bool IsJuevesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsJuevesNull();
             }
	        }
        public Boolean Viernes {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Viernes"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Viernes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Viernes = value;
               }
	          }
        public bool IsViernesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsViernesNull();
             }
	        }
        public Boolean Sabado {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Sabado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Sabado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Sabado = value;
               }
	          }
        public bool IsSabadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsSabadoNull();
             }
	        }
        public Boolean Domingo {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Domingo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Domingo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Domingo = value;
               }
	          }
        public bool IsDomingoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsDomingoNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public DateTime FechaHastaPedidos {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["FechaHastaPedidos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaHastaPedidos;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].FechaHastaPedidos = value;
               }
	          }
        public bool IsFechaHastaPedidosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsFechaHastaPedidosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaProduccionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramaProduccionDS );
     }
     public proProgramaProduccionActionExchange() : base( "proProgramaProduccion" ) {
     }

     public proProgramaProduccionActionExchange(proProgramaProduccionActionEnum.EnumproProgramaProduccionAction pAccion) : base(proProgramaProduccionActionEnum.GetAccionproProgramaProduccionAction(pAccion)) {
     }

     public proProgramaProduccionActionExchange(proProgramaProduccionActionEnum.EnumproProgramaProduccionAction pAccion, ProduccionCommon.proProgramaProduccionDS pdsParam) : base(proProgramaProduccionActionEnum.GetAccionproProgramaProduccionAction(pAccion), pdsParam) {
     }

     public proProgramaProduccionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramaProduccionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramaProduccionDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramaProduccionDS)mParam;
	        }
     }
  }
}
