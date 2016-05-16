(function (globals) {
    "use strict";
    //easiest way to save user logged-in state
    var userLogged = false;

    Bridge.define('Bridge.Layouts.Sample5.App', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            main: function () {
    
                Bridge.global.alert("Success");
    
                //easiest way to save user logged-in state
                //var userLogged = false;
    
                var app = new layouts.Application();
                app.map("/login", "Bridge.Layouts.Sample5/Login"); //mapping is case sensitive
                app.map("/page1/{user}", "Bridge.Layouts.Sample5/Page1");
                app.map("/page2/{parameter}", "app/Page2");
    
                app.onBeforeNavigate = Bridge.fn.combine(app.onBeforeNavigate, function (ctx) {
                    if (!Bridge.referenceEquals(ctx.nextUri, "/login") && !userLogged) {
                        ctx.cancel = true;
                        //user must be logged in before go ahead
                        app.navigate("/login");
                    }
                });
                app.navigate("/page1/myuser&-test");
            }
        }
    });
    
    Bridge.define('Bridge.Layouts.Sample5.Login', {
        inherits: [layouts.controls.Page],
        statics: {
            typeName: "Bridge.Layouts.Sample5.Login",
            pAGE_DEFINITION: "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n        <Stack Orientation = \"Vertical\" VerticalAlignment=\"Center\" HorizontalAlignment=\"Center\">\r\n          <TextBlock Text = \"Welcome to Login Page\" Margin=\"8\"/>\r\n          <TextBox   Text = \"{path:username,mode:twoway}\" Placeholder=\"User name (test)\" Margin=\"8\"/>\r\n          <TextBox   Text = '{path:password,mode:twoway}' Type=\"password\" Placeholder=\"Password (test)\" Margin=\"8\"/>\r\n          <Button Text=\"Sign In\" Command=\"{path:loginCommand}\" Margin=\"8,16,8,8\"/>\r\n        </Stack>\r\n        "
        },
        constructor: function () {
            //super();
    
            this.dataContext = new Bridge.Layouts.Sample5.LoginViewModel(this);
            this.initializeComponent();
        },
        initializeComponent: function () {
            var loader = new layouts.XamlReader();
            this.child = loader.Parse(Bridge.Layouts.Sample5.Login.pAGE_DEFINITION);
        },
        onNavigate: function (context) {
    
        }
    });
    
    Bridge.define('Bridge.Layouts.Sample5.LoginViewModel', {
        inherits: [layouts.DepObject],
        statics: {
            typeName: "app.LoginViewModel"
        },
        _username: null,
        _password: null,
        _loginCommand: null,     
        view: null,
        constructor: function (view) {
            //super();
            this.view = view;
          
        },

     

        //getusername: function () {
        //    return this._username;
        //},
        //setusername: function (value) {
        //    if (!Bridge.referenceEquals(this._username, value)) {
        //        var oldValue = this._username;
        //        this._username = value;
        //        this.onPropertyChanged("username", value, oldValue);
        //        layouts.Application.beginInvoke(Bridge.fn.bind(this, $_.Bridge.Layouts.Sample5.LoginViewModel.f3));
        //    }
        //},
        //getpassword: function () {
        //    return this._password;
        //},
        //setpassword: function (value) {
        //    if (!Bridge.referenceEquals(this._password, value)) {
        //        var oldValue = this._password;
        //        this._password = value;
        //        this.onPropertyChanged("password", value, oldValue);
        //        this.loginCommand.canExecuteChanged();
        //    }
        //},
        onLogin: function () {
            if (Bridge.referenceEquals(this._username, "test") && Bridge.referenceEquals(this._password, "test")) {
                userLogged = true;
                layouts.Application.current.navigate("/page1/" + this._username);
            }
            else  {
                Bridge.global.alert("Unable to login!");
            }
    
            return;
        },
        canLogin: function () {
            return this._username != null && this._username.trim().length > 0 && this._password != null && this._password.trim().length > 0;
        }
    });
    
    Object.defineProperty(Bridge.Layouts.Sample5.LoginViewModel.prototype, "username", {
        get: function () {
            return this._username;
        },
        set: function (value) {
            var _this = this;
            if (this._username != value) {
                var oldValue = this._username;
                this._username = value;
                this.onPropertyChanged("username", value, oldValue);
                layouts.Application.beginInvoke(function () {
                    return _this._loginCommand.canExecuteChanged();
                });
            }
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Bridge.Layouts.Sample5.LoginViewModel.prototype, "password", {
        get: function () {
            return this._password;
        },
        set: function (value) {
            if (this._password != value) {
                var oldValue = this._password;
                this._password = value;
                this.onPropertyChanged("password", value, oldValue);
                this._loginCommand.canExecuteChanged();
            }
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Bridge.Layouts.Sample5.LoginViewModel.prototype, "loginCommand", {
        get: function () {
            var _this = this;
            if (this._loginCommand == null)
                this._loginCommand = new layouts.Command(function (cmd, p) { return _this.onLogin(); }, function (cmd, p) { return _this.canLogin(); });
            return this._loginCommand;
        },
        enumerable: true,
        configurable: true
    });

    var $_ = {};
    
    Bridge.ns("Bridge.Layouts.Sample5.LoginViewModel", $_)
    
    Bridge.apply($_.Bridge.Layouts.Sample5.LoginViewModel, {
        f1: function (cmd, p) {
            this.onLogin();
        },
        f2: function (cmd, p) {
            return this.canLogin();
        },
        f3: function () {
            this.loginCommand.canExecuteChanged();
        }
    });
    
    Bridge.define('Bridge.Layouts.Sample5.Page1', {
        inherits: [layouts.controls.Page],
        statics: {
            typeName: "Bridge.Layouts.Sample5.Page1",
            pAGE_DEFINITION: "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n        <Stack Orientation=\"Vertical\" VerticalAlignment=\"Center\" HorizontalAlignment=\"Center\">\r\n         <TextBlock Text=\"{path:username}\" Format=\"Welcome to Page1 user {0}\" Margin=\"8\"/>\r\n         <TextBox Text=\"{path:parameter,twoway}\" Placeholder=\"Parameter for page 2\" Margin=\"8\"/>\r\n         <Button Text=\"Goto Page 2\" Command=\"{path:gotoPage2Command}\" Margin=\"8,16,8,8\"/>\r\n        </Stack>"
        },
        constructor: function () {
            this.initializeComponent();
        },
        initializeComponent: function () {
            var loader = new layouts.XamlReader();
            this.child = loader.Parse(Bridge.Layouts.Sample5.Page1.pAGE_DEFINITION);
        },
        onNavigate: function (context) {
    
            this.dataContext = new Bridge.Layouts.Sample5.Page1ViewModel(this, context.queryString.user);
    
        }
    });
    
    Bridge.define('Bridge.Layouts.Sample5.Page1ViewModel', {
        page1: null,
        v: null,
        constructor: function (page1, v) {
            this.page1 = page1;
            this.v = v;
        }
    });
    
    Bridge.init();
})(this);
