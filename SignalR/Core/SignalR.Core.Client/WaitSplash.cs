using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SignalR;
using SignalR.Core;
using SignalR.Core.Properties;


public sealed partial class WaitSplash : UserControl
{
    private CultureInfo _culture;
    private static WaitSplash _instance;

    [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("The culture caused to change your control language."), Category("Appearance")]
    [Localizable(true)]
    [DefaultValue(typeof(CultureInfo), "en")]
    public CultureInfo Culture
    {
        get { return _culture ?? CultureInfo.DefaultThreadCurrentCulture; }
        set
        {
            _culture = value;
            ChangeStatuse();
        }
    }

    public WaitSplash()
    {
        InitializeComponent();

        lblMessage.Font = EmbeddedFontLoader.IranSansFont(35F);

        ChangeStatuse();

        FitControlsLocations();

        lblMessage.TextChanged += (s, e) => FitControlsLocations();

        this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
    }

    public void FitControlsLocations()
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(FitControlsLocations));
        }
        else
        {
            // set lblMessage location
            int x = (picWaitGif.Size.Width - lblMessage.PreferredWidth) / 2;
            lblMessage.Location = new Point(picWaitGif.Location.X + x, lblMessage.Location.Y);
        }
    }

    private void ChangeStatuse()
    {
        lblMessage.Text = Culture.Name == CultureInfo.CreateSpecificCulture("fa-IR").Name
            ? Resources.WaitSplashTitleFA
            : Resources.WaitSplashTitle;
    }



    /// <summary>
    /// Docks the on control.
    /// </summary>
    /// <param name="ctrl">The control.</param>
    public static WaitSplash DockOnControlThreadSafe(Control ctrl)
    {
        return DockOnControlThreadSafe(ctrl, CultureInfo.DefaultThreadCurrentCulture);
    }

    public static WaitSplash DockOnControlThreadSafe(Control ctrl, CultureInfo culture)
    {
        if (ctrl.InvokeRequired)
        {
            return (WaitSplash)ctrl.Invoke(new Action(() => DockOnControlThreadSafe(ctrl, culture)));
        }
        else
        {
            if (_instance == null)
            {
                _instance = new WaitSplash
                {
                    Dock = DockStyle.Fill,
                    Culture = culture
                };
            }
            if (ctrl.Controls.Contains(_instance))
                _instance.Show();
            else
                ctrl.Controls.Add(_instance);

            _instance.BringToFront();
            return _instance;
        }
    }

    public new static void Hide()
    {
        if (_instance != null)
        {
            if (_instance.InvokeRequired)
            {
                _instance.Invoke(new Action(Hide));
                return;
            }
            else
            {
                ((Control) _instance).Hide();
            }
        }
    }
}
