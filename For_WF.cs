using Autodesk.AutoCAD.Runtime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace _16_03_2023_autocad_get_text_for_windows
{
    public class For_WF
    {
        [CommandMethod("WF_Form")]
        public void Demo()
        {
            WF_1 mf = new WF_1();
            mf.Show();
        }
    }
}
