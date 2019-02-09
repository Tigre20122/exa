class Rutas {
    constructor(nombre,descripcion,estado,action) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.estado = estado;
        this.action = action;
    }
    agregarRuta() {
        if (this.nombre == "") {
            document.getElementById("Nombre").focus();
        } else {
            if (this.descripcion == "") {
                document.getElementById("Descripcion").focus();
            } else {
                if (this.estado == "0") {
                    document.getElementById("mensaje").innerHTML = " Seleccione Estado";
                } else {
                    
                    var nombre = this.nombre;
                    var descripcion = this.descripcion;
                    var estado = this.estado;
                    var action = this.action;
                    var mensaje = this.mensaje;

                    $.ajax({
                        type: "POST",
                        url: action,
                        data: {
                            nombre, descripcion, estado
                        },
                        success: (response) => {
                            // console.log(response);
                            $.each(response, (index, val) => {
                                mensaje = val.code;

                            });
                            if (mensaje === "Save") {
                                this.restablecer();
                            } else {
                                document.getElementById("Mensaje").innerHTML = " Nose puede Guardar la ruta";
                            }
                        }
                    });
                }
            }
        }
    }
   

    

    restablecer() {
        document.getElementById("Nombre").value = "";
        document.getElementById("Descripcion").value = "";
        document.getElementById("mensaje").innerHTML = "";
        document.getElementById("Estado").selectedIndex = 0;
        $('#modalAR').modal('hide');
    }
}