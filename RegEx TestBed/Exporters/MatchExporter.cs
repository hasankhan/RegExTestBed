using System.Windows.Forms;
using System.IO;

namespace CrackSoft.RegexTestBed.Exporters
{
    enum ExportOption
    {
        MatchesOnly,
        GroupsOnly,
        Both
    }

    struct ExportParams
    {
        public string Pattern { get; set; }
        public ListView MatchList { get; set; }
        public ExportOption ExportOption { get; set; }
    }

    abstract class MatchExporter
    {
        protected ExportParams ExportParams { get; private set; }

        protected MatchExporter(ExportParams exportParams)
        {
            ExportParams = exportParams;
        }

        abstract public void Export(TextWriter writer);
    }
}
