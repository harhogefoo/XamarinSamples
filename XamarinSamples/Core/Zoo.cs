using System;
using Xamarin.Forms;

namespace XamarinSamples
{
	public class Zoo
	{
		public string ImageUrl { get; set; }
		public string Name { get; set; }

        public UriImageSource Image
        {
            get
            {
                return new UriImageSource
                {
                    Uri = new Uri(ImageUrl),
                    CachingEnabled = true,
                    CacheValidity = new TimeSpan(5, 0, 0, 0)
                };
            }

        }

	}
}
