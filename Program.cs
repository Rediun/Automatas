using System;
using System.Threading;
using System.Diagnostics;
using System.Media;

class Program
{
    public static int equilibrio = 10;
    public static int modoForzado = 0;
    public static int turnosAnclados = 0;

    public static int monedas = 0;

    static void Main()
    {
        int q = 0;

        while (true)
        {
            if (turnosAnclados > 0)
            {
                turnosAnclados--;
                if (turnosAnclados == 0)
                {
                    modoForzado = 0;
                }
            }

            Console.Clear();
            Console.WriteLine("==================================================================");
            
            
            int eqVisual = equilibrio < 0 ? 0 : (equilibrio > 10 ? 10 : equilibrio);
            string barraCordura = new string('■', eqVisual) + new string('-', 10 - eqVisual);
            
            
            string visualMonedas = monedas > 0 ? new string('$', monedas > 5 ? 5 : monedas) + (monedas > 5 ? "+" : "") : "-";

            string textoMov = turnosAnclados > 0 ? (modoForzado == 1 ? "FORZADO: Caminar" : "FORZADO: Correr") : "LIBRE";

            
            Console.WriteLine($" MENTE  : [{barraCordura}] {equilibrio}  |  BOLSILLOS: [ {monedas} ] {visualMonedas}");
            
            if (turnosAnclados > 0)
            {
                Console.WriteLine($" ESTADO : {textoMov,-18} |  ANCLAJE  : {turnosAnclados} turnos");
            }
            else
            {
                Console.WriteLine($" ESTADO : {textoMov}");
            }
            Console.WriteLine("==================================================================\n");
            if (equilibrio <= 0)
            {
                q = 99;
            }

            switch (q)
            {
                // Nodos inciales 1, 2, y 3
                // Nodo principal
                case 0:
                    Console.WriteLine("--- [ LUGAR: q0 - Algo parecido a una casa ] ---\n");
                    string op0 = Historia.AlgoparecidoaCasa();
                    if (op0 == "1") 
                    { 
                        int mov = ElegirMovimiento("el Bar");
                        if (mov == 1) { q = 1;}
                        else { q = 1; equilibrio -= 1; }
                    }
                    else if (op0 == "2") 
                    { 
                        int mov = ElegirMovimiento("el Callejon");
                        if (mov == 1) { q = 2;}
                        else { q = 2; equilibrio -= 1; }
                    }
                    else if (op0 == "3") 
                    { 
                        int mov = ElegirMovimiento("la Casa");
                        if (mov == 1) { q = 3;}
                        else { q = 3; equilibrio -= 1; }
                    }
                    else if (op0 == "0") 
                    { 
                        TerminarJuego(0); 
                    }
                    break;


                //Este nodo usara la familia de los nodos 20
                //Nodo principal
                case 1:
                    Console.WriteLine("--- [ LUGAR: q1 - Bar ] ---\n");
                    
                    string op1 = Historia.Bar();
                    if (op1 == "1") 
                    {
                        Historia.BeberComoIdiota();
                        if (monedas == 0)
                        {
                            equilibrio -= 5; 
                            modoForzado = 1; 
                            turnosAnclados = 2;
                        }
                        else
                        {
                            equilibrio -= 5; 
                            modoForzado = 1; 
                            turnosAnclados = 2;
                            monedas = 0;
                        }
                        q = 20;
                    }
                    else if (op1 == "2") 
                    { 
                        Historia.EventoHablarBorracho();
                        equilibrio -= 2; 
                        q = 20; 
                    }
                    else if (op1 == "3") 
                    { 
                        int mov = ElegirMovimiento("afuera del bar");
                        if (mov == 1) { q = 20;}
                        else { q = 20; equilibrio -= 1; }
                    }
                    break;

                case 20:
                    Console.WriteLine("--- [ LUGAR: q20 - Afuera del bar ] ---\n");
                    string op20 = Historia.AfueraDelBar();
                    if (op20 == "1") 
                    { 
                        int mov = ElegirMovimiento("OxxO");
                        if (mov == 1) { q = 5;}
                        else { q = 5; equilibrio -= 1; }
                    }
                    else if (op20 == "2") 
                    { 
                        int mov = ElegirMovimiento("Auto");
                        if (mov == 1) { q = 4;}
                        else { q = 4; equilibrio -= 1; }
                    }
                    else if (op20 == "0") 
                    {
                        TerminarJuego(2);
                    }
                    break;

                //Este nodo usara la familia de los 30
                //Nodo Principal
                case 2:
                    Console.WriteLine("--- [ LUGAR: q2 - Callejon oscuro ] ---\n");
                    Historia.Callejon();
                    equilibrio -= 5;
                    modoForzado = 2;
                    turnosAnclados = 2;
                    q = 4;
                    int pap = ElegirMovimiento("sin rumbo");
                    if (pap == 1) { q = 4; }
                    else { q = 4; TerminarJuego(3); }
                    
                    break;

                //Este nodo usara la familia de los 40
                //Nodo Principal
                case 3:
                    Console.WriteLine("--- [ LUGAR: q3 - Casa Familiar ] ---\n");
                    string op3 = Historia.CasaMorrinson();
                    if (op3 == "1") 
                    { 
                        string op3_1 = Historia.CasaMorrinsonAdentro();
                        if (op3_1 == "1") { TerminarJuego(4); }
                        else if (op3_1 == "2") { q = 40; equilibrio -= 4; modoForzado = 2; turnosAnclados = 1; }
                    }
                    else if (op3 == "2") 
                    { 
                        int mov = ElegirMovimiento("fuera de la casa");
                        if (mov == 1) { q = 40;}
                        else { q = 40; equilibrio -= 1; }
                    }
                    break;

                case 40:
                    Console.WriteLine("--- [ LUGAR: q40 - Afuera de la casa ] ---\n");
                    string op40 = Historia.CasaMorrinsonAfuera();
                    if (op40 == "1") 
                    {
                        int mov = ElegirMovimiento("OxxO");
                        if (mov == 1) { q = 5;}
                        else { q = 5; equilibrio -= 1; }
                    }
                    else if (op40 == "2") 
                    { 
                        int mov = ElegirMovimiento("Auto");
                        if (mov == 1) { q = 4;}
                        else { q = 4; equilibrio -= 1; }
                    }
                    else if (op40 == "0") 
                    {
                        TerminarJuego(2);
                    }
                    break;

                //Este nodo usara la familia de los 50
                //Nodo Principal
                case 4:
                    Console.WriteLine("--- [ LUGAR: q4 - Auto ] ---\n");
                    if (equilibrio <= 5 && modoForzado == 2)
                    {
                        TerminarJuego(3);
                    }
                    string op4 = Historia.Auto();
                    if (op4 == "1") 
                    { 
                        Historia.AutoEntrar();
                        equilibrio = 0;
                    }
                    else if (op4 == "2") 
                    { 
                        int mov = ElegirMovimiento("Una... Casa? Un lugar seguro?");
                        if (mov == 1) { q = 6;}
                        else { q = 6; equilibrio -= 1; }
                    }
                    break;
                
                //Este nodo usara la familia de los 60
                //Nodo Principal
                case 5:
                    Console.WriteLine("--- [ LUGAR: q5 - Un pinchi OxxO ] ---\n");
                    string op5 = Historia.OxxO();
                    if (op5 == "1") 
                    { 
                        Historia.OxxOPedirCerveza();
                        q = 60;
                    }
                    else if (op5 == "2") 
                    { 
                        Historia.OxxORobar();
                        q = 60;
                    }
                    else if (op5 == "3") 
                    { 
                        Historia.OxxOAlagar();
                        q = 60;
                    }
                    else if (op5 == "0") 
                    {
                        if (monedas >= 99)
                        {
                            Historia.OxxOFinal();
                            Thread.Sleep(20000);
                        }
                        else
                        {
                            Historia.OxxOFinal();
                        }
                    }
                    break;

                case 60:
                    Console.WriteLine("--- [ LUGAR: q60 - Fuera del OxxO ] ---\n");
                    Historia.OxxOSalida();
                    int mov60 = ElegirMovimiento("Una... Casa? Un lugar seguro?");
                    if (mov60 == 1) { q = 6;}
                    else { q = 6; equilibrio -= 1; }
                    break;

                //Nodo final
                case 6:
                    Console.WriteLine("--- [ LUGAR: q6 - ¿Casa? ] ---\n");
                        Historia.MerecesMorir();
                        TerminarJuego(7);
    
                    break;

                case 99:
                    Historia.Finales(67);
                    Console.WriteLine("\n\nPresiona ENTER para reiniciar...");
                    Console.ReadLine();
                    equilibrio = 10;
                    modoForzado = 0;
                    turnosAnclados = 0;
                    q = 0;
                    break;

                default:
                    q = 0;
                    break;
            }
        }
    }

