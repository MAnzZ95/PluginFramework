using PluginFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluginFramework.IService
{
    public interface IImageManupulateService
    {
        Image getAllImages();
        ImageManupulation saveImageGraphics(ImageManupulation imManupulation);

    }
}
