//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: Decorator.cs
//Version: 20120704

/*
NOTE: Please add at your source code file:

#if SILVERLIGHT
using Decorator = System.Windows.Controls.Border;
#endif

...and then use Decorator (instead of Border) in both WPF and Silverlight in your source code
 (WPF's Border extends WPF Decorator, whereas Silverlight's Border doesn't since Silverlight doesn't have Decorator class)

*/