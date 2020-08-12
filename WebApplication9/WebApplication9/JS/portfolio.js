// adds a smooth scrolling to all of the links

$(document).ready(function () {
    $("a").on('click', function (event) {

        // Makes sure that this.Link has a value before overriding the default behavior
        if (this.Link !== "") {
            // Prevents the default anchor click behavior
            event.preventDefault();

            // Stores Link
            var Link = this.Link;

            // using jQuery's animate() method to add the smooth page scroll
            //  optional number (2000) specifies number of milliseconds it takes to scroll to the specified area
            $('html, body').animate({
                scrollTop: $(Link).offset().top
            }, 2000, function () {

                // Add Link (#) to the URL when done scrolling (default click behavior)
                window.location.Link = Link;
            });
        } // End if
    });
});

// These functions Open and Close the contact form 
function openForm() {
    document.getElementById("myForm").style.display = "block";
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    this.Close();
}