#pragma checksum "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65875e260aa82224ff48e5e3c621eb2a59b3decf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\_ViewImports.cshtml"
using EFMigrationsSqlLiteMiniMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\_ViewImports.cshtml"
using EFMigrationsSqlLiteMiniMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65875e260aa82224ff48e5e3c621eb2a59b3decf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619f6d7a867ebf26ea96ded9352f15c07f236fe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViewProduct>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65875e260aa82224ff48e5e3c621eb2a59b3decf3582", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65875e260aa82224ff48e5e3c621eb2a59b3decf4548", async() => {
                WriteLiteral(@"
    <div>
        <script>
            function AddPerson() {
                let Name = $('#ProductName').val()
                let Price = $('#Price').val();
                let Cattegory = $('#Cattegories').val();
                $.post(""/Actions/AddProduct"", { Name: Name, Price: Price, Cattegory: Cattegory })
                    .done(function (data) {
                        if (data != ""Error"" && data != ""Please fill all fields"") {
                            $(""#TableBody"").append(`<tr id=${data.id}><td>${data.id}</td><td id=Name_${data.id}>${data.name}</td><td id=Price_${data.id}>${data.price}</td><td id=Cattegory_${data.id}>${data.cattegory}</td><td><button class=""btn btn-primary"" style=""width:80px"" data-target=""#AddModal"" data-toggle=""modal"" onclick=""EditProduct(${data.id})"">Edit</button> <button class=""btn btn-danger"" style=""width:80px"" onclick=""DeleteProduct(${data.id})"">Delete</button> </td></tr>`);
                            $('#ProductName').val("""")
                            $('");
                WriteLiteral(@"#Price').val("""");
                            $('#Cattegories').val("""");
                            alert(""Product was added successfully"");
                        }
                        else {
                            alert(data);
                        }
                    });
            }
            function DeleteProduct(id) {
                $.post(""/Actions/DeleteProduct"", { ID: id })
                    .done(function (data) { $(`#${id}`).empty() })
            }
            function EditProduct(id) {
                let Name = $(`#Name_${id}`).html();
                let Price = $(`#Price_${id}`).html();
                $('#ProductName').val(Name)
                $('#Price').val(Price);
                $('#Cattegories').val(""selectedIndex"", 0);
                $('#SaveBtn').attr(""onclick"", `Edit(${id})`)
                $('#SaveBtn').html(""Сохранить"");
            }
            function Edit(id) {
                let Name = $('#ProductName').val()
                le");
                WriteLiteral(@"t Price = $('#Price').val();
                let Cattegory = $('#Cattegories').val();
                let CattegoryText = $('#Cattegories option:selected').text();
                $.post(""/Actions/EditProduct"", { ID: id, Name: Name, Price: Price, Cattegory: Cattegory })
                    .done(function (data) {
                        if (data == ""OK"") {
                            $(`#Name_${id}`).html(Name);
                            $(`#Price_${id}`).html(Price);
                            $(`#Cattegory_${id}`).html(CattegoryText);
                            alert(""Product was edited successfully"");
                        }
                        else {
                            alert(""Please fill all fields"");
                        }
                    })
            }
            function Close() {
                $('#SaveBtn').attr(""onclick"", ""AddPerson()"")
                $('#SaveBtn').html(""Добавить"");
            }
        </script>
    </div>
    <table class=""tabl");
                WriteLiteral(@"e text-center"">
        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Price</th>
                <th>Cattegory</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody id=""TableBody"">
");
#nullable restore
#line 76 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr");
                BeginWriteAttribute("id", " id=\"", 3524, "\"", 3537, 1);
#nullable restore
#line 78 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 3529, item.Id, 3529, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 79 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td");
                BeginWriteAttribute("id", " id=\"", 3603, "\"", 3621, 2);
                WriteAttributeValue("", 3608, "Name_", 3608, 5, true);
#nullable restore
#line 80 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 3613, item.Id, 3613, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td");
                BeginWriteAttribute("id", " id=\"", 3663, "\"", 3682, 2);
                WriteAttributeValue("", 3668, "Price_", 3668, 6, true);
#nullable restore
#line 81 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 3674, item.Id, 3674, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 81 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td");
                BeginWriteAttribute("id", " id=\"", 3725, "\"", 3748, 2);
                WriteAttributeValue("", 3730, "Cattegory_", 3730, 10, true);
#nullable restore
#line 82 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 3740, item.Id, 3740, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
                                           Write(item.Cattegory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\" style=\"width:80px\" data-target=\"#AddModal\" data-toggle=\"modal\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3916, "\"", 3947, 3);
                WriteAttributeValue("", 3926, "EditProduct(", 3926, 12, true);
#nullable restore
#line 84 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 3938, item.Id, 3938, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3946, ")", 3946, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</button>\r\n                        <button class=\"btn btn-danger\" style=\"width:80px\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4037, "\"", 4070, 3);
                WriteAttributeValue("", 4047, "DeleteProduct(", 4047, 14, true);
#nullable restore
#line 85 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
WriteAttributeValue("", 4061, item.Id, 4061, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4069, ")", 4069, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 88 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>
    <button style=""width:100%"" class=""btn btn-success"" data-target=""#AddModal"" data-toggle=""modal"">Добавить</button>
    <div class=""modal fade"" id=""AddModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Добавление</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""Close()"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <label>ProductName</label>
                    <input class=""form-control"" placeholder=""ProductName"" id=""ProductName"" name=""ProductName"" required />
                    <label>Price</label>
                    <input type=""nu");
                WriteLiteral("mber\" class=\"form-control\" placeholder=\"Price\" id=\"Price\" name=\"Price\" required />\r\n                    <label>Cattegory</label>\r\n                    ");
#nullable restore
#line 107 "C:\Users\C#Developer\source\repos\EFMigrationsSqlLiteMiniMarket\EFMigrationsSqlLiteMiniMarket\Views\Home\Index.cshtml"
               Write(Html.DropDownList("Cattegories", null, "-Выберите Каттегорию-", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button style=""width:100%"" type=""button"" id=""SaveBtn"" onclick=""AddPerson()"" class=""btn btn-primary"">Добавить</button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViewProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
