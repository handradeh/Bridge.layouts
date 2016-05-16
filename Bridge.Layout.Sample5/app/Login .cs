using Bridge.Layouts;
using Bridge.Layouts.Controls;
using Bridge.Layouts.Sample5;

namespace Bridge.Layouts.Sample5
{

    public class Login : Page
    {
        new static string typeName = "Bridge.Layouts.Sample5.Login";
        //get typeName(): string {
        //    return Login.typeName;
        //}

        public Login() //  constructor()
        {
            //super();

            this.dataContext = new LoginViewModel(this);
            this.initializeComponent();
        }

        public static string PAGE_DEFINITION =
       @"<?xml version=""1.0"" encoding=""utf-8""?>
        <Stack Orientation = ""Vertical"" VerticalAlignment=""Center"" HorizontalAlignment=""Center"">
          <TextBlock Text = ""Welcome to Login Page"" Margin=""8""/>
          <TextBox   Text = ""{path:username,mode:twoway}"" Placeholder=""User name (test)"" Margin=""8""/>
          <TextBox   Text = '{path:password,mode:twoway}' Type=""password"" Placeholder=""Password (test)"" Margin=""8""/>
          <Button Text=""Sign In"" Command=""{path:loginCommand}"" Margin=""8,16,8,8""/>
        </Stack>
        ";
        //     public static string PAGE_DEFINITION = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
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
            this.child = loader.Parse(Login.PAGE_DEFINITION);
        }

        public void onNavigate(NavigationContext context)
        {

        }

    }
}