using PluginFramework.IService;
using PluginFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluginFramework.Service
{
    public class ImageManupulateService : IImageManupulateService
    {

        public Image getAllImages()
        {
            ImagePaths img = new ImagePaths();
            var imgPath = new Image();
           
                foreach(var item in img.ImagePath)
                 {
                     imgPath.imagePath = item;
                 }
           
            return imgPath;           
        }

        public ImageManupulation saveImageGraphics(ImageManupulation imManupulation)
        {
            //service need to implement
            //update and insert handle by this section
            ImageManupulation image = new ImageManupulation();

            return image;
        }
    }
}
