using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovprovXmlBuscarActionExchange : Framework.Core.Exchange{

        public Int64 comMovprov {
            get {
                if(((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0]["comMovprov"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].comMovprov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].comMovprov = value;
               }
	          }
        public bool IscomMovprovNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].IscomMovprovNull();
             }
	        }
        public String UUID {
            get {
                if(((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public String Xml {
            get {
                if(((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0]["Xml"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].Xml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].Xml = value;
               }
	          }
        public bool IsXmlNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].IsXmlNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovXmlBuscarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovprovXmlBuscarDS );
     }
     public comMovprovXmlBuscarActionExchange() : base( "comMovprovXmlBuscar" ) {
     }

     public comMovprovXmlBuscarActionExchange(comMovprovXmlBuscarActionEnum.EnumcomMovprovXmlBuscarAction pAccion) : base(comMovprovXmlBuscarActionEnum.GetAccioncomMovprovXmlBuscarAction(pAccion)) {
     }

     public comMovprovXmlBuscarActionExchange(comMovprovXmlBuscarActionEnum.EnumcomMovprovXmlBuscarAction pAccion, ComprasCommon.comMovprovXmlBuscarDS pdsParam) : base(comMovprovXmlBuscarActionEnum.GetAccioncomMovprovXmlBuscarAction(pAccion), pdsParam) {
     }

     public comMovprovXmlBuscarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovprovXmlBuscarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovprovXmlBuscarDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovprovXmlBuscarDS)mParam;
	        }
     }
  }
}
