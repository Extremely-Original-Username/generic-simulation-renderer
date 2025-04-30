using SixLabors.ImageSharp.Processing;
using System;

namespace ui.Model
{
    public class SampleSimulation : BaseSimulationEngine
    {
        public SampleSimulation() : base ("./sampleImage.png")
        {

        }

        public void FlipPngImage()
        {
            // Flip the image vertically
            _image.Mutate(x => x.Flip(FlipMode.Horizontal));
        }

        protected override void step()
        {
            FlipPngImage();
        }
    }
}
