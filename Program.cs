using IronBarCode;
using IronSoftware.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            string link = "https://in.linkedin.com/";
            string file = "C:\\Users\\Admin\\source\\repos\\QR codes\\demo12.png";
            string logofile = "C:\\Users\\Admin\\source\\repos\\QR codes\\locobuzz_logo.jpg";
            int errorCorrectionLevel = (int)QRCodeWriter.QrErrorCorrectionLevel.Highest;
            QRCodeLogo logo = new QRCodeLogo(logofile);
            //GeneratedBarcode barcode = IronBarCode.BarcodeWriter.CreateBarcode(link,BarcodeEncoding.QRCode);
            //barcode.SaveAsPng("C:\\Users\\Admin\\source\\repos\\QR codes\\"+file);
            GeneratedBarcode QRcodewithLogo = QRCodeWriter.CreateQrCodeWithLogo(link, logo, errorCorrectionLevel);
            QRcodewithLogo.ResizeTo(500, 500).SetMargins(15).ChangeBarCodeColor(Color.Black);
            QRcodewithLogo.SaveAsPng(file);

        }
    }
}
