function ValidarVoucher()
{
    var voucher = document.getElementById('txtCodigo').value;

    if(voucher.length > 32)
    {
        alert("El codigo del voucher es demasiado largo");
        return false
    }
    return true;
}

function ValidarFormularioCliente()
{
    var dni = document.getElementById('tbxDni').value;
    var nombre = document.getElementById('tbxNombre').value;
    var apellido = document.getElementById('tbxApellido').value;
    var email = document.getElementById('tbxEmail').value;
    var direccion = document.getElementById('tbxDireccion').value;
    var ciudad = document.getElementById('tbxCiudad').value;
    var codigopostal = document.getElementById('tbxCp').value;
    var ischecked = document.getElementById('cbxTerminos').checked;

    if (dni.length > 10) {
        alert("El dni ingresado es largo");
        return false;
    } else {
        if (ContieneLetras(dni) == 1) {
            alert("El dni ingresado es incorrecto. Atencion! debe contener solo caracteres numericos");
            return false;
        } 
    }

    if (nombre.length > 50) {
        alert("El nombre ingresado es largo");
        return false;
    } else {
        if (ContieneNumeros(nombre) == 1) {
            alert("El nombre ingresado es incorrecto. Atencion! debe contener solo caracteres alfabeticos");
            return false;
        }
    }

    if (apellido.length > 50) {
        alert("El apellido ingresado es largo");
        return false;
    }
    else {
        if (ContieneNumeros(apellido) == 1) {
            alert("El apellido ingresado es incorrecto. Atencion! debe contener solo caracteres alfabeticos");
            return false;
        }
    }

    if (email.length > 100) {
        alert("El mail ingresado es largo");
        return false;
    }

    if (direccion.length > 50) {
        alert("La direccion ingresada es larga");
        return false;
    }

    if (ciudad.length > 50) {
        alert("La ciudad ingresada es larga");
        return false;
    }

    if (codigopostal.length > 8) {
        alert("El codigo postal ingresado es largo");
        return false;
    }
    else {
        if (ContieneLetras(codigopostal) == 1) {
            alert("El codigo postal ingresado es incorrecto. Atención! debe contener solo caracteres numéricos")
            return false;    
        }
    }

    if (!ischecked) {
        alert("Error!!. Debe aceptar los Términos y Condiciones para continuar");
        return false;
    }
    return true;
}

function ContieneLetras(texto)
{
    var letras = "abcdefghyjklmnñopqrstuvwxyz";

    texto = texto.toLowerCase();
    for (i = 0; i < texto.length; i++) {
        if (letras.indexOf(texto.charAt(i), 0) != -1) {
              return 1;
        }
    }
        return 0;
}

function ContieneNumeros(texto)
{
    var numeros = "0123456789";

    for (i = 0; i < texto.length; i++)
    {
        if (numeros.indexOf(texto.charAt(i), 0) != -1)
        {
                return 1;
        }
    }
        return 0;
    
}
