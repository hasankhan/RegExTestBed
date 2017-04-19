using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;

namespace CrackSoft.RegexTestBed
{
    struct SearchParams
    {
        public bool IncrementalSearch { get; set; }
        public bool ContinueSearch { get; set; }
        public string InputText { get; set; }
    }

    class SearchResult
    {
        public int MatchCount { get; set; }
        public SearchParams SearchParams { get; set; }
        public List<ListViewItem> ListItems { get; set; }
        public TimeSpan SearchTime { get; set; }
    }

    static class SearchUtility
    {
        static bool textHighlighted = false; // to prevent flicker of removing highlight on each key press

        public static ListViewItem CreateListItem(Match match)
        {
            ListViewItem item = new ListViewItem(match.Value);
            for (int i = 1; i < match.Groups.Count; i++)
                item.SubItems.Add(match.Groups[i].Value);
            return item;
        }

        public static void ClearHighlight(RichTextBox textBox)
        {
            if ((textBox.Text != String.Empty) && textHighlighted)
            {
                int i = textBox.SelectionStart;
                textBox.SelectAll();
                textBox.SelectionBackColor = SystemColors.Window;
                textBox.SelectionColor = SystemColors.WindowText;
                textBox.SelectionStart = i;
                textBox.SelectionLength = 0;
                textHighlighted = false;
            }
        }

        public static Regex GetRegExObject(string pattern, bool singleLine, bool ignoreCase)
        {
            RegexOptions opts = RegexOptions.None;
            if (singleLine)
                opts |= RegexOptions.Singleline;
            if (ignoreCase)
                opts |= RegexOptions.IgnoreCase;
            return new Regex(pattern, opts);
        }

        internal static void HighlightMatch(ref RichTextBox textBox, Match match, bool scrollToMatch)
        {
            textBox.Select(match.Index, match.Length);
            textBox.SelectionBackColor = Color.Red;
            textBox.SelectionColor = Color.White;
            if (scrollToMatch)
                textBox.ScrollToCaret();
            textHighlighted = true;
        }
    }
}
