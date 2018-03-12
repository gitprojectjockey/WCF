
$(document).on('focus', 'input[type=button]', function () {
    var self = $(this);
    if (self.val() == self.attr('title')) {

        if (!self.hasClass('my-events-are-added')) {
            self.addClass("my-events-are-added");
            
            self.click(function () {
                var self = $(this);
                val = self.val();
                if ($("#divStateCode_" + val).is(":visible"))
                {
                    $("#divStateCode_" + val).slideUp();
                }
                else
                {
                    slideUpAllOpenDivs();
                    retrieveJsonStateCodeData(val) 
                    $("#divStateCode_" + val).slideDown();
                    $("#divStateCode_" + val).css('display', 'inline-block');
                }
            });
        }
    };
});

$(document).ready()
{
    function ShowRegistrationSuccessModel() {
        $('#successModal').modal('show');
    }


    hideTableDivs();
    function hideTableDivs()
    {
        $("#tblStateCode tr td").find("div").hide();
    }

    function slideUpAllOpenDivs()
    {
        $("#tblStateCode tr td").find("div").slideUp();
    }

    function retrieveJsonStateCodeData(stateAbbrev) {

        //Call controller which calls WCF Service
        var uri = "http://localhost:65124/api/gopostal/PostalStateCodeManager/StateCode/" + stateAbbrev;

        $.ajax({
            method: 'GET',
            url: uri,
            contentType: 'application/json',
            success: function (response) {

                $("#divStateCode_" + stateAbbrev).html(response);
            },
            error: function (jqXHR) {
                // API returns error in jQuery xml http request object.
                if (jqXHR.status == '401') {

                }
                else {

                }
            }
        });
    };
}

