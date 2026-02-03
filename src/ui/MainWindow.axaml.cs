using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.IO;
using model;

namespace ui
{
    public partial class MainWindow : Window
    {
        private SampleSimulation simulation = new SampleSimulation();

        public MainWindow()
        {
            InitializeComponent();

            simulation.OnStep += UpdateImage;
            UpdateImage();
        }

        private void RunSimulation(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            int frames = (int)(FramesInput.Value ?? 10);
            simulation.run(frames);
        }

        private void UpdateImage()
        {
            var base64 = simulation.getImageBase64();
            RenderImage.Source = Base64ToBitmap(base64);
        }

        private static Bitmap Base64ToBitmap(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using var ms = new MemoryStream(bytes);
            return new Bitmap(ms);
        }
    }
}