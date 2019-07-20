using System;
using Xamarin.Forms;

namespace TestIconColorXamarin
{
    public class IconViewControl : View
    {
        public event EventHandler<EventArgs> Toggled;
        #region ForegroundProperty
        public IconViewControl()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            Foreground = ColorUnActive;
            this.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Toggled?.Invoke(sender, e);

            if (Foreground == ColorActive)
            {
                Foreground = ColorUnActive;
            }
            else
            {
                Foreground = ColorActive;
            }
        }

        public static readonly BindableProperty ForegroundProperty = BindableProperty.Create(nameof(Foreground), typeof(Color), typeof(IconViewControl), default(Color));

        public Color Foreground
        {
            get
            {
                return (Color)GetValue(ForegroundProperty);
            }
            set
            {
                SetValue(ForegroundProperty, value);
            }
        }

        #endregion

        #region SourceProperty

        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(IconViewControl), default(string));

        public string Source
        {
            get
            {
                return (string)GetValue(SourceProperty);
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }

        #endregion


        #region ColorActiveProperty

        public static readonly BindableProperty ColorActiveProperty = BindableProperty.Create(nameof(ColorActive), typeof(Color), typeof(IconViewControl), Color.Black);

        public Color ColorActive
        {
            get
            {
                return (Color)GetValue(ColorActiveProperty);
            }
            set
            {
                SetValue(ColorActiveProperty, value);
            }
        }

        #endregion


        #region ColorUnActiveProperty

        public static readonly BindableProperty ColorUnActiveProperty = BindableProperty.Create(nameof(ColorUnActive), typeof(Color), typeof(IconViewControl), Color.Black);

        public Color ColorUnActive
        {
            get
            {
                return (Color)GetValue(ColorUnActiveProperty);
            }
            set
            {
                SetValue(ColorUnActiveProperty, value);
            }
        }

        #endregion
    }
}
