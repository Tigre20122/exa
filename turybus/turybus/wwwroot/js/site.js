// Write your JavaScript code.

$('#modalAR').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalAC').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalM').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalE').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalED').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalMC').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalEC').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});
$('#modalACon').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});

$('#modalcon').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});

$('#modalcone').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});

$('#modalAV').on('shown.bs.modal', function () {
    $('#Nombre').focus()
});






var items;
var id;
var Nombre;
var Descripcion;
var Estado;

function getRutaAjax(id, action) {
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            //console.log(response);
            OnSuccess(response);
        }
    });
}

function OnSuccess(response) {
    items = response;
    $.each(items, function (index, val) {
        $('input[name=IdRuta]').val(val.idRuta);
        $('input[name=Nombre]').val(val.nombre);
        $('input[name=Descripcion]').val(val.descripcion); 
    });
}

function EditarAjax(action) {
     id = $('input[name=IdRuta]')[0].value;
     Nombre = $('input[name=Nombre]')[0].value;
    Descripcion = $('input[name=Descripcion]')[0].value;

    console.log(Nombre);
    console.log(Descripcion);

    $.ajax({
        type: "POST",
        url: action,
        data: {
            id,Nombre,Descripcion
              },
        success: function (response) {
            if (response == "Save") {
                window.location.href = "https://localhost:44351/Rutas";
            } else {
                alert("NO se puede editar los datos");
            }
        }
    });
}

function EliminarAjax(action) {
    var id = $('input[name=IdRuta]')[0].value;
    $.ajax({
        type: "POST",
        url: action,
        data:{ id },
        success: function (response) {
            if (response === "delete") {
                window.location.href = "https://localhost:44351/Rutas";
            }
        }
    });
}

function getCLienteAjax(id, action) {
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            //console.log(response);
            OnSuccessCliente(response);
        }
    });
}

function OnSuccessCliente(response) {
    items = response;
    $.each(items, function (index, val) {
        $('input[name=IdCliente]').val(val.idCliente);
        $('input[name=Cedula]').val(val.cedula);
        $('input[name=Nombre]').val(val.nombre);
        $('input[name=Apellido]').val(val.apellido);
        $('input[name=Telefono]').val(val.telefono);
    });
}

function EliminarClienteAjax(action) {
    var id = $('input[name=IdCliente]')[0].value;
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            if (response === "delete") {
                window.location.href = "https://localhost:44351/Clientes";
            }
        }
    });
}


function getConductorAjax(id, action) {
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            //console.log(response);
            OnSuccessConductor(response);
        }
    });
}

function OnSuccessConductor(response) {
    items = response;
    $.each(items, function (index, val) {
        $('input[name=IdConductor]').val(val.idConductor);
        $('input[name=Cedula]').val(val.cedula);
        $('input[name=Nombre]').val(val.nombre);
        $('input[name=Apellido]').val(val.apellido);
        $('input[name=Telefono]').val(val.telefono);
        $('input[name=Direccion]').val(val.direccion);

    });
}

function EliminarConductorAjax(action) {
    var id = $('input[name=IdConductor]')[0].value;
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            if (response === "delete") {
                window.location.href = "https://localhost:44351/Conductors";
            }
        }
    });
}
var agregarRuta = () => {
    var nombre = document.getElementById("Nombre").value;
    var descripcion = document.getElementById("Descripcion").value;
    var estados = document.getElementById("Estado").value;
    //var estado = estados.options[estados.selectedIndex].value;
    var action = 'Rutas/guardarRuta';
    var ruta = new Rutas(nombre, descripcion, estados, action);
    ruta.agregarRuta();
}

var agregarCliente = () => {
    var cedula = document.getElementById("Cedula").value;
    var nombre = document.getElementById("Nombre").value;
    var apellido = document.getElementById("Apellido").value;
    var telefono = document.getElementById("Telefono").value;
    var action = 'Clientes/guardarCliente';
    var cliente = new Cliente(cedula, nombre, apellido, telefono, action);
    cliente.agregarCliente();
}

var agregarConductor = () => {
    var cedula = document.getElementById("Cedula").value;
    var nombre = document.getElementById("Nombre").value;
    var apellido = document.getElementById("Apellido").value;
    var telefono = document.getElementById("Telefono").value;
    var direccion = document.getElementById("Direccion").value;
    var action = 'Conductors/guardarConductor';
    var conductor = new Conductor(cedula, nombre, apellido, telefono, direccion, action);
    conductor.agregarConductor();
}




//reportes

var ListaRutas = () => {
    var accion = 'Rutas/Lista_Ruta_Controller';
    var diag = new Rutas('', '','', accion);
    diag.ListaRutas();
}   

var Imprimir_Rutas = () => {
    var contenido = document.getElementById('Imprimir_Rutas').innerHTML;
    var contenidopaginaoriginal = document.body.innerHTML;
    document.body.innerHTML = contenido;
    window.print();
    document.body.innerHTML = contenidopaginaoriginal;
    $('#Reporte').modal('hide');
}

var ListaClientes = () => {
    var accion = 'Clientes/Lista_Cliente_Controller';
    var diag = new Cliente('', '', '', '',accion);
    diag.ListaClientes();
}

var Imprimir_Clientes = () => {
    var contenido = document.getElementById('Imprimir_Clientes').innerHTML;
    var contenidopaginaoriginal = document.body.innerHTML;
    document.body.innerHTML = contenido;
    window.print();
    document.body.innerHTML = contenidopaginaoriginal;
    $('#Reporte1').modal('hide');
}




