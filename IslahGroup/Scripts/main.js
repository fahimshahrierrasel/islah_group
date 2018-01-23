$(function(){

	// Instantiate MixItUp:

	$('#container').mixItUp();
	
	  
$('.img-zoom').magnificPopup({
  type: 'image',
  gallery:{
    enabled:true
  }
});	   
$('.video-zoom').magnificPopup({
  type: 'iframe',
  gallery:{
    enabled:true
  }
});	  

});
