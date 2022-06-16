
using Eventos_y_Delegados_Cs28;

var archivo = new Archivo() { Titulo = "Archivo 1" };
var asistenteDescarga = new AsistenteDescarga();//emisor

asistenteDescarga.Descarga(archivo);