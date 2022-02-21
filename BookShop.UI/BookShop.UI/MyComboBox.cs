using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BookShop.UI
{
    public class MyComboBox : ComboBox
    {
        [Bindable(true)]
        [Category("Appearance")]
        public Brush BackGround { get; set; } = new SolidColorBrush(Colors.Red);



        //[Bindable(true)]
        //[Category("Appearance")]
        //[TypeConverter(typeof(FontSizeConverter))]
        //[Localizability(LocalizationCategory.None)]
        //public  double MyFontSize { get; set; }
    }
}
