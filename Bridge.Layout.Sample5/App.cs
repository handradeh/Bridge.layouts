using Bridge.Html5;

namespace Bridge.Layouts.Sample5
{
    public class App
    {
        [Ready]
        public static void Main()
        {
         
            Global.Alert("Success");

            //easiest way to save user logged-in state
            //bool userLogged = false;

            Global.Set("userLogged", false);          


            var app =new  Application();
            app.map("/login", "Bridge.Layouts.Sample5/Login");//mapping is case sensitive
            app.map("/page1/{user}", "Bridge.Layouts.Sample5/Page1");
            app.map("/page2/{parameter}", "app/Page2");

            app.onBeforeNavigate += (ctx) => {
                if (ctx.nextUri != "/login" && !Global.Get<bool>("userLogged"))
                {                   
                    ctx.cancel = true;
                    //user must be logged in before go ahead
                    app.navigate("/login");
                }
            };
            app.navigate("/page1/myuser&-test");
        }
    }
}