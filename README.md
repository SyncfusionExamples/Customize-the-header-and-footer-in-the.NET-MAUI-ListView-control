# Customize-the-header-and-footer-in-the.NET-MAUI-ListView-control
This sample demonstrate how to customize the header and footer in the .NET MAUI ListView control.

A quick-start example to help you how to customize the header and footer in the .NET MAUI ListView control. The ListView allows you to stick the header and footer items to view by enabling the IsStickyHeader and IsStickyFooter properties. 

Watch the video: Coming soon...

Documentation: https://help.syncfusion.com/maui/listview/header-and-footer#sticky-header-and-footer 

```
 <syncfusion:SfListView x:Name="listView"  
                               SelectionMode="None"
                               ItemsSource="{Binding Products}" 
                               AutoFitMode="Height" 
                               IsStickyHeader="True"
                               IsStickyFooter="True">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid Padding="3">
                        <StackLayout>
                            <Label Text="{Binding ProductName}" FontAttributes="Bold" VerticalOptions="Center" FontSize="20"/>
                            <Label  Text="{Binding ProductDescription}" VerticalOptions="Center" FontSize="16"/>
                        </StackLayout>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
            <syncfusion:SfListView.HeaderTemplate>
                <DataTemplate>
                    <Grid Background="LightGray">
                        <Label Text="Products" FontSize="24"  FontAttributes="Bold" 
                               HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.HeaderTemplate>
            <syncfusion:SfListView.FooterTemplate>
                <DataTemplate>
                    <Grid>
                        <StackLayout Orientation="Horizontal">
                            <Button Text="Edit" HorizontalOptions="CenterAndExpand" HeightRequest="40" WidthRequest="100" />
                            <Button Text="Delete" HorizontalOptions="CenterAndExpand" HeightRequest="40"  WidthRequest="100"/>
                        </StackLayout>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.FooterTemplate>
        </syncfusion:SfListView>
``` 

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

To run the sample demo, refer to [System Requirements for .NET MAUI.](https://help.syncfusion.com/maui/system-requirements)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.