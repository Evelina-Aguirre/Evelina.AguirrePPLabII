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
            Producto led4 = new Producto("Led 1w", 1250, 103, "Led Blanco Frio Backlight 3528 3v 1w Tv LG " +
                "X 50 Unidades", ECategoriaElectronico.Leds);
            Producto led5 = new Producto("Led SMD 3030", 2370, 104, "50 Unidades Led Smd 3030 6v 2w Pct Simetrico 3mm " +
                "X 3mm", ECategoriaElectronico.Leds);
            Producto led6 = new Producto("Led Cob 50w",1188, 105, "Led Cob 50w Blanco Frio 220v C/bornera 6000/6500k",
                ECategoriaElectronico.Leds);
            Producto led7 = new Producto("Tira LGB 5050", 1439, 106, "Tira Luces Led Rgb 5050 Usb 2 M Decoracion Gamer Tv" +
                " Pc Strip", ECategoriaElectronico.Leds);
            Producto led8 = new Producto("Conector L",202, 107, "Conector L Esquina Tiras Led 5050 Rgb Hebilla Sin Soldar" +
                " 90°", ECategoriaElectronico.Leds);
            Producto led9 = new Producto("Controladora RGB", 600, 108, "Controladora Para Tira Led Rgb 24 Teclas Control" +
                " Remoto 12v", ECategoriaElectronico.Leds);
            Producto led10 = new Producto("Controladora COB", 720, 109, "Controladora Para Tira Led Cob 24 Teclas Control" +
                " Remoto 12v", ECategoriaElectronico.Leds);

            //Bobinas Inductancia:  22uH, 33uH, 47uH, 56uH, 100uH, 220uH, 330uH(MicroHenrio
            Producto bobina1 = new Producto("Bobina 22uH",  640, 110, "Tipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente",
            ECategoriaElectronico.Bobinas);
            Producto bobina2 = new Producto("Bobina 33uH", 660, 111, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina3 = new Producto("Bobina 33uH", 680, 112, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina4 = new Producto("Bobina 47uH", 700, 113, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina5 = new Producto("Bobina 56uH", 720, 114, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina6 = new Producto("Bobina 100uH", 740, 115, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina7 = new Producto("Bobina 220uH", 760, 116, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina8 = new Producto("Bobina 330uH",780, 117, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina9 = new Producto("Bobina 470uH", 800, 118, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);
            Producto bobina10 = new Producto("Bobina 470uH 50u", 2500, 119, "ipo: Bobina Toroidal" +
            "Estilo de montaje: Vertical Corriente Máxima: 3A , Núcleo: Ferrita, Baja radiación, Baja pérdida de núcleo, Gran capacidad de corriente", ECategoriaElectronico.Bobinas);

            //Capacitores transistores - voltaje - potencia
            Producto capacitor1 = new Producto("Kit capacitores", 355, 120,
                "Kit de capacitores cerámicos, Montaje: SMD, Encapsulado: 0603, Rango de capacitancia: 0.5PF a 10UF, Número de compartimientos: 128," +
                "Valores disponibles: 92, Cantidad por cada valor: 100, Color del estuche: Gris", ECategoriaElectronico.Capacitores);
            Producto capacitor2 = new Producto("Cerámico 1uF 16V", 10, 121, "Valor: 1 uF, Tolerancia: ± 10 %, Voltaje: " +
                "16VEmpaquetado: SMD / SMT, Dimensiones: 0805(Pulgadas) / 20 - 12 mm, Código Dieléctrico: X5R, Fabricación: Cerámico Multicapa MLCC, " +
                "RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            Producto capacitor3 = new Producto("Cerámico 20pF 50V",  70, 122, "Valor: 20pF, Tolerancia: ±5 %,Voltaje: 50V" +
                "Empaquetado: SMD / SMT, Dimensiones: 0603(Pulgadas), Fabricación: Cerámico Multicapa MLCC,HS: Libre de plomo",
                ECategoriaElectronico.Capacitores);
            Producto capacitor4 = new Producto("Poliéster 630V",  73, 123, "Tipo: Capacitor de poliéster, Tolerancia: J = +/ -5 % " +
                "Tipo de montaje: Agujeros pasantes THT, Voltaje Max: 630V", ECategoriaElectronico.Capacitores);
            Producto capacitor5 = new Producto("Poliéster 100V",  90, 124, "Tipo: Capacitor de poliéster,Tolerancia: J = +/ -5 %, " +
                "Tipo de montaje: Agujeros pasantes THT, Voltaje Max: 100V, Capacitancia: 100nf, Dimensiones: 6.6mm x 5.8mm, Longitud de los pines: " +
                "23mm", ECategoriaElectronico.Capacitores);
            Producto capacitor6 = new Producto("Electrolítico 400V",  67, 125, "Tipo: Capacitor Electrolítico, Valor: 330uF," +
                "Voltaje Max.: 400V, Tolerancia de error: ± 20 % (120Hz 20 ℃), Resistencia a la temperatura: 105 ℃, Ciclo de vida: Aprox. 2000 horas(menos de 105 ℃)," +
                "Forma: Cilíndrica, Marca: JCCON, Dimensiones: Alto: 40mm x Ancho: 25mm", ECategoriaElectronico.Capacitores);
            Producto capacitor7 = new Producto("Cerámico 100nF", 10, 126, "Capacitor Cerámico, Tipo de montaje: A través del orificio THT," +
                "Número de pines: 2, Capacitancia: 100nF | 0.1uF | 104, Posición de montaje: Vertical, Voltaje Máx.: 50V, Tolerancia: ±80 % 20 %,Dieléctrico: Y5V " +
                "Pitch: 2.54mm, Dimensiones:  Ø4.5mm x 1.8mm Grosorm, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            Producto capacitor8 = new Producto("Electrolítico 470uF", 12, 127, "Valor: 470uF, Tolerancia: ± 20 % (120Hz, +20°C), " +
                "Voltaje: 35V, Empaquetado: SMD / SMT, Dimensiones: 10mm diámetro x 10.2mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            Producto capacitor9 = new Producto("Electrolítico 330uF", 15, 128, "Valor: 330uF, Tolerancia: ± 20 %, Voltaje: 10V, " +
                "Empaquetado: SMD / SMT, Dimensiones: 6.3mm diámetro x 7.7mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);
            Producto capacitor10 = new Producto("Electrolítico 220uF",  16, 129, "Valor: 220uF, Tolerancia: ± 20 %, Voltaje: 50V, " +
                "Empaquetado: SMD / SMT, Dimensiones: 10mm diámetro x 10.2mm Altura, RoHS: Libre de plomo", ECategoriaElectronico.Capacitores);

            //Conectores - canyidad de pines 
            Producto conector1 = new Producto(" Audio", 250, 130, "Conector de Audio XLR 3 Pines Negro Macho / Hembra"
                , ECategoriaElectronico.Conectores);
            Producto conector2 = new Producto("USB 16 pines", 250, 131, "Tipo de Conector: SMD, Modelo: Type C 16P USB3.1," +
                "Numero de pines: 16, Velocidad Máxima de Transmisión: 10 gbit, Potencia: 100w", ECategoriaElectronico.Conectores);
            Producto conector3 = new Producto("USB 4 pines", 0, 132, "Conector: USB, Tipo de montaje: Superficial SMD, " +
                "Numero de Pines: 4, Tipo de conector: Tipo A, Tipo de contacto: Macho", ECategoriaElectronico.Conectores);
            Producto conector4 = new Producto("Conector XH2.54mm", 750, 133, "Tipo: Conector JST XH con cable, Conector de tipo: Hembra," +
                "Calibre del cable: Cable 26AWG, Longitud del cable: 20cm, Pines: 2, 3, 4, 5 y 6, Paso(Pitch): 2.54 mm", ECategoriaElectronico.Conectores);
            Producto conector5 = new Producto("PH2.0mm 8",350, 134, "Conector: JST, Serie: PH, Tipo de contacto: Macho," +
                "Pitch: 2.0mm, Posición de montaje: Vertical, Tipo de montaje: Superficial SMD, Pines 8", ECategoriaElectronico.Conectores);
            Producto conector6 = new Producto("PH2.0mm 6", 225, 135, "Conector: JSTm, Serie: PH, Tipo de contacto: Macho," +
                "Pitch: 2.0mm, Posición de montaje: Horizontal, Tipo de montaje: Superficial SMD, Número de pines: 6", ECategoriaElectronico.Conectores);
            Producto conector7 = new Producto("PH2.0mm 4 pines", 430, 136, "Material aislante: PBT, UL94V-0, Tipo de contacto: Hembra, " +
                "Temperatura de trabajo: -25°C a + 85°C, Resistencias de contacto: 20mΩ Máx., Resistencia de aislamiento: 100MΩ Min., Terminal compatible: Terminal PH2.0mm, " +
                "Calibre de cable compatible: 26AWG", ECategoriaElectronico.Conectores);
            Producto conector8 = new Producto("RJ45 Mach/Hemb", 170, 137, "Tipo: Conector RJ45 con Terminales, Conector: Disponible Macho y Hembra, " +
                "Estándar del cableado: EIA / TIA 568B,Material: PVC + Metal, Color: Negro + Verde, Incluyen terminales de 8 pines, Funcionan muy bien para " +
                "dividir pares de cable UTP y cámara CCTV", ECategoriaElectronico.Conectores);
            Producto conector9 = new Producto("RJ45 UTP cat 5", 90, 138, "Categoría: CAT5,Marca: Kai Ping, Número de contactos: 8, " +
                "Compatible: 568 - A y 568 - B, Diámetro Cu - conductor: 22 - 26 AWG, Tamaño de pines: 50 micro pulgadas, Temperatura de Trabajo: -40 °C to +80 °C, " +
                "Color: Transparente", ECategoriaElectronico.Conectores);
            Producto conector10 = new Producto("JST PH 5 Pin 2.00mm", 50, 139, "Conectores JST PH Vertical, Tipo de montaje: A través del " +
                "orificio THT, Número de pines: 5p ,Pitch: 2mm,Tipo de contacto: Macho, Posición de montaje: Vertical, RoHS: Libre de plomo", ECategoriaElectronico.Conectores);


            //Circuitos Integrados - Comparibilidad arduino uno si / no
            Producto circuito1 = new Producto("Tuch Arduino", 3500, 140, "Tipo: Shield TFT Touch, Tamaño de pantallas: 2.4″, Driver IC ILI9341," +
                "Voltaje de funcionamiento: 5V / 3.3V, Consumo de energía: 90mw, Interfaz de módulo Interfaz paralela de 8 bits, Resolución: 320 x 240 px, " +
                "Color de pantalla RGB 65K color", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito2 = new Producto("Due Core ATmel",  1820, 141, "Microcontrolador: AT91SAM3X8EA, Bits: 32, Voltaje de operación: 3.3V, " +
                "Voltaje de entrada: 7V a 12V(recomendado), Pines Digitales I / O: 54(de los cuales 12 son PWM), Entradas Analógicas: 12 entradas, Comunicación: UART(4) , TWI(2), " +
                "Digital / Analógica : 2, Conversor Digital/ Analógico: 2, Reproducción de Archivos WAV: SI, Corriente Directa por Pin: 130 mA, " +
                "Corriente Directa por Pin de 3.3v: 800 mA, Memoria Flash: 512 KB; de los cuales 0.5 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito3 = new Producto("CNC Shield V3", 1700, 142, "Compatible Arduino uno, Shield CNC 3.0, Alimentación: 12 - 36V DC. " +
                "(Dependiendo de los controladores utilizados), " +
                "Soporte para 4 ejes(X, Y, Z, A), Soporta hasta 6 finales de carrera 2 por cada eje X, Y y Z, Compatible con el software GRBL, Jumpers para control de micro - stepping, " +
                "Los motores pueden ser conectados con bornes tipo Molex de 4 pines, Dimensiones: 6.9 cm X 5.3 cm X 1.9 cm", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito4 = new Producto("USB Host Shield ",  1250, 143, "Modelo: USB Host Shield, Dimensiones: 53.5mm x 53mm, " +
                "Interfaz SPI, Conector USB Tipo A hembra, Provee alimentación para el dispositivo esclavo, Compatibilidad: Arduino UNO / Diecimila / Duemilanove / MEGA 2560 / MEGA 1280" +
                "Peso: 16g", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito5 = new Producto("Shield Multifuncional", 2125, 144, "ipo: Shield, Dimensiones Aprox.: 68.5 mm x 53.5mm x 17mm," +
                "Peso:20g, Voltaje de Alimentación: 5V DC, Compatible con Uno, Mega, Leonardo y otros Arduinos de 5V que utilizan el diseño de pines Uno R3" +
                "Comunicación I2C y UART(RX / TX)", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito6 = new Producto("Arduino Uno Rev3",  2545, 145, "Microcontrolador: ATmega328P, Tensión de funcionamiento: 5V, " +
                "Voltaje de entrada(recomendado): 7 a 12 V, Voltaje de entrada(límite): 6 a 20 V, Pines de E / S digitales: 14(de los cuales 6 proporcionan salida PWM), " +
                "Pines de entrada analógica: 6, Corriente CC por pin de E / S: 20 mA, Corriente CC para pin de 3.3V: 50 mA, Memoria flash: 32 KB(ATmega328P) de los cuales " +
                "0,5 KB utiliza el gestor de arranque, SRAM: 2 KB(ATmega328P), EEPROM: 1 KB(ATmega328P), Velocidad de reloj: 16 MHz, Microcontrolador CMOS de 8 bits, " +
                "LED_BUILTIN 13, Largo 68.6 milímetros, Ancho 53.4 milímetros, Peso 25 g, No incluye cable USB", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito7 = new Producto("Arduino Mega", 2700, 146, "Microcontrolador ATmega2560, Tensión de funcionamiento: 5V, " +
                "Voltaje de entrada(recomendado): 7 - 12 V, Voltaje de entrada(límite): 6 - 20 V, Pines de E / S digitales: 54(de los cuales 15 proporcionan salida PWM), " +
                "Pines de entrada analógica: 16, Corriente CC por pin de E / S: 20 mA, Corriente CC para pin de 3.3V: 50 mA, Memoria flash: 256 KB de " +
                "los cuales 8 KB utiliza el gestor de arranque", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito8 = new Producto("ATMEGA 2560", 2950, 147, "Incluye USB, Placa: ATMEGA 2560 CH340, Microcontrolador: ATmega2560, " +
                "Voltaje de operación USB: 5V, Voltaje de entrada Power Jack: 7V a 12V(Recomendado), USB - Serial CH340, Pines de E / S Digital: 54(15 son PWM), " +
                "Pines Analógicos: 16 entradas, Corriente DC por cada pin de E / S: 40m, Corriente DC para el pin de 3.3V: 50mA, Memoria Flash: " +
                "256 KB de los cuales 8 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito9 = new Producto("Nano Tipo C", 4200, 148, "Microcontrolador: ATMEGA328P, Conversor serial a USB: CH340, " +
                "Voltaje de operación: 5V, Voltaje de entrada recomendado(Vin): 7V a 12V, Pines Digitales I/ O: 14(de los cuales 6 son PWM), Salidas PWM: 6(D3, D5, D6, D9, D10, D11), " +
                "Entradas Analógicas: 8(de A0 – A7), Corriente máxima por pin: 40mA(se recomienda 20 mA), Memoria Flash: 32 KB;" +
                " de los cuales 2 KB son usados por el bootloader", ECategoriaElectronico.CircuitosIntegrados);
            Producto circuito10 = new Producto("Nano Expansion", 1980, 149, "tipo: Shield para Arduino Nano, Voltaje de alimentación: 4.8V a 12V(Power jack), " +
                "Regulador de voltaje: AMS1117 3.3V, Led de PWR, Botón de RESET, 14 pines de E / S(tipo servo con GND, potencia y señal), 8 pines analógicos con salida de Voltaje y GND" +
                "Diseño tipo Arduino UNO, 4 barrenos de sujeción con Ø3mm", ECategoriaElectronico.CircuitosIntegrados);

            //Plaquetas - material - tamaño 15x30
            Producto plaqueta1 = new Producto("PLaqueta Cobre",  800, 150, "3 Unidades Plaqueta Cobre Pertinax 10x10 Lisa Simple Faz", ECategoriaElectronico.Plaquetas);
            Producto plaqueta2 = new Producto("Experimental Arduin", 1079, 151, "Plaqueta Experimental de 15cm x 9cm Doble Faz, Material:" +
                "Epoxi FR4 agujeros metalizados", ECategoriaElectronico.Plaquetas);
            Producto plaqueta3 = new Producto("Plaqueta Fenólico",  999, 152, "Placa Plaqueta Fenólico 30x20 Simple Faz Cobre Pcb Pertinax"
                , ECategoriaElectronico.Plaquetas);
            Producto plaqueta4 = new Producto("Plaqueta Pcb", 1270, 153, "5 Unidades Plaqueta Pcb Cobre Pertinax 10 X 5 Lisa 10x5"
                , ECategoriaElectronico.Plaquetas);
            Producto plaqueta5 = new Producto("Placa Universal", 729, 154, "Placa Universal Perforada 9x15 Doble para Prototipos ", ECategoriaElectronico.Plaquetas);

            //Soldado
            Producto soldador1 = new Producto("Estación de Soldado",  19049, 155, "Estacion De Soldado 2 En 1 Gadnic 750w + Aire Caliente + Kit", ECategoriaElectronico.Soldado);
            Producto soldador2 = new Producto("Pistola Aire",19250, 156, "Estacion De Soldado Pistola Aire Smd Soldador Apagado Auto", ECategoriaElectronico.Soldado);
            Producto soldador3 = new Producto("Estaño",  299, 157, "Estaño Para Soldador En Rollo Electronica Soldado Yihua 250g", ECategoriaElectronico.Soldado);
            Producto soldador4 = new Producto("Kit 7 Puntas", 2405, 158, "Kit 7 Puntas Estacion Soldado Electronica 900m 936 937 907", ECategoriaElectronico.Soldado);
            Producto soldador5 = new Producto("Cautín", 2199, 159, "Soldador De Estaño Lapiz Cautin Para Soldar Punta Ceramica", ECategoriaElectronico.Soldado);

            //Limpieza
            Producto limpieza1 = new Producto("Limpiador Contactos", 1729, 160, "Contact Matic Super Verde Delta Grande 440cc/450g", ECategoriaElectronico.Limpieza);
            Producto limpieza2 = new Producto("Alcohol Isopropílico", 800, 161, "Alcohol compatible con la limpieza de circuítos electrónicos", ECategoriaElectronico.Limpieza);
            Producto limpieza3 = new Producto("Cepillo antiestática", 600, 162, "Cepillo Anti Estatico Para Limpieza Plaquetas Pc Electronica", ECategoriaElectronico.Limpieza);
            Producto limpieza4 = new Producto("Limpiador Placas", 1320, 163, "ALTA PUREZA 99,83% - 500cc, Marca: DELTA, Modelo: PHA - 440m Presentación: Aerosol 440 cc", ECategoriaElectronico.Limpieza);
            Producto limpieza5 = new Producto("Resina",  1100, 164, "Resina De Limpieza De Soldadores Delta 40g", ECategoriaElectronico.Limpieza);
            Producto limpieza6 = new Producto("Aire Comprimido",  700, 165, "AIRE COMPRIMIDO X 180cc / 160g 1° DELTA", ECategoriaElectronico.Limpieza);
            Producto limpieza7 = new Producto("Kit Celulares",  3658, 166, "Kit para la limpieza y mantenimiento de equipos de telefonía celular y fija," +
                "Laptops, Notebooks y electronica en general.", ECategoriaElectronico.Limpieza);
            Producto limpieza8 = new Producto("LSD Screen Clean",  1190, 167, "Kit Lipieza Pantallas Celulares Leds ( X 2 )", ECategoriaElectronico.Limpieza);
            Producto limpieza9 = new Producto("Kit Limpieza Soldador",  2430, 168, "Puntas para limpieza de estaciones de soldado", ECategoriaElectronico.Limpieza);
            Producto limpieza10 = new Producto("Malla Estaño", 250, 169, "Malla para limpieza de estaño", ECategoriaElectronico.Limpieza);

            //Herramientas
            Producto herramienta1 = new Producto("Multímetro",  3030, 170, "Multímetro Tester Digital Medidor Baw 113a", ECategoriaElectronico.Herramientas);
            Producto herramienta2 = new Producto("Pinza Amp",  15936, 171, "Pinza amperimétrica digital Uni - T UT210D 200A", ECategoriaElectronico.Herramientas);
            Producto herramienta3 = new Producto("Mult+ Pinza",  5707, 172, "ESTER DIGITAL MULTIMETRO BAW 113C BUZZER IMAN NCV DISPLAY LUZ + Pinza", ECategoriaElectronico.Herramientas);
            Producto herramienta4 = new Producto("Lapiz BuscapoloVolt",  1899, 173, "Tester Busca Polo Voltaje Luz Sin Contacto Con Indicador", ECategoriaElectronico.Herramientas);
            Producto herramienta5 = new Producto("Mini Amperímetro",  2098, 174, "Mini Amperímetro digital con visor LED ROJO., Alcance 100A, con " +
                "transformador toroidal(TI) provisto.", ECategoriaElectronico.Herramientas);
            Producto herramienta6 = new Producto("Voltímetro",  599, 175, "Voltimetro Digital Dc Panel 0.36p Led Mini Verde", ECategoriaElectronico.Herramientas);
            Producto herramienta7 = new Producto("Tester Acrílico", 4303, 176, "Tester Con Acrilico Diodo Triodo Transistor Esr Lcr-t4 Mega3", ECategoriaElectronico.Herramientas);
            Producto herramienta8 = new Producto("Tester Capacitancia", 3412, 177, "Tester Capacitancia Diodo Triodo Transistor Esr Mos Npn Lcr", ECategoriaElectronico.Herramientas);
            Producto herramienta9 = new Producto("Tester Probador",  7999, 178, "Tester Probador De Componentes Tc1 - Capacitores Esr Capache", ECategoriaElectronico.Herramientas);
            Producto herramienta10 = new Producto("Probador Led Lcd",  10499, 179, "Probador portátil de tiras Backlight o LED individuales." +
                "Aplicable a cualquier tamaño de TV LED", ECategoriaElectronico.Herramientas);

            //ControlTermico
            Producto controladorTermico1 = new Producto("Pasta termica",  2011, 180, "Jeringa Pasta Térmica Arctic Mx-4 2grs Original 8.5w/mk + Clean Pad ", ECategoriaElectronico.ControlTermico);
            Producto controladorTermico2 = new Producto("Grasa siliconada",  3990, 181, "Pote - Pasta Termica Disipador De Calor Cpu Gpu Pote X 100 G", ECategoriaElectronico.ControlTermico);
            Producto controladorTermico3 = new Producto("Clean prep Pad",  390, 182, "Removedor para circuitos", ECategoriaElectronico.ControlTermico);
            Producto controladorTermico4 = new Producto("Cooler ref. Liquida",  21079, 183, "Enfriador de agua AIO con CPU todo en uno multi-compatible " +
                "con A-RGB, Compatible con Intel y AMD, bomba eficiente controlada por PWM, Velocidad del ventilador: 650-2000 RPM - Negro", ECategoriaElectronico.ControlTermico);
            Producto controladorTermico5 = new Producto("Cooler Fan", 7700, 184, "Material: Marco metálico – hélice plástica, Alimentación: 220 Vac – 0.25 A, " +
                "Tipo de transmisión: Ruleman", ECategoriaElectronico.ControlTermico);


            catalogo.Add(1000,led1); 
            catalogo.Add(1001,led2); 
            catalogo.Add(1002,led3);
            catalogo.Add(1003, led4);
            catalogo.Add(1004, led5);
            catalogo.Add(1005, led6);
            catalogo.Add(1006, led7);
            catalogo.Add(1007, led8);
            catalogo.Add(1008, led9);
            catalogo.Add(1009, led10);
            catalogo.Add(1010, bobina1);
            catalogo.Add(1011, bobina2);
            catalogo.Add(1012, bobina3);
            catalogo.Add(1013, bobina4);
            catalogo.Add(1014, bobina5);
            catalogo.Add(1015, bobina6);
            catalogo.Add(1016, bobina7);
            catalogo.Add(1017, bobina8);
            catalogo.Add(1018, bobina9);
            catalogo.Add(1019, bobina10);
            catalogo.Add(1020, capacitor1);
            catalogo.Add(1021, capacitor2);
            catalogo.Add(1022, capacitor3);
            catalogo.Add(1023, capacitor4);
            catalogo.Add(1024, capacitor5);
            catalogo.Add(1025, capacitor6);
            catalogo.Add(1026, capacitor7);
            catalogo.Add(1027, capacitor8);
            catalogo.Add(1028, capacitor9);
            catalogo.Add(1029, capacitor10);
            catalogo.Add(1030, conector1);
            catalogo.Add(1031, conector2);
            catalogo.Add(1032, conector3);
            catalogo.Add(1033, conector4);
            catalogo.Add(1034, conector5);
            catalogo.Add(1035, conector6);
            catalogo.Add(1036, conector7);
            catalogo.Add(1037, conector8);
            catalogo.Add(1038, conector9);
            catalogo.Add(1039, conector10);
            catalogo.Add(1040, circuito1);
            catalogo.Add(1041, circuito2);
            catalogo.Add(1042, circuito3);
            catalogo.Add(1043, circuito4);
            catalogo.Add(1044, circuito5);
            catalogo.Add(1045, circuito6);
            catalogo.Add(1046, circuito7);
            catalogo.Add(1047, circuito8);
            catalogo.Add(1048, circuito9);
            catalogo.Add(1049, circuito10);
            catalogo.Add(1050, plaqueta1);
            catalogo.Add(1051, plaqueta2);
            catalogo.Add(1052, plaqueta3);
            catalogo.Add(1053, plaqueta4);
            catalogo.Add(1054, plaqueta5);
            catalogo.Add(1055, soldador1);
            catalogo.Add(1056, soldador2);
            catalogo.Add(1057, soldador3);
            catalogo.Add(1058, soldador4);
            catalogo.Add(1059, soldador5);
            catalogo.Add(1060, limpieza1);
            catalogo.Add(1061, limpieza2);
            catalogo.Add(1062, limpieza3);
            catalogo.Add(1063, limpieza4);
            catalogo.Add(1064, limpieza5);
            catalogo.Add(1065, limpieza6);
            catalogo.Add(1066, limpieza7);
            catalogo.Add(1067, limpieza8);
            catalogo.Add(1068, limpieza9);
            catalogo.Add(1069, limpieza10);
            catalogo.Add(1070, herramienta1);
            catalogo.Add(1071, herramienta2);
            catalogo.Add(1072, herramienta3);
            catalogo.Add(1073, herramienta4);
            catalogo.Add(1074, herramienta5);
            catalogo.Add(1075, herramienta6);
            catalogo.Add(1076, herramienta7);
            catalogo.Add(1077, herramienta8);
            catalogo.Add(1078, herramienta9);
            catalogo.Add(1079, herramienta10);
            catalogo.Add(1080, controladorTermico1);
            catalogo.Add(1081, controladorTermico2);
            catalogo.Add(1082, controladorTermico3);
            catalogo.Add(1083, controladorTermico4);
            catalogo.Add(1084, controladorTermico5);



        }
    }
}
