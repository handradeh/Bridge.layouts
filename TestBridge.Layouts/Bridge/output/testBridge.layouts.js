(function (globals) {
    "use strict";

    Bridge.define('TestBridge.Layouts.App', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            main: function () {
                // Simple alert()
                Bridge.global.alert("Success");
    
                // To confirm Bridge.NET is working: 
                // 1. Build this project (Ctrl + Shift + B)
                // 2. Browse to file /Bridge/www/demo.html
                // 3. Right-click on file and select "View in Browser" (Ctrl + Shift + W)
                // 4. File should open in a browser and the alert message above should popup
                // 5. Success!
    
                var xamlapp = new layouts.Application();
                var lmlReader = new layouts.XamlReader();
    
                var lmlTest = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n   <Page>   \r\n       <Grid Rows =\"48 *\" Columns = \"Auto *\" >      \r\n              <Border Background =\"Yellow\" Grid.ColumnSpan =\"2\" />         \r\n              <Border Background = \"Green\" Grid.Row = \"1\" Grid.Column =\"0\" Width = \"80\" />              \r\n        </Grid>\r\n    </Page >\r\n     ";
    
    
                xamlapp.page = lmlReader.Parse(lmlTest);
            }
        }
    });
    
    Bridge.init();
})(this);
