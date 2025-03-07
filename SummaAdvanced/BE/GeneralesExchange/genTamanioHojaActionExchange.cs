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
    public class genTamanioHojaActionExchange : Framework.Core.Exchange{

        public String TamanioHoja {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["TamanioHoja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].TamanioHoja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].TamanioHoja = value;
               }
	          }
        public bool IsTamanioHojaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsTamanioHojaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal AltoIn {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["AltoIn"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AltoIn;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AltoIn = value;
               }
	          }
        public bool IsAltoInNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAltoInNull();
             }
	        }
        public Decimal AnchoIn {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["AnchoIn"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AnchoIn;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AnchoIn = value;
               }
	          }
        public bool IsAnchoInNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAnchoInNull();
             }
	        }
        public Decimal Altocm {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["Altocm"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Altocm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Altocm = value;
               }
	          }
        public bool IsAltocmNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAltocmNull();
             }
	        }
        public Decimal Anchicm {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["Anchicm"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Anchicm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Anchicm = value;
               }
	          }
        public bool IsAnchicmNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAnchicmNull();
             }
	        }
        public Int32 AltoPx {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["AltoPx"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AltoPx;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AltoPx = value;
               }
	          }
        public bool IsAltoPxNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAltoPxNull();
             }
	        }
        public Int32 AnchoPx {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["AnchoPx"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AnchoPx;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].AnchoPx = value;
               }
	          }
        public bool IsAnchoPxNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsAnchoPxNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTamanioHojaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genTamanioHojaDS );
     }
     public genTamanioHojaActionExchange() : base( "genTamanioHoja" ) {
     }

     public genTamanioHojaActionExchange(genTamanioHojaActionEnum.EnumgenTamanioHojaAction pAccion) : base(genTamanioHojaActionEnum.GetAcciongenTamanioHojaAction(pAccion)) {
     }

     public genTamanioHojaActionExchange(genTamanioHojaActionEnum.EnumgenTamanioHojaAction pAccion, GeneralesCommon.genTamanioHojaDS pdsParam) : base(genTamanioHojaActionEnum.GetAcciongenTamanioHojaAction(pAccion), pdsParam) {
     }

     public genTamanioHojaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genTamanioHojaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genTamanioHojaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genTamanioHojaDS)mParam;
	        }
     }
  }
}
