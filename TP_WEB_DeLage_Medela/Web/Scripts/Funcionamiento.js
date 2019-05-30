function ValidarVoucher()
{
    alert("Estoy dentro de la funcion");
    var voucher = document.getElementById('txtCodigo').value;

    if(voucher.length > 32)
    {
        alert("El codigo del voucher es demasiado largo");
        return false
    }
    return true;
}