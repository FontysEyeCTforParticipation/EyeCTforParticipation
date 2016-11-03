using System;
using System.Collections.Generic;
using System.Text;
using Phidgets; 
using Phidgets.Events; 

namespace RFID_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RFID rfid = new RFID(); 

                
                rfid.Attach += new AttachEventHandler(rfid_Attach);
                rfid.Detach += new DetachEventHandler(rfid_Detach);
                rfid.Error += new ErrorEventHandler(rfid_Error);

                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.TagLost += new TagEventHandler(rfid_TagLost);
                rfid.open();

                Console.WriteLine("waiting for attachment...");
                rfid.waitForAttachment();

                //turn on the antenna and the led 
                rfid.Antenna = true;
                rfid.LED = true;

                Console.WriteLine("Press any key to end...");
                Console.Read();

                rfid.LED = false;
                rfid.close();
                rfid = null;
                Console.WriteLine("ok");
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        static void rfid_Attach(object sender, AttachEventArgs e)
        {
            Console.WriteLine("RFIDReader {0} attached!",
                                    e.Device.SerialNumber.ToString());
        }

        static void rfid_Detach(object sender, DetachEventArgs e)
        {
            Console.WriteLine("RFID reader {0} detached!", 
                                    e.Device.SerialNumber.ToString());
        }

        static void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }

        static void rfid_Tag(object sender, TagEventArgs e)
        {
            
            Console.WriteLine("Tag {0} scanned", e.Tag);
        }

        static void rfid_TagLost(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} lost", e.Tag);
        }
    }
}
