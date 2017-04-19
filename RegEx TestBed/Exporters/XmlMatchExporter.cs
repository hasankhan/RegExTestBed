using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace CrackSoft.RegexTestBed.Exporters
{
    class XmlMatchExporter: MatchExporter
    {
        public XmlMatchExporter(ExportParams exportParams) : base(exportParams) { }

        XmlTextWriter xWriter;

        public override void Export(TextWriter writer)
        {
            xWriter = new XmlTextWriter(writer);
            xWriter.Formatting = Formatting.Indented;

            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("RegEx_Search");
            xWriter.WriteStartAttribute("Pattern");
            xWriter.WriteValue(ExportParams.Pattern);
            xWriter.WriteEndAttribute();

            if (ExportParams.MatchList.Items.Count > 0)
            {
                switch (ExportParams.ExportOption)
                {
                    case ExportOption.MatchesOnly:
                        foreach (ListViewItem item in ExportParams.MatchList.Items)
                        {
                            xWriter.WriteStartElement("Matches");
                                xWriter.WriteElementString("Match", item.Text);
                            xWriter.WriteEndElement();
                        }
                        break;
                    case ExportOption.GroupsOnly:
                        foreach (ListViewItem item in ExportParams.MatchList.Items)
                        {
                            xWriter.WriteStartElement("Matches");
                                WriteGroups(item);
                            xWriter.WriteEndElement();
                        }
                        break;
                    case ExportOption.Both:
                        foreach (ListViewItem item in ExportParams.MatchList.Items)
                        {
                            xWriter.WriteStartElement("Matches");
                                xWriter.WriteElementString("Match", item.Text);
                                WriteGroups(item);
                            xWriter.WriteEndElement();
                        }
                        break;
                }
            }

            xWriter.WriteEndElement();
            xWriter.WriteEndDocument();
        }

        void WriteGroups(ListViewItem item)
        {
            for (int i = 1; i < item.SubItems.Count; i++)
                xWriter.WriteElementString(ExportParams.MatchList.Columns[i].Text, item.SubItems[i].Text);
        }
    }
}
