using System.Drawing;
using System.Runtime.CompilerServices;

namespace DataTierWebServer.Models
{
    public class ProfileImageGen
    {
        private readonly Random _random = new Random();
        private readonly List<Bitmap> _icons;

        public ProfileImageGen()
        {
            _icons = new List<Bitmap>();
            for (var i = 0; i < 10; i++)
            {
                var image = new Bitmap(64, 64);
                for (var x = 0; x < 64; x++)
                {
                    for (var y = 0; y < 64; y++)
                    {
                        image.SetPixel(x, y, Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)));
                    }
                }
                _icons.Add(image);
            }
        }

        public Bitmap GetIcon() => _icons[_random.Next(_icons.Count)];

        public byte[] GetImageBytes(Bitmap image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Save as PNG or any preferred format
                return ms.ToArray();
            }
        }
    }
}
