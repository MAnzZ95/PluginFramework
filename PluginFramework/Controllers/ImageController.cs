using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PluginFramework.IService;
using PluginFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluginFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ImageController : ControllerBase
    {
        private readonly IImageManupulateService _imgService;

        public ImageController(IImageManupulateService imgService)
        {
            _imgService = imgService;
        }

        [HttpGet]
        [Route("Image/allImage")]
        public ActionResult GetAllImages()
        {
            try
            {
                var image = _imgService.getAllImages();
                return Ok(image);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        public ActionResult saveImageGraphics(bool ef1,bool ef2,bool ef3, int radius,int size)
        {
            ImageManupulation img = new ImageManupulation();
            // if any condition need to clarify then it includes this section I am just pass the values which coming from front end
            try
            {
                img.efectOne = ef1;
                img.efectTwo = ef2;
                img.efectThree = ef3;
                img.Radius = radius;
                img.Size = size;

                var image = _imgService.saveImageGraphics(img);
                return Ok(image);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }    
            
        }

        [HttpPut]
        public ActionResult updateImageGraphics(bool ef1, bool ef2, bool ef3, int radius, int size)
        {
            ImageManupulation img = new ImageManupulation();
            // if any condition need to clarify then it includes this section I am just pass the values which coming from front end
            try
            {
                img.efectOne = ef1;
                img.efectTwo = ef2;
                img.efectThree = ef3;
                img.Radius = radius;
                img.Size = size;

                var image = _imgService.saveImageGraphics(img);
                return Ok(image);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
