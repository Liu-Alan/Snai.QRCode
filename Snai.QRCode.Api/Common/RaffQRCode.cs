using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.QRCode.Api.Common
{
    public class RaffQRCode : IQRCode
    {
        /* GetGraphic方法参数说明
                public Bitmap GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor, Bitmap icon = null, int iconSizePercent = 15, int iconBorderWidth = 6, bool drawQuietZones = true)
            * 
                int pixelsPerModule:生成二维码图片的像素大小 ，我这里设置的是5 
            * 
                Color darkColor：暗色   一般设置为Color.Black 黑色
            * 
                Color lightColor:亮色   一般设置为Color.White  白色
            * 
                Bitmap icon :二维码 水印图标 例如：Bitmap icon = new Bitmap(context.Server.MapPath("~/images/zs.png")); 默认为NULL ，加上这个二维码中间会显示一个图标
            * 
                int iconSizePercent： 水印图标的大小比例 ，可根据自己的喜好设置 
            * 
                int iconBorderWidth： 水印图标的边框
            * 
                bool drawQuietZones:静止区，位于二维码某一边的空白边界,用来阻止读者获取与正在浏览的二维码无关的信息 即是否绘画二维码的空白边框区域 默认为true

            */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">存储内容</param>
        /// <param name="pixel">像素大小</param>
        /// <returns></returns>
        public Bitmap GetQRCode(string url, int pixel)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData codeData = generator.CreateQrCode(url, QRCodeGenerator.ECCLevel.M, true);
            QRCoder.QRCode qrcode = new QRCoder.QRCode(codeData);

            Bitmap qrImage = qrcode.GetGraphic(pixel, Color.Black, Color.White, true);

            return qrImage;
        }
    }
}
