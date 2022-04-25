 <div class="page-wrapper">
        <!-- Bread crumb and right sidebar toggle -->
        <!-- ============================================================== -->
           
                  


        <div class="page-breadcrumb">
            <div class="row">
                <div class="col-12 d-flex no-block align-items-center">
                    <h4 class="page-title">PRODUCT</h4>
                    <div class="ms-auto text-end">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><a href="DEFAULT.aspx">Home</a></li>
                                <li class="breadcrumb-item active" aria-current="page">HOME
                                </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End Bread crumb and right sidebar toggle -->
         <%--<div class="btn-back_to_top">
    <span class="ti-arrow-up"></span>
  </div>--%>

        <div class="container-fluid">
            <div class="card" id="divView">
                 <div class="border-top">
                    <div class="card-body">
                        <button type="button" class="btn btn-primary" onclick="AddNewEntry();" style="float:right;">
                            Add New                                       
                        </button>
                    </div>
                </div>
              
                <div class="table-responsive">
                      <div class="card">
                <div class="card-body">
                  <h5 class="card-title">Product Record</h5>
                  <div class="table-responsive">
                    <table class="table table-striped table-bordered" id="tblData">
                        <thead>
                            <tr>
                                <th>Action</th>
                                <th>PRODUCT NAME</th>
                               <%-- <th>BRAND</th>--%>
                                <th>CATEGORY</th>
                                <th>COST</th>
                                <th>QUNTIT</th>
                                <th>DATE</th>

                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
                    </div></div></div>
            </div>
            <div class="card" id="divEntry" style="display: none;">
                <div class="border-top">
                    <div class="card-body">
                        <button type="button" class="btn btn-primary" onclick="ViewEntry();" style="float: right;">
                            View                                       
                        </button>
                    </div>
                </div>
                <form class="form-horizontal">
                    <div class="card-body">
                        <%--<h4 class="card-title">PRODUCT</h4>--%>
                        <div class="form-group row">
                            <%-- <label
                        class="col-sm-3 text-end control-label col-form-label"
                        >PRODUCT ID</label
                      >--%>
                            <div class="col-sm-9">
                                <input
                                    type="hidden"
                                    class="form-control"
                                    id="PID"
                                    placeholder="CATEGORY ID Here" disabled />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label
                                class="col-sm-2 text-end control-label col-form-label">
                              PRODUCT  NAME</label>
                               <div class="col-sm-6">
                                    <input
                                    type="text"
                                    class="form-control"
                                    id="ddlPRODUCT"
                                         style="text-transform:uppercase"
                                    placeholder="NAME" />
                                <%--<select class="select2 form-select shadow-none"
                                    style="width: 100%; height: 36px" id="ddlPRODUCT">
                                </select>--%>
                            </div>
                        </div>
                        
                        <div class="form-group row">
                            <label
                                for="Category"
                                class="col-sm-2 text-end control-label col-form-label">
                                Category</label>
                            <div class="col-sm-6">
                                <select class="form-control" id="ddlcategory" onchange="BindBRAND();"></select>
                            </div>
                        
                          <div class="col-sm-3">
                            <div class="box-tools pull-left" id="divbuttonAdd">
                                <a href="#" onclick="AddNewItem();">
                                    <i class="fa fa-plus fa-2x"></i></a>
                            </div>

                          </div></div>
                         <div class="form-group row">
                            <label
                                for="lname"
                                class="col-sm-2 text-end control-label col-form-label">
                                Branad</label>
                            <div class="col-sm-6">
                                <select class="form-control" id="ddlbrand"></select>
                            </div>
                              <div class="col-sm-3">
                            <div class="box-tools pull-left" id="divbuttonAdd">
                                <a href="#" onclick="AddNewItem1();">
                                    <i class="fa fa-plus fa-2x"></i></a>
                            </div></div>
                        </div>
                        <div class="form-group row">
                            <label class="col-sm-2 text-end control-label col-form-label">QUNTITY</label>
                            <div class="col-sm-6">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="QUNTITY"
                                    placeholder="" />
                            </div>
                        </div>
                        <br />
                         <div class="form-group row">
                             <label
                                class="col-sm-2 text-end control-label col-form-label">
                                I/O Entry</label>
                            <div class="col-sm-6">
                                   <select class="form-control" id="IOENT">
                                       <option value="i">IN</option>
                                       <option value="o">OUT</option>
                                   </select>
                            </div>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label
                                class="col-sm-2 text-end control-label col-form-label">
                                COST</label>
                            <div class="col-sm-6">
                                <input
                                    type="number"
                                    class="form-control"
                                    id="txtcost" />
                            </div>
                        </div>
                       
                        <div class="form-group row">
                            <label
                                class="col-sm-2 text-end control-label col-form-label">
                                Date</label>
                            <div class="col-sm-6">
                                <input
                                    type="date"
                                    class="form-control"
                                    id="date"
                                    placeholder="date" />
                            </div>
                        </div>
                    <div class="form-group row">
                            <label class="col-sm-2 text-end control-label col-form-label">Dicription</label>
                            <div class="col-sm-6">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="Discription"
                                    placeholder="DISCRIPTION" />
                            </div>
                        </div>
                        <div class="border-top">
                            <div class="card-body">
                                <button type="button" id="btnSave" style="display: none;" class="btn btn-success" onclick="CallClientToServer();">
                                    Submit
                                </button>
                                <button type="button" id="btnUpdate" style="display: none;" class="btn btn-primary" onclick="Callupdate();">
                                    UPDATE
                                </button>
                                <button type="button" id="btnDelete" style="display: none;" class="btn btn-danger" onclick="CALLDELETE();">
                                    DELETE
                                </button>
                                <button type="button" id="btnCancel" style="display: none;" class="btn btn-warning" onclick="CANCLEENTRY();">
                                    Cancel
                                </button>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>

      <div class="modal fade" id="divItemMultiModal" tabindex="-1" role="dialog" aria-labelledby="forgotLabel" data-backdrop="static">
          <uc1:CATEGORYBIND runat="server" ID="CATEGORYBIND" />
          </div>
     <div class="modal fade" id="divItemMultiModal1" tabindex="-1" role="dialog" aria-labelledby="forgotLabel" data-backdrop="static">
         <uc1:BRAND runat="server" ID="BRAND" />
            </div>
   
    

    <%--<link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.css" rel="stylesheet">--%>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <%--   <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css">

    <script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#divItemMultiModal').on('shown.bs.modal', function (e) {
                $("#txtItem").focus();
            });
            $('#divItemMultiModal').on('hidden.bs.modal', function (e) {
                $("#btnAddNewMItem").focus();
            });
        });
        function AddNewItem() {
            $("#divItemMultiModal").modal("show");
        }
        function AddNewItem1() {
            $("#divItemMultiModal1").modal("show");
        }
        function Addbrand() {
            $("#divItemMultiModal2").modal("show");
        }
        function AddItemCancel() {
            $("#divItemMultiModal").modal("hide");
            ClearItemControl();
            $("#btnAddNewMItem").focus();
        }
        function AddItemCancel1() {
            $("#divItemMultiModal2").modal("hide");
            ClearItemControl();
            $("#btnAddNewMItem2").focus();
        }
        function ClearItemControl() {
            $("#txtItem").val("");
            $("#txtRate").val("0.00");
        }
        function ShowNewRefPopup() {
            $("#category").modal("show");
            $("#category").focus();
        }

        function CANCLEENTRY() {
            $("#divView").show();
            $("#divEntry").hide();
        }


        $(document).ready(function () {
            Bindcategory();

        });

        function AddNewEntry() {
            $("#divView").hide();
            $("#divEntry").show();
            $("#txtname").val('');
            $("#Discription").val('');
            $("#ddlcategory").val('');
            $("#txtcost").val('');
            $("#QUNTITY").val('');
            $("#IOENT").val('');
            $("#ddlbrand").val('');
            $("#date").val('');
            $("#PID").val('PID');
            $("#btnCancel").show();
            $("#btnSave").show();
            $("#btnUpdate").hide();
            $("#btnDelete").hide();
            
        }
        function ViewEntry() {
            $("#divView").show();
            $("#divEntry").hide();
        }
        function CANCLEENTRY() {
            $("#divView").show();
            $("#divEntry").hide();
        }


        function Bindcategory() {

            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/Getcategory",
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                async: true,
                success: function (response) {
                    var ddl = $("#ddlcategory").empty();
                    $(ddl).append("<option value=''>--Select--</option>");
                    $(response.d).find("tblData").each(function () {
                        $(ddl).append("<option value='" + $(this).find("CID").text() + "'>" + $(this).find("CNAME").text() + "</option>");
                    })
                },
                failure: function (response) {

                }
            });
        }
        $(document).ready(function () {

            BindPRODUCT();

        });
        function BindPRODUCT() {

            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/GetPRODUCT",
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                async: true,
                success: function (response) {
                    var ddl = $("#ddlPRODUCT").empty();
                    $(ddl).append("<option value=''>--Select Product Here--</option>");
                    $(response.d).find("tblData").each(function () {
                        $(ddl).append("<option value='" + $(this).find("PID").text() + "'>" + $(this).find("PNAME").text() + "</option>");
                    })
                },
                failure: function (response) {

                }
            });
        }
        function BindBRAND() {

            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/GetBRAND",
                data: JSON.stringify({ CATEGORY: $("#ddlcategory").val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                async: false,
                success: function (response) {
                    var ddl = $("#ddlbrand").empty();
                    $(ddl).append("<option value=''>--Select--</option>");
                    $(response.d).find("tblData").each(function () {
                        $(ddl).append("<option value='" + $(this).find("CATEGORY").text() + "'>" + $(this).find("BNAME").text() + "</option>");
                    })
                },
                failure: function (response) {

                }
            });
        }


        function CallClientToServer() {
            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/Save",
                data: JSON.stringify({ USERID: '<%=HttpContext.Current.Session["PRIYALUSERID"].ToString()%>', PNAME: $("#ddlPRODUCT").val(), DISCRIPTION: $("#Discription").val(), CATEGORY: $("#ddlcategory").val(), COST: $("#txtcost").val(), BRAND: $("#ddlbrand").val(), DATE: $("#date").val(), IOENT: $("#IOENT").val(), QUNTITY: $("#QUNTITY").val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccess(response) {
            location.reload();
            alert(response.d);

        }








        function GETALL() {
            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/GetAll",

                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                //data: postdata,
                success: function (response) {
                    var datatable = $("#tblData tbody").empty();
                    $(response.d).find("tblData").each(function () {

                        var PNAME = $(this).find("PNAME").text();
                        var DISCRIPTION = $(this).find("DISCRIPTION").text();
                        var CATEGORY = $(this).find("CNAME").text();
                        var PRICE = $(this).find("PRICE").text();
                        var BRAND = $(this).find("BNAME").text();
                        var IOENT = $(this).find("IOENT").text();
                        
                        var QUNTITY = $(this).find("QUNTITY").text();
                        var DATE = $(this).find("DATE").text();
                        var PID = $(this).find("PID").text();
                        var viewbtn = "<input type='button'  onclick='GETDETAIL(\"" + PID + "\")' class='btn btn-secondary btn-sm' value='View'>";

                        var row = $("<tr><td>" + viewbtn + "</td><td>" + PNAME + "</td><td>" + CATEGORY + "</td><td>" + PRICE + "</td><td>" + QUNTITY + "</td><td>" + DATE + "</td></tr>")
                        $(datatable).append(row);
                    });
                },
                failure: function (response) {

                }
            });
        }


        function GETDETAIL(_PID) {
            $("#divView").hide();
            $("#divEntry").show();
            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/GETDETAIL",
                data: JSON.stringify({ PID: _PID }),
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                //data: postdata,
                success: function (response) {
                    $(response.d).find("tblData").each(function () {

                        var PNAME = $(this).find("PNAME").text();
                        var DISCRIPTION = $(this).find("DISCRIPTION").text();
                        var CATEGORY = $(this).find("CATEGORY").text();
                        var COST = $(this).find("PRICE").text();
                        var BRAND = $(this).find("BRAND").text();
                        var QUNTITY = $(this).find("QUNTITY").text();
                        var IOENT = $(this).find("IOENT").text();
                        var DATE = $(this).find("DATE").text();
                        var PID = $(this).find("PID").text();
                        if (PID == "0") {
                            $("#btnSave").show();
                            $("#btnUpdate").hide();
                            $("#btnCancel").show();

                        }
                        else {
                            $("#btnSave").hide();
                            $("#btnUpdate").show();
                            $("#btnCancel").show();
                            $("#btnDelete").show();
                        }
                        $("#ddlPRODUCT").val(PNAME);
                        $("#Discription").val(DISCRIPTION);
                        $("#ddlcategory").val(CATEGORY);
                        BindBRAND();
                        $("#QUNTITY").val(QUNTITY);
                        $("#IOENT").val(IOENT);
                        $("#txtcost").val(COST);
                        $("#ddlbrand").val(BRAND);
                        $("#date").val(DATE);
                        $("#PID").val(PID);
                    });
                },
                failure: function (response) {

                }
            });
        }

        function Callupdate() {
            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/UPDATE",
                data: JSON.stringify({ PID: $("#PID").val(), USERID: '<%=HttpContext.Current.Session["PRIYALUSERID"].ToString()%>', PNAME: $("#ddlPRODUCT").val(), DISCRIPTION: $("#Discription").val(), CATEGORY: $("#ddlcategory").val(), COST: $("#txtcost").val(), BRAND: $("#ddlbrand").val(), DATE: $("#date").val(), IOENT: $("#IOENT").val(), QUNTITY: $("#QUNTITY").val(), }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccess(response) {

            alert(response.d);
            location.reload();
        }

        function CALLDELETE() {
            $.ajax({
                type: "POST",
                url: "PRODUCT.aspx/DELETE",
                data: JSON.stringify({ PID: $("#PID").val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                    GETALL();
                    $("#PID").val(), '<%=HttpContext.Current.Session["PRIYALUSERID"].ToString()%>', $("#ddlPRODUCTs").val(), $("#Discription").val(), $("#ddlcategory").val(), $("#txtcost").val(), $("#ddlbrand").val(), $("#date").val()
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccess(response) {
            alert(response.d);
            location.reload();
        }


    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            GETALL();
        });
    </script>
  
