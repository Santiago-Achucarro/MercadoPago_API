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
    public class proExistenciaActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String Deposito_Id_Nueva {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Deposito_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Deposito_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Deposito_Id_Nueva = value;
               }
	          }
        public bool IsDeposito_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsDeposito_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Decimal Existencia {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Existencia"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Existencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Existencia = value;
               }
	          }
        public bool IsExistenciaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsExistenciaNull();
             }
	        }
        public Decimal Produccion {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Produccion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Produccion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Produccion = value;
               }
	          }
        public bool IsProduccionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsProduccionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proExistenciaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExistenciaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proExistenciaDS );
     }
     public proExistenciaActionExchange() : base( "proExistencia" ) {
     }

     public proExistenciaActionExchange(proExistenciaActionEnum.EnumproExistenciaAction pAccion) : base(proExistenciaActionEnum.GetAccionproExistenciaAction(pAccion)) {
     }

     public proExistenciaActionExchange(proExistenciaActionEnum.EnumproExistenciaAction pAccion, ProduccionCommon.proExistenciaDS pdsParam) : base(proExistenciaActionEnum.GetAccionproExistenciaAction(pAccion), pdsParam) {
     }

     public proExistenciaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proExistenciaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proExistenciaDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proExistenciaDS)mParam;
	        }
     }
  }
}
