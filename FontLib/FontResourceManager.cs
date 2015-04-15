using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Win32;

namespace FontLib
{
    /// <summary>
    /// Uses AddFontResource() and RemoveFontResource() along 
    /// with some internal data to temporarily add and remove 
    /// fonts to the system
    /// </summary>
    public class FontResourceManager
    {
        #region Properties
        /// <summary>
        /// Gets the list of fonts currently handled 
        /// by this FontResource object
        /// </summary>
        public Font[] Fonts
        {
            get { return this.fonts.ToArray(); }
        }

        /// <summary>
        /// Gets a filter (for use with OpenFileDialog/SaveFileDialog) of
        /// the supported font types + "All Files (*.*)"
        /// </summary>
        public string SupportedTypesFileFilter
        {
            get { return "All Fonts (*.fon;*.fnt;*.ttf;*.ttc;*.fot;*.otf)|*.fon;*.fnt;*.ttf;*.ttc;*.fot;*.otf|Font Resource Files (*.fon)|*.fon|Bitmap Font Files (*.fnt)|*.fnt|TrueType Fonts (*.ttf)|*.ttf|TrueType Font Collections (*.ttc)|*.ttc|TrueType Resource Files (*.fot)|*.fot|OpenType Fonts (*.otf)|*.otf|All Files (*.*)|*.*"; }
        }
        #endregion Properties

        #region Members
        private List<Font> fonts;
        #endregion Members

        #region Constructors
        public FontResourceManager()
        {
            // Allocate members
            this.fonts = new List<Font>();
        }
        #endregion Constructors

        #region Destructors
        ~FontResourceManager()
        {
            this.RemoveAll();
        }
        #endregion Destructors

        #region Public Methods
        /// <summary>
        /// Adds a font
        /// </summary>
        /// <param name="filename">the filename for the font</param>
        /// <returns>0 on error, else the number of fonts added</returns>
        public int Add(string filename)
        {
            // Add the font to our internal list
            this.fonts.Add(new Font(filename));

            // Add it to the system font resource table
            return GDI32.AddFontResource(filename);
        }

        /// <summary>
        /// Adds a font
        /// </summary>
        /// <param name="font">a FontLib.Font object representing the font</param>
        /// <returns>0 on error, else the number of fonts added</returns>
        public int Add(Font font)
        {
            // Add the font to our internal list
            this.fonts.Add(font);

            // Add it to the system font resource table
            return GDI32.AddFontResource(font.Filename);
        }

        /// <summary>
        /// Removes a font
        /// </summary>
        /// <param name="filename">the filename for the font</param>
        /// <returns><c>true</c> on success, <c>false</c> on error</returns>
        public bool Remove(string filename)
        {
            // Remove it from our list
            Font font = this.fonts.Find(f => f.Filename == filename);
            this.fonts.Remove(font);
            
            // Remove it from the system font resource table
            return GDI32.RemoveFontResource(font.Filename);
        }

        /// <summary>
        /// Removes all added fonts
        /// </summary>
        public void RemoveAll()
        {
            // Get an array of font names
            Font[] list = this.Fonts;

            // Call Remove() on each one
            foreach (Font f in list)
            {
                this.Remove(f.Filename);
            }
        }
        #endregion Public Methods
    }
}
