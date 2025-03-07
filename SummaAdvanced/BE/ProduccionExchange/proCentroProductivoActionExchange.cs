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
    public class proCentroProductivoActionExchange : Framework.Core.Exchange{

        public Int32 proCentroProductivo {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["proCentroProductivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].proCentroProductivo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].proCentroProductivo = value;
               }
	          }
        public bool IsproCentroProductivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsproCentroProductivoNull();
             }
	        }
        public String CtroProd_Id {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["CtroProd_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtroProd_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtroProd_Id = value;
               }
	          }
        public bool IsCtroProd_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsCtroProd_IdNull();
             }
	        }
        public String CtroProd_Id_Nueva {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["CtroProd_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtroProd_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtroProd_Id_Nueva = value;
               }
	          }
        public bool IsCtroProd_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsCtroProd_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String CtaProdProceso {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["CtaProdProceso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtaProdProceso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].CtaProdProceso = value;
               }
	          }
        public bool IsCtaProdProcesoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsCtaProdProcesoNull();
             }
	        }
        public String DescripcionCtaProdProceso {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["DescripcionCtaProdProceso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCtaProdProceso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].DescripcionCtaProdProceso = value;
               }
	          }
        public bool IsDescripcionCtaProdProcesoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsDescripcionCtaProdProcesoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCentroProductivoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proCentroProductivoDS );
     }
     public proCentroProductivoActionExchange() : base( "proCentroProductivo" ) {
     }

     public proCentroProductivoActionExchange(proCentroProductivoActionEnum.EnumproCentroProductivoAction pAccion) : base(proCentroProductivoActionEnum.GetAccionproCentroProductivoAction(pAccion)) {
     }

     public proCentroProductivoActionExchange(proCentroProductivoActionEnum.EnumproCentroProductivoAction pAccion, ProduccionCommon.proCentroProductivoDS pdsParam) : base(proCentroProductivoActionEnum.GetAccionproCentroProductivoAction(pAccion), pdsParam) {
     }

     public proCentroProductivoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proCentroProductivoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proCentroProductivoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proCentroProductivoDS)mParam;
	        }
     }
  }
}
