using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CloudCakes
{
    public class AboutPage : ContentPage
    {

        public AboutPage ()
        {
            var title = new Label {
                Text = "About Us",
                FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var description = new Label {
                Text = "CloudCakes aims to revolutionize the cake delivery business by delivering on-demand cakes and other treats with the click of a button. No longer will you need to go to the store or even remember your type of cake - just signup for an account and you're good to go!"
            };

            var blogTitle = new Label {
                Text = "In The News",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            List<string> articles = new List<string> {
                "CloudCakes raises $50m and leads the Cake-as-a-Service models",
                "Top 10 Cities with the Best Cakes",
                "CloudCakes CEO awarded for Food Innovation Award 2016"
            };

            ListView articlesView = new ListView {
                ItemSource = articles
            };

            Content = new StackLayout {
                Padding = 30,
                Spacing = 10,
                Children = { title, description, blogTitle, articlesView }
            };
        }
    }
}