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
    public class venEsquemaAutoActionExchange : Framework.Core.Exchange{

        public Int32 venEsquemaAuto {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["venEsquemaAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].venEsquemaAuto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].venEsquemaAuto = value;
               }
	          }
        public bool IsvenEsquemaAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsvenEsquemaAutoNull();
             }
	        }
        public String EsquemaAuto_Id {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String EsquemaAuto_Id_Nueva {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["EsquemaAuto_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id_Nueva = value;
               }
	          }
        public bool IsEsquemaAuto_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsEsquemaAuto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venEsquemaAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venEsquemaAutoDS );
     }
     public venEsquemaAutoActionExchange() : base( "venEsquemaAuto" ) {
     }

     public venEsquemaAutoActionExchange(venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction pAccion) : base(venEsquemaAutoActionEnum.GetAccionvenEsquemaAutoAction(pAccion)) {
     }

     public venEsquemaAutoActionExchange(venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction pAccion, VentasCommon.venEsquemaAutoDS pdsParam) : base(venEsquemaAutoActionEnum.GetAccionvenEsquemaAutoAction(pAccion), pdsParam) {
     }

     public venEsquemaAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venEsquemaAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venEsquemaAutoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venEsquemaAutoDS)mParam;
	        }
     }
  }
}
