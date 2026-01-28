using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;

namespace ui.Model
{
    public abstract class BaseSimulationEngine : ISimulationEngine
    {
        public event ISimulationEngine.OnStepHandler OnStep;
        protected SixLabors.ImageSharp.Image _image {  get; set; }

        public BaseSimulationEngine(string imageLocation)
        {
            _image = SixLabors.ImageSharp.Image.Load(imageLocation);
        }

        public string getImageBase64()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                _image.Save(ms, PngFormat.Instance);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public void run(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                step();
                OnStep?.Invoke();
            }
        }

        protected abstract void step();
    }
}
