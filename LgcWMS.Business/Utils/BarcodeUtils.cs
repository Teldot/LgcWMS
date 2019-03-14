using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.Utils
{
    public class BarcodeUtils
    {
        public static byte[] GenBarcode(string data)
        {
            Barcode b = new Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, data, Color.Black, Color.White, 450, 50);
            MemoryStream stream = new System.IO.MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();

        }
    }
}
