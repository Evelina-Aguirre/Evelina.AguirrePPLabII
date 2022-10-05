using System.Collections.Generic;

namespace Entidades.Tienda
{
    public static class CatalogoProveedor
    {
        public static Dictionary<int,Producto> catalogo;

        static CatalogoProveedor()
        {
            catalogo = new Dictionary<int, Producto>();
            CargarCatalogo();
        }

        public static Dictionary<int, Producto> Catalogo
        {
            get
            {
                return catalogo;
            } 
        }
        /// <summary>
        /// Carga la lista que contendrá el catálogo de productos que ofrece quien provee la tienda electrónica.
        /// </summary>
        private static void CargarCatalogo()
        {
            //Leds - voltaje - potencia -watts - metros tienen algunos
            Producto led1 = new Producto("Tira Led 15w", 1225,100,  "Perfil Aluminio 1 Metro Con luces Led 5630," +
                " \nDirecto A 220V\n,15 W Alta Potencia, conector en la punta para unir uno a otro perfil.\nColor: Blanco Frío con 144 leds o Blanco Cálido con 72 leds"
                , ECategoriaElectronico.Leds);
            Producto led2 = new Producto("Tira Led 9w", 1100,101, "Perfil Aluminio 50 Cm C/36LED 5630, Directo A 220V Alta" +
                " Potencia, viene conector en la punta para unir uno a otro perfil.Color: Blanco frío – Blanco Calido", ECategoriaElectronico.Leds);
            Producto led3 = new Producto("Led 1w", 3500,102,"Led Blanco Frio Backlight 3030 3v 1w Centro Chico" +
                " X 100 U", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led4 = new ComponentesElectronicos("Led 1w", 100, 1250,103,"Led Blanco Frio Backlight 3528 3v 1w Tv LG " +
            //    "X 50 Unidades", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led5 = new ComponentesElectronicos("Led SMD 3030", 50, 2370,104,"50 Unidades Led Smd 3030 6v 2w Pct Simetrico 3mm " +
            //    "X 3mm", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led6 = new ComponentesElectronicos("Led Cob 50w",10, 1188,105,"Led Cob 50w Blanco Frio 220v C/bornera 6000/6500k", 
            //    ECategoriaElectronico.Leds);
            //ComponentesElectronicos led7 = new ComponentesElectronicos("Tira LGB 5050",10, 1439,106, "Tira Luces Led Rgb 5050 Usb 2 M Decoracion Gamer Tv" +
            //    " Pc Strip", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led8 = new ComponentesElectronicos("Conector L", 10, 202,107, "Conector L Esquina Tiras Led 5050 Rgb Hebilla Sin Soldar" +
            //    " 90°", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led9 = new ComponentesElectronicos("Controladora RGB", 10, 600,108, "Controladora Para Tira Led Rgb 24 Teclas Control" +
            //    " Remoto 12v", ECategoriaElectronico.Leds);
            //ComponentesElectronicos led10 = new ComponentesElectronicos("Controladora COB", 25, 720,109, "Controladora Para Tira Led Cob 24 Teclas Control" +
            //    " Remoto 12v", ECategoriaElectronico.Leds);

            ////Bobinas Inductancia:  22uH, 33uH, 47uH, 56uH, 100uH, 220uH, 330uH(MicroHenrio
            //ComponentesElectronicos bobina1 = new ComponentesElectronicos("Bobina 22uH", 20, 640,110,  "Tipo: Bobina Toroidal"+
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente",
            //ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina2 = new ComponentesElectronicos("Bobina 33uH", 20, 660, 111, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina3 = new ComponentesElectronicos("Bobina 33uH", 20, 680, 112, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina4 = new ComponentesElectronicos("Bobina 47uH", 20, 700, 113, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina5 = new ComponentesElectronicos("Bobina 56uH", 20, 720, 114, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina6 = new ComponentesElectronicos("Bobina 100uH", 20, 740, 115, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina7 = new ComponentesElectronicos("Bobina 220uH", 20, 760,116,  "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina8 = new ComponentesElectronicos("Bobina 330uH", 20, 780, 117, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina9 = new ComponentesElectronicos("Bobina 470uH", 20, 800,  118,"ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            //ComponentesElectronicos bobina10 = new ComponentesElectronicos("Bobina 470uH 50u", 50,2500, 119, "ipo: Bobina Toroidal" +
            //"Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);

            ////Capacitores transistores - voltaje - potencia
            //ComponentesElectronicos capacitor1 = new ComponentesElectronicos("Kit capacitores", 100, 355,120, 
            //    "Kit de capacitores cerámicos, Montaje: SMD, Encapsulado: 0603, Rango de capacitancia: 0.5PF a 10UF, Número de compartimientos: 128," +
            //    "Valores disponibles: 92, Cantidad por cada valor: 100, Color del estuche: Gris", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor2 = new ComponentesElectronicos("Cerámico 1uF 16V", 100, 10, 121, "Valor: 1 uF, Tolerancia: ± 10 %, Voltaje: " +
            //    "16VEmpaquetado: SMD / SMT, Dimensiones: 0805(Pulgadas) / 20 - 12 mm, Código Dieléctrico: X5R, Fabricación: Cerámico Multicapa MLCC, " +
            //    "RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor3 = new ComponentesElectronicos("Cerámico 20pF 50V", 15, 70,122,  "Valor: 20pF, Tolerancia: ±5 %,Voltaje: 50V" +
            //    "Empaquetado: SMD / SMT, Dimensiones: 0603(Pulgadas), Fabricación: Cerámico Multicapa MLCC,HS: Libre de plomo",
            //    ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor4 = new ComponentesElectronicos("Poliéster 630V", 10, 73,123, "Tipo: Capacitor de poliéster, Tolerancia: J = +/ -5 % " +
            //    "Tipo de montaje: Agujeros pasantes THT, Voltaje Max: 630V", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor5 = new ComponentesElectronicos("Poliéster 100V", 111, 90,124,  "Tipo: Capacitor de poliéster,Tolerancia: J = +/ -5 %, " +
            //    "Tipo de montaje: Agujeros pasantes THT, Voltaje Max: 100V, Capacitancia: 100nf, Dimensiones: 6.6mm x 5.8mm, Longitud de los pines: " +
            //    "23mm", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor6 = new ComponentesElectronicos("Electrolítico 400V", 24, 67,125 , "Tipo: Capacitor Electrolítico, Valor: 330uF," +
            //    "Voltaje Max.: 400V, Tolerancia de error: ± 20 % (120Hz 20 ℃), Resistencia a la temperatura: 105 ℃, Ciclo de vida: Aprox. 2000 horas(menos de 105 ℃)," +
            //    "Forma: Cilíndrica, Marca: JCCON, Dimensiones: Alto: 40mm x Ancho: 25mm", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor7 = new ComponentesElectronicos("Cerámico 100nF", 30, 10,126 , "Capacitor Cerámico, Tipo de montaje: A través del orificio THT," +
            //    "Número de pines: 2, Capacitancia: 100nF | 0.1uF | 104, Posición de montaje: Vertical, Voltaje Máx.: 50V, Tolerancia: ±80 % 20 %,Dieléctrico: Y5V " +
            //    "Pitch: 2.54mm, Dimensiones:  Ø4.5mm x 1.8mm Grosorm, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor8 = new ComponentesElectronicos("Electrolítico 470uF", 10, 12,127,  "Valor: 470uF, Tolerancia: ± 20 % (120Hz, +20°C), " +
            //    "Voltaje: 35V, Empaquetado: SMD / SMT, Dimensiones: 10mm diámetro x 10.2mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor9 = new ComponentesElectronicos("Electrolítico 330uF", 1, 15, 128, "Valor: 330uF, Tolerancia: ± 20 %, Voltaje: 10V, " +
            //    "Empaquetado: SMD / SMT, Dimensiones: 6.3mm diámetro x 7.7mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            //ComponentesElectronicos capacitor10 = new ComponentesElectronicos("Electrolítico 220uF", 10, 16, 129, "Valor: 220uF, Tolerancia: ± 20 %, Voltaje: 50V, " +
            //    "Empaquetado: SMD / SMT, Dimensiones: 10mm diámetro x 10.2mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);

            ////Conectores - canyidad de pines 
            //ComponentesElectronicos conector1 = new ComponentesElectronicos(" Audio", 14, 250, 130, "Conector de Audio XLR 3 Pines Negro Macho / Hembra"
            //    , ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector2 = new ComponentesElectronicos("USB 16 pines", 2, 250,131,  "Tipo de Conector: SMD, Modelo: Type C 16P USB3.1," +
            //    "Numero de pines: 16, Velocidad Máxima de Transmisión: 10 gbit, Potencia: 100w", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector3 = new ComponentesElectronicos("USB 4 pines", 3, 0,132, "Conector: USB, Tipo de montaje: Superficial SMD, " +
            //    "Numero de Pines: 4, Tipo de conector: Tipo A, Tipo de contacto: Macho", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector4 = new ComponentesElectronicos("Conector XH2.54mm", 4, 750,133,  "Tipo: Conector JST XH con cable, Conector de tipo: Hembra," +
            //    "Calibre del cable: Cable 26AWG, Longitud del cable: 20cm, Pines: 2, 3, 4, 5 y 6, Paso(Pitch): 2.54 mm", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector5 = new ComponentesElectronicos("PH2.0mm 8", 1, 350, 134, "Conector: JST, Serie: PH, Tipo de contacto: Macho," +
            //    "Pitch: 2.0mm, Posición de montaje: Vertical, Tipo de montaje: Superficial SMD, Pines 8", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector6 = new ComponentesElectronicos("PH2.0mm 6",5, 225,135,  "Conector: JSTm, Serie: PH, Tipo de contacto: Macho," +
            //    "Pitch: 2.0mm, Posición de montaje: Horizontal, Tipo de montaje: Superficial SMD, Número de pines: 6", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector7 = new ComponentesElectronicos("PH2.0mm 4 pines",6, 430, 136, "Material aislante: PBT, UL94V-0, Tipo de contacto: Hembra, " +
            //    "Temperatura de trabajo: -25°C a + 85°C, Resistencias de contacto: 20mΩ Máx., Resistencia de aislamiento: 100MΩ Min., Terminal compatible: Terminal PH2.0mm, " +
            //    "Calibre de cable compatible: 26AWG", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector8 = new ComponentesElectronicos("RJ45 Mach/Hemb",7, 170,137 , "Tipo: Conector RJ45 con Terminales, Conector: Disponible Macho y Hembra, " +
            //    "Estándar del cableado: EIA / TIA 568B,Material: PVC + Metal, Color: Negro + Verde, Incluyen terminales de 8 pines, Funcionan muy bien para " +
            //    "dividir pares de cable UTP y cámara CCTV", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector9 = new ComponentesElectronicos("RJ45 UTP cat 5", 1, 90,138, "Categoría: CAT5,Marca: Kai Ping, Número de contactos: 8, " +
            //    "Compatible: 568 - A y 568 - B, Diámetro Cu - conductor: 22 - 26 AWG, Tamaño de pines: 50 micro pulgadas, Temperatura de Trabajo: -40 °C to +80 °C, " +
            //    "Color: Transparente", ECategoriaElectronico.Conectores);
            //ComponentesElectronicos conector10 = new ComponentesElectronicos("JST PH 5 Pin 2.00mm", 1, 50,139,  "Conectores JST PH Vertical, Tipo de montaje: A través del " +
            //    "orificio THT, Número de pines: 5p ,Pitch: 2mm,Tipo de contacto: Macho, Posición de montaje: Vertical, RoHS: Libre de plomo", ECategoriaElectronico.Conectores);


            ////Circuitos Integrados - Comparibilidad arduino uno si / no
            //ComponentesElectronicos circuito1 = new ComponentesElectronicos("Tuch Arduino", 4, 3500,140, "Tipo: Shield TFT Touch, Tamaño de pantallas: 2.4″, Driver IC ILI9341," +
            //    "Voltaje de funcionamiento: 5V / 3.3V, Consumo de energía: 90mw, Interfaz de módulo Interfaz paralela de 8 bits, Resolución: 320 x 240 px, " +
            //    "Color de pantalla RGB 65K color", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito2 = new ComponentesElectronicos("Due Core ATmel", 15, 1820,141, "Microcontrolador: AT91SAM3X8EA, Bits: 32, Voltaje de operación: 3.3V, " +
            //    "Voltaje de entrada: 7V a 12V(recomendado), Pines Digitales I / O: 54(de los cuales 12 son PWM), Entradas Analógicas: 12 entradas, Comunicación: UART(4) , TWI(2), " +
            //    "Digital / Analógica : 2, Conversor Digital/ Analógico: 2, Reproducción de Archivos WAV: SI, Corriente Directa por Pin: 130 mA, " +
            //    "Corriente Directa por Pin de 3.3v: 800 mA, Memoria Flash: 512 KB; de los cuales 0.5 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito3 = new ComponentesElectronicos("CNC Shield V3", 5, 1700,142,  "Compatible Arduino uno, Shield CNC 3.0, Alimentación: 12 - 36V DC. " +
            //    "(Dependiendo de los controladores utilizados), " +
            //    "Soporte para 4 ejes(X, Y, Z, A), Soporta hasta 6 finales de carrera 2 por cada eje X, Y y Z, Compatible con el software GRBL, Jumpers para control de micro - stepping, " +
            //    "Los motores pueden ser conectados con bornes tipo Molex de 4 pines, Dimensiones: 6.9 cm X 5.3 cm X 1.9 cm", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito4 = new ComponentesElectronicos("USB Host Shield ", 40, 1250,143 ,"Modelo: USB Host Shield, Dimensiones: 53.5mm x 53mm, " +
            //    "Interfaz SPI, Conector USB Tipo A hembra, Provee alimentación para el dispositivo esclavo, Compatibilidad: Arduino UNO / Diecimila / Duemilanove / MEGA 2560 / MEGA 1280" +
            //    "Peso: 16g", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito5 = new ComponentesElectronicos("Shield Multifuncional", 12, 2125, 144,"ipo: Shield, Dimensiones Aprox.: 68.5 mm x 53.5mm x 17mm," +
            //    "Peso:20g, Voltaje de Alimentación: 5V DC, Compatible con Uno, Mega, Leonardo y otros Arduinos de 5V que utilizan el diseño de pines Uno R3" +
            //    "Comunicación I2C y UART(RX / TX)", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito6 = new ComponentesElectronicos("Arduino Uno Rev3", 10, 2545,145,  "Microcontrolador: ATmega328P, Tensión de funcionamiento: 5V, " +
            //    "Voltaje de entrada(recomendado): 7 a 12 V, Voltaje de entrada(límite): 6 a 20 V, Pines de E / S digitales: 14(de los cuales 6 proporcionan salida PWM), " +
            //    "Pines de entrada analógica: 6, Corriente CC por pin de E / S: 20 mA, Corriente CC para pin de 3.3V: 50 mA, Memoria flash: 32 KB(ATmega328P) de los cuales " +
            //    "0,5 KB utiliza el gestor de arranque, SRAM: 2 KB(ATmega328P), EEPROM: 1 KB(ATmega328P), Velocidad de reloj: 16 MHz, Microcontrolador CMOS de 8 bits, " +
            //    "LED_BUILTIN 13, Largo 68.6 milímetros, Ancho 53.4 milímetros, Peso 25 g, No incluye cable USB", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito7 = new ComponentesElectronicos("Arduino Mega", 5, 2700, 146,"Microcontrolador ATmega2560, Tensión de funcionamiento: 5V, " +
            //    "Voltaje de entrada(recomendado): 7 - 12 V, Voltaje de entrada(límite): 6 - 20 V, Pines de E / S digitales: 54(de los cuales 15 proporcionan salida PWM), " +
            //    "Pines de entrada analógica: 16, Corriente CC por pin de E / S: 20 mA, Corriente CC para pin de 3.3V: 50 mA, Memoria flash: 256 KB de " +
            //    "los cuales 8 KB utiliza el gestor de arranque", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito8 = new ComponentesElectronicos("ATMEGA 2560", 4, 2950,147, "Incluye USB, Placa: ATMEGA 2560 CH340, Microcontrolador: ATmega2560, " +
            //    "Voltaje de operación USB: 5V, Voltaje de entrada Power Jack: 7V a 12V(Recomendado), USB - Serial CH340, Pines de E / S Digital: 54(15 son PWM), " +
            //    "Pines Analógicos: 16 entradas, Corriente DC por cada pin de E / S: 40m, Corriente DC para el pin de 3.3V: 50mA, Memoria Flash: " +
            //    "256 KB de los cuales 8 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito9 = new ComponentesElectronicos("Nano Tipo C", 5, 4200,148,  "Microcontrolador: ATMEGA328P, Conversor serial a USB: CH340, " +
            //    "Voltaje de operación: 5V, Voltaje de entrada recomendado(Vin): 7V a 12V, Pines Digitales I/ O: 14(de los cuales 6 son PWM), Salidas PWM: 6(D3, D5, D6, D9, D10, D11), " +
            //    "Entradas Analógicas: 8(de A0 – A7), Corriente máxima por pin: 40mA(se recomienda 20 mA), Memoria Flash: 32 KB;" +
            //    " de los cuales 2 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            //ComponentesElectronicos circuito10 = new ComponentesElectronicos("Nano Expansion", 5, 1980,149, "tipo: Shield para Arduino Nano, Voltaje de alimentación: 4.8V a 12V(Power jack), " +
            //    "Regulador de voltaje: AMS1117 3.3V, Led de PWR, Botón de RESET, 14 pines de E / S(tipo servo con GND, potencia y señal), 8 pines analógicos con salida de Voltaje y GND" +
            //    "Diseño tipo Arduino UNO, 4 barrenos de sujeción con Ø3mm", ECategoriaElectronico.CircuitosIntegrados);

            ////Plaquetas - material - tamaño 15x30
            //ComponentesElectronicos plaqueta1 = new ComponentesElectronicos("PLaqueta Cobre", 12, 800,150,  "3 Unidades Plaqueta Cobre Pertinax 10x10 Lisa Simple Faz", ECategoriaElectronico.Plaquetas);
            //ComponentesElectronicos plaqueta2 = new ComponentesElectronicos("Experimental Arduin", 4, 1079,151,  "Plaqueta Experimental de 15cm x 9cm Doble Faz, Material:" +
            //    "Epoxi FR4 agujeros metalizados", ECategoriaElectronico.Plaquetas);
            //ComponentesElectronicos plaqueta3 = new ComponentesElectronicos("Plaqueta Fenólico", 5, 999,152, "Placa Plaqueta Fenólico 30x20 Simple Faz Cobre Pcb Pertinax"
            //    , ECategoriaElectronico.Plaquetas);
            //ComponentesElectronicos plaqueta4 = new ComponentesElectronicos("Plaqueta Pcb", 5, 1270,153, "5 Unidades Plaqueta Pcb Cobre Pertinax 10 X 5 Lisa 10x5"
            //    , ECategoriaElectronico.Plaquetas);
            //ComponentesElectronicos plaqueta5 = new ComponentesElectronicos("Placa Universal", 10, 729,154,  "Placa Universal Perforada 9x15 Doble para Prototipos ", ECategoriaElectronico.Plaquetas);

            ////Soldado
            //Otros soldador1 = new Otros("Estación de Soldado", 10, 19049,155,  "Estacion De Soldado 2 En 1 Gadnic 750w + Aire Caliente + Kit", ECategoriaElectronico.Soldado);
            //Otros soldador2 = new Otros("Pistola Aire", 3, 19250,156,  "Estacion De Soldado Pistola Aire Smd Soldador Apagado Auto", ECategoriaElectronico.Soldado);
            //Otros soldador3 = new Otros("Estaño", 100, 299,157,  "Estaño Para Soldador En Rollo Electronica Soldado Yihua 250g", ECategoriaElectronico.Soldado);
            //Otros soldador4 = new Otros("Kit 7 Puntas", 6, 2405,158,  "Kit 7 Puntas Estacion Soldado Electronica 900m 936 937 907", ECategoriaElectronico.Soldado);
            //Otros soldador5 = new Otros("Cautín", 9, 2199,159, "Soldador De Estaño Lapiz Cautin Para Soldar Punta Ceramica", ECategoriaElectronico.Soldado);

            ////Limpieza
            //Otros limpieza1 = new Otros("Limpiador Contactos", 5, 1729,160, "Contact Matic Super Verde Delta Grande 440cc/450g", ECategoriaElectronico.Limpieza);
            //Otros limpieza2 = new Otros("Alcohol Isopropílico", 4, 800,161, "Alcohol compatible con la limpieza de circuítos electrónicos", ECategoriaElectronico.Limpieza);
            //Otros limpieza3 = new Otros("Cepillo antiestática", 4, 600,162,  "Cepillo Anti Estatico Para Limpieza Plaquetas Pc Electronica", ECategoriaElectronico.Limpieza);
            //Otros limpieza4 = new Otros("Limpiador Placas", 5, 1320,163,  "ALTA PUREZA 99,83% - 500cc, Marca: DELTA, Modelo: PHA - 440m Presentación: Aerosol 440 cc", ECategoriaElectronico.Limpieza);
            //Otros limpieza5 = new Otros("Resina", 30, 1100,164, "Resina De Limpieza De Soldadores Delta 40g", ECategoriaElectronico.Limpieza);
            //Otros limpieza6 = new Otros("Aire Comprimido", 25, 700,165,  "AIRE COMPRIMIDO X 180cc / 160g 1° DELTA", ECategoriaElectronico.Limpieza);
            //Otros limpieza7 = new Otros("Kit Celulares", 12, 3658,166,  "Kit para la limpieza y mantenimiento de equipos de telefonía celular y fija," +
            //    "Laptops, Notebooks y electronica en general.", ECategoriaElectronico.Limpieza);
            //Otros limpieza8 = new Otros("LSD Screen Clean", 14, 1190,167, "Kit Lipieza Pantallas Celulares Leds ( X 2 )", ECategoriaElectronico.Limpieza);
            //Otros limpieza9 = new Otros("Kit Limpieza Soldador", 11, 2430,168,"Puntas para limpieza de estaciones de soldado", ECategoriaElectronico.Limpieza);
            //Otros limpieza10 = new Otros("Malla Estaño", 9, 250,169,  "Malla para limpieza de estaño", ECategoriaElectronico.Limpieza);

            ////Herramientas
            //Otros herramienta1 = new Otros("Multímetro", 24, 3030,170, "Multímetro Tester Digital Medidor Baw 113a", ECategoriaElectronico.Herramientas);
            //Otros herramienta2 = new Otros("Pinza Amp", 11, 15936,171, "Pinza amperimétrica digital Uni - T UT210D 200A", ECategoriaElectronico.Herramientas);
            //Otros herramienta3 = new Otros("Mult+ Pinza", 5, 5707,172, "ESTER DIGITAL MULTIMETRO BAW 113C BUZZER IMAN NCV DISPLAY LUZ + Pinza", ECategoriaElectronico.Herramientas);
            //Otros herramienta4 = new Otros("Lapiz BuscapoloVolt", 14, 1899,173, "Tester Busca Polo Voltaje Luz Sin Contacto Con Indicador", ECategoriaElectronico.Herramientas);
            //Otros herramienta5 = new Otros("Mini Amperímetro", 1, 2098, 174, "Mini Amperímetro digital con visor LED ROJO., Alcance 100A, con " +
            //    "transformador toroidal(TI) provisto.", ECategoriaElectronico.Herramientas);
            //Otros herramienta6 = new Otros("Voltímetro", 6, 599,175, "Voltimetro Digital Dc Panel 0.36p Led Mini Verde", ECategoriaElectronico.Herramientas);
            //Otros herramienta7 = new Otros("Tester Acrílico", 7, 4303, 176, "Tester Con Acrilico Diodo Triodo Transistor Esr Lcr-t4 Mega3", ECategoriaElectronico.Herramientas);
            //Otros herramienta8 = new Otros("Tester Capacitancia", 8, 3412, 177, "Tester Capacitancia Diodo Triodo Transistor Esr Mos Npn Lcr", ECategoriaElectronico.Herramientas);
            //Otros herramienta9 = new Otros("Tester Probador", 9, 7999, 178,"Tester Probador De Componentes Tc1 - Capacitores Esr Capache", ECategoriaElectronico.Herramientas);
            //Otros herramienta10 = new Otros("Probador Led Lcd", 10, 10499, 179, "Probador portátil de tiras Backlight o LED individuales." +
            //    "Aplicable a cualquier tamaño de TV LED", ECategoriaElectronico.Herramientas);

            ////ControlTermico
            //Otros controladorTermico1 = new Otros("Pasta termica", 15, 2011,180,  "Jeringa Pasta Térmica Arctic Mx-4 2grs Original 8.5w/mk + Clean Pad ", ECategoriaElectronico.ControlTermico);
            //Otros controladorTermico2 = new Otros("Grasa siliconada", 16, 3990,  181,"Pote - Pasta Termica Disipador De Calor Cpu Gpu Pote X 100 G", ECategoriaElectronico.ControlTermico);
            //Otros controladorTermico3 = new Otros("Clean prep Pad", 15, 390,182,  "Removedor para circuitos", ECategoriaElectronico.ControlTermico);
            //Otros controladorTermico4 = new Otros("Cooler ref. Liquida", 14, 21079,183,  "Enfriador de agua AIO con CPU todo en uno multi-compatible " +
            //    "con A-RGB, Compatible con Intel y AMD, bomba eficiente controlada por PWM, Velocidad del ventilador: 650-2000 RPM - Negro", ECategoriaElectronico.ControlTermico);
            //Otros controladorTermico5 = new Otros("Cooler Fan", 5, 7700,184,  "Material: Marco metálico – hélice plástica, Alimentación: 220 Vac – 0.25 A, " +
            //    "Tipo de transmisión: Ruleman", ECategoriaElectronico.ControlTermico);

            
            catalogo.Add(1000,led1); 
            catalogo.Add(1001,led2); 
            catalogo.Add(1002,led3); 
            //catalogo.Add(1003,led4); 
            //catalogo.Add(1004,led5); 
            //catalogo.Add(1005,led6); 
            //catalogo.Add(1006,led7); 
            //catalogo.Add(1007,led8); 
            //catalogo.Add(1008,led9); 
            //catalogo.Add(1009,led10);
            //catalogo.Add(1010,bobina1); 
            //catalogo.Add(1011,bobina2); 
            //catalogo.Add(1012,bobina3); 
            //catalogo.Add(1013,bobina4); 
            //catalogo.Add(1014,bobina5); 
            //catalogo.Add(1015,bobina6); 
            //catalogo.Add(1016,bobina7); 
            //catalogo.Add(1017,bobina8); 
            //catalogo.Add(1018,bobina9); 
            //catalogo.Add(1019,bobina10);
            //catalogo.Add(1020,capacitor1); 
            //catalogo.Add(1021,capacitor2); 
            //catalogo.Add(1022,capacitor3); 
            //catalogo.Add(1023,capacitor4); 
            //catalogo.Add(1024,capacitor5); 
            //catalogo.Add(1025,capacitor6); 
            //catalogo.Add(1026,capacitor7); 
            //catalogo.Add(1027,capacitor8); 
            //catalogo.Add(1028,capacitor9); 
            //catalogo.Add(1029,capacitor10);
            //catalogo.Add(1030,conector1);
            //catalogo.Add(1031,conector2);
            //catalogo.Add(1032,conector3);
            //catalogo.Add(1033,conector4);
            //catalogo.Add(1034,conector5);
            //catalogo.Add(1035,conector6);
            //catalogo.Add(1036,conector7);
            //catalogo.Add(1037,conector8);
            //catalogo.Add(1038,conector9);
            //catalogo.Add(1039,conector10);
            //catalogo.Add(1040,circuito1); 
            //catalogo.Add(1041,circuito2); 
            //catalogo.Add(1042,circuito3); 
            //catalogo.Add(1043,circuito4); 
            //catalogo.Add(1044,circuito5); 
            //catalogo.Add(1045,circuito6); 
            //catalogo.Add(1046,circuito7); 
            //catalogo.Add(1047,circuito8); 
            //catalogo.Add(1048,circuito9); 
            //catalogo.Add(1049,circuito10);
            //catalogo.Add(1050,plaqueta1);
            //catalogo.Add(1051,plaqueta2);
            //catalogo.Add(1052,plaqueta3);
            //catalogo.Add(1053,plaqueta4);
            //catalogo.Add(1054,plaqueta5);
            //catalogo.Add(1055,soldador1);
            //catalogo.Add(1056,soldador2);
            //catalogo.Add(1057,soldador3);
            //catalogo.Add(1058,soldador4);
            //catalogo.Add(1059,soldador5);
            //catalogo.Add(1060,limpieza1); 
            //catalogo.Add(1061,limpieza2); 
            //catalogo.Add(1062,limpieza3); 
            //catalogo.Add(1063,limpieza4); 
            //catalogo.Add(1064,limpieza5); 
            //catalogo.Add(1065,limpieza6); 
            //catalogo.Add(1066,limpieza7); 
            //catalogo.Add(1067,limpieza8); 
            //catalogo.Add(1068,limpieza9); 
            //catalogo.Add(1069,limpieza10);
            //catalogo.Add(1070,herramienta1);
            //catalogo.Add(1071,herramienta2);
            //catalogo.Add(1072,herramienta3);
            //catalogo.Add(1073,herramienta4);
            //catalogo.Add(1074,herramienta5);
            //catalogo.Add(1075,herramienta6);
            //catalogo.Add(1076,herramienta7);
            //catalogo.Add(1077,herramienta8);
            //catalogo.Add(1078,herramienta9);
            //catalogo.Add(1079,herramienta10);
            //catalogo.Add(1080,controladorTermico1);
            //catalogo.Add(1081,controladorTermico2);
            //catalogo.Add(1082,controladorTermico3);
            //catalogo.Add(1083,controladorTermico4);
            //catalogo.Add(1084,controladorTermico5);
            


        }
    }
}
