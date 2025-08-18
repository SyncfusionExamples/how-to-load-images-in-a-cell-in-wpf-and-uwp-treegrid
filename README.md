# How to load images in a cell in wpf and uwp treegrid?

## About the example

This example illustrates how to load images in a cell in [WPF TreeGrid](https://www.syncfusion.com/wpf-controls/treegrid) and [UWP TreeGrid](https://www.syncfusion.com/uwp-ui-controls/treegrid).

You can add the image to `TreeGrid` cell by using `TreeGridTemplateColumn`.

## XAML code:

``` xml
<syncfusion:TreeGridTemplateColumn MappingName="ImageLink">
    <syncfusion:TreeGridTemplateColumn.CellTemplate>
          <DataTemplate>
               <Image Source="{Binding Path=ImageLink,
                      Converter={StaticResource converter}}"/>
          </DataTemplate>
    </syncfusion:TreeGridTemplateColumn.CellTemplate>
</syncfusion:TreeGridTemplateColumn>
```

## c# code:

``` c#
public class StringToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        string imagename = value as string;
        return new BitmapImage(new Uri(string.Format(@"..\..\Images\{0}", imagename), UriKind.Relative));
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return null;
    }
}
```