﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Mensajes
{
    public static class Mensajes
    {
        public const String M1= "¿Está seguro que desea guardar esta información?";
        public const String M2= "La información ha sido guardada correctamente.";
        public const String M3= "La información ha sido guardada correctamente. Estimado postulante, Se le ha enviado un link de confirmación al correo registrado para completar su registro al sistema SIGRA.";
        public const String M4= "El campo {0} es obligatorio.";
        public const String M5= "Usuario ya se encuentra Registrado.";
        public const String M6= "N° de Documento y/o Correo Electrónico Ingresado no corresponde al usuario que solicito el registro del postulante.";
        public const String M7= "La Contraseña  y Repetir  Contraseña deben ser idénticas.";
        public const String M8= "¿Está seguro que desea cancelar el registro? Recuerde que perderá la información ingresada hasta el momento.";
        public const String M9= "El usuario no tiene acceso al sistema, comuníquese con el administrador {0}.";
        public const String M10= "El usuario o contraseña es incorrecto.";
        public const String M11= "Capcha incorrecta.";
        public const String M12= "La contraseña se ha registrado correctamente.";
        public const String M13= "La Contraseña actual no es la correcta.";
        public const String M14= "La Nueva contraseña y confirme nueva contraseña no coinciden.";
        public const String M15= "La Nueva contraseña debe contener como mínimo 8 caracteres, al menos un número y un carácter especial";
        public const String M16= "No se pudo cambiar la contraseña";
        public const String M17= "La nueva Contraseña no debe ser igual a las ultimas 6 contraseñas ingresadas.";
        public const String M18= "Estimado postulante, Se le ha enviado un link para recuperar su contraseña.";
        public const String M19= "Correo Ingresado no Se encuentra registrado en el Sistema SIGRA";
        public const String M20= "El Registro ha sido {0} correctamente.";
        public const String M21= "¿Está seguro que desea cancelar?";
        public const String M22= "¿Está seguro que desea cancelar el Operativo?";
        public const String M23= "No Existen Registros para la consulta realizada";
        public const String M24= "El {0} ya se encuentra registrado.";
        public const String M29= "¿Está seguro de procesar la información?";
        public const String M30= "¿Está seguro que desea eliminar esta información?";
        public const String M31= "El formato del archivo debe ser XLSX";
        public const String M32= "Código de Sede se encuentra duplicado en el archivo de carga";
        public const String M33= "Nombre de Sede se encuentra duplicado para el tipo de sede en el archivo de carga";
        public const String M34= "Tipo de sede no es valido";
        public const String M35= "Código de Sede PAdre no existe y no es de tipo sede región en el archivo de carga";
        public const String M36= "No se pudo eliminar la Sede, debido a que se está utilizando en un proceso de selección.";
        public const String M37= "La Sede Región no se puede eliminar, debido a que se está utilizando en un proceso de selección.";
        public const String M38= "La Sede Región no se puede eliminar, debido a que una de sus Sedes Provincias/Distrito se está utilizando en un proceso de selección.";
        public const String M39= "La Sede Provincia/Distrito no se puede eliminar, debido a que se está utilizando en un proceso de selección.";
        public const String M40= "Institución Educativa se encuentra duplicado en el archivo de carga";
        public const String M41= "El Código o Nombre de DRE se encuentran vacíos en el archivo de carga";
        public const String M42= "El Código o Nombre de UGEL se encuentran vacíos en el archivo de carga";
        public const String M43= "El código de la sede no se encuentra asociada al operativo.";
        public const String M44= "El Código Ubigeo se encuentra vacío en el archivo de carga";
        public const String M45= "El Código Local se encuentra vacío en el archivo de carga";
        public const String M46= "El Código Modular  se encuentra vacío en el archivo de carga";
        public const String M47= "El anexo  se encuentra vacío en el archivo de carga";
        public const String M48= "El Nombre de la Institución Educativa se encuentra vacío en el archivo de carga";
        public const String M49= "El Código de la Gestión no es válido.";
        public const String M50= "¿Está seguro que desea salir de la pestaña?";
        public const String M51= "El rango de fechas {0} no es correcto, debe ser mayor o igual a: {1}";
        public const String M52= "El rango de fechas {0} no es correcto, debe ser menor o igual a: {1}";
        public const String M55= "El rango de fecha no es correcta, debe ser 18 años menor a la fecha:{0}";
        public const String M56= "¿Está seguro que desea cambiar la situación del postulante como apto? ";
        public const String M57= "¿Está seguro que desea cambiar la situación del postulante como no apto? ";
        public const String M58= "No existen registros para exportar";
        public const String M59= "No es posible agregar el archivo, debido que existen asistentes duplicados para misma institución educativa.";
        public const String M60= "La institución educativa no pertenece a la sede del supervisor que está realizando la carga.";
        public const String M61= "La institución educativa no existe para el operativo seleccionado";
        public const String M62= "El N° de documento no pertenece a una persona con el rol asistente";
        public const String M63= "El asistente no tiene asignada la sede Provincia /distrito de la institución educativa del operativo";
        public const String M64= "Debe seleccionar al menos un registro para agregar";
        public const String M65= "¿Esta seguro que desea cambiar de página sin guardar los registros seleccionados?";
        public const String M66= "Error al ejecutar proceso 'Cerrar Estados Operativo'";
        public const String M67= "Error al ejecutar proceso 'Cerrar Etapas del Proceso de selección'";
        public const String M68= "Error al ejecutar proceso Etapas del Cronograma por proceso de selección y sede'";
        public const String M69= "Error al ejecutar proceso Cerrar Etapas con Estados por Postulante'";
        public const String M70= "La Fecha del Examen Pre-Selección debe ser menor a la fecha Hasta y mayor a la fecha Desde de la Pre-selección.";
        public const String M71= "La fecha Desde de Capacitación se debe encontrar en el rango de las Fechas Desde y Hasta  y ser menor a la fecha Hasta de Gestión Capacitación.";
        public const String M72= "La fecha Hasta de Capacitación se debe encontrar en el rango de las Fechas Desde y Hasta  y ser menor a la fecha Hasta de Gestión Capacitación.";
        public const String M73= "La Sede seleccionada no se puede eliminar, debido a que operativo se encuentrea Vigente o Publicado.";
        public const String M75= "El Código del Área no es válido.";
        public const String M76= "El Código de Evaluación no es válido.";
        public const String M77= "No se está ingresando la cantidad de aplicadores para la Institución Educativa.";
        public const String M78= "La cantidad de aplicadores debe ser numérico y mayor 0 para la Institución Educativa.";
        public const String M79= "La cantidad de líderes debe ser numérico para la Institución Educativa.";
        public const String M80= "La cantidad de alumnos por sección debe ser numérico para la Institución Educativa.";
        public const String M81= "No se pudo eliminar la institución debido a que se está utilizando en un proceso de selección.";
        public const String M82= "No se pudo eliminar las secciones de la institución debido a que se está utilizando en un proceso de selección.";
        public const String M83= "Debe Seleccionar al menos un registro para agregar";
        public const String M84= "El Personal a Eliminar Tiene Instituciones Educativas Asignar que también se eliminarán.";
        public const String M85= "Tipo de documento no es valido";
        public const String M86= "Tipo de documento se encuentra vacío en el archivo de carga";
        public const String M87= "Número de documento se encuentra vacío en el archivo de carga";
        public const String M88= "El Personal enviado no se encuentra registrado como usuario del Sistema SIGRA";
        public const String M89= "Código de Sede se encuentra vacío en el archivo de carga";
        public const String M90= "¿Está seguro que desea Distribuir a todos los postulantes?";
        public const String M91= "¿Está seguro que desea quitar  a todos los postulantes del local que aún no están  notificados?";
        public const String M92= "El Archivo de Carga debe contener mínimo {0} registros.";
        public const String M93= "Existen Postulantes duplicados";
        public const String M94= "El Postulante no pertenece al proceso , sede  y local";
        public const String M95= "El postulante tiene resultados de pre-selección registrados ";
        public const String M96= "Por favor asegúrese de actualizar o completar su ficha de postulación antes de postular. ¿Está seguro que desea postular?";
        public const String M97= "Calificación  fuera de rango, el rango es de 0 a 20";
        public const String M98= "¿Está seguro que desea invitar a {0} al postulante?";
        public const String M99= "No existen postulantes para notificar";
        public const String M100= "Existen asistencias registradas para el local {0}";
        public const String M101= "No Existen postulantes para quitar, Los postulantes se encuentran notificados o pendientes de notificación";
        public const String M102= "No es posible eliminar  la distribución, Existen postulantes Notificados";
        public const String M103= "No es posible {0} el postulante se encuentra notificado";
        public const String M104= "No existe  local(es) con disponibilidad  para la distribución.";
        public const String M105= "No Existen locales registrados  para la distribución";
        public const String M106= "No Existen postulantes aptos  para la distribución";
        public const String M107= "¿Está seguro que desea notificar a los postulantes?";
        public const String M108= "Se procedió a enviar notificaciones a los postulantes, el proceso puede tardar unos minutos.";
        public const String M109= "La distribución se realizó correctamente.";
        public const String M110= "No existen postulantes en el registro de asistencia";
        public const String M111= "La fecha {0} no es válida , debe ser mayor o igual a la {1}.";
        public const String M112= "No Existen postulantes aptos o invitados para la capacitación";
        public const String M113= "El postulante tiene resultados de capacitación";
        public const String M114= "La fecha de asistencia no pertenece a ninguna fecha de capacitación";
        public const String M115= "El postulante tiene asignado orden de selección";
        public const String M116= "El o los códigos de criterio no pertenece al proceso de selección";
        public const String M117= "La fecha {0} no es válida , debe ser menor o igual a la {1}.  ";
        public const String M119= "La Hora Inicio es mayor a la Hora Fin";
        public const String M120= "La Hora Fin es menor a la Hora Inicio.";
        public const String M122= "El postulante ya fue  invitado  o tiene una invitación en curso para  mismo  proceso y  sede.";
        public const String M123= "¿Está seguro que desea asignar el ordenar de seleccione  a todos los postulantes?";
        public const String M124= "Los postulantes fueron ordenados correctamente";
        public const String M125= "No Existen postulantes para asignar orden de selección";
        public const String M126= "No es posible asignar orden de selección , Existen postulantes asignados a IE ";
        public const String M127= "No es posible cambiar orden , el postulante tiene IE asignada";
        public const String M128= "No existe vacantes disponibles para asignar a titulares.";
        public const String M129= "N° de Documento de Identidad No Existe. Verificar que sea un número valido y que sea mayor de edad.";
        public const String M130= "¿Está seguro que desea realizar la asignación de postulantes a IE y secciones?";
        public const String M131= "Se ha  realizado a asignación de IE y secciones Correctamente";
        public const String M132= "¿Está seguro que desea notificar a los postulantes asignados?";
        public const String M133= "Los postulantes fueron notificados correctamente";
        public const String M134= "¿Está seguro que desea quitar todos los postulantes asignados";
        public const String M135= "No existe IE para realizar la asignación";
        public const String M136= "No existen postulantes disponibles para asignar";
        public const String M137= "No es posibles asignar postulantes, la(s) IE(s) tiene su capacidad cubierta'. ";
        public const String M138= "La capacidad de líderes debe ser igual o mayor al número de aplicadores asignados";
        public const String M139= "La capacidad de aplicadores debe ser igual o mayor al total de aplicadores asignados (aplicadores y acompañantes)";
        public const String M140= "La capacidad aplicadores debe ser mayor a 0";
        public const String M141= "Debe seleccionar al menos una   asignación de un postulante para asignar";
        public const String M142= "Debe seleccionar sección para los postulantes con asignación aplicador y/o aplicador acompañante";
        public const String M143= "La cantidad de aplicadores líderes a asignar supera la capacidad de aplicadores líderes que requiere  la IE";
        public const String M144= "El total de aplicadores  (aplicadores y aplicadores acompañantes) a asignar supera la capacidad de aplicadores que requiere  la IE";
        public const String M145= "Solo puede asignar  1 aplicador acompañante por sección.";
        public const String M146= "No existen aplicadores (aplicadores líderes, aplicador, aplicador acompañante) pendientes de notificar";
        public const String M147= "No es posible eliminar, el aplicador {0} ya fue notificado";
        public const String M148= "No es posible procesar, existe un proceso en ejecución  ";
        public const String M149= "¿Está seguro que desea quitar esta información?";
        public const String M150= "La postulación se registró correctamente, se le estará enviado un correo electrónico con la información correspondiente.";
        public const String M151= "No tiene permisos para consultar información de la IE";
        public const String M152= "No hay capacidad disponible para asignar {0}";
        public const String M153= "La sección ya tienen aplicador acompañante asignado con estado 'Efectivo'";
        public const String M154= "No es posible quitar, el postulante tiene evaluación de desempeño";
        public const String M155= "Debe seleccionar valor a todos los criterios.";
        public const String M156= "La Sede Provincia/Distrito no se puede eliminar, debido a que tiene postulantes registrados.";
        public const String M157= "El Aula ya se encuentra registrado";
        public const String M158= "El local no se puede eliminar, debido a que tiene aulas que están siendo utilizadas en la Preselección y/o Capacitación.";
        public const String M159= "El Aula no se puede eliminar, debido a que esta siendo utilizada en la Preselección y/o Capacitación.";
        public const String M160= "La Capacidad del Aula no puede ser menor a la utilizada en la Preselección y/o Capacitación.";
        public const String M161= "Ya existe un valor de parámetro registrado con el mismo nombre para el parámetro.";
        public const String M162= "Ya existe una formación educativa con los mismo valores";
        public const String M163= "Ya existe otros (Certificaciones, Diplomados, Especializaciones u otros) con los mismo valores";
        public const String M164= "Ya existe una experiencia laboral con los mismo valores";
        public const String M165= "Ya existe un conocimiento informático con los  mismos valores";
        public const String M166= "Ya existe un idioma con los mismos valores";
        public const String M167= "Ya existe una lengua originaria con los mismos valores";
        public const String M169= "El código de la sede no se encuentra asociada al proceso de selección.";
        public const String M170= "El Nombre del Local se encuentra Vacío.";
        public const String M171= "El Dirección del Local se encuentra Vacío.";
        public const String M172= "El N° de Aula del Local se encuentra Vacío.";
        public const String M173= "El Capacidad de Aula del Local se encuentra Vacío.";
        public const String M174= "El N° de Aula del Local se esta repitiendo en el archivo de carga.";
        public const String M175= "El N° de Aula del Local esta siendo utilizado.";
        public const String M176= "El Local se esta siendo utilizado.";
        public const String M177= "Usted No puede Editar, debido a que la fecha actual es mayor a la fecha de inicio de capacitación del local";
        public const String M178= "La fecha de asistencia debe ser misma para todos los registros.";
        public const String M179= "El rango de fecha inicio y fecha fin se excede, debe ser menor o igual a 7 días";
        public const String M180= "Los Días ingresado deben estar en el rango de 1 al 30.";
        public const String M181= "La cantidad de aplicadores por sección debe ser menor o igual a {0}.";
        public const String M182= "No es posible cambiar asignación , el estado final debe ser 'efectivo'";
        public const String M183= "El postulante ya se encuentra distribuido en el local seleccionado ";
        public const String M184= "¿Está seguro que desea quitar al invitado de la programación de {0}?";
        public const String M185= "El postulante se encuentra invitado, no es posible actualizar su calificación(es)";
        public const String M186= "El postulante se encuentra invitado.";
        public const String M187= "El postulante no asistió a todos los días de capacitación";
        public const String M188= "El postulante no asistió a la pre - selección.";
        public const String M189= "El postulante se encuentra distribuido en la capacitación";
        public const String M190= "Usted no puede agregar más de un  valor a este parámetro.";
        public const String M191= "El archivo tiene columnas que no tienen el formato correcto ";
        public const String M192= "Existen locales tienen fecha de examen de pre – selección  menor a la fecha actual.";
        public const String M193= "La fecha  de examen de pre- selección  de un local (es)  debe ser mayor  a la fecha de actual";
        public const String M194= "El formato de hora debe ser hh/mm/ss";
        public const String M195= "La cantidad de columnas criterio debe  ser igual a la  cantidad de criterios del proceso.";
        public const String M196= "Existen código(s) de criterio(s) duplicado(s)";
        public const String M197= "No es posible agregar el archivo, se debe incluir los criterios como cabecera en la primera fila a partir de la posición 3";
        public const String M198= "La fecha fin de capacitación se encuentra fuera de rango de la gestión de capacitación";
        public const String M199= "La fecha de examen de pre-selección se encuentra fuera de rango de la pre-selección";
        public const String M200= "El aplicador ya tiene estado final diferente asignado en la ejecución de asignación.";
        public const String M201= "No hay vacante disponible para asignar seleccionados.";
        public const String M202= "No hay aula(s) con disponibilidad mayor a cero.";
        public const String M203= "N° de RUC No Existe. Verificar que sea un número valido.";
        public const String M204= "El formato de la fecha debe ser dd/mm/aaaa.";
        public const String M205= "Ha superado el máximo de intentos permitido.";
        public const String M206= "El Link ejecutado no se encuentra vigente";
        public const String M207= "Existen Secciones con el mismo nombre a partir de la columna  N° 31";
        public const String M208= "No es posible editar local, existen postulantes pendientes de notificar";
        public const String M209= "El formato del archivo debe ser PDF";
        public const String M210= "El peso  del archivo de ser igual o menor a 5 MB";
        public const String M212= "N° de RUC ya se encuentra registrado.";
        public const String M213= "Confirmar Correo Electrónico es Distinto al Correo Electrónico ingresado.";
        public const String M214= "Correo Electrónico ya se encuentra registrado.";
        public const String M215= "Código de UBIGEO no es Valido.";
        public const String M216= "La fecha de asistencia no es igual a la fecha del local ,Para actualizar la fecha de asistencia debe notificar a los postulantes.";
        public const String M217= "No  es posible {0} al postulante, debido a que se encuentra notificado o pendiente de notificar.";
        public const String M218= "No es posibles realizar la distribución, existe una distribución en ejecución para la misma sede";
        public const String M219= "Se ha(n) quitado todos los postulantes que aún no han sido notificados o que están pendientes de notificación";
        public const String M220= "Se ha quitado el  postulante seleccionado del local y aula distribuido";
        public const String M221= "Se ha quitado correctamente el postulante Invitado ";
        public const String M222= "El aula no tiene disponibilidad";
        public const String M223= "El Operativo no se puede Cancelar, debido a que tiene Procesos de Selección Vigentes y/o Finalizados.";
        public const String M224= "No es posible realizar la asignación de IE, existe una asignación de IE en ejecución para la misma sede";
        public const String M225= "No es posible copiar el archivo en la ruta";
        public const String M226= "El postulante tienen criterio(s) sin calificación.";
        public const String M227= "El postulante tienen criterio(s) sin calificación.";
        public const String M228= "La sumatoria de pesos  de los criterios de  {0} debe ser igual a 100%";
        public const String M229= "La cantidad máxima de criterios {0}  debe ser menor o igual a 7.";
        public const String M230= "El local ya existe para el tipo seleccionado";
        public const String M231= "El Código de Local ya existe en la Sede.";
        public const String M232= "No se puede guardar, debido a que no existe registros en la secciones del perfil.";
        public const String M233= "El código Modular no es valido.";
        public const String M234= "Se ha quitado la información del detalle de evaluación";
        public const String M235= "El Link ejecutado no es válido";
        public const String M236= "No es posible cambiar orden , el postulante tiene estado final en ejecución de asignación";
        public const String M237= "No es posible realizar la asignación de orden de selección ,  existe una asignación  en ejecución para la misma sede";
        public const String M238 = "Existen postulantes que ya se encuentran asignados a una IE del mismo nivel y grado.";

        public const String M991 = "Ocurrió un problema al momento de registrar";
        public const String M992 = "Ocurrió un problema al momento de modificar";
        public const String M993 = "Ocurrió un problema al momento de eliminar";

        public const String M994 = "Error de tiempo de espera con el servicio. Inténtelo más tarde.";
        public const String M995 = "Error de Conexión con el servicio. Inténtelo más tarde.";
        public const String M996 = "Ha ocurrido un error en el sistema. Inténtelo más tarde.";

        public static String Show(string messageID, params string[] arguments)
        {
            var t = typeof(Mensajes);
            //var formato = t.GetType().GetProperty(messageID).GetValue(t, null).ToString();

            //return string.Format(formato, arguments);
            return string.Format(messageID, arguments);
        }
    }
}
