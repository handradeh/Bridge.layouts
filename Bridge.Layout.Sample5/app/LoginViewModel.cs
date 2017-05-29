using Bridge.Html5;
using System;

namespace Bridge.Layouts.Sample5
{
    class LoginViewModel : DepObject
    {
        static string typeName = "app.LoginViewModel";
        //public string typeName
        //{
        //    get { return LoginViewModel.typename; }
        //}

        public LoginViewModel(Login view):base() 
        {
            //super();
            this.view = view;
        
        }

        private string _username; 
        private Command _loginCommand;
    
        public string username
        {
            get { return this._username; }
            set
            {
                if (this._username != value)
                {
                    var oldValue = this._username;
                    this._username = value;
                    this.onPropertyChanged("username", value, oldValue);
                    Application.beginInvoke(() =>
                        this.loginCommand.canExecuteChanged());
                }
            }
        }

        private string _password; 
      
        public string password
        {
            get { return this._password; }
            set
            {
                if (this._password != value)
                {
                    var oldValue = this._password;
                    this._password = value;
                    this.onPropertyChanged("password", value, oldValue);
                    this.loginCommand.canExecuteChanged();
                }
            }
        }
     
        public  bool userLogged;
        private Login view;

        public Command loginCommand 
        {
            get
            {
                if (this._loginCommand == null)
                    this._loginCommand = new Command((cmd, p) => this.onLogin(), (cmd, p) => this.canLogin());
                return this._loginCommand;
            }

        }

     public void onLogin()
    {
        if (this._username == "test" &&
            this._password == "test")
        {
            userLogged = true;
            Global.Set("userLogged", true);
            Application.current.navigate("/page1/" + this._username);
        }
        else
           Global.Alert("Unable to login!");

            return;
    } 

     public bool  canLogin(){
            return this._username != null && this._username.Trim().Length > 0 &&
                this._password != null && this._password.Trim().Length > 0;
    }

}
}