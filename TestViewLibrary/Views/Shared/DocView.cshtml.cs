//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RazorEngine.Dynamic {
    
    
    public class DocView : RazorEngine.Templating.TemplateBase<TW.PDF.DocSection> {
        
#line hidden

        
        public DocView() {
        }
        
        public override void Execute() {
            this.Clear();

Write(model);

WriteLiteral(" TW.PDF.DocSection\r\n<div>\r\n    <h1>");


   Write(Model.Title);

WriteLiteral("</h1>\r\n    <div>");


    Write(Model.Content);

WriteLiteral("</div>\r\n");


     foreach (var s1 in Model.SubSections)
    { 

WriteLiteral("        <h2>");


       Write(s1.SectionNumber);

WriteLiteral(". ");


                          Write(s1.Title);

WriteLiteral("</h2>\r\n");



WriteLiteral("        <div>");


        Write(s1.Content);

WriteLiteral("</div>\r\n");


        foreach (var s2 in s1.SubSections)
        { 

WriteLiteral("        <h3>");


       Write(s2.SectionNumber);

WriteLiteral(". ");


                          Write(s2.Title);

WriteLiteral("</h3>\r\n");



WriteLiteral("        <div>");


        Write(s2.Content);

WriteLiteral("</div>\r\n");


        }
    }

WriteLiteral("\r\n</div>\r\n");


        }
    }
}
