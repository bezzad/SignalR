using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using SignalR.Core.Extensions;

namespace SignalR.Core.View
{
    public partial class RuntimeCompiler : Form
    {
        #region Syntax Parser Members

        private string _lang = "CSharp (built-in highlighter)"; //"CSharp (custom highlighter)";
        private const int MaxBracketSearchIterations = 2000;

        //styles
        public TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        public TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        public TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        public TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        public TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        public TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        public TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        public MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        #endregion

        #region Compiler Errors Members

        private Color infoStyle = Color.Black;
        private Color warningStyle = Color.BurlyWood;
        private Color errorStyle = Color.Red;

        #endregion

        private readonly Client _client;
        private readonly List<string> _users;

        public RuntimeCompiler(Client conn, List<string> users)
        {
            InitializeComponent();

            _users = users;
            _client = conn;
            _client.ExecuteAcknowledge += ExecuteCSharpCodesAcknowledge;
        }


        #region Syntax Parser Methods

        private void InitStylesPriority()
        {
            //add this style explicitly for drawing under other styles
            txtSyntaxParser.AddStyle(SameWordsStyle);
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (_lang)
            {
                case "CSharp (custom highlighter)":
                    //For sample, we will highlight the syntax of C# manually, although could use built-in highlighter
                    CSharpSyntaxHighlight(e);//custom highlighting
                    break;
                default:
                    break;//for highlighting of other languages, we using built-in FastColoredTextBox highlighter
            }

            if (txtSyntaxParser.Text.Trim().StartsWith("<?xml"))
            {
                txtSyntaxParser.Language = Language.XML;

                txtSyntaxParser.ClearStylesBuffer();
                txtSyntaxParser.Range.ClearStyle(StyleIndex.All);
                InitStylesPriority();
                txtSyntaxParser.AutoIndentNeeded -= fctb_AutoIndentNeeded;

                txtSyntaxParser.OnSyntaxHighlight(new TextChangedEventArgs(txtSyntaxParser.Range));
            }
        }

        private void CSharpSyntaxHighlight(TextChangedEventArgs e)
        {
            txtSyntaxParser.LeftBracket = '(';
            txtSyntaxParser.RightBracket = ')';
            txtSyntaxParser.LeftBracket2 = '\x0';
            txtSyntaxParser.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.ShowReplaceDialog();
        }

