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
    public class conCuentasActualizacionActionExchange : Framework.Core.Exchange{

        public Int32 conCuentas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["conCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].conCuentas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].conCuentas = value;
               }
	          }
        public bool IsconCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsconCuentasNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String Cuenta_Id_Nueva {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Cuenta_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuenta_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuenta_Id_Nueva = value;
               }
	          }
        public bool IsCuenta_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsCuenta_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Tipo_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Tipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Tipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Tipo_Id = value;
               }
	          }
        public bool IsTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsTipo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public Boolean Imputable {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Imputable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Imputable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Imputable = value;
               }
	          }
        public bool IsImputableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsImputableNull();
             }
	        }
        public String TipoRubro {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["TipoRubro"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].TipoRubro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].TipoRubro = value;
               }
	          }
        public bool IsTipoRubroNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsTipoRubroNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String Base_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Base_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Base_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Base_Id = value;
               }
	          }
        public bool IsBase_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsBase_IdNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public Int32 Cuadro1Fila_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Cuadro1Fila_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuadro1Fila_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Cuadro1Fila_Id = value;
               }
	          }
        public bool IsCuadro1Fila_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsCuadro1Fila_IdNull();
             }
	        }
        public String ReservadaPor {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["ReservadaPor"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].ReservadaPor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].ReservadaPor = value;
               }
	          }
        public bool IsReservadaPorNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsReservadaPorNull();
             }
	        }
        public DateTime Fecha_Reserva {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Fecha_Reserva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Fecha_Reserva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Fecha_Reserva = value;
               }
	          }
        public bool IsFecha_ReservaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsFecha_ReservaNull();
             }
	        }
        public String SubCuenta_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["SubCuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].SubCuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].SubCuenta_Id = value;
               }
	          }
        public bool IsSubCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsSubCuenta_IdNull();
             }
	        }
        public Boolean NoSeReserva {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["NoSeReserva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].NoSeReserva;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].NoSeReserva = value;
               }
	          }
        public bool IsNoSeReservaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsNoSeReservaNull();
             }
	        }
        public String Rubro_Balance {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Rubro_Balance"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Rubro_Balance;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Rubro_Balance = value;
               }
	          }
        public bool IsRubro_BalanceNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsRubro_BalanceNull();
             }
	        }
        public Boolean Ajustable {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Ajustable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Ajustable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Ajustable = value;
               }
	          }
        public bool IsAjustableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsAjustableNull();
             }
	        }
        public String Notas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Notas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Notas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Notas = value;
               }
	          }
        public bool IsNotasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsNotasNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Indice_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Indice_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Indice_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Indice_Id = value;
               }
	          }
        public bool IsIndice_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsIndice_IdNull();
             }
	        }
        public Int16 Metodo {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Metodo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Metodo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Metodo = value;
               }
	          }
        public bool IsMetodoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsMetodoNull();
             }
	        }
        public Boolean EliminaConsolida {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["EliminaConsolida"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].EliminaConsolida;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].EliminaConsolida = value;
               }
	          }
        public bool IsEliminaConsolidaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsEliminaConsolidaNull();
             }
	        }
        public String TipoSAT_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["TipoSAT_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].TipoSAT_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].TipoSAT_Id = value;
               }
	          }
        public bool IsTipoSAT_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsTipoSAT_IdNull();
             }
	        }
        public String Naturaleza {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Naturaleza"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Naturaleza;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Naturaleza = value;
               }
	          }
        public bool IsNaturalezaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsNaturalezaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String DescripcionconBaseDistri {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconBaseDistri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconBaseDistri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconBaseDistri = value;
               }
	          }
        public bool IsDescripcionconBaseDistriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconBaseDistriNull();
             }
	        }
        public String DescripcionconCuadro1Filas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconCuadro1Filas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconCuadro1Filas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconCuadro1Filas = value;
               }
	          }
        public bool IsDescripcionconCuadro1FilasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconCuadro1FilasNull();
             }
	        }
        public String DescripcionconGruposCont {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconGruposCont"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconGruposCont;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconGruposCont = value;
               }
	          }
        public bool IsDescripcionconGruposContNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconGruposContNull();
             }
	        }
        public String DescripcionconRubros {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconRubros"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconRubros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconRubros = value;
               }
	          }
        public bool IsDescripcionconRubrosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconRubrosNull();
             }
	        }
        public String DescripcionconSituPatri {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconSituPatri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconSituPatri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconSituPatri = value;
               }
	          }
        public bool IsDescripcionconSituPatriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconSituPatriNull();
             }
	        }
        public String DescripcionconSubCuentas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconSubCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconSubCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconSubCuentas = value;
               }
	          }
        public bool IsDescripcionconSubCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconSubCuentasNull();
             }
	        }
        public String DescripcionconTiposContables {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconTiposContables"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconTiposContables;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconTiposContables = value;
               }
	          }
        public bool IsDescripcionconTiposContablesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconTiposContablesNull();
             }
	        }
        public String DescripcionconTiposSAT {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionconTiposSAT"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconTiposSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionconTiposSAT = value;
               }
	          }
        public bool IsDescripcionconTiposSATNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionconTiposSATNull();
             }
	        }
        public String DescripcionIndicesAjustes {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionIndicesAjustes"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionIndicesAjustes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionIndicesAjustes = value;
               }
	          }
        public bool IsDescripcionIndicesAjustesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionIndicesAjustesNull();
             }
	        }
        public String DescripcionEmpresa {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionEmpresa"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionEmpresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionEmpresa = value;
               }
	          }
        public bool IsDescripcionEmpresaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionEmpresaNull();
             }
	        }
        public String DescripciongenMonedas {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripciongenMonedas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripciongenMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripciongenMonedas = value;
               }
	          }
        public bool IsDescripciongenMonedasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripciongenMonedasNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String CuentaSC {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["CuentaSC"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].CuentaSC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].CuentaSC = value;
               }
	          }
        public bool IsCuentaSCNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsCuentaSCNull();
             }
	        }
        public String DescripcionSC {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionSC"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionSC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionSC = value;
               }
	          }
        public bool IsDescripcionSCNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionSCNull();
             }
	        }
        public Boolean PorSubCuenta {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["PorSubCuenta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].PorSubCuenta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].PorSubCuenta = value;
               }
	          }
        public bool IsPorSubCuentaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsPorSubCuentaNull();
             }
	        }
        public String Description {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Description"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Description;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Description = value;
               }
	          }
        public bool IsDescriptionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescriptionNull();
             }
	        }
        public Int32 RubroAxi_Id {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["RubroAxi_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].RubroAxi_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].RubroAxi_Id = value;
               }
	          }
        public bool IsRubroAxi_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsRubroAxi_IdNull();
             }
	        }
        public String DescripcionRubroAxi {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["DescripcionRubroAxi"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionRubroAxi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].DescripcionRubroAxi = value;
               }
	          }
        public bool IsDescripcionRubroAxiNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsDescripcionRubroAxiNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasActualizacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCuentasActualizacionDS );
     }
     public conCuentasActualizacionActionExchange() : base( "conCuentasActualizacion" ) {
     }

     public conCuentasActualizacionActionExchange(conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction pAccion) : base(conCuentasActualizacionActionEnum.GetAccionconCuentasActualizacionAction(pAccion)) {
     }

     public conCuentasActualizacionActionExchange(conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction pAccion, ContabilidadCommon.conCuentasActualizacionDS pdsParam) : base(conCuentasActualizacionActionEnum.GetAccionconCuentasActualizacionAction(pAccion), pdsParam) {
     }

     public conCuentasActualizacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCuentasActualizacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCuentasActualizacionDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCuentasActualizacionDS)mParam;
	        }
     }
  }
}
