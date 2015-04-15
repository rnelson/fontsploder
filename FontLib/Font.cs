using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace FontLib
{
    /// <summary>
    /// Holds various information about a Font; for use with 
    /// FontResource
    /// </summary>
    public class Font
    {
        #region Properties
        /// <summary>
        /// Gets the font's filename
        /// </summary>
        public string Filename
        {
            get { return this.filename; }
        }

        /// <summary>
        /// Gets the font's name; if unknown, it returns the 
        /// filename
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets/sets the font's tag
        /// </summary>
        public Object Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }
        #endregion Properties

        #region Members
        private string filename;
        private string name;
        private object tag;
        #endregion Members

        #region Constructors
        public Font(string filename)
        {
            // Save the filename
            this.filename = filename;

            // Fill in what else we can
            this.ParseFont();
        }
        #endregion Constructors

        #region Public Methods
        #endregion Public Methods

        #region Private Methods
        private void ParseFont()
        {
            // Set the name = filename
            this.name = Path.GetFileName(this.Filename);

            /*
            ICollection<FontFamily> families = Fonts.GetFontFamilies(this.Filename);
            foreach (FontFamily family in families)
            {
                family.
            }
            Fonts.GetTypefaces(
            */
        }
        #endregion Private Methods
    }
}
