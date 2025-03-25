# How to handle the empty points gap in .NET MAUI Cartesian Chart
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
                      ShowDataLabels="True"
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
    ShowDataLabels = true,
    EmptyPointMode = EmptyPointMode.None,
};

chart.Series.Add(series);
this.Content = chart;
``` 
![EmptyPointMode-None.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM3OTgxIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.NMODfKeo-tmoCOnS_V13vi_pFpoSci_PC3ZwgT3NivI)
**2.  Zero**

Empty points are replaced with zero, maintaining continuity in the series. 

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:AreaSeries ItemsSource="{Binding ProductSales}"
                      XBindingPath="Product"
                      YBindingPath="Sales"
                      ShowDataLabels="True"
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
    ShowDataLabels = true,
    EmptyPointMode = EmptyPointMode.Zero,
};
chart.Series.Add(series);
this.Content = chart;
```
![EmptyPointMode-zero.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM3OTg1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.L7lIUH25RUnmk6UFRnZdaRwxXRXw2lrp9ffFXBDUNVQ)
**3.  Average**

Empty points are replaced with the average value of surrounding data points. 

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <chart:ColumnSeries ItemsSource="{Binding ProductSales}"
                        XBindingPath="Product"
                        YBindingPath="Sales"
                        ShowDataLabels="True"
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
    ShowDataLabels = true,
    EmptyPointMode = EmptyPointMode.Average,
}
chart.Series.Add(series);
this.Content = chart;
```
![EmptyPointMode-Average.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM3OTgzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.U0JRL1NyQFlN_HVOAucnGrt-nmQZpeUYjw50HKWrXZc)
By default, the [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) property is set to [None](elp.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointMode_None).

**Customizing Empty Points**

You can modify the appearance of empty points using the [EmptyPointSettings](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html) property. The following visual properties can be customized:

* [Fill](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Fill): Defines the fill color of empty points.
* [Stroke](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Fill): Specifies the stroke (border) color.
* [StrokeWidth](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html#Syncfusion_Maui_Toolkit_Charts_EmptyPointSettings_Stroke): Sets the thickness of the stroke.

The following example demonstrates how to customize empty points:

**[XAML]**
```
<chart:SfCartesianChart IsTransposed="True">
. . .
    <chart:ColumnSeries ItemsSource="{Binding ProductSales}"
                        XBindingPath="Product"
                        YBindingPath="Sales"
                        ShowDataLabels="True"
                        EmptyPointMode="Average">
        <chart:ColumnSeries.EmptyPointSettings>
            <chart:EmptyPointSettings Fill="LightGrey" StrokeWidth="2" />
        </chart:ColumnSeries.EmptyPointSettings>
    </chart:LineSeries>
</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
chart.IsTransposed = true;
. . .
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().ProductSales,
    XBindingPath = "Product",
    YBindingPath = "Sales",
    ShowDataLabels = true,
    EmptyPointMode = EmptyPointMode.Average
};

EmptyPointSettings emptypointSettings = new EmptyPointSettings()
{
    Fill = Colors.LightGray,
    StrokeWidth = 2
};

series.EmptyPointSettings = emptypointSettings;
chart.Series.Add(series);
this.Content = chart;
```
![Customizing_Empty_Points.png](https://support.syncfusion.com/kb/agent/attachment/article/19659/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM3OTg0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.pFiLeI23El957IQcI4HMr-v76CoXa4GIuUIPAnfKdfY)
By using [EmptyPointMode](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointMode.html) and [EmptyPointSettings](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.EmptyPointSettings.html), you can efficiently manage missing data in .NET MAUI Cartesian Charts, ensuring a smooth, accurate, and visually appealing charting experience.
