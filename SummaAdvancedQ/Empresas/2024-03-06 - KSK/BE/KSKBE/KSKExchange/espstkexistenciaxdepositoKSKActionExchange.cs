using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espstkexistenciaxdepositoKSKActionExchange : Framework.Core.Exchange{

        public String Producto {
            get {
                if(((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0]["Producto"] != DBNull.Value  ){
                    return ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Producto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Producto = value;
               }
	          }
        public bool IsProductoNull {
             get {
                 return mParam==null || ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].IsProductoNull();
             }
	        }
        public String Sucursal {
            get {
                if(((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Int32 Empresa {
            get {
                if(((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0]["Empresa"] != DBNull.Value  ){
                    return ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Empresa;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Empresa = value;
               }
	          }
        public bool IsEmpresaNull {
             get {
                 return mParam==null || ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].IsEmpresaNull();
             }
	        }
        public String Lista {
            get {
                if(((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0]["Lista"] != DBNull.Value  ){
                    return ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Lista;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Lista = value;
               }
	          }
        public bool IsListaNull {
             get {
                 return mParam==null || ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].IsListaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espstkexistenciaxdepositoKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espstkexistenciaxdepositoKSKDS );
     }
     public espstkexistenciaxdepositoKSKActionExchange() : base( "espstkexistenciaxdepositoKSK" ) {
     }

     public espstkexistenciaxdepositoKSKActionExchange(espstkexistenciaxdepositoKSKActionEnum.EnumespstkexistenciaxdepositoKSKAction pAccion) : base(espstkexistenciaxdepositoKSKActionEnum.GetAccionespstkexistenciaxdepositoKSKAction(pAccion)) {
     }

     public espstkexistenciaxdepositoKSKActionExchange(espstkexistenciaxdepositoKSKActionEnum.EnumespstkexistenciaxdepositoKSKAction pAccion, KSKCommon.espstkexistenciaxdepositoKSKDS pdsParam) : base(espstkexistenciaxdepositoKSKActionEnum.GetAccionespstkexistenciaxdepositoKSKAction(pAccion), pdsParam) {
     }

     public espstkexistenciaxdepositoKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espstkexistenciaxdepositoKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public espstkexistenciaxdepositoKSKActionExchange(KSKCommon.espstkexistenciaxdepositoKSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.espstkexistenciaxdepositoKSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espstkexistenciaxdepositoKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espstkexistenciaxdepositoKSKDS)mParam;
	        }
     }
  }
}
