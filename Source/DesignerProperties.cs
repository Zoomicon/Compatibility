//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: DesignerProperties.cs
//Version: 20151128

using System.Windows.Controls;

namespace Compatibility
{

  public static class DesignerProperties //note: this class will "replace" System.ComponentModel.DesignerProperties if one does "using Compatibility"
  {

    public static bool IsInDesignTool
    {
      get
      {
        bool result = System.ComponentModel.DesignerProperties.GetIsInDesignMode(new Button());
        #if SILVERLIGHT
        return result || System.ComponentModel.DesignerProperties.IsInDesignTool; //note: make sure we use full namespace here, else it will do infinite loop
        #else
        return result;
        #endif
      }
    }

  }

}
