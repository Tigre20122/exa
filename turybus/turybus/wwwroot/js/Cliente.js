class Cliente {
    constructor(cedula, nombre, apellido, telefono, action) {
        this.cedula = cedula;
        this.nombre = nombre;
        this.apellido = apellido;
        this.telefono = telefono;
        this.action = action;
    }
    agregarCliente() {
        if (this.cedula == "") {
            document.getElementById("Cedula").focus();
        } else {
            if (this.nombre == "") {
                document.getElementById("Nombre").focus();
            } else {
                if (this.apellido == "") {
                    document.getElementById("Apellido").focus();
                } else {
                    if (this.telefono == "") {
                        document.getElementById("Telefono").focus();
                    } else {

                        var cedula = this.cedula;
                        var nombre = this.nombre;
                        var apellido = this.apellido;
                        var telefono = this.telefono;
                        var mensaje = this.mensaje;
                        var action = this.action;



                        $.ajax({
                            type: "POST",
                            url: action,
                            data: {
                                cedula, nombre, apellido, telefono
                            },
                            success: (response) => {
                                // console.log(response);
                                $.each(response, (index, val) => {
                                    mensaje = val.code;

                                });
                                if (mensaje === "Save") {
                                    this.restablecer();
                                }
                            }
                        });
                    }
                }
            }
        }
    }




        restablecer() {
            document.getElementById("Cedula").value = "";
            document.getElementById("Nombre").value = "";
            document.getElementById("Apellido").value = "";
            document.getElementById("Telefono").value = "";
            $('#modalAC').modal('hide');
        }
    }
