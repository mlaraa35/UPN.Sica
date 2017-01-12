using MED.Comun.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroComunOperacion
    {
        public int Id_Operacion { get; set; }
        public int Id_Tipo_Operacion { get; set; }
        public Nullable<int> Id_Configuracion_Evaluacion { get; set; }
        public int Id_Estado_Operacion { get; set; }
        public int Id_Tipo_informacion { get; set; }
        public Nullable<System.DateTime> Fecha_Operacion { get; set; }
        public string Codigo_Usuario { get; set; }
        public int Numero_Registros { get; set; }
        public string Nombre_Archivo { get; set; }
        public string Ip_Origen { get; set; }
        public string Ruta_Archivo { get; set; }
        public string Ruta_Destino { get; set; }
        public string Ruta_Origen { get; set; }
        public string Nombre_Archivo_Destino { get; set; }
        public Nullable<bool> Es_Inactivo { get; set; }
        public System.DateTime Fecha_Creacion { get; set; }
        public bool Estado_Registro { get; set; }
        public int? Id_Competencia { get; set; }
        public string Id_Grado { get; set; }
        public string Id_Nivel { get; set; }
        public bool Carga_Inicial { get; set; }
        public int Carga_Inicial_Enum { get; set; }
        //not mappep
        public int? Id_Tipo_Mensaje_Operacion { get; set; }
        public string Estado { get; set; }
        public int? Row { get; set; }
        public string Correo { get; set; }
        public int Niveles { get; set; }
        public int Id_Tipo_Evaluacion { get; set; }
        public int Id_Anio { get; set; }
    }
}
