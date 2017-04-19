using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CrackSoft.RegexTestBed.Exporters
{
    class CsvMatchExporter : MatchExporter
    {
        public CsvMatchExporter(ExportParams exportParams) : base(exportParams) { }

        public override void Export(TextWriter writer)
        {
            if (ExportParams.MatchList.Items.Count == 0)
                return;

            List<string> temp = new List<string>();
            switch (ExportParams.ExportOption)
            {
                case ExportOption.MatchesOnly:
                    writer.WriteLine(ExportParams.MatchList.Columns[0].Text);
                    foreach (ListViewItem item in ExportParams.MatchList.Items)
                        writer.WriteLine(item.Text);
                    break;

                case ExportOption.GroupsOnly:
                    for (int i = 1; i < ExportParams.MatchList.Columns.Count; i++)
                        temp.Add(ExportParams.MatchList.Columns[i].Text);
                    WriteRecord(writer, temp.ToArray());
                    temp.Clear();

                    foreach (ListViewItem item in ExportParams.MatchList.Items)
                    {
                        for (int i=1; i<item.SubItems.Count; i++)
                            temp.Add(item.SubItems[i].Text);
                        WriteRecord(writer, temp.ToArray());
                        temp.Clear();
                    }
                    break;

                case ExportOption.Both:
                    foreach (ColumnHeader column in ExportParams.MatchList.Columns)
                        temp.Add(column.Text);
                    WriteRecord(writer, temp.ToArray());
                    temp.Clear();

                    foreach (ListViewItem item in ExportParams.MatchList.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            temp.Add(subItem.Text);
                        WriteRecord(writer, temp.ToArray());
                        temp.Clear();
                    }
                    break;
            }
        }

        void WriteRecord(TextWriter writer, string[] items)
        {
            //// Code below is for escaping the double quotes in the string
            //items = Array.ConvertAll<string, string>(
            //    items,
            //    new Converter<string, string>(delegate(string item)
            //    {
            //        return item.Replace("\"", "\"\"");
            //    }));
            writer.WriteLine(String.Join(", ", items));
        }
    }
}
