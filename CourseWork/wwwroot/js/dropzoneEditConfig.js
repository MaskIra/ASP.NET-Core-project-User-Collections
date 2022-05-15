Dropzone.autoDiscover = false;
$(document).ready(function () {
    $('#myDropzone').dropzone({
        paramName: "Image",
        clickable: '#previews',
        previewsContainer: "#previewFiles",
        autoProcessQueue: false,
        uploadMultiple: false,
        parallelUploads: 1,
        maxFiles: 1,
        //  url:"/", // url here to save file
        maxFilesize: 100, // MB
        addRemoveLinks: true,
        dictResponseError: 'Server not Configured',
        acceptedFiles: ".png,.jpg,.gif,.bmp,.jpeg",
        init: function () {
            var self = this;
            self.options.addRemoveLinks = true;
            self.options.dictRemoveFile = "Remove";

            self.on("addedfile", function (file) {
                console.log('new file added ', file);
                $('.dz-success-mark').hide();
                $('.dz-error-mark').hide();
                $('#previews').hide();
                $('#chb').hide();
                $('#DeleteImage').checked = false;
            });

            self.on("sending", function (file) {
                console.log('upload started', file);
                $('.meter').show();
            });

            self.on("totaluploadprogress", function (progress) {
                console.log("progress ", progress);
                $('.roller').width(progress + '%');
            });

            self.on("queuecomplete", function (progress) {
                $('.meter').delay(999).slideUp(999);
                location.href = $("#RedirectTo").val();
            });

            self.on("removedfile", function (file) {
                console.log(file);
                $('#previews').show();
                $('#chb').show();
                $('#DeleteImage').checked = false;
            });

            $('#submit').on("click", function (e) {
                if (self.getQueuedFiles().length > 0) {
                    e.preventDefault();
                    self.processQueue();
                } else {
                    document.getElementById("myDropzone").submit();
                }
            });
        }
    });
})