using System.Collections;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace XamarinSamples { 
	public class PACDHeaderBox : Frame
	{
		public int Radius { get; set; }     // 角丸のサイズ
		public int ShadowSize { get; set; } // 影の幅
		public string jsonData { get; set; } // ヘッダメニューの設定ファイル(PACDサーバーから受け取る)
		public PACDCarouselPageView PDContentView { get; set;}
		public ScrollView GroupTabScrollView { get; set; }

		public PACDHeaderBox()
		{
			//Radius = 10;
			//ShadowSize = 5;
			WidthRequest = 375;
			HeightRequest = 100;
			Padding = 0;

			var stack = new AbsoluteLayout
			{
				Padding = 0,
			};
			stack.Children.Add(AddSearchBar());
			stack.Children.Add(AddScrollMenu(), new Point(0, 50));

			Content = stack;
		}

		/// <summary>
		/// Adds the search bar.
		/// </summary>
		/// <returns>The search bar.</returns>
		public Entry AddSearchBar()
		{
			var searchBar = new Entry
			{
				WidthRequest = 300,
				Placeholder = "検索"
			};
			return searchBar;
		}

		public void AddSettingButton()
		{

		}

		/// <summary>
		/// 無限スクロールメニューを生成する
		/// </summary>
		/// <returns>The scroll menu.</returns>
		public ScrollView AddScrollMenu()
		{
			var stack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 30,
			};

			for (int i = 0; i < 30; i++)
			{
				stack.Children.Add(new PACDHeaderScrollMenuButton { 
					Text = "Button " + i,
					Index = i,
				});
			}

			GroupTabScrollView = new ScrollView
			{
				WidthRequest = 375,
				HeightRequest = 30,
				Content = stack,
				Orientation = ScrollOrientation.Horizontal,
			};

			return GroupTabScrollView;

		}

		/// <summary>
		/// 無限ループのスクロールビューメニューを表示/非表示を切り替える
		/// </summary>
		/// <param name="state">If set to <c>true</c> state.</param>
		public void SetScrollMenuEnabled(bool state)
		{
		}

		/// <summary>
		/// 検索バーの表示/非表示を切り替える
		/// </summary>
		/// <param name="state">If set to <c>true</c> state.</param>
		public void SetSearchBarEnabled(bool state)
		{
		}

		public void SetPDContentView(PACDCarouselPageView pDContentView)
		{
			this.PDContentView = pDContentView;

			var stack = GroupTabScrollView.Content as StackLayout;
			for (int i = 0; i < stack.Children.Count; i++) {
				PACDHeaderScrollMenuButton button = stack.Children[i] as PACDHeaderScrollMenuButton;
				button.PDContentView = pDContentView;
			}
		}

		/// <summary>
		/// タブメニューの選択及びその位置をずらす
		/// </summary>
		/// <param name="index">Index.</param>
		public void SetCurrentItemIndex(int index) { 
			for (int i = 0; i < (GroupTabScrollView.Content as StackLayout).Children.Count; i++) {
				((GroupTabScrollView.Content as StackLayout).Children[i] as PACDHeaderScrollMenuButton).SetSelected(false);
			}

			((GroupTabScrollView.Content as StackLayout).Children[index] as PACDHeaderScrollMenuButton).SetSelected(true);

			//位置をずらす
			//TODO
		}
	}
}
