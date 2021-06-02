
function UploadFile() {
    var formData = new FormData();
    var fileDetails = $("#fileUpload").get(0).files;

    if (fileDetails != null && fileDetails.length > 0) {
        formData.append("UploadedImage", fileDetails[0]);
        $.ajax({
            type: "POST",
            url: '/api/FileUpload/UploadFileInDB',
            contentType: false,
            processData: false,
            data: formData,
            success: function (response) {
                if (response == true) {
                    alert("File uploaded successfully.");
                    window.location = '/Home/Index';
                }
                else {
                    alert("Something went wrong with file upload.");
                }
            }
        });
    }
    else {
        alert("Please select file before submit.");
    }
}