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
    public class genPermisosActionExchange : Framework.Core.Exchange{

        public Int32 Usuario_id {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Consultar {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Consultar"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Consultar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Consultar = value;
               }
	          }
        public bool IsConsultarNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsConsultarNull();
             }
	        }
        public Boolean Actualizar {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Actualizar"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Actualizar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Actualizar = value;
               }
	          }
        public bool IsActualizarNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsActualizarNull();
             }
	        }
        public Boolean Borrar {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Borrar"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Borrar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Borrar = value;
               }
	          }
        public bool IsBorrarNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsBorrarNull();
             }
	        }
        public Boolean Postear {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Postear"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Postear;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Postear = value;
               }
	          }
        public bool IsPostearNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsPostearNull();
             }
	        }
        public Boolean ModificaCodigos
        {
            get
            {
                if (((GeneralesCommon.genPermisosDS)mParam).Principal[0]["ModificaCodigos"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].ModificaCodigos;
                }
                else
                {
                    return false;
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genPermisosDS)mParam).Principal[0].ModificaCodigos = value;
            }
        }
        public bool IsModificaCodigosNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsModificaCodigosNull();
            }
        }

        public Boolean Existe {
            get {
                if(((GeneralesCommon.genPermisosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genPermisosDS );
     }
     public genPermisosActionExchange() : base( "genPermisos" ) {
     }

     public genPermisosActionExchange(genPermisosActionEnum.EnumgenPermisosAction pAccion) : base(genPermisosActionEnum.GetAcciongenPermisosAction(pAccion)) {
     }

     public genPermisosActionExchange(genPermisosActionEnum.EnumgenPermisosAction pAccion, GeneralesCommon.genPermisosDS pdsParam) : base(genPermisosActionEnum.GetAcciongenPermisosAction(pAccion), pdsParam) {
     }

     public genPermisosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genPermisosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genPermisosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genPermisosDS)mParam;
	        }
     }
  }
}
