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
        public static Form GetFormByName(string name)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            foreach (Type type in myAssembly.GetTypes())
            {
                if (type.BaseType != null && type.BaseType.FullName == "System.Windows.Forms.Form")
                {
                    if (type.Name == name)
                    {
                        Form form = Activator.CreateInstance(Type.GetType(name)) as Form;
                        return form;
                    }
                }
            }
            return null;
        }
    }
}
