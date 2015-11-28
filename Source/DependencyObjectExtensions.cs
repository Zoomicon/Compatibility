//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: DependencyObjectExtensions.cs
//Version: 20151128

namespace Compatibility
{

    public static class DependencyObjectExtensions
    {

#if SILVERLIGHT

        public static void CoerceValue(this System.Windows.DependencyObject target, System.Windows.DependencyProperty dp)
        {
            System.Windows.FrameworkPropertyMetadata.DoExplicitCoercion(target, dp);
        }

#endif

    }

}
