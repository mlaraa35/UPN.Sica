using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Constantes
{

    public class CONSTANTES
    {
        ////const - colocar estos roles en el config y deben ser leídos de allí
        //public const string MODALIDAD_EBR = "01";
        //public const int ID_SISTEMA_SIGRA = 11;

        ////Roles - colocar estos roles en el config y deben ser leídos de allí
        //public const int ROL_AdministradorDeSistema = 21;
        //public const int ROL_EspecialistaUMC = 28;
        //public const int ROL_Postulante = 29;
        //public const int ROL_MonitoresSTAFF = 30;
        //public const int ROL_Monitores = 31;
        //public const int ROL_CoordinadorRegional = 32;
        //public const int ROL_SupervisorDeSedeProvDistr = 33;
        //public const int ROL_Asistente = 34;

        //plantillas
        public const string PLANTILLA_REGISTROPOSTULANTE = "P001";
        public const string PLANTILLA_RECUPERARCONTRASENA = "P002";
        public const string PLANTILLA_CONFIRMACIONPOSTULACION = "P003";
        public const string PLANTILLA_PRESELECCION = "P004";
        public const string PLANTILLA_CAPACITACION = "P005";
        public const string PLANTILLA_ASIGNACION = "P006";

        public const string RUTA = "Ruta del aplicativo SIGRA";
        public const int TIEMPO_VIGENCIA_LINK = 48;
        public const int MAYOREDAD = 18;

        //Estados de registros
        public const bool ESTADO_REGISTRO_ACTIVO = true;
        public const bool ESTADO_REGISTRO_ELIMINADO = false;


        //Tipo de accion (M20)
        public const string ACCION_ACTIVO = "Activado";
        public const string ACCION_INACTIVO = "Inactivado";

        //Resultado de operación (M20)
        //Se utiliza?
        public const string RESULTADO_ELIMINADO = "eliminado";
        public const string RESULTADO_PROCESADO = "procesado";
        
        // Estado Verificacion Perfil
        public const string ESTADO_VERIFICACION_PERFIL_ACTO = "Apto";
        public const string ESTADO_VERIFICACION_PERFIL_NO_ACTO = "No Apto";

        // Presentacion Expediente
        public const string PRESENTACION_EXPEDIENTE_SI = "SI";
        public const string PRESENTACION_EXPEDIENTE_NO = "NO";

        // Estado Verificacion Expediente
        public const string ESTADO_VERIFICACION_EXPEDIENTE_ACTO = "Apto";
        public const string ESTADO_VERIFICACION_EXPEDIENTE_NO_ACTO = "No Apto";

        public const bool ESTADO_REGISTRO_NOELIMINADO = true;

        // Clave Encriptado Link
        public const string CLAVE_ENCRIPTADO_LINK = "$1GR4&/#";
        public const string LINK_COMPLEMENTO_SIGRA = "#ConfirmarRegistro/";
        public const string LINK_COMPLEMENTO_RECUPERAR = "#RecuperarContrasenia/";

        // Estados de la distribución
        public const int  ESTADO_DISTRIBUCION_SEDE_EJECUCION = 1;
        public const int ESTADO_DISTRIBUCION_SEDE_SINEJECUCION = 0;

        public const string FECHA_DEFAULT = "01/01/2012 ";

        // campo importación para cargas dinámicas
        public const int ID_CAMPOIMPORTACION_TIPO9 = 7;

        //valor campo es_activo
        public const bool ES_ACTIVO_ACTIVO = true;
    }

}
