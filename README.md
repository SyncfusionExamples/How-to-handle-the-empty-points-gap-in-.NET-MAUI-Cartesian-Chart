# How to handle the empty points gap in .NET MAUI Cartesian Chart
In .NET MAUI [SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts), empty points represent missing or null data in a series. These points can occur due to unavailable data, improper formatting, or explicit assignment of null or double.NaN.

In .NET MAUI [SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts), empty points represent missing or null data in a series. These points can occur due to unavailable data, improper formatting, or explicit assignment of null or double.NaN.

This article covers handling empty points using [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) to manage missing data and customizing empty points to enhance their visual appearance.

**Handling Empty Points Using EmptyPointMode**

The [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) property determines how missing data points are treated in a series. It offers the following options:

**1.  None**

Empty points are not rendered in the chart, leaving gaps in the series.

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:LineSeries ItemsSource="{Binding ProductSales}"
                      XBindingPath="Product"
                      YBindingPath="Sales"
                      StrokeWidth="2"
                      EmptyPointMode="None"
    </chart:LineSeries>

</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
. . .
LineSeries series = new LineSeries()
{
    ItemsSource = new ViewModel().ProductSales,
    XBindingPath = "Product",
    YBindingPath = "Sales",
    StrokeWidth = 2,
    EmptyPointMode = EmptyPointMode.None,
};

chart.Series.Add(series);
this.Content = chart;
``` 
 ![EmptyPointMode-None.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM4MTc3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.rCNEgkYk4PlxIast3LGTiauSFofqwNGTHU89wBdn4BY)

**2.  Zero**

Empty points are replaced with zero, maintaining continuity in the series. 

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:AreaSeries ItemsSource="{Binding ProductSales}"
                      XBindingPath="Product"
                      YBindingPath="Sales"
                      EmptyPointMode="Zero"/>
</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
. . .
AreaSeries series = new AreaSeries()
{
    ItemsSource = new ViewModel().ProductSales,
    XBindingPath = "Product",
    YBindingPath = "Sales",
    EmptyPointMode = EmptyPointMode.Zero,
};
chart.Series.Add(series);
this.Content = chart;
```
 ![EmptyPointMode-zero.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM4MTc5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.40gf7wl743HeVWGvwPjz4MR2o2l2yA6CW5G5YOIdFdg)

**3.  Average**

Empty points are replaced with the average value of surrounding data points. 

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:ColumnSeries ItemsSource="{Binding ProductSales}"
                        XBindingPath="Product"
                        YBindingPath="Sales"
                        EmptyPointMode="Average"/>
</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().ProductSales,
    XBindingPath = "Product",
    YBindingPath = "Sales",
    EmptyPointMode = EmptyPointMode.Average,
}
chart.Series.Add(series);
this.Content = chart;
```
 ![EmptyPointMode-Average.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM4MTgwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.6_78cUYRCPosrsZla-xjlc7QALQdPiiKiswMDz5I2S4)
By default, the [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) property is set to [None](elp.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointMode_None).

**Customizing Empty Points**

You can modify the appearance of empty points using the [EmptyPointSettings](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html) property. The following visual properties can be customized:

* [Fill](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Fill): Defines the fill color of empty points.
* [Stroke](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Fill): Specifies the stroke (border) color.
* [StrokeWidth](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Stroke): Sets the thickness of the stroke.

The following example demonstrates how to customize empty points:

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:ColumnSeries ItemsSource="{Binding ProductSales}"
                        XBindingPath="Product"
                        YBindingPath="Sales"
                        EmptyPointMode="Average">
        <chart:ColumnSeries.EmptyPointSettings>
            <chart:EmptyPointSettings Fill="LightGrey"/>
        </chart:ColumnSeries.EmptyPointSettings>
    </chart:LineSeries>
</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().ProductSales,
    XBindingPath = "Product",
    YBindingPath = "Sales",
    EmptyPointMode = EmptyPointMode.Average
};

EmptyPointSettings emptypointSettings = new EmptyPointSettings()
{
    Fill = Colors.LightGray,
};

series.EmptyPointSettings = emptypointSettings;
chart.Series.Add(series);
this.Content = chart;
```
 ![Customizing_Empty_Points.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM4MTgxIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.6JH-gSBZYdsTZZV9vXpAdof9t0DZwuadMyZgleKltSE)
By using [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) and [EmptyPointSettings](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html), you can efficiently manage missing data in .NET MAUI Cartesian Charts, ensuring a smooth, accurate, and visually appealing charting experience.

**Troubleshooting**

Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [how to handle the empty points gap in .NET MAUI Cartesian Chart]()
