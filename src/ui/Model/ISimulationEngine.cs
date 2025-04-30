using SixLabors.ImageSharp.Formats.Png;

namespace ui.Model
{
    public interface ISimulationEngine
    {
        public delegate void OnStepHandler();
        public event  OnStepHandler OnStep;

        public void run(int iterations);
        public string getImageBase64(PngFormat format);
    }
}