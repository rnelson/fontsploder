using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Win32
{
    /// <summary>
    /// Imports functions from gdi32.dll
    /// </summary>
    public class GDI32
    {
        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int AddFontResource(string filename);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern bool RemoveFontResource(string filename);
    }
}
