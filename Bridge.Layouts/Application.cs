using Bridge;
using Bridge.Html5;
using System;

namespace Bridge.Layouts
{
    [Ignore]
    [Namespace("layouts")]
    public class XamlReader
    {
       public  InstanceLoader instanceLoader;
        public string namespaceResolver;
        [Name ("namespaceResolver")]
        public string namespaceresolver( string xmlNs)
        {
            return default(string);
        }
        public string xmlNs;
        private string DefaultNamespace;
        //public XamlReader(InstanceLoader instanceLoader, string xmlNs) {
        //    //(xmlNs: string): string;

        //    this.instanceLoader = instanceLoader;
        //    this.xmlNs = xmlNs; 
        //    return;         
        //}
        public XamlReader()
        {
            return; 
        }
        private object  _createdObjectsWithId;
        [Name("Parse")]
        public Bridge.Layouts.Controls.Page Parse(string lml)
        {
            return default(Bridge.Layouts.Controls.Page);
        }//: any;

        public string resolveNameSpace(string xmlns)
        {
            return default(string);
        }
        //Load(xamlNode: Node): any; 
        //static bool compareXml(Node nodeLeft, Node nodeRight)
        //{
        //    return default(bool);
        //}
        //private trySetProperty(obj, propertyName, propertyNameSpace, value);
        //private static tryCallMethod(obj, methodName, value);
        //private static tryParseBinding(value);
    }
    [Ignore]
    [Namespace("layouts")]
    public class Application
    {
        //constructor()
        //{ }

        public Application() { return; }
        private object  _current;
        public static Application current;
        private object _page;
        public Bridge.Layouts.Controls.Page page;
        private static void requestAnimationFrame()
        {
            return;
        }
        private static void onAnimationFrame()
        {
            return; 
        }
        private static object _beginInvokeActions;
        public static void beginInvoke(Action action) {
            return;
        } //: void;
        private UriMapping[] _mappings;
        public UriMapping[] mappings;
       public UriMapping map( string uri, string mappedUri)
        {
            return default(UriMapping);
        }
        private object  _navigationStack;
        private object  _currentNavigationitem;
        private string  _returnUri;
        public delegate void onBeforeNavigateEvent(NavigationContext ctx);
        public onBeforeNavigateEvent onBeforeNavigate;

        //onAfterNavigate: (ctx: controls.NavigationContext) => void;
        public bool  navigate(string uri,  InstanceLoader loader=null )
        {
            return default(bool); 
        }
            //: boolean;
        //private hashChanged(hash);
    }

    public class UriMapping
    {
       string uri;
       public UriMapping(string uri,  string mapping)
        {
            this.uri = uri;
            this.mapping = mapping;
        }
        private string _mapping;
        string mapping;
        private static string _rxMapping;
        private string _compiled;
        private string _compiledUri;
        private string[] _queryStringTokens;
        public void compile() {
            return;
        }
        public bool test( string uri)
        {
            return default(bool);
        } 
       public bool  resolve( string uriToResolve) {

            return default(bool);
        } 
    }

    [Ignore]
    [Namespace("layouts")]
    public class InstanceLoader
   {
     private object  context;
     public InstanceLoader (object context)
     {
            this.context = context; 
     }
        public void  getInstance( string name,ArrayBuffer[]  args) {

            return;
             
        }//: any;
   }
  
}