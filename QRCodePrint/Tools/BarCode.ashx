<%@ WebHandler Language="C#" Class="BarCode" %>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec.Data;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using Rectangle = System.Drawing.Rectangle;

public class BarCode : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
          



        context.Response.ContentType = "text/plain";

        var bmp = MakeBarCode(context.Request.Params["id"]);
        var stream = new MemoryStream();
        bmp.Save(stream, ImageFormat.Png);
        context.Response.ClearContent();
        context.Response.ContentType = "image/png";
        context.Response.BinaryWrite(stream.ToArray());
    }

    public bool IsReusable
    {
        get { return false; }
    }

    /// <summary>
    /// 生成二维码
    /// </summary>
    /// <param name="str"></param>
    public static Bitmap MakeBarCode(string str)
    {
        var decoder = new QRCodeEncoder //创建二维码生成类  
        {
            QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE, //设置编码模式 
            QRCodeScale = 4, //设置编码测量度（每一个小点占多少像素）
            QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M, //设置编码错误纠正 (L：纠错7%的数据码字，M：15%，Q：25%，H：30%)
            QRCodeVersion = 0 //版本控制，1-41，版本号越大，点越多，每增加一个版本，添加4行4列; 0:自动大小
        };
        var bmp = decoder.Encode(str, Encoding.UTF8); //生成二维码图片

        return bmp;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="img"></param>
    private void Decode(QRCodeImage img)
    {
        var decode = new QRCodeDecoder();
        decode.decode(img, Encoding.UTF8);
    }


    /// <summary>
    /// 利用Zxing生成qrcode
    /// </summary>
    /// <param name="str">要生成的字符</param>
    /// <returns></returns>
    private Bitmap ZxingCode(string str)
    {
        EncodingOptions options = null;
        BarcodeWriter writer = null;
        options = new QrCodeEncodingOptions
        {
            Margin = 0, //设置间隙
            DisableECI = true, //禁用ECI编码段
            CharacterSet = "UTF-8", //编码格式
            Width = 100, //宽带px
            Height = 100, //高度px
            ErrorCorrection = ErrorCorrectionLevel.M //容错等级
        };
        writer = new BarcodeWriter();
        writer.Format = BarcodeFormat.QR_CODE;
        writer.Options = options;
        var bmp = writer.Write(str);
        return bmp;
    }


    /// <summary>
    /// 生成二维码
    /// </summary>
    /// <param name="url">生成的内容</param>
    /// <param name="width">二维码宽</param>
    /// <param name="height">二维码高</param>
    /// <returns></returns>
    private Bitmap GetCodeImgUrl(string url, int width, int height)
    {
        var writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Renderer = new BitmapRenderer
            {
                Foreground = Color.Black
            },
            Options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                Height = height,
                Width = width,
                Margin = 0,
                CharacterSet = "UTF-8",
                ErrorCorrection = ErrorCorrectionLevel.M
            }
        };
        var bitmap = writer.Write(url);
        var img = new ImageCut(0, 0, 85, 85);
        var icon = img.KiCut(bitmap);

        return icon;
    }


    public class ImageCut
    {

        /// <summary>
        /// 剪裁 -- 用GDI+
        /// </summary>
        /// <param name="b">原始Bitmap</param>
        /// <param name="StartX">开始坐标X</param>
        /// <param name="StartY">开始坐标Y</param>
        /// <param name="iWidth">宽度</param>
        /// <param name="iHeight">高度</param>
        /// <returns>剪裁后的Bitmap</returns>
        public Bitmap KiCut(Bitmap b)
        {
            if (b == null)
            {
                return null;
            }
            int w = b.Width;
            int h = b.Height;
            int intWidth = 0;
            int intHeight = 0;
            if (h*Width/w > Height)
            {
                intWidth = Width;
                intHeight = h*Width/w;
            }
            else if (h*Width/w < Height)
            {
                intWidth = w*Height/h;
                intHeight = Height;

            }
            else
            {
                intWidth = Width;
                intHeight = Height;
            }
            var bmpOutB = new System.Drawing.Bitmap(b, intWidth, intHeight);
            w = bmpOutB.Width;
            h = bmpOutB.Height;

            if (X >= w || Y >= h)
            {
                return null;
            }
            if (X + Width > w)
            {
                Width = w - X;
            }
            else
            {
                X = (w - Width)/2;
            }
            if (Y + Height > h)
            {
                Height = h - Y;
            }


            try
            {
                var bmpOut = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(bmpOutB, new Rectangle(0, 0, Width, Height), new Rectangle(X, Y, Width, Height),
                    GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }

        public int X = 0;
        public int Y = 0;
        public int Width = 120;
        public int Height = 120;

        public ImageCut(int x, int y, int width, int heigth)
        {
            X = x;
            Y = y;
            Width = width;
            Height = heigth;
        }
    }


}