#pragma checksum "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c641cee8302be3f9e054b321551716a8b553ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Create), @"mvc.1.0.view", @"/Views/Items/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\_ViewImports.cshtml"
using CourseWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\_ViewImports.cshtml"
using CourseWork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c641cee8302be3f9e054b321551716a8b553ec", @"/Views/Items/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02632091e196bc08a750dfa69aa0de3fd748461d", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseWork.ViewModels.ItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
  
    ViewData["Title"] = "Create new item";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4>New item</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c641cee8302be3f9e054b321551716a8b553ec5764", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1c641cee8302be3f9e054b321551716a8b553ec6069", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CollectionId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                                                   WriteLiteral(Model.CollectionId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"Name\" class=\"control-label\"></label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1c641cee8302be3f9e054b321551716a8b553ec8627", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 17 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c641cee8302be3f9e054b321551716a8b553ec10222", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 18 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"otherFields\" class=\"form-group\">\r\n");
#nullable restore
#line 22 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                   int i = -1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                 foreach (var field in Model.Fields)
                {
                    i++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 904, "\"", 926, 3);
                WriteAttributeValue("", 910, "Fields[", 910, 7, true);
#nullable restore
#line 28 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 917, i, 917, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 919, "].Value", 919, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">");
#nullable restore
#line 28 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                                                                       Write(field.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input");
                BeginWriteAttribute("name", " name=\"", 1001, "\"", 1024, 3);
                WriteAttributeValue("", 1008, "Fields[", 1008, 7, true);
#nullable restore
#line 29 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1015, i, 1015, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1017, "].Value", 1017, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("type", " type=\"", 1025, "\"", 1043, 1);
#nullable restore
#line 29 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1032, field.Type, 1032, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                        <input");
                BeginWriteAttribute("name", " name=\"", 1100, "\"", 1122, 3);
                WriteAttributeValue("", 1107, "Fields[", 1107, 7, true);
#nullable restore
#line 30 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1114, i, 1114, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1116, "].Type", 1116, 6, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1137, "\"", 1156, 1);
#nullable restore
#line 30 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1145, field.Type, 1145, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input");
                BeginWriteAttribute("name", " name=\"", 1192, "\"", 1214, 3);
                WriteAttributeValue("", 1199, "Fields[", 1199, 7, true);
#nullable restore
#line 31 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1206, i, 1206, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1208, "].Name", 1208, 6, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1229, "\"", 1248, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
WriteAttributeValue("", 1237, field.Name, 1237, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" id=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
#nullable restore
#line 43 "C:\Users\User\Desktop\курсач\2 Коллекции\CourseWork\CourseWork\Views\Items\Create.cshtml"
                    await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<LangResource> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseWork.ViewModels.ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591