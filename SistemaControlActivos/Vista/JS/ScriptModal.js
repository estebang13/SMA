$('#btnYes').click(function () {
    console.log("entro");
        console.log($('#name').val());
        console.log($('#email').val());
        console.log($('#phone').val());
        // puede usar la forma de arriba o la de abajo, dan lo mismo.
        console.log(document.getElementById("name").value);
        alert("enviado");
    });
