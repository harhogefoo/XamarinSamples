using Xamarin.Forms;

namespace XamarinSamples
{
	public class PACDHeaderScrollMenuButton : Button
	{
		public bool selected = false;
		public int Index { get; set; }
		public PACDCarouselPageView PDContentView { get; set; }

		public PACDHeaderScrollMenuButton()
		{
			WidthRequest = 100;
			HeightRequest = 30;
			BorderRadius = 15;
			TextColor = Color.White;
			this.BackgroundColor = Color.FromHex("#3BB0C9");

			this.Clicked += OnButtonClicked;

		}

		public void SetSelected(bool state)
		{
			this.selected = state;
			if (state)
			{
				this.BackgroundColor = Color.White;
				this.TextColor = Color.FromHex("#3BB0C9");
			}
			else {
				this.BackgroundColor = Color.FromHex("#3BB0C9");
				TextColor = Color.White;
			}
		}

		void OnButtonClicked(object sender, System.EventArgs e)
		{
			
			PACDEventManager.Instance().SetPagePosition(Index);
		}

	}
}
	
