using Xamarin.Forms;

namespace ListViewDynamicHeight.Selectors
{
    public class MyListViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate A50Template { get; set; }
        public DataTemplate A100Template { get; set; }
        public DataTemplate A150Template { get; set; }

        public MyListViewItemTemplateSelector()
        {
            A50Template = (DataTemplate)Application.Current.Resources["A50Template"];
            A100Template = (DataTemplate)Application.Current.Resources["A100Template"];
            A150Template = (DataTemplate)Application.Current.Resources["A150Template"];
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is A150)
                return A150Template;

            if (item is A100)
                return A100Template;

            return A50Template;
        }
    }
}
