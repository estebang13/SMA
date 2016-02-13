$('#btnYes').click(function () {
    console.log("entro");
        console.log($('#name').val());
        console.log($('#email').val());
        console.log($('#phone').val());
        // puede usar la forma de arriba o la de abajo, dan lo mismo.
        console.log(document.getElementById("name").value);
        alert("enviado");
})

$('#exampleModal').on('show.bs.modal', function (event) {
       var button = $(event.relatedTarget) // Button that triggered the modal
        var recipient = button.data('whatever') // Extract info from data-* attributes
       // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
        // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
       var modal = $(this)
        modal.find('.modal-title').text('New message to ' + recipient)
        modal.find('.modal-body input').val(recipient)
    }) 
