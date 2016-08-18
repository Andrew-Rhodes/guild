$(document).ready(function() {
    $('a')
        .mouseenter(function() {
            $('a').fadeTo(100, 0.5);
        });

    $('a')
        .mouseleave(function() {
            $('a').fadeIn(1600);
        });
});


fadeTo( 250, 0.25, function()


//.mouseenter(function() {
//    $( "p:first", this ).text( "mouse enter" );
//    $( "p:last", this ).text( ++n );
//})
// .mouseleave(function() {
//     $( "p:first", this ).text( "mouse leave" );
// });