
var OnCreateJobClick = function () {
    $(".createJob").val("");
    $.ajax({
        url: "/job/create",
        method: "POST",
        data: $('#createJob_Form').serialize(),
        beforeSend: function () {
            $('#response').html('<span class="text-info">Loading response...</span>');
        },
        success: function (data) {
            $('form').trigger("reset");
            $('#response').fadeIn().html(data);
            setTimeout(function () {
                $('#response').fadeOut("slow");
            }, 5000);
            $(".createJob").val("");
        }
    });
}

var OnSearchJobClick = function () {
    $.ajax({
        url: "/job/Search",
        method: "POST",
        data: $('#SearchForm').serialize(),
        beforeSend: function () {
            $('#searchResponse').html('<span class="text-info">Loading response...</span>');
        },
        success: function (data) {
            $('form').trigger("reset");
            if (data !== null) {
                console.log("Data:", data);
                $("#divJobDetails").css("display", "block");
                $('#searchResponse').fadeIn().html("Data found");
                $('#spanJobId').text(data.jobId);
                $('#spanCustomerName').text(data.customerName);
                $('#spanCustomerPhone').text(data.customerPhone);
                $('#spanServiceType').text(data.serviceType);
            }
            else {
                $(".createJob").val("");
                $(".jobDetails").text("");
                $("#divJobDetails").css("display", "none");
                $('#searchResponse').fadeIn().html("No data found");
            }
            setTimeout(function () {
                $('#searchResponse').fadeOut("slow");
            }, 10000);
        }
    });
}