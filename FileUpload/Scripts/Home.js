$(document).ready(function () {
    GetFileUploadData();
}); 

function GetFileUploadData() {
    var getUrl = '/api/FileUpload/GetFileUploadList';
    $.ajax({
        type: 'GET',
        url: getUrl,
        datatype: 'json',
        contentType: "application/json",
        success: function (response) {
            var fileUploadTable = $('#fileUpload tbody');
            fileUploadTable.empty();

            $(response).each(function (index, file) {
                fileUploadTable.append(
                    '<tr><td>' + file.FileName + '</td><td>' + file.UserName + '</td></tr>');
            });
        }
    });
}