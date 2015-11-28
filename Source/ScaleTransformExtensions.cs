//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: ScaleTransformExtensions.cs
//Version: 20151128

using System.Windows.Media;

namespace Compatibility
{

  public static class ScaleTransformExtensions
  {

    public static ScaleTransform new_ScaleTransform(double scaleX, double scaleY) //unfortunately there are is no extension method mechanism for constructors in C# yet (and the ScaleTransform class is sealed so we can't create descendent class)
    {
#if SILVERLIGHT
      ScaleTransform result = new ScaleTransform() { ScaleX = scaleX, ScaleY = scaleY };
#else
      ScaleTransform result = new ScaleTransform(scaleX, scaleY);
#endif
      return result;
    }

    public static ScaleTransform SetScale(this ScaleTransform transform, double scaleX, double scaleY) //can use this in both WPF and Silverlight (the last one misses a parametric constructor) to initialize on the same statement on which we construct the ScaleTransform
    {
      transform.ScaleX = scaleX;
      transform.ScaleY = scaleY;
      return transform; //return the transform so that it can be used in the form ScaleTransform t = new ScaleTransform().SetScale(scaleX, scaleY)
    }

    public static ScaleTransform SetScale(this ScaleTransform transform, double scale) //can use this in both WPF and Silverlight (the last one misses a parametric constructor) to initialize on the same statement on which we construct the ScaleTransform
    {
      return transform.SetScale(scale, scale);
    }

  }

}
