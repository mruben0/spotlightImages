using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace spotlightImages
{
    class GetPic
    {

        string username;
        string place;
        public GetPic(string user, string DestPlace)
        {
            username = user;
            place = DestPlace;
        }
        public void spotL()
        {

            string w = @"C:\Users\" + username + @"\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            string[] p = Directory.GetFiles(w, "*.*");
            if (!Directory.Exists(place))
            {
                Directory.CreateDirectory(place);
            }

            if (!Directory.Exists(@"C:\Users\" + username + @"\Desktop\WindowsPics"))
                Directory.CreateDirectory(@"C:\Users\" + username + @"\Desktop\WindowsPics");
            if (p.Length > 0)
            {
                foreach (var pic in p)
                {
                    FileInfo f = new FileInfo(pic);
                    if (f.Length / 1024 > 512)
                    {
                        string picName = pic.Substring(w.Length + 1) + ".jpg";

                        string dest = Path.Combine(place, picName);

                        if (!File.Exists(dest))
                        {
                            File.Copy(pic, dest, true);
                        }
                        else continue;


                    }
                    else continue;
               } 

            }
            else throw new Exception("Cant't Find Your files. try again later or mail me: rambler@gmail.com");

        }
    }

}
