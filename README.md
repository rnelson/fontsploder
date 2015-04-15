# FontSploder

![Screenshot](https://raw.githubusercontent.com/rnelson/fontsploder/images/fontsploder.jpg)

FontSploder came out of a request from a friend in 2010. Using a locked down 
Windows computer at work, he was unable to do many things, including adding 
and removing fonts to the system.

The occasional IT request to change system fonts isn't too bad, but for a guy 
doing a lot of graphic design, it's simply not practical.

Enter FontSploder!

I discovered that the GDI API has a couple of handy functions, 
`AddFontResource(string)` and `RemoveFontResource(string)`. These functions 
can be used by a non-elevated process, temporarily adding and removing 
specific font files into the system.

This allows users to load font files into the system and make them accessible 
to any program. Tested on Windows XP and Windows 7. Requires .NET 3.5 or newer.

[Download](https://github.com/rnelson/fontsploder/releases/tag/0.0.1.0)