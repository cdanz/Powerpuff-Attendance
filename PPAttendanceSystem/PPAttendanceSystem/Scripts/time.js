var input = $('#input-a');
input.clockpicker({
	autoclose: true
});

// Manual operations
$('#button-a').click(function (e) {
	// Have to stop propagation here
	e.stopPropagation();
	input.clockpicker('show')
		.clockpicker('toggleView', 'minutes');
});
$('#button-b').click(function (e) {
	// Have to stop propagation here
	e.stopPropagation();
	input.clockpicker('show')
		.clockpicker('toggleView', 'hours');
});