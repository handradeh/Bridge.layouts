using Bridge;
using Bridge.Layouts.Controls;

[Ignore]
[Namespace("layouts.controls")]
public class NavigationContext
{
    Page previousPage;
    string previousUri;
    Page nextPage;
    public  string nextUri;
    public  object queryString;
    public NavigationContext(Page previousPage, string previousUri,  Page nextPage,  string nextUri,object  queryString)
    {
        this.previousPage = previousPage;
        this.previousUri = previousUri;
        this.nextPage = nextPage;
        this.nextUri= nextUri;
        this.queryString = queryString; 
        return;
    }

      public bool  cancel;
      string returnUri;
    }