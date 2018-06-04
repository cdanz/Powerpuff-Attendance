function edit_row(no) {
	document.getElementById("edit_button" + no).style.display = "section-scroll btn btn-primary";
	document.getElementById("save_button" + no).style.display = "section-scroll btn btn-primary";

    var fname = document.getElementById("fname_row" + no);
    var lname = document.getElementById("lname_row" + no);
    var status = document.getElementById("status_row" + no);

    var fname_data = fname.innerHTML;
    var lname_data = lname.innerHTML;
    var status_data = status.innerHTML;

    fname.innerHTML = "<input type='text' class='form-control' id='fname_text" + no + "' value='" + fname_data + "'>";
	lname.innerHTML = "<input type='text' class='form-control' id='lname_text" + no + "' value='" + lname_data + "'>";
	status.innerHTML = "<input type='text' class='form-control' id='status_text" + no + "' value='" + status_data + "'>";
}

function save_row(no) {
    var fname_val = document.getElementById("fname_text" + no).value;
    var lname_val = document.getElementById("lname_text" + no).value;
    var status_val = document.getElementById("status_text" + no).value;

    document.getElementById("fname_row" + no).innerHTML = fname_val;
    document.getElementById("lname_row" + no).innerHTML = lname_val;
    document.getElementById("status_row" + no).innerHTML = status_val;

	document.getElementById("edit_button" + no).style.display = "section-scroll btn btn-primary";
	document.getElementById("save_button" + no).style.display = "section-scroll btn btn-primary";
}

function delete_row(no) {
    document.getElementById("row" + no + "").outerHTML = "";
}

function add_row() {
    var new_fname = document.getElementById("new_fname").value;
    var new_lname = document.getElementById("new_lname").value;
    var new_status = document.getElementById("new_status").value;

    var table = document.getElementById("data_table");
    var table_len = (table.rows.length) - 1;
	var row = table.insertRow(table_len).outerHTML = "<tr id='row" + table_len + "'><td id='fname_row" + table_len + "'>" + new_fname + "</td><td id='lname_row" + table_len + "'>" + new_lname + "</td><td id='status_row" + table_len + "'>" + new_status + "</td><td><input type='button' id='edit_button" + table_len + "' value='Edit' class='section-scroll btn btn-primary' onclick='edit_row(" + table_len + ")'> <input type='button' id='save_button" + table_len + "' value='Save' class='section-scroll btn btn-primary' onclick='save_row(" + table_len + ")'> <input type='button' value='Delete' class='section-scroll btn btn-primary' onclick='delete_row(" + table_len + ")'></td></tr>";

    document.getElementById("new_fname").value = "";
    document.getElementById("new_lname").value = "";
	document.getElementById("new_status").value = "";
}