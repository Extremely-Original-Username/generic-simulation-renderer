using SixLabors.ImageSharp.Processing;
using System;

namespace ui.Model
{
    public class SampleSimulation : BaseSimulationEngine
    {
        public SampleSimulation() : base ("./favicon.png")
        {

        }

        private void FlipPngImage()
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
