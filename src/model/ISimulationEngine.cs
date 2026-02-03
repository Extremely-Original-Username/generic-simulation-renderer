using SixLabors.ImageSharp.Formats.Png;

namespace model
{
    public interface ISimulationEngine
    {
        public delegate void OnStepHandler();
        public event  OnStepHandler OnStep;

        public void run(int iterations);
        public string getImageBase64();
    }
}