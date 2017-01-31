using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSamples
{
    /// <summary>
    /// iOSのみ動作．Androidは動作せず...
    /// </summary>
    public class HttpClientSample : ContentPage
    {
        public HttpClientSample()
        {
            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Hello ContentPage" }
            //    }
            //};
            // ボタンとラベル（２つ）を配置する
            var button = new Button { Text = "Push" };
            var status = new Label();
            var html = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                LineBreakMode = LineBreakMode.WordWrap,
                Font = Font.SystemFontOfSize(NamedSize.Small),
            };

            Content = new StackLayout
            {
                Spacing = 20,
                Children = { button, status, html }
            };

            //ボタンを押した時の処理
            button.Clicked += async (s, a) =>
            {
                //ラベルの表示を初期化する
                status.Text = "Loding...";
                html.Text = "";

                //非同期でダウンロード
                var str = await Download();

                //ダウンロード完了後にラベルを更新する
                status.Text = str.Length + " bytes downloaded";
                html.Text = str;
            };
        }

        async Task<string> Download()
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync("http://www.sapporoworks.ne.jp/");
        }
    }
}

