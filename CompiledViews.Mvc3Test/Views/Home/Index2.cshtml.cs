//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompiledViews.Mvc3Test.Views.Home {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    
    public class Index2 : CompiledViews.Mvc.CompiledViewPage<CompiledViews.Mvc3Test.Models.HomeModel> {
        
#line hidden

        
        public Index2() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

  
    ViewBag.Title = "Index2";


WriteLiteral("\r\n<h2>Index 2</h2> \r\n\r\nTest Property: ");


          Write(Model.TestProperty);

WriteLiteral("\r\nTest Property: ");


          Write(Model.TestProperty);

WriteLiteral("\r\n\r\n");


DefineSection("Section1", () => {

WriteLiteral("\r\n\r\nThis is a test section 2\r\n\r\n");


});


        }
    }
}