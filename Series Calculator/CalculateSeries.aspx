<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateSeries.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="Series_Calculator.CalculateSeries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Series Calculator</title>
    <!-- Bootstrap Css -->
    <link href="css/bootstrap.min.css" type="text/css" rel="Stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/animate.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link href="css/default.css" rel="stylesheet" type="text/css" />
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-custom">
    <form id="form2" runat="server">
        <div id="preloader">
            <div id="load">
            </div>
        </div>
        <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header page-scroll">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                        <i class="fa fa-bars"></i>
                    </button>
                    <a class="navbar-brand" href="CalculateSeries.aspx">
                        <h1>Series Calculator</h1>
                    </a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#feature">Home</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container -->
        </nav>
        <!-- Section: intro -->
        <section id="intro" class="intro">

            <div class="slogan">
                <h4>WELCOME TO <span class="text_color">Series Calculator</span> </h4>
            </div>
            <div class="page-scroll">
                <a href="#feature" class="btn btn-circle">
                    <i class="fa fa-angle-double-down animated"></i>
                </a>
            </div>
        </section>
        <!-- /Section: intro -->
        <section id="feature">
            <div class="row">
                <div class="col-lg-8">
                    <div class="boxed-grey">
                        <form id="feature-form">
                            <div class="row">
                                <div class="col-md-10">
                                    <div class="form-group">
                                        <asp:Label ID="lb_num" runat="server" Text="Enter Number" CssClass="labelnew"></asp:Label>
                                        <asp:TextBox ID="txt_userInput" runat="server" CssClass="form-control" placeholder="Enter a number" required="required"></asp:TextBox>
                                    </div>

                                    <div class="col-md-12">
                                        <asp:Button runat="server" CssClass="btn btn-skin pull-right" ID="bt_generateSeries" Text="Generate List" OnClick="bt_generateSeries_Click" OnClientClick="return validateTextBox();" />
                                    </div>

                                </div>
                            </div>
                        </form>
                    </div>
                </div>

            </div>
            <br />

            <div class="row marginbot-1 ">
                <div class="col-md-10">
                    <strong>
                        <asp:Label ID="lb_Series1" runat="server" Text="" CssClass="labelnew"></asp:Label></strong>
                </div>
            </div>
            <div class="row marginbot-2">
                <div class="col-md-10">
                    <asp:Literal ID="lt_Series1" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="row marginbot-1">
                <div class="col-md-10">
                    <strong><asp:Label ID="lb_Series2" runat="server" Text="" CssClass="labelnew"></asp:Label></strong>
                </div>
            </div>
            <div class="row marginbot-2">
                <div class="col-md-10">
                    <asp:Literal ID="lt_Series2" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="row marginbot-1">
                <div class="col-md-10">
                    <strong><asp:Label ID="lb_Series3" runat="server" Text="" CssClass="labelnew"></asp:Label></strong>
                </div>
            </div>
            <div class="row marginbot-2">
                <div class="col-md-10">
                    <asp:Literal ID="lt_Series3" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="row marginbot-1">
                <div class="col-md-10">
                    <strong><asp:Label ID="lb_Series4" runat="server" Text="" CssClass="labelnew"></asp:Label></strong>
                </div>
            </div>
            <div class="row marginbot-2">
                <div class="col-md-10">
                    <asp:Literal ID="lt_Series4" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="row marginbot-1">
                <div class="col-md-10">
                    <strong><asp:Label ID="lb_Series5" runat="server" Text="" CssClass="labelnew"></asp:Label></strong>
                </div>
            </div>
            <div class="row marginbot-2">
                <div class="col-md-10">
                    <asp:Literal ID="lt_Series5" runat="server"></asp:Literal>
                </div>
            </div>

        </section>
        <!--/#feature-->


        <footer>
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-12">
                        <div class="wow shake" data-wow-delay="0.4s">
                            <div class="page-scroll marginbot-30">
                                <a href="#intro" id="totop" class="btn btn-circle">
                                    <i class="fa fa-angle-double-up animated"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!-- Core JavaScript Files -->
        <script type="text/javascript">

            function validateTextBox() {
                var textBox = document.getElementById('<%=txt_userInput.ClientID%>');
                if (textBox.value == "") {
                    bootbox.alert(" Please enter a number");
                    return false;
                }
                return true;
            }
        </script>
        <script src="js/jquery.min.js" type="text/javascript"></script>
        <script src="js/bootstrap.min.js" type="text/javascript"></script>
        <script src="js/jquery.easing.min.js" type="text/javascript"></script>
        <script src="js/jquery.scrollTo.js" type="text/javascript"></script>
        <script src="js/wow.min.js"></script>
        <script src="js/bootbox.min.js"></script>
        <!-- Custom Theme JavaScript -->
        <script src="js/custom.js" type="text/javascript"></script>
    </form>
</body>




</html>
