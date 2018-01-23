<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IslahGroup.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Islah Group | Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="fdb-block" style="background-image: url(images/mosque.png)">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-12 col-md-6 mb-4 mb-md-0">
                    <img alt="image" class="img-fluid" src="./images/islah_logo.png">
                </div>
                <div class="col-12 col-md-6 col-lg-5 ml-md-auto text-left">
                    <h1 class="cssanimation fadeInRight">Slogan Or Text</h1>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt 
					ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut 
					aliquip ex ea commodo consequat.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <section class="fdb-block" id="about-us">
        <div class="container">
            <div class="row justify-content-center pb-5">
                <div class="col-12 text-center">
                    <h1>About Us</h1>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt 
					ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut 
					aliquip ex ea commodo consequat.<a href="https://www.froala.com">Lorem ipsum</a>.
                    </p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="Images/landing_page/boss.png">
                </div>
                <div class="col-12 col-md-5 m-md-auto" data-scrolly-down="moveFromRight, iteration-count:1">
                    <h2><strong>Message From Chairman</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5 m-md-auto order-md-5" data-scrolly-down="moveFromRight, iteration-count:1">
                    <img alt="image" class="img-fluid" src="Images/landing_page/boss.png">
                </div>
                <div class="col-12 col-md-5" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <h2><strong>Message From Founder</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5">
                <div class="col-4 col-md-5" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="Images/landing_page/boss.png">
                </div>
                <div class="col-12 col-md-5 m-md-auto" data-scrolly-down="moveFromRight, iteration-count:1">
                    <h2><strong>Message From CEO</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <section class="fdb-block" id="about-us">
        <div class="container">
            <div class="row text-center justify-content-center">
                <div class="col-8">
                    <h1>Image Gallery</h1>
                </div>
            </div>
            <div class="row text-center pb-5">
                <div class="container">
                    <div id="carouselExampleIndicators" class="carousel slide" data-interval="2000" data-ride="carousel" data-wrap="true">
                        <ol class="carousel-indicators">
                            <li data-target="#carouselExampleIndicators" data-slide-to="0"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner" role="listbox">
                            <div class="carousel-item">
                                <img class="d-block w-100" src="https://farm5.static.flickr.com/4616/39774184942_b080697566_b.jpg" alt="First slide">
                            </div>
                            <div class="carousel-item active">
                                <img class="d-block w-100" src="https://farm5.static.flickr.com/4764/39785687112_37a9be0880_b.jpg" alt="Second slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block w-100" src="https://farm5.static.flickr.com/4666/39817646841_be5de2332a_b.jpg" alt="Third slide">
                            </div>
                        </div>
                        <a class="carousel-control-prev" id="prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" id="nex" href="#carouselExampleIndicators" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="fdb-block team-3 " id="industry-verticals">
        <div class="container">
            <div class="row text-center justify-content-center">
                <div class="col-8">
                    <h1>Industry Verticals</h1>
                </div>
            </div>
            <div class="row-70"></div>
            <div class="row text-center justify-content-center">
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/1.jpg">
                    <h3><strong>TextTiles</strong></h3>
                    <p><em>Founder</em></p>
                </div>
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromRight, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/2.png">

                    <h3><strong>Pharmaceuticals</strong></h3>
                    <p><em>Founder</em></p>
                </div>
            </div>
            <div class="row text-center justify-content-center">
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/3.png">

                    <h3><strong>Ceramics</strong></h3>
                    <p><em>Founder</em></p>
                </div>
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromRight, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/4.png">

                    <h3><strong>Energy</strong></h3>
                    <p><em>Founder</em></p>
                </div>
            </div>
            <div class="row justify-content-center text-center">
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/5.png">

                    <h3><strong>Energy</strong></h3>
                    <p><em>Founder</em></p>
                </div>
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromRight, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/1.jpg">
                    <h3><strong>Ceramics</strong></h3>
                    <p><em>Founder</em></p>
                </div>
            </div>
            <div class="row justify-content-center text-center">
                <div class="col-sm-2 m-sm-auto" data-scrolly-down="moveFromLeft, iteration-count:1">
                    <img alt="image" class="img-fluid" src="images/image1/2.png">
                    <h3><strong>ICT & Media </strong></h3>
                    <p><em>Founder</em></p>
                </div>
            </div>
        </div>
    </section>

    <section class="fdb-block" id="our-services">
        <div class="container">
            <div class="row justify-content-center pb-5">
                <div class="col-12 text-center">
                    <h1>Our Services</h1>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/mosque.png">
                </div>
                <div class="col-12 col-md-5 m-md-auto">
                    <h2><strong>Building Mosques</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5 m-md-auto order-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/hospital.png">
                </div>
                <div class="col-12 col-md-5">
                    <h2><strong>Blood Banks</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5">
                <div class="col-4 col-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/mosque.png">
                </div>
                <div class="col-12 col-md-5 m-md-auto">
                    <h2><strong>Building Madrasha</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5 m-md-auto order-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/shop.png">
                </div>
                <div class="col-12 col-md-5">
                    <h2><strong>Employement</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5">
                <div class="col-4 col-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/donate.png">
                </div>
                <div class="col-12 col-md-5 m-md-auto">
                    <h2><strong>Helping Needy People</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
            <div class="row text-left align-items-center pt-5 pb-md-5">
                <div class="col-4 col-md-5 m-md-auto order-md-5">
                    <img alt="image" class="img-fluid" src="Images/landing_page/donate.png">
                </div>
                <div class="col-12 col-md-5">
                    <h2><strong>Doing Charity Works</strong></h2>
                    <p class="text-h3">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <p><a href="https://www.froala.com">Learn More &gt;</a></p>
                </div>
            </div>
        </div>
    </section>

    <div class="video-gallery fdb-block container">
        <div class="row ">
            <div class="col-12 text-center justify-content-center pb-5">
                <h1 class="p-3">Video Gallery</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
            <div class="col-sm-4 p-1">
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/EqgU3pX9vUA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                </div>
            </div>
        </div>
    </div>

    <section class="fdb-block" id="companies">
        <div class="container">
            <div class="row text-center">
                <div class="col-12">
                    <h1>Our Dedicating Companies</h1>
                </div>
            </div>
            <div class="row text-center justify-content-center mt-5">
                <div class="col-10 col-sm-3">
                    <img alt="image" class="img-fluid" src="images/brand/1.jpg">
                    <h3><strong>Company One</strong></h3>
                </div>
                <div class="col-10 col-sm-3 pt-5 pt-sm-0">
                    <img alt="image" class="img-fluid" src="images/brand/1.jpg">
                    <h3><strong>Company Two</strong></h3>
                </div>
                <div class="col-10 col-sm-3 pt-5 pt-sm-0">
                    <img alt="image" class="img-fluid" src="images/brand/1.jpg">
                    <h3><strong>Company Three</strong></h3>
                </div>
                <div class="col-10 col-sm-3 pt-5 pt-sm-0">
                    <img alt="image" class="img-fluid" src="images/brand/1.jpg">
                    <h3><strong>Company Four</strong></h3>
                </div>
            </div>
        </div>
    </section>

    <section class="fdb-block" style="background-image: url(images/mashjid.jpg)">
        <div class="container">
            <div class="fdb-box">
                <div class="row align-items-center justify-content-center">
                    <div class="col-10 col-sm-6 col-md-4 col-lg-3 col-xl-2 m-auto">
                        <img alt="image" class="img-fluid" src="Images/landing_page/boss.png" />
                    </div>
                    <div class="col-12 col-md-8 ml-auto mr-auto mt-4 mt-md-0">
                        <p class="text-h3">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
					incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
					nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <p class="text-h3 mt-4 mt-lg-5"><strong>Person Name</strong></p>
                        <p><em>Co-founder at Company</em></p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <div class="portfolio-area fdb-block" id="industries">
        <div class="container">
            <div class="row text-center">
                <div class="col-12">
                    <h1>Our Industries</h1>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-12">
                    <div class="filter-menu">
                        <div class="filter btn btn-outline-primary" data-filter="all">All Copmanies</div>
                        <div class="filter btn btn-outline-primary" data-filter=".web">Group Name1</div>
                        <div class="filter btn btn-outline-primary" data-filter=".photo">Group Name2</div>
                        <div class="filter btn btn-outline-primary" data-filter=".graphics">Group Name3</div>
                        <div class="filter btn btn-outline-primary" data-filter=".seo">Group Name4</div>
                    </div>
                    <div class="row">
                        <div id="container">
                            <div class="col-md-3 mix web seo">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix photo seo">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix graphics">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix web">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix photo seo">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix graphics">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix photo">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix web">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                            <div class="col-md-3 mix graphics">
                                <a class="img-zoom" href="Images/landing_page/shop.png">
                                    <img src="Images/landing_page/shop.png" alt="" class="img-size" /></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <section class="fdb-block" id="location">
        <div class="container">
            <div class="row text-center">
                <div class="col-12">
                    <div class="row justify-content-center pb-5">
                        <div class="col-12 col-lg-8 text-center">
                            <h1 class="p-3 mb-2">Our Location And Network Around The World</h1>
                        </div>
                    </div>

                    <img alt="image" class="img-fluid" src="Images/landing_page/map.png">
                </div>
            </div>
        </div>
    </section>

</asp:Content>
