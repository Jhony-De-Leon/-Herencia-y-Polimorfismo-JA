using claseOOP1.misclases;


Console.WriteLine("Carro Electrico:");
carroElectrico miToyota = new carroElectrico(2023, "AlfA MEGA", "Corinto");
miToyota.InformacionVehiculo();
miToyota.encender();    
miToyota.Acelerar(10);
miToyota.Frenar(5); 
miToyota.apagar();
Console.WriteLine("Carga de la bateria es:" + miToyota.verNivelBateria());

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Auto de Combustion:");
AutoDeCombustión miFord = new AutoDeCombustión(2015, "Suzuki Swift", "Rojo");
miFord.InformacionVehiculo();
miFord.verAscientos();
miFord.encender();
miFord.Acelerar(20);
miFord.Frenar(10);
miFord.vernivelAceite();
miFord.apagar();   
Console.WriteLine("Nivel de gasolina: " + miFord.verNivelGasolina());

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Motocicleta:");
Motocicleta miM53 = new Motocicleta(2025, "Navi", "Verde");
miM53.InformacionVehiculo();
miM53.verMotor();
miM53.encender();
miM53.Acelerar(50);
miM53.Frenar(50);
miM53.apagar();
Console.WriteLine("El tipo de arranque es: " + miM53.verArranque());

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Camion:");
Camión miCamiónJA = new Camión(2005, "Volvo", "Azul");
miCamiónJA.InformacionVehiculo();
miCamiónJA.encender();
miCamiónJA.Acelerar(40);
miCamiónJA.Frenar(20);
miCamiónJA.tipoVehiculo();
miCamiónJA.verAsientos();
miCamiónJA.cargar(5);
miCamiónJA.descargar();
miCamiónJA.apagar();
Console.WriteLine("Capacidad de carga en toneladas es: " + miCamiónJA.verCapacidadCarga());




