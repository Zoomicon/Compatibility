//Project: Compatibility (http://github.com/Zoomicon/Compatibility)
//Filename: FocusManager.cs
//Version: 20151130

using System.Windows;

namespace Compatibility
{
  public static class FocusManager
  {

    //See: http://referencesource.microsoft.com/#PresentationCore/Core/CSharp/System/Windows/Input/FocusManager.cs

    #region IsFocusScope Property

    /// <summary>
    /// The DependencyProperty for the IsFocusScope property.
    /// This property is used to mark the special containers (like Window, Menu) so they can
    /// keep track of the FocusedElement element inside the container. Once focus is set
    /// on the container - it is delegated to the FocusedElement element
    ///     Default Value:      false
    /// </summary>
    public static readonly DependencyProperty IsFocusScopeProperty =
      DependencyProperty.RegisterAttached("IsFocusScope", typeof(bool), typeof(FocusManager),
                                          new PropertyMetadata(false
                                            #if !SILVERLIGHT
                                            , OnFocusScopePropertyChanged
                                            #endif
                                            ));

    #if !SILVERLIGHT

    private static void OnFocusScopePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      UIElement element = (UIElement)d;
      d.SetValue(System.Windows.Input.FocusManager.IsFocusScopeProperty, e.NewValue); //pass on to WPF's FocusManager.IsFocusScopeProperty implementation
    }

    #endif

    #endregion

  }
}
