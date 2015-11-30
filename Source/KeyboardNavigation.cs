//See: http://referencesource.microsoft.com/#PresentationFramework/src/Framework/System/Windows/Input/KeyboardNavigation.cs

#if SILVERLIGHT

using System.Windows.Controls;

namespace System.Windows.Input
{

  ///<summary>
  /// KeyboardNavigation class provide methods for logical (Tab) and directional (arrow) navigation between focusable controls
  ///</summary>
  public sealed class KeyboardNavigation
  {

    public KeyboardNavigation()
    {

    }

    #region TabNavigation Property

    /// <summary>
    /// Controls the behavior of logical navigation on the children of the element this property is set on.
    /// TabNavigation is invoked with the TAB key.
    /// </summary>
/*
    [CustomCategory("Accessibility")]
    [Localizability(LocalizationCategory.NeverLocalize)]
    [CommonDependencyProperty]
*/
    public static readonly DependencyProperty TabNavigationProperty =
            DependencyProperty.RegisterAttached(
                    "TabNavigation",
                    typeof(KeyboardNavigationMode),
                    typeof(KeyboardNavigation),
                    new FrameworkPropertyMetadata(KeyboardNavigationMode.Local, OnTabNavigationChanged)); //there is no KeyboardNavigationMode.Continue in Silverlight - the default value for the separate Control.TabNavigation property is KeyboardNavigationMode.Local according to https://msdn.microsoft.com/en-us/library/system.windows.controls.control.tabnavigation(VS.95).aspx

    private static void OnTabNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      d.SetValue(Control.TabNavigationProperty, e.NewValue); //pass on to Silverlight's Control.TabNavigationProperty implementation (note that is not an AttachedProperty, it's only available to Control class and its descendents)
    }

    #endregion

  }
}

#endif
