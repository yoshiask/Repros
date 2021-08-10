using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContentControlTemplateSelector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Models = new ObservableCollection<Model>
            {
                new Model
                {
                    Title = "TestA",
                    Value = "Testing string values"
                },
                new Model
                {
                    Title = "DateTime test",
                    Value = DateTime.Now
                },
                new Model
                {
                    Title = "DateTimeOffset test",
                    Value = DateTimeOffset.Now
                },
                new Model
                {
                    Title = "Just a link",
                    Value = new Uri("https://github.com/ZuneDev")
                },
                new Model
                {
                    Title = "Many arbitrary objects",
                    Value = new List<object>
                    {
                        "Element0", "Element1", new DateTime(1, 1, 1)
                    }
                },
            };
        }

        public ObservableCollection<Model> Models
        {
            get => (ObservableCollection<Model>)GetValue(ModelsProperty);
            set => SetValue(ModelsProperty, value);
        }
        public static readonly DependencyProperty ModelsProperty = DependencyProperty.Register(
            nameof(Models), typeof(ObservableCollection<Model>), typeof(MainPage), new PropertyMetadata(null));


    }
}
