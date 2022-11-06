using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Mrinmoy
{
    public class DocxUtils
    {
        public static void WriteFile(string path)
        {
            string fileName = path;
            var doc = DocX.Create(fileName);
            //Create Table with 2 rows and 4 columns.  
            Table t = doc.AddTable(2, 4);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.ColorfulList;
            //Fill cells by adding text.  
            t.Rows[0].Cells[0].Paragraphs.First().Append("AA");
            t.Rows[0].Cells[1].Paragraphs.First().Append("BB");
            t.Rows[0].Cells[2].Paragraphs.First().Append("CC");
            t.Rows[0].Cells[3].Paragraphs.First().Append("DD");
            t.Rows[1].Cells[0].Paragraphs.First().Append("EE");
            t.Rows[1].Cells[1].Paragraphs.First().Append("FF");
            t.Rows[1].Cells[2].Paragraphs.First().Append("GG");
            t.Rows[1].Cells[3].Paragraphs.First().Append("HH");
            doc.InsertTable(t);
            doc.Save();
        }
    }
}
