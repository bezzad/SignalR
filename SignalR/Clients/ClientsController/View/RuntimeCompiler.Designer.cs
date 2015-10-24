using FastColoredTextBoxNS;

namespace ClientsController.View
{
    partial class RuntimeCompiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuntimeCompiler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.setSelectedAsReadonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSelectedAsWritableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseSelectedBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exapndAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.increaseIndentSiftTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseIndentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.commentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncommentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.goBackwardCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goForwardCtrlShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.autoIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.goLeftBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goRightBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.startStopMacroRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.miCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.cSharpbuiltinHighlighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miVB = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeHotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecuteOnClients = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSyntaxParser = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grbErrors = new System.Windows.Forms.GroupBox();
            this.txtCompilerErrors = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyntaxParser)).BeginInit();
            this.grbErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.miLanguage,
            this.miExport,
            this.changeHotkeysToolStripMenuItem,
            this.btnExecuteOnClients,
            this.btnCompile});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 56);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setSelectedAsReadonlyToolStripMenuItem,
            this.setSelectedAsWritableToolStripMenuItem,
            this.toolStripMenuItem8,
            this.collapseSelectedBlockToolStripMenuItem,
            this.toolStripMenuItem3,
            this.collapseAllregionToolStripMenuItem,
            this.exapndAllregionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.increaseIndentSiftTabToolStripMenuItem,
            this.decreaseIndentTabToolStripMenuItem,
            this.toolStripMenuItem10,
            this.commentSelectedLinesToolStripMenuItem,
            this.uncommentSelectedLinesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.goBackwardCtrlToolStripMenuItem,
            this.goForwardCtrlShiftToolStripMenuItem,
            this.toolStripMenuItem5,
            this.autoIndentToolStripMenuItem,
            this.toolStripMenuItem6,
            this.goLeftBracketToolStripMenuItem,
            this.goRightBracketToolStripMenuItem,
            this.toolStripMenuItem7,
            this.miPrint,
            this.toolStripMenuItem9,
            this.startStopMacroRecordingToolStripMenuItem,
            this.executeMacroToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 52);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.findToolStripMenuItem.Text = "&Find [Ctrl+F]";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.replaceToolStripMenuItem.Text = "&Replace [Ctrl+H]";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(306, 6);
            // 
            // setSelectedAsReadonlyToolStripMenuItem
            // 
            this.setSelectedAsReadonlyToolStripMenuItem.Name = "setSelectedAsReadonlyToolStripMenuItem";
            this.setSelectedAsReadonlyToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.setSelectedAsReadonlyToolStripMenuItem.Text = "Set selected as readonly";
            this.setSelectedAsReadonlyToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsReadonlyToolStripMenuItem_Click);
            // 
            // setSelectedAsWritableToolStripMenuItem
            // 
            this.setSelectedAsWritableToolStripMenuItem.Name = "setSelectedAsWritableToolStripMenuItem";
            this.setSelectedAsWritableToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.setSelectedAsWritableToolStripMenuItem.Text = "Set selected as writable";
            this.setSelectedAsWritableToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsWritableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(306, 6);
            // 
            // collapseSelectedBlockToolStripMenuItem
            // 
            this.collapseSelectedBlockToolStripMenuItem.Name = "collapseSelectedBlockToolStripMenuItem";
            this.collapseSelectedBlockToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.collapseSelectedBlockToolStripMenuItem.Text = "Collapse selected block";
            this.collapseSelectedBlockToolStripMenuItem.Click += new System.EventHandler(this.collapseSelectedBlockToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(306, 6);
            // 
            // collapseAllregionToolStripMenuItem
            // 
            this.collapseAllregionToolStripMenuItem.Name = "collapseAllregionToolStripMenuItem";
            this.collapseAllregionToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.collapseAllregionToolStripMenuItem.Text = "Collapse all #region";
            this.collapseAllregionToolStripMenuItem.Click += new System.EventHandler(this.collapseAllregionToolStripMenuItem_Click);
            // 
            // exapndAllregionToolStripMenuItem
            // 
            this.exapndAllregionToolStripMenuItem.Name = "exapndAllregionToolStripMenuItem";
            this.exapndAllregionToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.exapndAllregionToolStripMenuItem.Text = "Exapnd all #region";
            this.exapndAllregionToolStripMenuItem.Click += new System.EventHandler(this.exapndAllregionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(306, 6);
            // 
            // increaseIndentSiftTabToolStripMenuItem
            // 
            this.increaseIndentSiftTabToolStripMenuItem.Name = "increaseIndentSiftTabToolStripMenuItem";
            this.increaseIndentSiftTabToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.increaseIndentSiftTabToolStripMenuItem.Text = "Increase Indent [Tab]";
            this.increaseIndentSiftTabToolStripMenuItem.Click += new System.EventHandler(this.increaseIndentSiftTabToolStripMenuItem_Click);
            // 
            // decreaseIndentTabToolStripMenuItem
            // 
            this.decreaseIndentTabToolStripMenuItem.Name = "decreaseIndentTabToolStripMenuItem";
            this.decreaseIndentTabToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.decreaseIndentTabToolStripMenuItem.Text = "Decrease Indent [Shift + Tab]";
            this.decreaseIndentTabToolStripMenuItem.Click += new System.EventHandler(this.decreaseIndentTabToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(306, 6);
            // 
            // commentSelectedLinesToolStripMenuItem
            // 
            this.commentSelectedLinesToolStripMenuItem.Name = "commentSelectedLinesToolStripMenuItem";
            this.commentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.commentSelectedLinesToolStripMenuItem.Text = "Comment selected lines";
            this.commentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedLinesToolStripMenuItem_Click);
            // 
            // uncommentSelectedLinesToolStripMenuItem
            // 
            this.uncommentSelectedLinesToolStripMenuItem.Name = "uncommentSelectedLinesToolStripMenuItem";
            this.uncommentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.uncommentSelectedLinesToolStripMenuItem.Text = "Uncomment selected lines";
            this.uncommentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.uncommentSelectedLinesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(306, 6);
            // 
            // goBackwardCtrlToolStripMenuItem
            // 
            this.goBackwardCtrlToolStripMenuItem.Name = "goBackwardCtrlToolStripMenuItem";
            this.goBackwardCtrlToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.goBackwardCtrlToolStripMenuItem.Text = "Go Backward [Ctrl+ -]";
            this.goBackwardCtrlToolStripMenuItem.Click += new System.EventHandler(this.goBackwardCtrlToolStripMenuItem_Click);
            // 
            // goForwardCtrlShiftToolStripMenuItem
            // 
            this.goForwardCtrlShiftToolStripMenuItem.Name = "goForwardCtrlShiftToolStripMenuItem";
            this.goForwardCtrlShiftToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.goForwardCtrlShiftToolStripMenuItem.Text = "Go Forward [Ctrl+Shift+ -]";
            this.goForwardCtrlShiftToolStripMenuItem.Click += new System.EventHandler(this.goForwardCtrlShiftToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(306, 6);
            // 
            // autoIndentToolStripMenuItem
            // 
            this.autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
            this.autoIndentToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.autoIndentToolStripMenuItem.Text = "Auto Indent selected text";
            this.autoIndentToolStripMenuItem.Click += new System.EventHandler(this.autoIndentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(306, 6);
            // 
            // goLeftBracketToolStripMenuItem
            // 
            this.goLeftBracketToolStripMenuItem.Name = "goLeftBracketToolStripMenuItem";
            this.goLeftBracketToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.goLeftBracketToolStripMenuItem.Text = "Go Left Bracket";
            this.goLeftBracketToolStripMenuItem.Click += new System.EventHandler(this.goLeftBracketToolStripMenuItem_Click);
            // 
            // goRightBracketToolStripMenuItem
            // 
            this.goRightBracketToolStripMenuItem.Name = "goRightBracketToolStripMenuItem";
            this.goRightBracketToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.goRightBracketToolStripMenuItem.Text = "Go Right Bracket";
            this.goRightBracketToolStripMenuItem.Click += new System.EventHandler(this.goRightBracketToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(306, 6);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(309, 24);
            this.miPrint.Text = "Print...";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(306, 6);
            // 
            // startStopMacroRecordingToolStripMenuItem
            // 
            this.startStopMacroRecordingToolStripMenuItem.Name = "startStopMacroRecordingToolStripMenuItem";
            this.startStopMacroRecordingToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.startStopMacroRecordingToolStripMenuItem.Text = "Start/Stop macro recording [Ctrl+M]";
            this.startStopMacroRecordingToolStripMenuItem.Click += new System.EventHandler(this.startStopMacroRecordingToolStripMenuItem_Click);
            // 
            // executeMacroToolStripMenuItem
            // 
            this.executeMacroToolStripMenuItem.Name = "executeMacroToolStripMenuItem";
            this.executeMacroToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.executeMacroToolStripMenuItem.Text = "Execute macro [Ctrl+E]";
            this.executeMacroToolStripMenuItem.Click += new System.EventHandler(this.executeMacroToolStripMenuItem_Click);
            // 
            // miLanguage
            // 
            this.miLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCSharp,
            this.cSharpbuiltinHighlighterToolStripMenuItem,
            this.miVB,
            this.hTMLToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.jSToolStripMenuItem,
            this.luaToolStripMenuItem});
            this.miLanguage.Name = "miLanguage";
            this.miLanguage.Size = new System.Drawing.Size(84, 52);
            this.miLanguage.Text = "Language";
            this.miLanguage.DropDownOpening += new System.EventHandler(this.miLanguage_DropDownOpening);
            // 
            // miCSharp
            // 
            this.miCSharp.Name = "miCSharp";
            this.miCSharp.Size = new System.Drawing.Size(258, 24);
            this.miCSharp.Text = "CSharp (custom highlighter)";
            this.miCSharp.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // cSharpbuiltinHighlighterToolStripMenuItem
            // 
            this.cSharpbuiltinHighlighterToolStripMenuItem.Checked = true;
            this.cSharpbuiltinHighlighterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cSharpbuiltinHighlighterToolStripMenuItem.Name = "cSharpbuiltinHighlighterToolStripMenuItem";
            this.cSharpbuiltinHighlighterToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.cSharpbuiltinHighlighterToolStripMenuItem.Text = "CSharp (built-in highlighter)";
            this.cSharpbuiltinHighlighterToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // miVB
            // 
            this.miVB.Name = "miVB";
            this.miVB.Size = new System.Drawing.Size(258, 24);
            this.miVB.Text = "VB";
            this.miVB.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.xmlToolStripMenuItem.Text = "XML";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // jSToolStripMenuItem
            // 
            this.jSToolStripMenuItem.Name = "jSToolStripMenuItem";
            this.jSToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.jSToolStripMenuItem.Text = "JS";
            this.jSToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // luaToolStripMenuItem
            // 
            this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
            this.luaToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.luaToolStripMenuItem.Text = "Lua";
            this.luaToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
            // 
            // miExport
            // 
            this.miExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem1,
            this.rTFToolStripMenuItem});
            this.miExport.Name = "miExport";
            this.miExport.Size = new System.Drawing.Size(62, 52);
            this.miExport.Text = "Export";
            // 
            // hTMLToolStripMenuItem1
            // 
            this.hTMLToolStripMenuItem1.Name = "hTMLToolStripMenuItem1";
            this.hTMLToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.hTMLToolStripMenuItem1.Text = "HTML";
            this.hTMLToolStripMenuItem1.Click += new System.EventHandler(this.hTMLToolStripMenuItem1_Click);
            // 
            // rTFToolStripMenuItem
            // 
            this.rTFToolStripMenuItem.Name = "rTFToolStripMenuItem";
            this.rTFToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.rTFToolStripMenuItem.Text = "RTF";
            this.rTFToolStripMenuItem.Click += new System.EventHandler(this.rTFToolStripMenuItem_Click);
            // 
            // changeHotkeysToolStripMenuItem
            // 
            this.changeHotkeysToolStripMenuItem.Name = "changeHotkeysToolStripMenuItem";
            this.changeHotkeysToolStripMenuItem.Size = new System.Drawing.Size(123, 52);
            this.changeHotkeysToolStripMenuItem.Text = "Change hotkeys";
            this.changeHotkeysToolStripMenuItem.Click += new System.EventHandler(this.changeHotkeysToolStripMenuItem_Click);
            // 
            // btnExecuteOnClients
            // 
            this.btnExecuteOnClients.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExecuteOnClients.Image = global::ClientsController.Properties.Resources.Executer;
            this.btnExecuteOnClients.Name = "btnExecuteOnClients";
            this.btnExecuteOnClients.Size = new System.Drawing.Size(189, 52);
            this.btnExecuteOnClients.Text = "Execute Procedure";
            this.btnExecuteOnClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecuteOnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExecuteOnClients.ToolTipText = "Click to execute this procedure on clients";
            this.btnExecuteOnClients.Click += new System.EventHandler(this.btnExecuteOnClients_Click);
            // 
            // btnCompile
            // 
            this.btnCompile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCompile.Image = global::ClientsController.Properties.Resources.Compile;
            this.btnCompile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(122, 52);
            this.btnCompile.Text = "Compile";
            this.btnCompile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCompile.ToolTipText = "Click to compile this codes";
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // txtSyntaxParser
            // 
            this.txtSyntaxParser.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtSyntaxParser.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.txtSyntaxParser.AutoIndentExistingLines = false;
            this.txtSyntaxParser.AutoScrollMinSize = new System.Drawing.Size(557, 405);
            this.txtSyntaxParser.BackBrush = null;
            this.txtSyntaxParser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSyntaxParser.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtSyntaxParser.CharHeight = 15;
            this.txtSyntaxParser.CharWidth = 7;
            this.txtSyntaxParser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSyntaxParser.DelayedEventsInterval = 200;
            this.txtSyntaxParser.DelayedTextChangedInterval = 500;
            this.txtSyntaxParser.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSyntaxParser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSyntaxParser.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSyntaxParser.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSyntaxParser.IsReplaceMode = false;
            this.txtSyntaxParser.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtSyntaxParser.LeftBracket = '(';
            this.txtSyntaxParser.LeftBracket2 = '{';
            this.txtSyntaxParser.Location = new System.Drawing.Point(0, 0);
            this.txtSyntaxParser.Name = "txtSyntaxParser";
            this.txtSyntaxParser.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSyntaxParser.PreferredLineWidth = 80;
            this.txtSyntaxParser.ReservedCountOfLineNumberChars = 2;
            this.txtSyntaxParser.RightBracket = ')';
            this.txtSyntaxParser.RightBracket2 = '}';
            this.txtSyntaxParser.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSyntaxParser.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtSyntaxParser.ServiceColors")));
            this.txtSyntaxParser.Size = new System.Drawing.Size(776, 376);
            this.txtSyntaxParser.TabIndex = 3;
            this.txtSyntaxParser.Text = resources.GetString("txtSyntaxParser.Text");
            this.txtSyntaxParser.Zoom = 100;
            this.txtSyntaxParser.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChanged);
            this.txtSyntaxParser.SelectionChangedDelayed += new System.EventHandler(this.fctb_SelectionChangedDelayed);
            this.txtSyntaxParser.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.fctb_AutoIndentNeeded);
            this.txtSyntaxParser.CustomAction += new System.EventHandler<FastColoredTextBoxNS.CustomActionEventArgs>(this.fctb_CustomAction);
            // 
            // grbErrors
            // 
            this.grbErrors.Controls.Add(this.txtCompilerErrors);
            this.grbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbErrors.Location = new System.Drawing.Point(0, 0);
            this.grbErrors.Name = "grbErrors";
            this.grbErrors.Size = new System.Drawing.Size(776, 184);
            this.grbErrors.TabIndex = 5;
            this.grbErrors.TabStop = false;
            this.grbErrors.Text = "Compiler Errors";
            // 
            // txtCompilerErrors
            // 
            this.txtCompilerErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompilerErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompilerErrors.Location = new System.Drawing.Point(3, 16);
            this.txtCompilerErrors.Name = "txtCompilerErrors";
            this.txtCompilerErrors.ReadOnly = true;
            this.txtCompilerErrors.Size = new System.Drawing.Size(770, 165);
            this.txtCompilerErrors.TabIndex = 0;
            this.txtCompilerErrors.Text = "";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 56);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.txtSyntaxParser);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grbErrors);
            this.splitContainer.Size = new System.Drawing.Size(780, 576);
            this.splitContainer.SplitterDistance = 380;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 6;
            // 
            // RuntimeCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 632);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RuntimeCompiler";
            this.Text = "Runtime Dynamic Compiler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyntaxParser)).EndInit();
            this.grbErrors.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBox txtSyntaxParser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLanguage;
        private System.Windows.Forms.ToolStripMenuItem miCSharp;
        private System.Windows.Forms.ToolStripMenuItem miVB;
        private System.Windows.Forms.ToolStripMenuItem collapseAllregionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exapndAllregionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem increaseIndentSiftTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseIndentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miExport;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collapseSelectedBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem goBackwardCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goForwardCtrlShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem goLeftBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goRightBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem cSharpbuiltinHighlighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSelectedAsReadonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSelectedAsWritableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem startStopMacroRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeHotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem commentSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncommentSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCompile;
        private System.Windows.Forms.ToolStripMenuItem btnExecuteOnClients;
        private System.Windows.Forms.GroupBox grbErrors;
        private System.Windows.Forms.RichTextBox txtCompilerErrors;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

