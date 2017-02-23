using System;
namespace XamarinSamples
{
	public class PACDEventManager
	{
		public static PACDCarouselPageView PDContentView;
		public static PACDHeaderBox PACDHeaderMenu;

		private static PACDEventManager _instance = new PACDEventManager();

		private PACDEventManager(){}

		static internal PACDEventManager Instance()
		{
			return _instance;
		}

		public void SetPagePosition(int index)
		{
			// Menuを選択する

			// カルーセルのページを移動する
			PDContentView.Position = index;
			PACDHeaderMenu.SetCurrentItemIndex(index);
		}

		public void SetFixedItems(PACDCarouselPageView pDContentView, PACDHeaderBox pACDHeaderMenu)
		{
			PDContentView = pDContentView;
			PACDHeaderMenu = pACDHeaderMenu;
		}

	}
}
