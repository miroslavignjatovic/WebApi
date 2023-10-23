function getAllUsers() {
    $.get("/api/Users/getAllUser/", function (data) {
        displayResult(data);
    });
}

function getUserById() {
    var userId = $("#userId").val();
    $.get("/api/Users/" + userId, function (data) {
        displayResult(data);
    });
}

function displayResult(data) {
    var resultDiv = $("#result");
    resultDiv.html(data);
}
