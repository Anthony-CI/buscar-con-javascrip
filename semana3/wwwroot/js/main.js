

//$.ajax({
//    url: 'https://localhost:44352/Tema/Mostar',
//    type: 'get'
//}).done(function (response) {
//    $("tbody#cuerpo").html(response);
//});


$("form.form-inline").on('submit', function (evento) {
    $.ajax({
        type: 'Get',
        url: "/tema?query=" + $("#buscar").val()
    }).done(function (response) {
        $("tbody#cuerpo").html(response);
    });
    evento.preventDefault();
});