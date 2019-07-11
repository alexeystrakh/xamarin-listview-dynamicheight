namespace ListViewDynamicHeight
{
    public class BaseItem
    {
        public string Title => this.GetType().Name;

        public override string ToString()
        {
            return Title;
        }
    }

    public class A50 : BaseItem { }
    public class A100 : BaseItem { }
    public class A150 : BaseItem { }
}
