using Bridge.Html5;

namespace Bridge.Layouts.Controls
{
    [Ignore]
    [Namespace("layouts.controls")]
    public class Page:FrameworkElement 
    {
       public static string typeName = "layouts.controls.Page";
        public string typename
        {
            get
            {
                return Page.typeName;
            }
        }
        public  UIElement child;
        private void tryLoadChildFromServer()
        {
            var req = new XMLHttpRequest();
            req.OnReadyStateChange = () =>
            {
                if (req.ReadyState == AjaxReadyState.Done && req.Status == 200)
                {
                    var loader = new XamlReader();
                    this.child = loader.Parse(req.ResponseText);
                }
            };
            req.Open("GET", this.typename.Replace(".", "/") + ".xml", true);
            req.Send();
        }
    }
}