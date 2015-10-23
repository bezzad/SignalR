using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

public partial class AlertButton : UserControl
{
    public AlertButton()
    {
        InitializeComponent();

        btnAlert.Click += (s, e) => InvokeOnClick(this, e);

        OnSizeChanged(null);

        btnAlert.Cursor = Cursors.Hand;
    }

    #region Members

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("Text on the button."), Category("Appearance")]
    [Localizable(true)]
    [Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public new string Text
    {
        set
        {
            btnAlert.Text = value;
            base.Text = value;
        }
        get { return btnAlert.Text; }
    }

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("Border side sizes."), Category("Appearance")]
    [Localizable(true)]
    public int Tickness
    {
        set
        {
            _tickness = value;
            OnSizeChanged(null);
        }
        get { return _tickness; }
    }

    private int _tickness = 10;

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("The button status, that are two cases which checked or not. Change the option to change the button background color's.")]
    [Category("Appearance")]
    [Localizable(true)]
    public bool Checked
    {
        set
        {
            _checked = value;
            BackColor = value ? CheckedColor : UnCheckedColor;
        }
        get { return _checked; }
    }

    private bool _checked = false;

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("The button background color's when that's checked"), Category("Appearance")]
    [Localizable(true)]
    [Editor(typeof(System.Drawing.Design.ColorEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [DefaultValue(typeof(Color), "ForestGreen")]
    public Color CheckedColor
    {
        set
        {
            _checkedColor = value;
            BackColor = _checked ? CheckedColor : UnCheckedColor;
        }
        get { return _checkedColor; }
    }
    private Color _checkedColor = Color.ForestGreen;

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("The button background color's when that's unchecked"), Category("Appearance")]
    [Localizable(true)]
    [Editor(typeof(System.Drawing.Design.ColorEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [DefaultValue(typeof(Color), "Firebrick")]
    public Color UnCheckedColor
    {
        set
        {
            _unCheckedColor = value;
            BackColor = _checked ? CheckedColor : UnCheckedColor;
        }
        get { return _unCheckedColor; }
    }

    private Color _unCheckedColor = Color.Firebrick;

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("The button background color's when that's unchecked"), Category("Appearance")]
    [Localizable(true)]
    [Editor(typeof(System.Drawing.Design.FontEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [DefaultValue(typeof(Color), "Firebrick")]
    public new Font Font
    {
        set { btnAlert.Font = value; }
        get { return btnAlert.Font; }
    }


    #endregion

    #region Methods

    public void Check()
    {
        Checked = true;
    }

    public void UnCheck()
    {
        Checked = false;
    }

    protected override sealed void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);

        btnAlert.Size = new Size(this.Width - _tickness, this.Height - _tickness);

        btnAlert.Location = new Point((_tickness / 2), (_tickness / 2));
    }

    #endregion
}

