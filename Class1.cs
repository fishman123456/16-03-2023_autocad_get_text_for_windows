using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

using Application = Autodesk.AutoCAD.ApplicationServices.Application;

namespace _16_03_2023_autocad_get_text_for_windows
{

    public class Class1
    {


        [CommandMethod("Helloy")]
        public void Helloworld()
        {
            var editor = Application.DocumentManager.MdiActiveDocument.Editor;
            editor.WriteMessage("Привет из Autocad плагина");
        }


        [CommandMethod("InsertText")]
        public void InsertText_Model()
        {
            MessageBox.Show("Пробуем вводить текст");
        }


        [CommandMethod("GetTextModel")]
        public void Get_Text_Model()
        {
            //создаем список для хранения слоев
            List<string> list = new List<string>();
            //делаем активный документ
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.
                DocumentManager.MdiActiveDocument;
            //открываем документ для редактирования
            Editor edt = doc.Editor;
            //берем базу данных документа
            Database db = doc.Database;
            try
            {
                //открываем транзакцию-замораживаем открытый чертеж
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    //берем все слои из документа
                    DBDictionary layer = tr.GetObject(db.LayerTableId,
                        OpenMode.ForRead) as DBDictionary;
                    
                    LayerTable tblLayer = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead, false);
                    
                    foreach (ObjectId ent in tblLayer)
                    {
                        LayerTableRecord entLayer = (LayerTableRecord)tr.GetObject(ent, OpenMode.ForRead);
                        MessageBox.Show("\nLayer name : " + entLayer.Name);
                        list.Add(entLayer.Name);
                    }
                    tr.Commit();
                }
                }
            catch (System.Exception ex)
            {
                edt.WriteMessage("\nError >> " + ex.Message);
            }
        }
    }
}
