using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;

namespace SignalR.Core
{
    public static class EmbeddedFontLoader
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts;
        public static Font IranSansFont(float size)
        {
            if (fonts != null && fonts.Families.Any())
                return new Font(fonts.Families[0], size);

            fonts = new PrivateFontCollection();
            byte[] fontData = Core.Properties.Resources.irsans;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Core.Properties.Resources.irsans.Length);
            AddFontMemResourceEx(fontPtr, (uint)Core.Properties.Resources.irsans.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], size);
        }
    }
}
