<%@ Page Title="Islah Group | Home" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IslahGroup.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="slider-area">
        <div class="slider-active owl-carousel">
            <img src="http://via.placeholder.com/1920x851/2576f9/000000?text=Slide-1">
            <img src="http://via.placeholder.com/1920x851/25f929/ffffff?text=Slide-2">
            <img src="http://via.placeholder.com/1920x851/f92568/ffffff?text=Slide-3">
        </div>
    </div>
    <!--slider area ends-->
    <!-- service section -->
    <div class="service-area">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class="fa fa-cut"></i>
                                <h4>Textiles</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>

                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class="fa fa-building"></i>
                                <h4>Industries</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class=" fa fa-user-secret"></i>
                                <h4>Clients</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class="fa  fa-trademark"></i>
                                <h4>Brands</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>

                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class="fa fa-reply"></i>
                                <h4>Services</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="box-area">
                        <div class="icon-and-text">
                            <a href="#">
                                <i class=" fa fa-bar-chart-o"></i>
                                <h4>CSR</h4>
                                <p>Lorem ipsum dolor sit amet</p>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="parallax">
        <div class="aboutus">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h1>About US</h1>
                        <hr></hr>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="cardwrapper">
                            <img src="Images/landing_page/boss.png" /><div class="cardcontentcontainer border border-warning">
                                <h2>The Managing Director</h2>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliquaUt enim adminim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip commodo consequat....
                                    <a href="aboutus.html" class="btn btn-primary">Read More</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- service section end-->
    <!--companies area start-->
    <div class="parallax1">
        <div class="company-area">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h1>Companies</h1>
                        <hr />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-3">
                        <i class="fa fa-amazon fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-foursquare fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-glide fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-medium fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-3">
                        <i class="fa fa-opencart fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-stack-overflow fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-soundcloud fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                    <div class="col-lg-3">
                        <i class="fa fa-reddit fa-5x text-dark p-2" aria-hidden="true"></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--companies area end-->
    <!--industries and verticals area start-->
    <div class="parallax2">
        <div class="industry-area">
            <div class="container ptb-30" id="industry_verticals">
                <div class="row">
                    <div class="col-lg-12">
                        <h1>Industry Verticals</h1>
                        <hr/>
                    </div>
                </div>
                <div class="row pb-10 text-dark">
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Building Mosques</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Blood Banks</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Building Madrashas</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row text-dark">
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Employement</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Helping Needy People</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card border border-danger" style="width: 18rem;">
                            <img class="card-img-top" src="img/bod/1.jpg" alt="Card image cap">
                            <div class="card-body">
                                <h4>Doing Charity Works</h4>
                                <p class="card-text">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="map-area">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Find Us Here</h1>
                    <hr></hr>
                </div>
                <div class="col-lg-12">
                    <div id="map" style="height: 600px;"></div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDC3Ip9iVC0nIxC6V14CKLQ1HZNF_65qEQ "></script>
    <script>
        // When the window has finished loading create our google map below
        google.maps.event.addDomListener(window, 'load', init);

        function init() {
            // Basic options for a simple Google Map
            // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
            var mapOptions = {
                // How zoomed in you want the map to start at (always required)
                zoom: 11,

                scrollwheel: false,

                // The latitude and longitude to center the map (always required)
                center: new google.maps.LatLng(23.747473, 90.411094), // New York

                // How you would like to style the map. 
                // This is where you would paste any style found on Snazzy Maps.
                styles: [
                    {
                        "featureType": "landscape.man_made",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "color": "#f7f1df"
                            }
                        ]
                    },
                    {
                        "featureType": "landscape.natural",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "color": "#d0e3b4"
                            }
                        ]
                    },
                    {
                        "featureType": "landscape.natural.terrain",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "visibility": "off"
                            }
                        ]
                    },
                    {
                        "featureType": "poi",
                        "elementType": "labels",
                        "stylers": [
                            {
                                "visibility": "off"
                            }
                        ]
                    },
                    {
                        "featureType": "poi.business",
                        "elementType": "all",
                        "stylers": [
                            {
                                "visibility": "off"
                            }
                        ]
                    },
                    {
                        "featureType": "poi.medical",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "color": "#fbd3da"
                            }
                        ]
                    },
                    {
                        "featureType": "poi.park",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "color": "#bde6ab"
                            }
                        ]
                    },
                    {
                        "featureType": "road",
                        "elementType": "geometry.stroke",
                        "stylers": [
                            {
                                "visibility": "off"
                            }
                        ]
                    },
                    {
                        "featureType": "road",
                        "elementType": "labels",
                        "stylers": [
                            {
                                "visibility": "off"
                            }
                        ]
                    },
                    {
                        "featureType": "road.highway",
                        "elementType": "geometry.fill",
                        "stylers": [
                            {
                                "color": "#ffe15f"
                            }
                        ]
                    },
                    {
                        "featureType": "road.highway",
                        "elementType": "geometry.stroke",
                        "stylers": [
                            {
                                "color": "#efd151"
                            }
                        ]
                    },
                    {
                        "featureType": "road.arterial",
                        "elementType": "geometry.fill",
                        "stylers": [
                            {
                                "color": "#ffffff"
                            }
                        ]
                    },
                    {
                        "featureType": "road.local",
                        "elementType": "geometry.fill",
                        "stylers": [
                            {
                                "color": "black"
                            }
                        ]
                    },
                    {
                        "featureType": "transit.station.airport",
                        "elementType": "geometry.fill",
                        "stylers": [
                            {
                                "color": "#cfb2db"
                            }
                        ]
                    },
                    {
                        "featureType": "water",
                        "elementType": "geometry",
                        "stylers": [
                            {
                                "color": "#a2daf2"
                            }
                        ]
                    }
                ]
            };

            // Get the HTML DOM element that will contain your map 
            // We are using a div with id="map" seen below in the <body>
            var mapElement = document.getElementById('map');

            // Create the Google Map using our element and options defined above
            var map = new google.maps.Map(mapElement, mapOptions);

            // Let's also add a marker while we're at it
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(23.747473, 90.411094),
                map: map,
                title: 'Snazzy!'
            });
        }
    </script>
</asp:Content>
