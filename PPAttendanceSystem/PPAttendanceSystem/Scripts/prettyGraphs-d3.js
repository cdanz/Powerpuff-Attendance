/***************************
 * D3.js customized charts *
 * *************************/

// Hard-coded student data (hours per day in a week)
var data = [30, 86, 168, 281, 303, 365];

// Simple bar chart
d3.select(".chart")
	.selectAll("div")
	.data(data)
	.enter()
	.append("div")
	.style("width", function (d) { return d + "px"; })
	.text(function (d) { return d; });