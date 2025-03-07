using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conRubrosAxiActionExchange : Framework.Core.Exchange{

        public Int32 conRubrosAxi {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["conRubrosAxi"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].conRubrosAxi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].conRubrosAxi = value;
               }
	          }
        public bool IsconRubrosAxiNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsconRubrosAxiNull();
             }
	        }
        public Int32 RubroAxi_Id {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["RubroAxi_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].RubroAxi_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].RubroAxi_Id = value;
               }
	          }
        public bool IsRubroAxi_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsRubroAxi_IdNull();
             }
	        }
        public Int32 RubroAxi_Id_Nueva {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["RubroAxi_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].RubroAxi_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].RubroAxi_Id_Nueva = value;
               }
	          }
        public bool IsRubroAxi_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsRubroAxi_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String DescripcionRubros {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["DescripcionRubros"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].DescripcionRubros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].DescripcionRubros = value;
               }
	          }
        public bool IsDescripcionRubrosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsDescripcionRubrosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosAxiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conRubrosAxiDS );
     }
     public conRubrosAxiActionExchange() : base( "conRubrosAxi" ) {
     }

     public conRubrosAxiActionExchange(conRubrosAxiActionEnum.EnumconRubrosAxiAction pAccion) : base(conRubrosAxiActionEnum.GetAccionconRubrosAxiAction(pAccion)) {
     }

     public conRubrosAxiActionExchange(conRubrosAxiActionEnum.EnumconRubrosAxiAction pAccion, ContabilidadCommon.conRubrosAxiDS pdsParam) : base(conRubrosAxiActionEnum.GetAccionconRubrosAxiAction(pAccion), pdsParam) {
     }

     public conRubrosAxiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conRubrosAxiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conRubrosAxiDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conRubrosAxiDS)mParam;
	        }
     }
  }
}
