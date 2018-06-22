using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.QRCode.Api.Common
{
    public interface IQRCode
    {
        Bitmap GetQRCode(string url, int pixel);
    }
}
