using System.Collections.Generic;

namespace ListViewDynamicHeight.ViewModels
{
    public class MyViewModel
    {
        public List<BaseItem> MyItems { get; set; } = new List<BaseItem>
        {
           new A100(),
           new A150(),
           new A50(),
           new A100(),
        };
    }
}
