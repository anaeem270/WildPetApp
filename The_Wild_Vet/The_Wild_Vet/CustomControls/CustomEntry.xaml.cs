using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Wild_Vet.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntry : ContentView
    {
        public static readonly BindableProperty HeaderLabelProperty = BindableProperty.Create(
        propertyName: nameof(HeaderLabel),
        returnType: typeof(string),
        declaringType: typeof(string),
        defaultValue: string.Empty,
        BindingMode.TwoWay);
        public string HeaderLabel
        {
            get { return (string)GetValue(HeaderLabelProperty); }
            set { SetValue(HeaderLabelProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        declaringType: typeof(string),
        defaultValue: string.Empty,
        BindingMode.TwoWay);
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        propertyName: nameof(Placeholder),
        returnType: typeof(string),
        declaringType: typeof(string),
        defaultValue: string.Empty,
        BindingMode.TwoWay);
        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create(
        propertyName: nameof(PlaceholderColor),
        returnType: typeof(Color),
        declaringType: typeof(Color),
        defaultValue: Color.Black,
        BindingMode.TwoWay);
        public Color PlaceholderColor
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

        public static new readonly BindableProperty HeightProperty = BindableProperty.Create(
        propertyName: nameof(Height),
        returnType: typeof(double),
        declaringType: typeof(double),
        defaultValue: 45.0,
        BindingMode.TwoWay);
        public new double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(
        propertyName: nameof(Keyboard),
        returnType: typeof(Keyboard),
        declaringType: typeof(Keyboard),
        defaultValue: Keyboard.Default,
        BindingMode.TwoWay);
        public Keyboard Keyboard
        {
            get { return (Keyboard)GetValue(KeyboardProperty); }
            set { SetValue(KeyboardProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(
            nameof(FontSize), typeof(NamedSize),
            typeof(CustomEntry),
            default(NamedSize),
            propertyChanged: (bindingObject, oldValue, newValue) =>
            {
                FontSizeConverter myFontSizeConverter = new FontSizeConverter();
                ((CustomEntry)bindingObject).entry.FontSize = (Double)myFontSizeConverter.ConvertFromInvariantString(newValue.ToString());
            });

        public NamedSize FontSize
        {
            get { return (NamedSize)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        

        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
        propertyName: nameof(IsPassword),
        returnType: typeof(bool),
        declaringType: typeof(bool),
        defaultValue: false,
        BindingMode.TwoWay);
        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set { SetValue(IsPasswordProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
        propertyName: nameof(BorderColor),
        returnType: typeof(Color),
        declaringType: typeof(Color),
        defaultValue: Color.FromHex("#E0C8FD"),
        BindingMode.TwoWay);
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty FocusBorderColorProperty = BindableProperty.Create(
        propertyName: nameof(FocusBorderColor),
        returnType: typeof(Color),
        declaringType: typeof(Color),
        defaultValue: Color.FromHex("#9C53DD"),
        BindingMode.TwoWay);
        public Color FocusBorderColor
        {
            get { return (Color)GetValue(FocusBorderColorProperty); }
            set { SetValue(FocusBorderColorProperty, value); }
        }

        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create(
        propertyName: nameof(MaxLength),
        returnType: typeof(int),
        declaringType: typeof(int),
        defaultValue: int.MaxValue,
        BindingMode.TwoWay);
        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        public CustomEntry()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == HeaderLabelProperty.PropertyName)
            {
                headerLabel.Text = HeaderLabel;
            }
            if (propertyName == TextProperty.PropertyName)
            {
                entry.Text = Text;
            }
            if (propertyName == FontSizeProperty.PropertyName)
            {
                entry.FontSize = ((double)FontSize);
            }
            if (propertyName == IsPasswordProperty.PropertyName)
            {
                entry.IsPassword = IsPassword;
                //ShowHidePassword.IsVisible = IsPassword;
            }
           
            if (propertyName == PlaceholderProperty.PropertyName)
            {
                entry.Placeholder = Placeholder;
            }
            if (propertyName == PlaceholderColorProperty.PropertyName)
            {
                entry.PlaceholderColor = PlaceholderColor;
            }
            if (propertyName == HeightProperty.PropertyName)
            {
                entry.HeightRequest = Height;
            }
            if (propertyName == KeyboardProperty.PropertyName)
            {
                entry.Keyboard = Keyboard;
            }
           
            if (propertyName == MaxLengthProperty.PropertyName)
            {
                entry.MaxLength = MaxLength;
            }
        }

        private void ShowPassword_Clicked(object sender, EventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;
            if (entry.IsPassword)
            {
                imageButton.Source = (FileImageSource)("show_active.png");
                entry.IsPassword = false;
            }
            else
            {
                imageButton.Source = (FileImageSource)("show_default.png");
                entry.IsPassword = true;
            }
        }

        public event EventHandler<TextChangedEventArgs> TextChanged;
        public new event EventHandler<FocusEventArgs> Focused;
        public new event EventHandler<FocusEventArgs> Unfocused;

        private void entry_Focused(object sender, FocusEventArgs e)
        {
            entryBorder.BorderColor = FocusBorderColor;
            
            Focused?.Invoke(entry, e);
        }

        private void entry_Unfocused(object sender, FocusEventArgs e)
        {
            entryBorder.BorderColor = BorderColor;
            
            Unfocused?.Invoke(entry, e);
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChanged?.Invoke(entry, e);
            Text = e.NewTextValue;
        }
    }
}