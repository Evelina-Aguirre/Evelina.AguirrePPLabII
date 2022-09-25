using System.Collections.Generic;

namespace Entidades.Tienda
{
    public static class CatalogoProveedor
    {
        public static List<Producto> catalogo;

        static CatalogoProveedor()
        {
            CargarCatalogo();
        }

        public static void CargarCatalogo()
        {
            catalogo = new List<Producto>();

            //Leds
            ComponentesElectronicos led1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led6 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led7 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led8 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led9 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);
            ComponentesElectronicos led10 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Leds);

            //Bobinas
            ComponentesElectronicos bobina1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina6 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina7 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina8 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina9 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);
            ComponentesElectronicos bobina10 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Bobinas);

            //Capacitores
            ComponentesElectronicos capacitor1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor6 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor7 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor8 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor9 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);
            ComponentesElectronicos capacitor10 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Capacitores);

            //Conectores
            ComponentesElectronicos conector1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector6 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector7 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector8 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector9 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);
            ComponentesElectronicos conector10 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Conectores);


            //Circuitos Integrados
            ComponentesElectronicos circuito1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito6 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito7 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito8 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito9 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);
            ComponentesElectronicos circuito10 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.CircuitosIntegrados);

            //Plaquetas
            ComponentesElectronicos plaqueta1 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta2 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta3 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta4 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Plaquetas);
            ComponentesElectronicos plaqueta5 = new ComponentesElectronicos("", 00, 0, "", ECategoriaElectronico.Plaquetas);

            //Soldado
            Otros soldador1 = new Otros("", 00, 0, "", ECategoriasOtros.Soldado);
            Otros soldador2 = new Otros("", 00, 0, "", ECategoriasOtros.Soldado);
            Otros soldador3 = new Otros("", 00, 0, "", ECategoriasOtros.Soldado);
            Otros soldador4 = new Otros("", 00, 0, "", ECategoriasOtros.Soldado);
            Otros soldador5 = new Otros("", 00, 0, "", ECategoriasOtros.Soldado);

            //Limpieza
            Otros limpieza1 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza2 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza3 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza4 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza5 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza6 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza7 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza8 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza9 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);
            Otros limpieza10 = new Otros("", 00, 0, "", ECategoriasOtros.Limpieza);

            //Heerramientas
            Otros herramienta1 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta2 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta3 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta4 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta5 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta6 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta7 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta8 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta9 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);
            Otros herramienta10 = new Otros("", 00, 0, "", ECategoriasOtros.Herramientas);

            //ControlTermico
            Otros controladorTermico1 = new Otros("", 00, 0, "", ECategoriasOtros.ControlTermico);
            Otros controladorTermico2 = new Otros("", 00, 0, "", ECategoriasOtros.ControlTermico);
            Otros controladorTermico3 = new Otros("", 00, 0, "", ECategoriasOtros.ControlTermico);
            Otros controladorTermico4 = new Otros("", 00, 0, "", ECategoriasOtros.ControlTermico);
            Otros controladorTermico5 = new Otros("", 00, 0, "", ECategoriasOtros.ControlTermico);

            
            catalogo.Add(led1); catalogo.Add(bobina1); catalogo.Add(capacitor1); catalogo.Add(conector1); 
            catalogo.Add(led2); catalogo.Add(bobina2); catalogo.Add(capacitor2); catalogo.Add(conector2); 
            catalogo.Add(led3); catalogo.Add(bobina3); catalogo.Add(capacitor3); catalogo.Add(conector3); 
            catalogo.Add(led4); catalogo.Add(bobina4); catalogo.Add(capacitor4); catalogo.Add(conector4); 
            catalogo.Add(led5); catalogo.Add(bobina5); catalogo.Add(capacitor5); catalogo.Add(conector5); 
            catalogo.Add(led6); catalogo.Add(bobina6); catalogo.Add(capacitor6); catalogo.Add(conector6); 
            catalogo.Add(led7); catalogo.Add(bobina7); catalogo.Add(capacitor7); catalogo.Add(conector7); 
            catalogo.Add(led8); catalogo.Add(bobina8); catalogo.Add(capacitor8); catalogo.Add(conector8); 
            catalogo.Add(led9); catalogo.Add(bobina9); catalogo.Add(capacitor9); catalogo.Add(conector9); 
            catalogo.Add(led10); catalogo.Add(bobina10); catalogo.Add(capacitor10); catalogo.Add(conector10);

            catalogo.Add(circuito1); catalogo.Add(plaqueta1); catalogo.Add(limpieza1); catalogo.Add(herramienta1); 
            catalogo.Add(circuito2); catalogo.Add(plaqueta2); catalogo.Add(limpieza2); catalogo.Add(herramienta2); 
            catalogo.Add(circuito3); catalogo.Add(plaqueta3); catalogo.Add(limpieza3); catalogo.Add(herramienta3); 
            catalogo.Add(circuito4); catalogo.Add(plaqueta4); catalogo.Add(limpieza4); catalogo.Add(herramienta4); 
            catalogo.Add(circuito5); catalogo.Add(plaqueta5); catalogo.Add(limpieza5); catalogo.Add(herramienta5); 
            catalogo.Add(circuito6); catalogo.Add(soldador1); catalogo.Add(limpieza6); catalogo.Add(herramienta6); 
            catalogo.Add(circuito7); catalogo.Add(soldador2); catalogo.Add(limpieza7); catalogo.Add(herramienta7); 
            catalogo.Add(circuito8); catalogo.Add(soldador3); catalogo.Add(limpieza8); catalogo.Add(herramienta8); 
            catalogo.Add(circuito9); catalogo.Add(soldador4); catalogo.Add(limpieza9); catalogo.Add(herramienta9); 
            catalogo.Add(circuito10); catalogo.Add(soldador5); catalogo.Add(limpieza10); catalogo.Add(herramienta10); 


        }
    }
}
