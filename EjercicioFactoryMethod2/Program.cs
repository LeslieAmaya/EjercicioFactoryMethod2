using EjercicioFactoryMethod2;

BebidaEnergizante oBebida = Creador.CreadorBebida(Creador.GATORADE);
Console.WriteLine(oBebida.Energia());