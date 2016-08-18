$( document ).ready(function() {
	$('#btnoutput').click(function( event ) {
        var content = $('#code').val(); // get the text from the text area
		$('#results').html(content); // set the text area text inside our results div
		hiliteSelections(); // color the matching selectors
    });
});

var hiliteSelections = function()
{
	$('.yellow').removeClass('yellow');  // remove from all elements so we are cleaned up
	var selectors = $('#userinput').val(); // get the value the user typed in
	$(selectors).addClass('yellow'); // change the background to yellow on any matches
};