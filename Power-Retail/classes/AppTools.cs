using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerRetail.classes
{
    public static class AppTools
    {
        public static Form GetFormByName(string frmname)
        {
            var formType = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name.ToLower() == frmname)
                .FirstOrDefault();

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (Form)Activator.CreateInstance(formType);
        }
    }
}
