# DataTemplateSelectorRegression
show the DataTemplateSelector regression in Xamarin Forms 4.7. Worked fine in 4.5

Using the DataTemplateSelector results in overlapping templates in iOS.

To repro, just run the project on iOS. To observe the expected behavior, simply revert to using Xamarin.Forms 4.5


Good in Xamarin.Forms v4.6.0.847:

![alt text](https://github.com/lucorn/DataTemplateSelectorRegression/blob/master/correct.png?raw=true)


Good in Xamarin.Forms v4.6.0.967:

![alt text](https://github.com/lucorn/DataTemplateSelectorRegression/blob/master/defect.png?raw=true)
