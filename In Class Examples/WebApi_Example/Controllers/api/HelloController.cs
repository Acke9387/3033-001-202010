using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Example.Controllers.api
{
    public class HelloController : ApiController
    {
        [HttpGet]
        [Route("api/Hello/World")]
        public string World()
        {
            return "Hello World!";
        }

        [HttpGet]

        public Shape Geometry(double area = 25.5)
        {
            Shape myshape = new Shape()
            {
                Area = 25.5,
                Color = "Blue",
                Name = "Circle",
                Perimeter = 10
            };

            myshape.Area = area;

            return myshape;
        }

    }

    public class Shape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public string Color { get; set; }


    }
}