   public static void EscribirRetro(string texto, int velocidad, int tono = 800)
    {
        bool saltar = false;
        
        foreach (char c in texto)
        {
            if (!saltar && Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Spacebar || tecla.Key == ConsoleKey.Enter)
                {
                    saltar = true;
                }
            }

            Console.Write(c);

            if (!saltar)
            {
                if (OperatingSystem.IsWindows() && char.IsLetterOrDigit(c))
                {
                    try { Console.Beep(tono, 10); } catch { }
                }
                
                Thread.Sleep(velocidad);

                if (c == '\n')
                {
                    Thread.Sleep(500);
                }
            }
        }
        
        while (Console.KeyAvailable) 
        {
            Console.ReadKey(true);
        }
    }

    public static void TerminarJuego(int valor)
    {
        Console.WriteLine("\n\n=============================================================");
        switch (valor)
        {
            case 0:
                Historia.Finales(1);
                break;
            case 2:
                Historia.Finales(2);
                break;
            case 3:
                Historia.Finales(3);
                break;
            case 4:
                Historia.Finales(4);
                break;
            case 67:
                Historia.Finales(67);
                break;
            case 7:
                Historia.Finales(7);
                break;
        }

        
        Environment.Exit(0);
    }

    public static void Dialogo(string texto, int velocidad = 20)
    {
        EscribirRetro(texto, velocidad);
        Console.WriteLine("\n\n _ _ _");
        Console.ReadKey(true);
    }

    public static int ElegirMovimiento(string destino)
    {
        if (modoForzado == 1)
        {
            Console.WriteLine("\n[ANCLADO] Caminas hacia " + destino + "...");
            Thread.Sleep(1200);
            return 1;
        }
        else if (modoForzado == 2)
        {
            Console.WriteLine("\n[ANCLADO] Corres hacia " + destino + "...");
            Thread.Sleep(1200);
            return 2;
        }
        else
        {
            Console.WriteLine("\n¿Como vas hacia " + destino + "?");
            Console.WriteLine("1. Caminar (Seguro)");
            Console.WriteLine("2. Correr (Rapido)");
            Console.Write("Elige tu ritmo: ");
            
            while (true)
            {
                string ritmo = Console.ReadLine();
                if (ritmo == "1" || ritmo == "2")
                {
                    return int.Parse(ritmo);
                }
            }
        }
    }
}