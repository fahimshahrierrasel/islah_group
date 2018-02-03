$(document).ready(function(){
  $('.slider-active').owlCarousel({
    loop:true,
    navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    nav:true,
    dots:true,
    animateIn:'bounceInRight',
    autoplay:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})
});
$(document).ready(function(){
  $('.bod_slider-active').owlCarousel({
    loop:true,
    navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    nav:true,
    dots:true,
    animateIn:'bounceInRight',
    autoplay:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})
});

document.getElementById('links').onclick = function (event) {
    event = event || window.event;
    var target = event.target || event.srcElement,
        link = target.src ? target.parentNode : target,
        options = {index: link, event: event},
        links = this.getElementsByTagName('a');
    blueimp.Gallery(links, options);
};