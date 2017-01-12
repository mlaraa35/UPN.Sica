using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Enumerados
{ 
    public class Enumerado
    { 
        public enum EnumeradoCabecera : int
        {
            EstadosOperativo = 1, //EstadosOperativo
            TipoDocumento = 2, //TipoDocumento
            TipoSede = 3, //TipoSede
            TipoAsignacion = 4, //TipoAsignacion
            OpcionesMenuPostulante = 5, //OpcionesMenuPostulante
            IndicadorOrigen = 6, //IndicadorOrigen
            EstadoAsignacion = 7, //EstadoAsignacion
            EstadoFinalEjecucion = 8, //EstadoFinalEjecucion
            SituacionEvaluacionDesempeno = 9, //SituacionEvaluacionDesempeno
            EstadoAsistencia = 10, //EstadoAsistencia
            TipoCarga = 11, //TipoCarga
            TipoOperacion = 12, //TipoOperacion
            TipoEtapa = 13, //TipoEtapa
            EstadoDistribucion = 14, //EstadoDistribucion
            SituacionPostulanteDistribucion = 15, //SituacionPostulanteDistribucion
            IndicadorInvitacion = 16, //IndicadorInvitacion
            OrdenSeleccion = 17, //OrdenSeleccion
            Gestion = 18, //Gestion
            Area = 19, //Area
            TipoOperacionVerificacion = 2,//TipoOperacionVerificacion
            EstadoLinkVerificacion = 21, //EstadoLinkVerificacion
            TipoLocal = 22, //TipoLocal
            NivelConocimiento = 23, //NivelConocimiento
            Requisito = 24, //Requisito
            NivelInstruccion = 25, //NivelInstruccion
            TipoTiempoEstudio = 26, //TipoTiempoEstudio
            NivelAlcanzado = 27, //NivelAlcanzado
            TipoIdiomaLengua = 28, //TipoIdiomaLengua
            IndicadorLenguaMaterma = 29, //IndicadorLenguaMaterma
            NivelHablaNivelLeeNivelEscribe = 30, //NivelHablaNivelLeeNivelEscribe
            EstadoPostulacion = 31, //EstadoPostulacion
            ResultadoPerfil = 32, //ResultadoPerfil
            EstadoCivil = 33, //EstadoCivil
            TipoVia = 34, //TipoVia
            TipoZona = 35, //TipoZona
            EstadoProcesoSeleccion = 36, //EstadoProcesoSeleccion
            SituacionVerificacionPerfil = 37, //SituacionVerificacionPerfil
            SituacionVerificacionExpediente = 38, //SituacionVerificacionExpediente
            AmbitoProceso = 39, //AmbitoProceso
            PresentacionExpediente = 40, //PresentacionExpediente
            EstadoEtapa = 41, //EstadoEtapa
            EstadoContrasena = 42, //EstadoContrasena
            Sexo = 43, //Sexo
            Operador = 44, //Operador
            EstadoCarga = 45, //EstadoCarga
            RespuestaExperienciaEspecifica = 46, //RespuestaExperienciaEspecifica
            EstadoPostulante = 47, //EstadoPostulante
            ValorCriterioEvaluacion = 48, //ValorCriterioEvaluacion
            RangoCalificacionPreseleccion = 49, //RangoCalificacionPreseleccion
            RangoCalificacionCapacitacion = 50, //RangoCalificacionCapacitacion
            CantidadMinimaRegistrosCarga = 51 //CantidadMinimaRegistrosCarga
        }
        public enum ESTADOS_OPERATIVO : int
        {
            Registrado = 1, //Registrado
            Cancelado = 2, //Cancelado
            Publicado = 3, //Publicado
            Vigente = 4, //Vigente
            Finalizado = 5, //Finalizado
        }
         
        public enum TIPO_DOCUMENTO : int
        {
            DNI = 1, //DNI
            CarnetDeExtranjeria = 4 //Carnet de Extranjeria
        }

        public enum TIPO_SEDE : int
        {
            SedeRegion = 1, //Sede Región
            SedeProvinciaDistrito = 2 //Sede Provincia Distrito 
        }

        public enum TIPO_ASIGNACION : int
        {
            AplicadorLider = 1,//Aplicador Líder
            Aplicador = 2, //Aplicador
            AplicadorAcompanante = 3, //Aplicador Acompañante
            Seleccionado = 4 //Seleccionado
        }

        public enum OPCIONES_MENU_POSTULANTE : int
        {
            FichaPostulante = 1, //Ficha Postulante
            Convocatorias = 2, //Convocatorias
            MisPostulaciones = 3 //Mis Postulaciones

        }

        public enum INDICADOR_ORIGEN : int
        {
            Asignacion = 1, //Asignación  
            Ejecucion = 2 //Ejecución   
        }

        public enum ESTADO_ASIGNACION : int
        {
            Asignado = 1, //Asignado
            PendienteNotificar = 2, //Pendiente Notificar
            Notificado = 3 //Notificado
        }

        public enum ESTADO_FINAL_EJECUCION : int
        {
            Asignado = 1, //Asignado
            Efectivo = 2, //Efectivo
            NoAsistio = 3, //No Asistió
            Renuncio = 4, //Renunció
            AsistenciaParcial = 5 //Asistencia Parcial
        }

        public enum SITUACION_EVALUACION_DESEMPENO : int
        {
            Recomendable = 1, //Recomendable
            NoRecomendable = 2 //No Recomendable
        }

        public enum ESTADO_ASISTENCIA : int
        {
            NoAsistio = 0, //No Asistió
            Asistio = 1, //Asistio
        }

        public enum TIPO_CARGA : int
        {
            CargaSede = 1, //carga_sede
            CargaIe = 2, //carga_ie
            CargaPersonalSede = 3, //carga_personal_Sede
            CargaAsistentesIe = 4, //carga_asistentes_ie
            CargaLocales = 5, //carga_locales
            CargaAsistenciaPreseleccion = 6, //carga_asistencia_preseleccion
            CargaAsistenciaCapacitacion = 7, //carga_asistencia_capacitacion
            CargaResultadoPreseleccion = 8, //carga_resultado_preseleccion
            CargaResultadoCapacitacion = 9 //carga_resultado_capacitacion
        }

        public enum TIPO_OPERACION : int
        {
            Insertar = 1, //Insertar
            Eliminar = 2 //Eliminar
        }

        public enum TIPO_ETAPA : int
        {
            Inscripcion = 1, //Inscripción
            VerificacionPerfil = 2, //Verificación perfil
            RecepcionExpediente = 3, //Recepcion expediente
            VerificacionDeExpediente = 4, //Verificacion de expediente
            Preseleccion = 5, //Preselección 
            GestionCapacitacion = 6, //GestionCapacitacion 
            Capacitacion = 7, //Capacitacion 
            Asignacion = 8, //Asignación 
            DuraccionDeServicio = 9, //Duracción de servicio
            Evaluacion = 10 //Evaluación
        }

        public enum ESTADO_DISTRIBUCION : int
        {
            Distribuido = 1, //Distribuido
            PendienteNotiticar = 2, //Pendiente Notiticar
            Notificado = 3 //Notificado 
        }

        public enum SITUACION_POSTULANTE_DISTRIBUCION : int
        {
            Apto = 1, //Apto
            NoApto = 2 //No Apto
        }

        public enum INDICADOR_INVITACION : int
        {
            SinInvitacion = 1, // Sin Invitación
            Invitado = 2 //Invitado
        }

        public enum ORDEN_SELECCION : int
        {
            Titular = 1, //Titular
            Reserva = 2 //Reserva
        }

        public enum GESTION : int
        {
            PublicaDeGestionDirecta = 1, //Pública de gestión directa
            PublicaDeGestionPrivada = 2, //Pública de gestión privada
            Privada = 3 //Privada
        }

        public enum AREA : int
        {
            Urbana = 1, //Urbana
            Rural = 2, //Rural
            UrbanoResidencial = 11, //Urbano Residencial
            UrbanoMarginal = 12, //Urbano Marginal
            AsentamientoHumano = 13 //Asentamiento Humano
        }

        public enum TIPO_OPERACION_VERIFICACION : int
        {
            RegistroPostulante = 1, //Registro Postulante
            RecuperarContrasenaPostulante = 2 //Recuperar  Contraseña postulante
        }

        public enum ESTADO_LINK_VERIFICACION : int
        {
            Vigente = 1, //Vigente
            Cancelado = 2, //Cancelado
            Finalizado = 3, //Finalizado
            Caducado = 4
        }

        public enum TIPO_LOCAL : int
        {
            EntregaDeExpedientes = 1, //Entrega de Expedientes
            PreSeleccion = 2, //Pre-Selección
            Capacitacion = 3, //Capacitación
            RecojoDeMateriales = 4 //Recojo de Materiales
        }

        public enum NIVEL_CONOCIMIENTO : int
        {
            Basico = 1, //Básico
            Intermedio = 2, //Intermedio
            Avanzado = 3 //Avanzado
        }

        public enum REQUISITO : int
        {
            Indispensable = 1, //Indispensable
            Deseable = 2 //Deseable
        }

        public enum NIVEL_INSTRUCCION : int
        {
            SECUNDARIACOMPLETA = 1, //SECUNDARIA COMPLETA
            SUPERIORNOUNIVERSITARIAINCOMPLETA = 2, //SUPERIOR  NO UNIVERSITARIA INCOMPLETA
            SUPERIORNOUNIVERSITARIACOMPLETA = 3, //SUPERIOR NO UNIVERSITARIA COMPLETA
            SUPERIORUNIVERSITARIAINCOMPLETA = 4, //SUPERIOR UNIVERSITARIA INCOMPLETA
            SUPERIORUNIVERSITARIACOMPLETA = 5, //SUPERIOR UNIVERSITARIA COMPLETA
            SEGUNDAESPECIALIDAD = 6 //SEGUNDA ESPECIALIDAD
        }

        public enum TIPO_TIEMPO_ESTUDIO : int
        {
            Ciclo = 1, //Ciclo
            Ano = 2 //Año
        }

        public enum NIVEL_ALCANZADO : int
        {
            ESTUDIANTE = 1, //ESTUDIANTE
            EGRESADO = 2, //EGRESADO
            BACHILLER = 3, //BACHILLER
            TITULADO = 4 //TITULADO
        }

        public enum TIPO_IDIOMA_LENGUA : int
        {
            Idiomas = 1, //Idiomas
            LenguasOriginariasDelPeru = 2 //Lenguas Originarias del Perú
        }

        public enum INDICADOR_LENGUA_MATERMA : int
        {
            Si = 1, //Si
            No = 2 //No
        }

        public enum NIVEL_HABLA_NIVEL_LEE_NIVEL_ESCRIBE : int
        {
            Basico = 1, //Básico
            Intermedio = 2,//Intermedio
            Avanzado = 3 //Avanzado
        }

        public enum ESTADO_POSTULACION : int
        {
            Vigente = 1, //Vigente
            Anulado = 2 //Anulado
        }

        public enum RESULTADO_PERFIL : int
        {
            SiCumple = 1,//Si Cumple
            NoCumple = 2 //No Cumple
        }

        public enum ESTADO_CIVIL : int
        {
            Solteroa = 1, //Soltero(a)
            Casado = 2, //Casado(o)
            Divorciado = 3 //Divorciado(a)
        }

        public enum ESTADO_PROCESO_SELECCION : int
        {
            Registrado = 1, //Registrado
            Cancelado = 2, //Cancelado
            Publicado = 3, //Publicado
            Vigente = 4, //Vigente
            Finalizado = 5 //Finalizado
        }

        public enum SITUACION_VERIFICACION_PERFIL : int
        {
            Apto = 1, //Apto
            NoApto = 2 //No Apto
        }

        public enum SITUACION_VERIFICACION_EXPEDIENTE : int
        {
            Apto = 1, //Apto
            NoApto = 2 //No  Apto
        }

        public enum AMBITO_PROCESO : int
        {
            SedeRegion = 1, //Sede Región
            ProvinciaDistrito = 2, //Provincia/Distrito
            InstitucionEducativa = 3 //Institución Educativa
        }

        public enum PRESENTACION_EXPEDIENTE : int
        {
            NO = 0,//NO
            SI = 1 //SI
        }

        public enum ESTADO_ETAPA : int
        {
            Registrado = 1, //Registrado
            Abierto = 2, //Abierto
            Cerrado = 3 //Cerrado
        }

        public enum ESTADO_CONTRASENA : int
        {
            Vigente = 1, //Vigente
            Caducado = 2 //Caducado
        }

        public enum SEXO : int
        {
            Masculino = 1, //Masculino
            Femenino = 2, //Femenino
        }

        public enum ESTADO_CARGA : int
        {
            Cargado = 1, //Cargado 
            EnProceso = 2, //EnProceso 
            ProcesadoConErrores = 3, //ProcesadoConErrores 
            procesado = 4 //Procesado 
        }

        public enum RESPUESTA_EXPERIENCIA_ESPECIFICA : int
        {
            NO = 0, //NO
            SI = 1 //SI
        }

        public enum ESTADO_POSTULANTE : int
        {
            Registrado = 1, //Registrado
            Vigente = 2 //Vigente
        }

        public enum VALOR_CRITERIO_EVALUACION : int
        {
            Pesimo = 1, //Pésimo
            Malo = 2, //Malo
            Adecuado = 3, //Adecuado
            Bueno = 4, //Bueno
            Excelente = 5 //Excelente
        }

        public enum RANGO_CALIFICACION_PRESELECCION : int
        {
            Minima = 0, //Minima
            Maxima = 20 //Maxima
        }

        public enum RANGO_CALIFICACION_CAPACITACION : int
        {
            Minima = 0, //Minima
            Maxima = 20 //Maxima
        }

        public enum CANTIDAD_MINIMA_REGISTROS_CARGA : int
        {
            Minima = 10 //Minima
        }

        public enum TipoReporte : int
        {
            Pdf = 1,
            Excel = 2,
            Word = 3,
            Mhtml = 4,
            Html4 = 5
        }

        public enum TIPO_INFORMACION : int
        {
            CargaNoEspecificada = 0,
            CargaPersonalSede = 1,
            CargaAsistentesIe = 2,
            CargaAsistenciaPreseleccion = 3,
            CargaAsistenciaCapacitacion = 4,
            CargaResultadoPreseleccion = 5,
            CargaSede = 6,
            CargaIe = 7,
            CargaLocal = 8,
            CargaResultadoCapacitacion = 9,
        }

        public enum ESTADO_OPERACION : int
        { 
            Procesado = 1,
            Procesado_con_errores= 2,
            Cargado= 3,
            En_proceso= 4,
            Abortado= 5,
            No_procesado = 6
        }

        public enum TIPO_MENSAJE_CARGA : int
        {
            Procesado = 1,
            Error_Data = 2,
            Error_Estructura = 3,
            Validacion_Negocio = 4,
            En_Cola = 5
        }

        public enum ValidacionSunat : int 
        {
            NO_VALIDADO = 0,
            VALIDADO
        }  
    }
}
