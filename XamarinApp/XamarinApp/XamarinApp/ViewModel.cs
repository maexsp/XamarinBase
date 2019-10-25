using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinApp
{
    public class ViewModel : BaseViewModel
    {
        int fontSize = 64;
        bool isIconBackgroundOn = true;

        public ViewModel()
        {
            Title = "Icons";
            IncreaseFontSizeCommand = new Command(() =>
            {
                if (FontSize >= 72) return;
                FontSize += 2;
            });
            DecreaseFontSizeCommand = new Command(() =>
            {
                if (FontSize <= 6) return;
                FontSize -= 2;
            });
        }

        public int FontSize
        {
            get { return fontSize; }
            set { SetProperty(ref fontSize, value); }
        }

        public bool IsIconBackgroundOn
        {
            get { return isIconBackgroundOn; }
            set { SetProperty(ref isIconBackgroundOn, value); }
        }

        public ICommand IncreaseFontSizeCommand { get; set; }

        public ICommand DecreaseFontSizeCommand { get; set; }
    }
}
