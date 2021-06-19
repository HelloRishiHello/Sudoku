<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Scripts1/jquery-ui.css" rel="stylesheet" />
    <link href="Bootstrap1/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts1/jquery.3.6.0.js"></script>
    <script src="Scripts1/jquery-ui.js"></script>
    <script>
        $(function () {
            $('#textbox1').datepicker(
            {
                dateFormat: 'dd/M/yy',
                changeMonth: true,
                changeYear: true,
                yearRange: '1950:2100'
            });

            $('#textbox2').datepicker(
            {
                dateFormat: 'dd/M/yy',
                changeMonth: true,
                changeYear: true,
                yearRange: '1950:2100'
            });
        });

        $(document).ready(function () {
            //debugger;
            $.ajax({
                type: "POST",
                url: "WebService1.asmx/getdropdown",
                data: "",
                success: function (data) {
                    var s = '<option value="-1">ALL</option>';
                    var d = [];
                    d = JSON.parse(data.children[0].textContent).Table;
                    for (var i = 0; i <= d.length - 1; i++) {
                        s += '<option value="' + d[i].DEPTCODE + '">' + d[i].DEPTNAME + '</option>';
                    }
                    $("#deptdropdown").html(s);
                }
            })


            $("input[id$='submitbutton']").click(function () {
                //debugger;
                $('table').empty();
                $('table').append('<thead><tr><th>DEPTCODE</th><th>PATIENTSCOUNT</th><th>NOTCONSULTED</th><th>CONSULTED</th><th>PAYING</th><th>CMPCREDIT</th>' +
                    '<th>SUPER</th><th>GEN</th><th>MALE</th><th>FEMALE</th><th>INSURANCE</th><th>SCHEME</th><th>CORPORATE</th><th>EHS</th><th>COVGOVT</th><th>ASP</th>' +
                    '</tr></thead>');
                $.ajax({
                    type: "POST",
                    //url: "WebService1.asmx/getdata",
                    url: "http://localhost:58048/api/Rishi/Data/CAR/01-Feb-2021/18-feb-2021",
                    //data: JSON.stringify({ dept_code: $("#deptdropdown").val(), from_date: $("#textbox1").val(), to_date: $("#textbox2").val() }),
                    data: "",
                    contentType: "application/json;charset=utf-8",
                    success: function (response) {
                        var data = JSON.parse(response.d).Table;
                        var tr;
                        //debugger;
                        for (var i = 0; i <= data.length - 1; i++)
                        {
                            //data = tr.append("<td>" + data[i] + "</td>");
                            //.find("").text());

                            tr = $('<tr/>');
                            tr.append("<td>" + data[i].DEPTCODE + "</td>");
                            tr.append("<td>" + data[i].PATIENTSCOUNT + "</td>");
                            tr.append("<td>" + data[i].NOTCONSULTED + "</td>");
                            tr.append("<td>" + data[i].CONSULTED + "</td>");
                            tr.append("<td>" + data[i].PAYING + "</td>");
                            tr.append("<td>" + data[i].CMPCREDIT + "</td>");
                            tr.append("<td>" + data[i].SUPER + "</td>");
                            tr.append("<td>" + data[i].GEN + "</td>");
                            tr.append("<td>" + data[i].MALE + "</td>");
                            tr.append("<td>" + data[i].FEMALE + "</td>");
                            tr.append("<td>" + data[i].INSURANCE + "</td>");
                            tr.append("<td>" + data[i].SCHEME + "</td>");
                            tr.append("<td>" + data[i].CORPORATE + "</td>");
                            tr.append("<td>" + data[i].EHS + "</td>");
                            tr.append("<td>" + data[i].COVGOVT + "</td>");
                            tr.append("<td>" + data[i].ASP + "</td>");
                            $('table').append(tr);
                        }
                    }
                })

            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label ID="fromlabel" class=" col-form-label" runat="server" Text="From Date"></asp:Label>
                    <asp:TextBox Class="form-control" ID="textbox1" runat="server" AutoCompleteType="Disabled" PlaceHolder="Select Date"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="Label2" class="col-form-label" runat="server" Text="To Date"></asp:Label>
                    <asp:TextBox class="form-control " ID="textbox2" runat="server" AutoCompleteType="Disabled" PlaceHolder="Select Date"></asp:TextBox>
                </div>
                <div class="form-group col">
                    <%--<asp:DropDownList ID="deptdropdown" runat="server" DataTextField="<%# Eval("deptcode") %>" DataValueField="<%# Eval("deptname") %>">
                    </asp:DropDownList>--%>
                    <asp:DropDownList ID="deptdropdown" class="btn btn-secondary dropdown-toggle" runat="server" DataTextField="deptname" DataValueField="deptcode"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <%--<asp:Button  ID="submitbutton"  class="btn btn-primary" runat="server" Text="Submit" />--%>
                <input type="button" id="submitbutton" class="btn btn-primary" value="Submit" />
            </div>
        </div>
        <table class="table table-bordered table-condensed table-hover table-striped">
            
            <tbody></tbody>
        </table>
    </form>
</body>
</html>
