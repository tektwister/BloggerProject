<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="BloggerProject.register" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Blog</title>
    <!-- Favicon -->
    <link href="./assets/img/brand/favicon.png" rel="icon" type="image/png">
    <!-- Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet">
    <!-- Icons -->
    <link href="./assets/vendor/nucleo/css/nucleo.css" rel="stylesheet">
    <link href="./assets/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- Argon CSS -->
    <link type="text/css" href="./assets/css/argon.css?v=1.0.1" rel="stylesheet">
    <!-- Docs CSS -->
    <link type="text/css" href="./assets/css/docs.min.css" rel="stylesheet">
</head>

<body>
    <header class="header-global">
        <nav id="navbar-main" class="navbar navbar-main navbar-expand-lg navbar-transparent navbar-light headroom" style="background-color: #141B46">
            <div class="container">
                <a class="navbar-brand mr-lg-6" href="./landing.aspx">
                    <!--<img src="">-->
                    <b style:"color:white"><h4>Blog</h4></b>
                </a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbar_global" aria-controls="navbar_global" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse" id="navbar_global">
                    <div class="navbar-collapse-header">
                        <div class="row">
                            <div class="col-6 collapse-brand">
                                <a href="./landing.aspx">
                                    <!--<img src="">-->
                                    <b style:"color:white"><h4>Blog</h4></b>
                                </a>
                            </div>
                            <div class="col-6 collapse-close">
                                <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbar_global" aria-controls="navbar_global" aria-expanded="false" aria-label="Toggle navigation">
                                    <span></span>
                                    <span></span>
                                </button>
                            </div>
                        </div>
                    </div>
                    <ul class="navbar-nav navbar-nav-hover align-items-lg-center">
                        <li class="nav-item dropdown">
                            <a href="#" class="nav-link" data-toggle="dropdown" href="#" role="button">
                                <i class="ni ni-ui-04 d-lg-none"></i>
                                <span class="nav-link-inner--text"><b>Feed</b></span>
                            </a>
                            <div class="dropdown-menu dropdown-menu-xl">
                                <div class="dropdown-menu-inner">
                                    <a href="./profile.aspx" class="media d-flex align-items-center">
                                        <div class="icon icon-shape bg-gradient-primary rounded-circle text-white">
                                            <i class="ni ni-spaceship"></i>
                                        </div>
                                        <div class="media-body ml-3">
                                            <h6 class="heading text-primary mb-md-1">Profile</h6>
                                            <p class="description d-none d-md-inline-block mb-0">Click this link to view your profile</p>
                                        </div>
                                    </a>
                                    <a href="./newform.aspx" class="media d-flex align-items-center">
                                        <div class="icon icon-shape bg-gradient-success rounded-circle text-white">
                                            <i class="ni ni-palette"></i>
                                        </div>
                                        <div class="media-body ml-3">
                                            <h6 class="heading text-primary mb-md-1">New Feed</h6>
                                            <p class="description d-none d-md-inline-block mb-0">Click to add a feed</p>
                                        </div>
                                    </a>
                                    <a href="./landing.aspx" class="media d-flex align-items-center">
                                        <div class="icon icon-shape bg-gradient-warning rounded-circle text-white">
                                            <i class="ni ni-ui-04"></i>
                                        </div>
                                        <div class="media-body ml-3">
                                            <h5 class="heading text-warning mb-md-1">Feed</h5>
                                            <p class="description d-none d-md-inline-block mb-0">Click to view others feed</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <ul class="navbar-nav align-items-lg-center ml-lg-auto">

                        <li class="nav-item d-none d-lg-block ml-lg-4">
                            <a href="./login.aspx" class="btn btn-neutral btn-icon">
                                <span class="btn-inner--icon">
                                    <i class="fa mr-2"></i>
                                </span>
                                <span class="nav-link-inner--text">Log in</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <!--</header>-->
        <main>
            <section class="section section-shaped section-lg">
                <div class="shape shape-style-1 bg-gradient-default">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                </div>
                <div class="container pt-lg-md">
                    <div class="row justify-content-center">
                        <div class="col-lg-5">
                            <div class="card bg-secondary shadow border-0">
                                <div class="card-body px-lg-5 py-lg-5">
                                    <div class="text-center text-muted mb-4">
                                        <h5>Sign Up</h5>
                                    </div>
                                    <form role="form" runat="server" id="f1">
                                        <div class="form-group">
                                            <div class="input-group input-group-alternative mb-3">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="ni ni-hat-3"></i></span>
                                                </div>
                                                <input class="form-control" placeholder="Name" type="text" id="name" runat="server">
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group input-group-alternative mb-3">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="ni ni-hat-3"></i></span>
                                                </div>
                                                <input class="form-control" placeholder="Profession" type="text" id="prof" runat="server">
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group input-group-alternative mb-3">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="ni ni-email-83"></i></span>
                                                </div>
                                                <input class="form-control" placeholder="Email" type="email" id="mail" runat="server">
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group input-group-alternative">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="ni ni-lock-circle-open"></i></span>
                                                </div>
                                                <input class="form-control" placeholder="Password" type="password" id="pass" runat="server">
                                            </div>
                                        </div>
                                        <div class="row my-4">
                                            <div class="col-12">
                                                <div class="custom-control custom-control-alternative custom-checkbox">
                                                    <input class="custom-control-input" id="customCheckRegister" type="checkbox">
                                                    <label class="custom-control-label" for="customCheckRegister">
                                                        <span>I agree with the
                           
                                                            <a href="#">Privacy Policy</a>
                                                        </span>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="text-center">
                                            <asp:Button ID="Button1" runat="server" Text="Create account" class="btn btn-primary mt-4" OnClick="Registering_User"
                                                />
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </main>
        <footer class="footer has-cards">
            <div class="container">
                <hr>
                <div class="row align-items-center justify-content-md-between">
                    <div class="col-md-6">
                        <div class="copyright">
                            &copy; 2018 Techietoasts
         
                        </div>
                    </div>
                    <div class="col-md-6">
                        <ul class="nav nav-footer justify-content-end">
                            <li class="nav-item">
                                <a href="./landing.aspx" class="nav-link" target="_blank">Blog</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </footer>
        <!-- Core -->
        <script src="./assets/vendor/jquery/jquery.min.js"></script>
        <script src="./assets/vendor/popper/popper.min.js"></script>
        <script src="./assets/vendor/bootstrap/bootstrap.min.js"></script>
        <script src="./assets/vendor/headroom/headroom.min.js"></script>
        <!-- Argon JS -->
        <script src="./assets/js/argon.js?v=1.0.1"></script>
</body>

</html>