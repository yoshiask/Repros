using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinAppSdk
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            FileInfo file = new(Path.Combine(ApplicationData.Current.LocalFolder.Path, "SystemIO.txt"));
            if (file.Exists)
                file.Delete();
            
            File.WriteAllText(file.FullName, "Howdy from WinUI 3 Desktop using System.IO");
            file.Refresh();

            Debug.WriteLine($"File attributes: {file.Attributes}");

            var file2 = await ApplicationData.Current.LocalFolder.CreateFileAsync("StorageFile.txt", CreationCollisionOption.ReplaceExisting);
            using var stream = await file2.OpenStreamForWriteAsync();
            using StreamWriter writer = new(stream);
            writer.Write("Howdy from WinUI 3 Desktop using StorageFile");
        }
    }
}
