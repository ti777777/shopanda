using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        public ActionResult Index()
        {
            var result = new object[]
            {
                new {
                    ID = "33456",
                    Name = "iPhone12 pro max (256GB)",
                    Img = "https://store.storeimages.cdn-apple.com/8756/as-images.apple.com/is/iphone-12-pro-family-hero?wid=940&amp;hei=1112&amp;fmt=jpeg&amp;qlt=80&amp;op_usm=0.5,0.5&amp;.v=1604021663000",
                    Brand = "Apple",
                    Description = "",
                    Category = "3C",
                    Price = "30000"
                },
                new {
                    ID = "8689",
                    Name = "Surface Pro 7",
                    Img = "https://m.media-amazon.com/images/I/714cHoaDUpL._AC_SL1500_.jpg",
                    Brand = "Microsoft",
                    Description = "",
                    Category = "3C",
                    Price = "36000"
                },
                new {
                    ID = "863249",
                    Name = "Dyson V11 吸塵器",
                    Img = "https://dysonshop.blob.core.windows.net/products/dyson-re-engineered-v11-absolute-extra/hero-480x480.jpg",
                    Brand = "Dyson",
                    Description = "",
                    Category = "3C",
                    Price = "20000"
                }
            };
            return new JsonResult(result);
        }
    }
}
