//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smartdocs {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("D:\\mobileapp2\\mobileapp\\Smartdocs\\View\\Login.xaml")]
    public partial class Login : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator indicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Smartdocs.EntryExt companyid;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Smartdocs.EntryExt username;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry password;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button loginButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Login));
            indicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "indicator");
            companyid = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Smartdocs.EntryExt>(this, "companyid");
            username = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Smartdocs.EntryExt>(this, "username");
            password = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "password");
            loginButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "loginButton");
        }
    }
}
