using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genCancMovActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int16 CuotaNro {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["CuotaNro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].CuotaNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].CuotaNro = value;
               }
	          }
        public bool IsCuotaNroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsCuotaNroNull();
             }
	        }
        public Int64 Asiento_Id_Ap {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Asiento_Id_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Asiento_Id_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Asiento_Id_Ap = value;
               }
	          }
        public bool IsAsiento_Id_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsAsiento_Id_ApNull();
             }
	        }
        public Int16 CuotaNro_Ap {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["CuotaNro_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].CuotaNro_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].CuotaNro_Ap = value;
               }
	          }
        public bool IsCuotaNro_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsCuotaNro_ApNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal Cambio_Ap {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Cambio_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Cambio_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Cambio_Ap = value;
               }
	          }
        public bool IsCambio_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsCambio_ApNull();
             }
	        }
        public Boolean Importacion {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Importacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Importacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Importacion = value;
               }
	          }
        public bool IsImportacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsImportacionNull();
             }
	        }
        public Boolean EsVentaContado {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["EsVentaContado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].EsVentaContado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].EsVentaContado = value;
               }
	          }
        public bool IsEsVentaContadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsEsVentaContadoNull();
             }
	        }
        public Boolean EsAplicOriginal {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["EsAplicOriginal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].EsAplicOriginal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].EsAplicOriginal = value;
               }
	          }
        public bool IsEsAplicOriginalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsEsAplicOriginalNull();
             }
	        }
        public Boolean LlamarAlWS {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["LlamarAlWS"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].LlamarAlWS;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].LlamarAlWS = value;
               }
	          }
        public bool IsLlamarAlWSNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsLlamarAlWSNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCancMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCancMovDS );
     }
     public genCancMovActionExchange() : base( "genCancMov" ) {
     }

     public genCancMovActionExchange(genCancMovActionEnum.EnumgenCancMovAction pAccion) : base(genCancMovActionEnum.GetAcciongenCancMovAction(pAccion)) {
     }

     public genCancMovActionExchange(genCancMovActionEnum.EnumgenCancMovAction pAccion, GeneralesCommon.genCancMovDS pdsParam) : base(genCancMovActionEnum.GetAcciongenCancMovAction(pAccion), pdsParam) {
     }

     public genCancMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCancMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genCancMovActionExchange(GeneralesCommon.genCancMovDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genCancMovDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCancMovDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCancMovDS)mParam;
	        }
     }
  }
}
