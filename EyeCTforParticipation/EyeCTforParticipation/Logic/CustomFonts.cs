using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Logic
{
    class CustomFonts
    {
        static PrivateFontCollection pfc = new PrivateFontCollection();

        static public FontFamily Roboto
        {
            get
            {
                if(pfc.Families.Length == 0)
                {
                    //VS Design mode...
                    return new FontFamily("Segoe UI");
                }
                return pfc.Families[0];
            }
        }
        
        static public void Load()
        {
            pfc.AddFontFile(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\Roboto.ttf");
        }
    }
}
