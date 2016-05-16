using Bridge.Layouts.Controls;

namespace Bridge.Layouts.Sample5
{
  
    public class Page1 : Page
    {
        static string typeName = "Bridge.Layouts.Sample5.Page1";
        //new public string typeName
        //{
        //    get { return Page1.typename; }
        //}
        public Page1()
        {
            this.initializeComponent();
        }


        public static string PAGE_DEFINITION =
        @"<?xml version=""1.0"" encoding=""utf-8""?>
        <Stack Orientation=""Vertical"" VerticalAlignment=""Center"" HorizontalAlignment=""Center"">
         <TextBlock Text=""{path:username}"" Format=""Welcome to Page1 user {0}"" Margin=""8""/>
         <TextBox Text=""{path:parameter,twoway}"" Placeholder=""Parameter for page 2"" Margin=""8""/>
         <Button Text=""Goto Page 2"" Command=""{path:gotoPage2Command}"" Margin=""8,16,8,8""/>
        </Stack>";
        //     public static string PAGE_DEFINITION =
        //@"<?xml version=""1.0"" encoding=""utf-8"" ?>
        //<Page>   
        //    <Grid Rows =""48 *"" Columns = ""Auto *"" >      
        //           <Border Background =""Yellow"" Grid.ColumnSpan =""2"" />         
        //           <Border Background = ""Green"" Grid.Row = ""1"" Grid.Column =""0"" Width = ""80"" />              
        //     </Grid>
        // </Page >
        //  ";

        protected void initializeComponent()
        {
            var loader = new XamlReader();
            this.child = loader.Parse(Page1.PAGE_DEFINITION);
        }

        public void onNavigate(NavigationContext context)
        {

            this.dataContext = new Page1ViewModel(this, context.queryString["user"]);

        }

    }
}