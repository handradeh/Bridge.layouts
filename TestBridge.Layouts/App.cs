using Bridge;
using Bridge.Html5;
using Bridge.Layouts;

namespace TestBridge.Layouts
{
    public class App
    {
        [Ready]
        public static void Main()
        {
            // Simple alert()
            Global.Alert("Success");

            // To confirm Bridge.NET is working: 
            // 1. Build this project (Ctrl + Shift + B)
            // 2. Browse to file /Bridge/www/demo.html
            // 3. Right-click on file and select "View in Browser" (Ctrl + Shift + W)
            // 4. File should open in a browser and the alert message above should popup
            // 5. Success!

            var xamlapp = new Application();
            var lmlReader = new XamlReader();

            string lmlTest = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
   <Page>   
       <Grid Rows =""48 *"" Columns = ""Auto *"" >      
              <Border Background =""Yellow"" Grid.ColumnSpan =""2"" />         
              <Border Background = ""Green"" Grid.Row = ""1"" Grid.Column =""0"" Width = ""80"" />              
        </Grid>
    </Page >
     ";           
            

            xamlapp.page = lmlReader.Parse(lmlTest);
        }
    }
}