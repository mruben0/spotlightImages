using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetImagesightImages
{
    class PicManager
    {

        string username;
        string place;
        public PicManager(string user, string DestPlace)
        {
            username = user;
            place = DestPlace;
        }
        public void GetImages()
        {

            string spotPath = @"C:\Users\" + username + @"\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            string[] picNames = Directory.GetFiles(spotPath, "*.*");
            if (!Directory.Exists(place))
            {
                Directory.CreateDirectory(place);
            }

          if (picNames.Length > 0)
            {
                foreach (var pic in picNames)
                {
                    FileInfo f = new FileInfo(pic);
                    if (f.Length / 1024 > 512)
                    {
                        string picName = pic.Substring(spotPath.Length + 1) + ".jpg";

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
