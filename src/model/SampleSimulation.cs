using SixLabors.ImageSharp.Processing;
using System;

namespace model
{
    public class SampleSimulation : BaseSimulationEngine
    {
        public SampleSimulation() : base ("./Resources/Images/sampleImage.png")
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
