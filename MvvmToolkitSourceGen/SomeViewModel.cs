using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace MvvmToolkitSourceGen
{
    public class SomeViewModel : ObservableObject
    {
        private bool _isTrue;

        public bool IsTrue
        {
            get => _isTrue;
            set => SetProperty(ref _isTrue, value);
        }
    }
}
