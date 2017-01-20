using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class SettingPage : ContentPage
	{
		List<SettingItem> items = new List<SettingItem>();
		
		public SettingPage()
		{
			InitializeComponent();

			// SettingListView.ItemsSource = items;
			items.Add(new SettingItem { DisplayName = "利用者情報" });
			items.Add(new SettingItem { DisplayName = "パスコード設定" });
			items.Add(new SettingItem { DisplayName = "プレフィックス設定" });
			items.Add(new SettingItem { DisplayName = "転送設定" });

		}

		void test(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("クリック");

		}
	}
}
