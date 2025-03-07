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
    public class comFactuReceOcActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comFactuReceOcDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comFactuReceOcDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comFactuReceOcDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comFactuReceOcDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactuReceOcDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comFactuReceOcDS );
     }
     public comFactuReceOcActionExchange() : base( "comFactuReceOc" ) {
     }

     public comFactuReceOcActionExchange(comFactuReceOcActionEnum.EnumcomFactuReceOcAction pAccion) : base(comFactuReceOcActionEnum.GetAccioncomFactuReceOcAction(pAccion)) {
     }

     public comFactuReceOcActionExchange(comFactuReceOcActionEnum.EnumcomFactuReceOcAction pAccion, ComprasCommon.comFactuReceOcDS pdsParam) : base(comFactuReceOcActionEnum.GetAccioncomFactuReceOcAction(pAccion), pdsParam) {
     }

     public comFactuReceOcActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comFactuReceOcDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comFactuReceOcDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comFactuReceOcDS)mParam;
	        }
     }
  }
}