        private void miLanguage_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem mi in miLanguage.DropDownItems)
                mi.Checked = mi.Text == _lang;
        }

        private void miCSharp_Click(object sender, EventArgs e)
        {
            //set language
            _lang = (sender as ToolStripMenuItem).Text;
            txtSyntaxParser.ClearStylesBuffer();
            txtSyntaxParser.Range.ClearStyle(StyleIndex.All);
            InitStylesPriority();
            txtSyntaxParser.AutoIndentNeeded -= fctb_AutoIndentNeeded;
            //
            switch (_lang)
            {
                //For example, we will highlight the syntax of C# manually, although could use built-in highlighter
                case "CSharp (custom highlighter)":
                    txtSyntaxParser.Language = Language.Custom;
                    txtSyntaxParser.CommentPrefix = "//";
                    txtSyntaxParser.AutoIndentNeeded += fctb_AutoIndentNeeded;
                    //call OnTextChanged for refresh syntax highlighting
                    txtSyntaxParser.OnTextChanged();
                    break;
                case "CSharp (built-in highlighter)": txtSyntaxParser.Language = Language.CSharp; break;
                case "VB": txtSyntaxParser.Language = Language.VB; break;
                case "HTML": txtSyntaxParser.Language = Language.HTML; break;
                case "XML": txtSyntaxParser.Language = Language.XML; break;
                case "SQL": txtSyntaxParser.Language = Language.SQL; break;
                case "PHP": txtSyntaxParser.Language = Language.PHP; break;
                case "JS": txtSyntaxParser.Language = Language.JS; break;
                case "Lua": txtSyntaxParser.Language = Language.Lua; break;
            }
            txtSyntaxParser.OnSyntaxHighlight(new TextChangedEventArgs(txtSyntaxParser.Range));
        }

        private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.CollapseBlock(txtSyntaxParser.Selection.Start.iLine, txtSyntaxParser.Selection.End.iLine);
        }

        private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to collapse all #region blocks (C#)
            if (!_lang.StartsWith("CSharp")) return;
            for (int iLine = 0; iLine < txtSyntaxParser.LinesCount; iLine++)
            {
                if (txtSyntaxParser[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    txtSyntaxParser.CollapseFoldingBlock(iLine);
            }
        }

        private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to expand all #region blocks (C#)
            if (!_lang.StartsWith("CSharp")) return;
            for (int iLine = 0; iLine < txtSyntaxParser.LinesCount; iLine++)
            {
                if (txtSyntaxParser[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    txtSyntaxParser.ExpandFoldedBlock(iLine);
            }
        }

        private void increaseIndentSiftTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.IncreaseIndent();
        }

        private void decreaseIndentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.DecreaseIndent();
        }

        private void hTMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string html = "";

                if (sfd.FilterIndex == 1)
                {
                    html = txtSyntaxParser.Html;
                }
                if (sfd.FilterIndex == 2)
                {

                    ExportToHTML exporter = new ExportToHTML();
                    exporter.UseBr = true;
                    exporter.UseNbsp = false;
                    exporter.UseForwardNbsp = true;
                    exporter.UseStyleTag = true;
                    html = exporter.GetHtml(txtSyntaxParser);
                }
                File.WriteAllText(sfd.FileName, html);
            }
        }

        private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
        {
            txtSyntaxParser.VisibleRange.ClearStyle(SameWordsStyle);
            if (!txtSyntaxParser.Selection.IsEmpty)
                return;//user selected diapason

            //get fragment around caret
            var fragment = txtSyntaxParser.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = txtSyntaxParser.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(SameWordsStyle);
        }

        private void goForwardCtrlShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.NavigateForward();
        }

        private void goBackwardCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.NavigateBackward();
        }

        private void autoIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.DoAutoIndent();
        }

        private void GoLeftBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            Range range = tb.Selection.Clone();//need to clone because we will move caret
            int counter = 0;
            int maxIterations = MaxBracketSearchIterations;
            while (range.GoLeftThroughFolded())//move caret left
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == 1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            }
            tb.Invalidate();
        }

        private void GoRightBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            var range = tb.Selection.Clone();//need clone because we will move caret
            int counter = 0;
            int maxIterations = MaxBracketSearchIterations;
            do
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == -1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.Selection.GoRightThroughFolded();
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            } while (range.GoRightThroughFolded());//move caret right

            tb.Invalidate();
        }

        private void goLeftBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLeftBracket(txtSyntaxParser, '{', '}');
        }

        private void goRightBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoRightBracket(txtSyntaxParser, '{', '}');
        }

        private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
        }

        private void setSelectedAsReadonlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.Selection.ReadOnly = true;
        }

        private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.Selection.ReadOnly = false;
        }

        private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.MacrosManager.IsRecording = !txtSyntaxParser.MacrosManager.IsRecording;
        }

        private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.MacrosManager.ExecuteMacros();
        }

        private void changeHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HotkeysEditorForm(txtSyntaxParser.HotkeysMapping);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtSyntaxParser.HotkeysMapping = form.GetHotkeys();
        }

        private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rtf = txtSyntaxParser.Rtf;
                File.WriteAllText(sfd.FileName, rtf);
            }
        }

        private void fctb_CustomAction(object sender, CustomActionEventArgs e)
        {
            MessageBox.Show(e.Action.ToString());
        }

        private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.InsertLinePrefix(txtSyntaxParser.CommentPrefix);
        }

        private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSyntaxParser.RemoveLinePrefix(txtSyntaxParser.CommentPrefix);
        }

        #endregion

        private void btnCompile_Click(object sender, EventArgs e)
        {
            txtCompilerErrors.Clear();

            CompileResult res;
            if (CodeGenerator.TryBuild(txtSyntaxParser.Text, out res))
            {
                Log("Build succeeded \n", infoStyle);
                try
                {
                    res.Method.Invoke(null, null);
                }
                catch (Exception exp)
                {
                    Log(string.Format("JIT exception from running dynamic assembly: \n {0}\n", exp.Message), warningStyle);
                    if(exp.InnerException != null)
                        Log(string.Format("\t Inner exception: {0}\n", exp.InnerException.Message), warningStyle);
                }
            }
            else
            {
                foreach (CompilerError error in res.Errors)
                {
                    string err = string.Format("{0} {1}:\t {2}\n at line {3}: {4}\n\n\r",
                        error.IsWarning ? "Warning" : "Error",
                        error.ErrorNumber,
                        error.ErrorText,
                        res.CodeMaps[error.Line].Item1,
                        res.CodeMaps[error.Line].Item2);

                    Log(err, error.IsWarning ? warningStyle : errorStyle);
                }

                Log("Build failed \n", infoStyle);
            }
        }

        private async void btnExecuteOnClients_Click(object sender, EventArgs e)
        {
            txtCompilerErrors.Clear();
            await _client.CallClientsAsync(_users, "ExecuteCSharpCodes", txtSyntaxParser.Text, _client.Username);
        }

        /// <summary>
        /// Executes the c# codes acknowledge.
        /// </summary>
        /// <param name="state">procedure status</param>
        /// <param name="username">Client username who sent this message</param>
        /// <param name="exception">if compiler didn't work as well then fill this argument</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void ExecuteCSharpCodesAcknowledge(string state, string username, string exception)
        {
            switch (state)
            {
                case "Executed": Log(string.Format("Your codes executed on user {0} successfully \n", username), infoStyle);
                    break;

                case "NotExecuted": Log(string.Format("Your codes did not execute on user {0} \n{1}\n", username, exception), errorStyle);
                    break;

                case "Failed": Log(string.Format("Your codes could not compiled on user {0} \n{1}\n", username, exception), errorStyle);
                    break;

                case "Boiled": Log(string.Format("Your codes build succeeded on user {0} \n", username), infoStyle);
                    break;
            }
        }

        #region Compiler Errors Methods

        private void Log(string text, Color style)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => LogUnSafe(text, style)));
            }
            else
            {
                LogUnSafe(text, style);
            }
        }

        private void LogUnSafe(string text, Color style)
        {
            //some stuffs for best performance
            txtCompilerErrors.AppendText(text, style);
        }

        #endregion

    }
}