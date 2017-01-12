using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WebForms;

namespace MED.Sigra.Transversal.Helpers.Extension
{
    public static class  FiltroExtension
    {
        public static Dictionary<string, object> AsDictionary(object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            return source.GetType().GetProperties(bindingAttr).ToDictionary
            (
                propInfo => propInfo.Name,
                propInfo => propInfo.GetValue(source, null)
            );
            //TODO: 
        }

        public static List<ReportParameter> AsReportParameterList(object source, 
            bool emptyToNull = true,
            bool ceroToNull = true,
            List<string> emptyColumns = null,
            List<string> ceroColumns = null,
            BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            var dic = AsDictionary(source, bindingAttr);

            var parametros = new List<ReportParameter>();
            foreach (var itm in dic)
            {
                string columna = itm.Key;
                string valor = string.Empty;
                if (itm.Value != null)
                {
                    valor = itm.Value.ToString();
                }
                if (emptyToNull && valor == string.Empty)
                {
                    if (emptyColumns == null)
                    {
                        parametros.Add(new ReportParameter(itm.Key));
                    }
                    else 
                    {
                        if (emptyColumns.Contains(columna))
                        {
                            parametros.Add(new ReportParameter(itm.Key));
                        }
                        else 
                        {
                            parametros.Add(new ReportParameter(itm.Key, valor));
                        }                        
                    }                    
                }
                else if (ceroToNull && valor == "0")
                {
                    if (ceroColumns == null)
                    {
                        parametros.Add(new ReportParameter(itm.Key));
                    }
                    else 
                    {
                        if (emptyColumns.Contains(columna))
                        {
                            parametros.Add(new ReportParameter(itm.Key));
                        }
                        else
                        {
                            parametros.Add(new ReportParameter(itm.Key, valor));
                        }
                    }                    
                }
                else {
                    parametros.Add(new ReportParameter(itm.Key, valor));
                }
                
            }

            return parametros;
        }

        public static void Map(object origen, object destino, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            var propiedades = origen.GetType().GetProperties(bindingAttr);
            foreach (PropertyInfo propiedad in propiedades)
            {
                var prop = destino.GetType().GetProperty(propiedad.Name);
                if (prop != null) 
                {
                    prop.SetValue(destino, propiedad.GetValue(origen, null));
                }
            }
        }
    }
}
