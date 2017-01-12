using MED.Comun.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Extension
{
    public static class ListFilterExtension
    {
        public static void AddFilter(this List<Filter> me, Op Operation, String PropertyName, Object Value)
        {
            me.Add(new Filter()
            {
                Operation = Operation,
                PropertyName = PropertyName,
                Value = Value
            });
        }

        public static void AddReportParameter(this List<Microsoft.Reporting.WebForms.ReportParameter> me, string name, string value)
        {
            me.Add(new Microsoft.Reporting.WebForms.ReportParameter(name, value));
        }

        public static void AddReportParameter(this List<Microsoft.Reporting.WebForms.ReportParameter> me, string name, object value)
        {
            me.Add(new Microsoft.Reporting.WebForms.ReportParameter(name, value == null ? "" : value.ToString()));
        }
    }
}
