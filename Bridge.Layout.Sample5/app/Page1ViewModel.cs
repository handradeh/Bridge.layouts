using Bridge.Layouts.Sample5;

namespace Bridge.Layouts.Sample5
{
  
    public class Page1ViewModel
    {
        private Page1 page1;
        private object v;

        public Page1ViewModel(Page1 page1, object v)
        {
            this.page1 = page1;
            this.v = v;
        }
    }
}