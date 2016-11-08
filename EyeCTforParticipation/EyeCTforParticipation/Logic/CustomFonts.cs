using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Logic
{
    class CustomFonts
    {
        static PrivateFontCollection pfc = new PrivateFontCollection();

        public class Families
        {
            static public FontFamily Roboto
            {
                get
                {
                    if(pfc.Families.Length == 0)
                    {
                        //Return alternate font for designer mode
                        return new FontFamily("Segoe UI");
                    }
                    return pfc.Families[0];
                }
            }

        }

        static public void Load()
        {
            //Adding Roboto font family
            pfc.AddFontFile(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\Roboto-Bold.ttf");
            pfc.AddFontFile(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\Roboto-Italic.ttf");
            pfc.AddFontFile(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\Roboto.ttf");
        }

        static public void ChangeFonts(Control.ControlCollection controlCollection, FontFamily fontFamily)
        {
            foreach (Control control in controlCollection)
            {
                if (control.HasChildren)
                {
                    ChangeFonts(control.Controls, fontFamily);
                }
                else
                {
                    control.Font = new Font(fontFamily, control.Font.Size, control.Font.Style);
                }
            }
        }
    }
}
