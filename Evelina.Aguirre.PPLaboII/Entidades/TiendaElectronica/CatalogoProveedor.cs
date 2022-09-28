using System.Collections.Generic;

namespace Entidades.Tienda
{
    public static class CatalogoProveedor
    {
        public static List<Producto> catalogo;

        static CatalogoProveedor()
        {
            catalogo = new List<Producto>();
            CargarCatalogo();
        }

        public static List<Producto> Catalogo
        {
            get
            {
                return catalogo;
            } 
        }
        /// <summary>
        /// Carga la lista que contendrá el catálogo de productos que ofrece quien provee la tienda electrónica.
        /// </summary>
        public static void CargarCatalogo()
        {
            //Leds
            ComponentesElectronicos led1 = new ComponentesElectronicos("", 100, 0, 100, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led2 = new ComponentesElectronicos("", 00, 0, 101, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led3 = new ComponentesElectronicos("", 00, 0, 102, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led4 = new ComponentesElectronicos("", 00, 0, 103, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led5 = new ComponentesElectronicos("", 00, 0, 104, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led6 = new ComponentesElectronicos("", 00, 0, 105, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led7 = new ComponentesElectronicos("", 00, 0, 106, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led8 = new ComponentesElectronicos("", 00, 0, 107, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led9 = new ComponentesElectronicos("", 00, 0, 108, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led10 = new ComponentesElectronicos("", 00, 0, 109, "", ECategoriaElectronico.Leds);

            //Bobinas
            ComponentesElectronicos bobina1 = new ComponentesElectronicos("", 9, 9.99, 110, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina2 = new ComponentesElectronicos("", 00, 0, 111, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina3 = new ComponentesElectronicos("", 00, 0, 112, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina4 = new ComponentesElectronicos("", 00, 0, 113, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina5 = new ComponentesElectronicos("", 00, 0, 114, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina6 = new ComponentesElectronicos("", 00, 0, 115, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina7 = new ComponentesElectronicos("", 00, 0, 116, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina8 = new ComponentesElectronicos("", 00, 0, 117, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina9 = new ComponentesElectronicos("", 00, 0, 118, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina10 = new ComponentesElectronicos("", 00, 0, 119, "", ECategoriaElectronico.Bobinas);

            //Capacitores
            ComponentesElectronicos capacitor1 = new ComponentesElectronicos("", 0, 355, 120, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor2 = new ComponentesElectronicos("", 00, 0, 121, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor3 = new ComponentesElectronicos("", 00, 0, 122, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor4 = new ComponentesElectronicos("", 00, 0, 123, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor5 = new ComponentesElectronicos("", 00, 0, 124, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor6 = new ComponentesElectronicos("", 00, 0, 125, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor7 = new ComponentesElectronicos("", 00, 0, 126, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor8 = new ComponentesElectronicos("", 00, 0, 127, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor9 = new ComponentesElectronicos("", 00, 0, 128, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor10 = new ComponentesElectronicos("", 00, 0, 129, "", ECategoriaElectronico.Capacitores);

            //Conectores
            ComponentesElectronicos conector1 = new ComponentesElectronicos("", 0, 120, 130, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector2 = new ComponentesElectronicos("", 00, 0, 131, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector3 = new ComponentesElectronicos("", 00, 0, 132, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector4 = new ComponentesElectronicos("", 00, 0, 133, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector5 = new ComponentesElectronicos("", 00, 0, 134, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector6 = new ComponentesElectronicos("", 00, 0, 135, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector7 = new ComponentesElectronicos("", 00, 0, 136, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector8 = new ComponentesElectronicos("", 00, 0, 137, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector9 = new ComponentesElectronicos("", 00, 0, 138, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector10 = new ComponentesElectronicos("", 00, 0, 139, "", ECategoriaElectronico.Conectores);


            //Circuitos Integrados
            ComponentesElectronicos circuito1 = new ComponentesElectronicos("", 00, 0, 140, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito2 = new ComponentesElectronicos("", 00, 0, 141, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito3 = new ComponentesElectronicos("", 00, 0, 142, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito4 = new ComponentesElectronicos("", 00, 0, 143, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito5 = new ComponentesElectronicos("", 00, 0, 144, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito6 = new ComponentesElectronicos("", 00, 0, 145, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito7 = new ComponentesElectronicos("", 00, 0, 146, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito8 = new ComponentesElectronicos("", 00, 0, 147, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito9 = new ComponentesElectronicos("", 00, 0, 148, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito10 = new ComponentesElectronicos("", 00, 0, 149, "", ECategoriaElectronico.CircuitosIntegrados);

            //Plaquetas
            ComponentesElectronicos plaqueta1 = new ComponentesElectronicos("", 00, 0, 150, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta2 = new ComponentesElectronicos("", 00, 0, 151, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta3 = new ComponentesElectronicos("", 00, 0, 152, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta4 = new ComponentesElectronicos("", 00, 0, 153, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta5 = new ComponentesElectronicos("", 00, 0, 154, "", ECategoriaElectronico.Plaquetas);

            //Soldado
            Otros soldador1 = new Otros("", 00, 0, 1001, "", ECategoriaElectronico.Soldado);
            Otros soldador2 = new Otros("", 00, 0, 1002, "", ECategoriaElectronico.Soldado);
            Otros soldador3 = new Otros("", 00, 0, 1003, "", ECategoriaElectronico.Soldado);
            Otros soldador4 = new Otros("", 00, 0, 1004, "", ECategoriaElectronico.Soldado);
            Otros soldador5 = new Otros("", 00, 0, 1005, "", ECategoriaElectronico.Soldado);

            //Limpieza
            Otros limpieza1 = new Otros("", 00, 0, 1010, "", ECategoriaElectronico.Limpieza);
            Otros limpieza2 = new Otros("", 00, 0, 1011, "", ECategoriaElectronico.Limpieza);
            Otros limpieza3 = new Otros("", 00, 0, 1012, "", ECategoriaElectronico.Limpieza);
            Otros limpieza4 = new Otros("", 00, 0, 1013, "", ECategoriaElectronico.Limpieza);
            Otros limpieza5 = new Otros("", 00, 0, 1014, "", ECategoriaElectronico.Limpieza);
            Otros limpieza6 = new Otros("", 00, 0, 1015, "", ECategoriaElectronico.Limpieza);
            Otros limpieza7 = new Otros("", 00, 0, 1016, "", ECategoriaElectronico.Limpieza);
            Otros limpieza8 = new Otros("", 00, 0, 1017, "", ECategoriaElectronico.Limpieza);
            Otros limpieza9 = new Otros("", 00, 0, 1018, "", ECategoriaElectronico.Limpieza);
            Otros limpieza10 = new Otros("", 00, 0, 1019, "", ECategoriaElectronico.Limpieza);

            //Herramientas
            Otros herramienta1 = new Otros("", 00, 0, 1020, "", ECategoriaElectronico.Herramientas);
            Otros herramienta2 = new Otros("", 00, 0, 1021, "", ECategoriaElectronico.Herramientas);
            Otros herramienta3 = new Otros("", 00, 0, 1022, "", ECategoriaElectronico.Herramientas);
            Otros herramienta4 = new Otros("", 00, 0, 1023, "", ECategoriaElectronico.Herramientas);
            Otros herramienta5 = new Otros("", 00, 0, 1024, "", ECategoriaElectronico.Herramientas);
            Otros herramienta6 = new Otros("", 00, 0, 1025, "", ECategoriaElectronico.Herramientas);
            Otros herramienta7 = new Otros("", 00, 0, 1026, "", ECategoriaElectronico.Herramientas);
            Otros herramienta8 = new Otros("", 00, 0, 1027, "", ECategoriaElectronico.Herramientas);
            Otros herramienta9 = new Otros("", 00, 0, 1028, "", ECategoriaElectronico.Herramientas);
            Otros herramienta10 = new Otros("", 00, 0, 1029, "", ECategoriaElectronico.Herramientas);

            //ControlTermico
            Otros controladorTermico1 = new Otros("", 00, 0, 1030, "", ECategoriaElectronico.ControlTermico);
            Otros controladorTermico2 = new Otros("", 00, 0, 1031, "", ECategoriaElectronico.ControlTermico);
            Otros controladorTermico3 = new Otros("", 00, 0, 1032, "", ECategoriaElectronico.ControlTermico);
            Otros controladorTermico4 = new Otros("", 00, 0, 1033, "", ECategoriaElectronico.ControlTermico);
            Otros controladorTermico5 = new Otros("", 00, 0, 1034, "", ECategoriaElectronico.ControlTermico);

            
            catalogo.Add(led1); 
            catalogo.Add(led2); 
            catalogo.Add(led3); 
            catalogo.Add(led4); 
            catalogo.Add(led5); 
            catalogo.Add(led6); 
            catalogo.Add(led7); 
            catalogo.Add(led8); 
            catalogo.Add(led9); 
            catalogo.Add(led10);
            catalogo.Add(bobina1); 
            catalogo.Add(bobina2); 
            catalogo.Add(bobina3); 
            catalogo.Add(bobina4); 
            catalogo.Add(bobina5); 
            catalogo.Add(bobina6); 
            catalogo.Add(bobina7); 
            catalogo.Add(bobina8); 
            catalogo.Add(bobina9); 
            catalogo.Add(bobina10);
            catalogo.Add(capacitor1); 
            catalogo.Add(capacitor2); 
            catalogo.Add(capacitor3); 
            catalogo.Add(capacitor4); 
            catalogo.Add(capacitor5); 
            catalogo.Add(capacitor6); 
            catalogo.Add(capacitor7); 
            catalogo.Add(capacitor8); 
            catalogo.Add(capacitor9); 
            catalogo.Add(capacitor10);
            catalogo.Add(conector1);
            catalogo.Add(conector2);
            catalogo.Add(conector3);
            catalogo.Add(conector4);
            catalogo.Add(conector5);
            catalogo.Add(conector6);
            catalogo.Add(conector7);
            catalogo.Add(conector8);
            catalogo.Add(conector9);
            catalogo.Add(conector10);
            catalogo.Add(circuito1); 
            catalogo.Add(circuito2); 
            catalogo.Add(circuito3); 
            catalogo.Add(circuito4); 
            catalogo.Add(circuito5); 
            catalogo.Add(circuito6); 
            catalogo.Add(circuito7); 
            catalogo.Add(circuito8); 
            catalogo.Add(circuito9); 
            catalogo.Add(circuito10);
            catalogo.Add(plaqueta1);
            catalogo.Add(plaqueta2);
            catalogo.Add(plaqueta3);
            catalogo.Add(plaqueta4);
            catalogo.Add(plaqueta5);
            catalogo.Add(soldador1);
            catalogo.Add(soldador2);
            catalogo.Add(soldador3);
            catalogo.Add(soldador4);
            catalogo.Add(soldador5);
            catalogo.Add(limpieza1); 
            catalogo.Add(limpieza2); 
            catalogo.Add(limpieza3); 
            catalogo.Add(limpieza4); 
            catalogo.Add(limpieza5); 
            catalogo.Add(limpieza6); 
            catalogo.Add(limpieza7); 
            catalogo.Add(limpieza8); 
            catalogo.Add(limpieza9); 
            catalogo.Add(limpieza10);
            catalogo.Add(herramienta1);
            catalogo.Add(herramienta2);
            catalogo.Add(herramienta3);
            catalogo.Add(herramienta4);
            catalogo.Add(herramienta5);
            catalogo.Add(herramienta6);
            catalogo.Add(herramienta7);
            catalogo.Add(herramienta8);
            catalogo.Add(herramienta9);
            catalogo.Add(herramienta10);
            catalogo.Add(controladorTermico1);
            catalogo.Add(controladorTermico2);
            catalogo.Add(controladorTermico3);
            catalogo.Add(controladorTermico4);
            catalogo.Add(controladorTermico5);
            


        }
    }
}
