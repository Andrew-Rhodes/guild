$(function() {
   $('div').mouseenter(function() {
//		$(this).addClass('black');
       $(this).animate({
           height: '+=10px'
       });
   });
   $('div').mouseleave(function() {
//		$(this).removeClass('black');
       $(this).animate({
           height: '-=10px'
       }); 
   });
   $('div').click(function() {
       $(this).toggle(1000);
   }); 
   $('#abutton').click(function(){
	  $('div').toggle(10000); 
   });
});