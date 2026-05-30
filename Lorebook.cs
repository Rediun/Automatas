using System;
using System.Threading;
using System.Diagnostics;
using NAudio.Wave;

public class Historia
{
    // Dialogo con el borracho del q1, opcion 2
    public static void EventoHablarBorracho()
    {
        Program.EscribirRetro("\nTe acercas a alguien.\nUn viejo borracho que parecio verte de reojo.\nCuando te acercas no te dirije la mirada, no sabes que pregunar.\nSin necesidad de decir nada, te dice:", 20);
        Program.EscribirRetro("\n\n - ??? : Hace tiempo que no escuchaba nada asi...\nque... refrescante...", 30, 500);
        Program.Dialogo("\nTe ignora denuevo para seguir bebiendo, no dice nada mas.", 20);
    }

    // Evento del q1, opcion 1
    public static void BeberComoIdiota()
    {
        if (Program.monedas > 0)
        {
            Program.EscribirRetro("\nTe acercas a la barra.\nEl barman te mira con indiferencia.\nBuscas si tienes algunas monodas, tienes " + Program.monedas + " monedas.", 20);
            Program.EscribirRetro("\n\n - Barman : Curioso, no se supone que debas de tener monedas para este punto...", 20, 600);
            Program.EscribirRetro("\n\n - Barman : Bueno, no importa, que quieres beber?", 20);
            Program.EscribirRetro("\n\n De la manera mas seria que puedes decir, le pides una cerveza:", 20, 600);
            Program.EscribirRetro("\n 'Me da una Tecate Ligth, por favor.'", 60);
            Program.EscribirRetro("\n\nDespues de que el Barman se riera de ti un poco, sacias tu sed de mierda y sales del bar.\nSatisfecho como un cachorro panson.", 20);
            Thread.Sleep(2000);
            Program.EscribirRetro("\n\n\t\t se que hiciste trampa...", 150, 300);
            Program.Dialogo("\n[Pierdes todas tus monedas por puta]\n[Equilibrio -5]\n[Por lo borracho que estas ahora solo puedes caminar]", 20);
            Program.monedas = 0;
        }
        else
        {
            Program.EscribirRetro("\nTe acercas a la barra.\nEl barman te mira con indiferencia.\nBuscas si tienes algunas monodas, no tienes nada.", 20);
            Program.EscribirRetro("\n\n - Barman : No tienes dinero, no te puedo servir.", 20);
            Program.EscribirRetro("\n\nTerminas robandole una bebida a algun pobre infeliz que estaba bebiendo.", 20);
            Thread.Sleep(2000);
            Program.EscribirRetro("\n\nTe corren del bar.\nHas saciado tu putrida sed, te sientes feliz.", 20);
            Console.WriteLine("\n[Equilibrio -5]\n[Por lo borracho que estas ahora solo puedes caminar]");
            Thread.Sleep(1000);
            Program.EscribirRetro("\nEres un asco.", 40, 300);
        }
    }

    //Saliendo del bar
    public static string AfueraDelBar()
    {
        Program.EscribirRetro("Estas fuera del bar, miras alrededor, hay tres lugares:", 20);
        Console.WriteLine("\n\n1. Un OxxO, se ve abierto... jaja");
        Console.WriteLine("2. Auto abandonado, se ve viejo y desgastado");
        Console.WriteLine("\n0. Quedarte donde estas...");
        Console.Write("\nElige tu accion: ");
        
        return Console.ReadLine();
    }

    // Lugar 1 q0
    public static string AlgoparecidoaCasa()
    {
        Program.EscribirRetro("Te acabas de despertar.\nTe duele la cabeza pero por alguna razon no es algo raro para ti.\nMiras alrededor.\nNotas luces calidas alrededor del cuarto, muebles bien cuidados.\nAlgo se esta cocinando en la estufa, lo puedes oler...\nPero no parece ser tu hogar.\nAlgunas fotos a en los muebles parecen gritartelo.\nSales del lugar.", 20);
        
        Console.WriteLine("\n\n Miras alrededor, hay tres lugares:");
        Console.WriteLine("\n1. Un Bar, se ve pobremente iluminado");
        Console.WriteLine("2. Callejon oscuro");
        Console.WriteLine("3. Una Casa que se te hace extrañamente familiar");
        Console.WriteLine("\n0. Quedarte donde estas...");
        Console.Write("\nElige tu accion: ");
        
        return Console.ReadLine();
    }

    // Bar q1
    public static string Bar()
    {
        Program.EscribirRetro("Entras al bar.\nApenas hay clientes, el lugar esta pobremente iluminado.\nSabes que apesta pero por alguna razon no percibes olor.\nLa madera cruje al ritmo de la baja musica.\nPodrias contar a 4 personas contando al barista...\nParecen ignorarte por completo...", 20);
        Console.WriteLine("\n\n Que haces?: ");
        Console.WriteLine("\n1. Sentarte en la barra y beber un poco");
        Console.WriteLine("2. Hablar con alguien");
        Console.WriteLine("3. Salir del bar");
        Console.Write("\nElige tu accion: ");

        return Console.ReadLine();
    }

    // Casa de los Morrinson q3
    public static string CasaMorrinson()
    {
        Program.EscribirRetro("Te acercas a esa familiar casa.\nSolo iluminada por las luces exteriores, pero por dentro todo esta oscuro.\nEs extraño...", 20);
        Program.EscribirRetro("\n\nLa casa te parece tan familiar...\nComo si la hubieses visto tantas veces ya.\nIncluso tienes un pequeño espectro del olor de su interior...", 20);
        Program.EscribirRetro("\n\nVoces te llegan pero no hay nadie hablando.\nLas escuchas...\nRisas.\nDiscusiones.\nGritos...\n¿Vienen de adentro?\n¿Adentro de donde, de la casa o de tu cabeza? ", 20);
        Program.EscribirRetro("\n\nEsas voces estan llenas de nostalgia para ti.\nComo si extrañaces la idea de escucharlas ahora", 20);
        Program.EscribirRetro("\n\nMiras detenidamente.\nEncuentras un nombre en su puerta.\nMorrinson... Familia Morrinson.", 20);
        Thread.Sleep(2000);
        Console.WriteLine("\n\n No tienes nada mas que ver, sigues adelante, miras alrededor, hay dos opciones:");
        Console.WriteLine("\n1. Llamar a la puerta");
        Console.WriteLine("2. Caminar por la misma calle, alejandote de la casa");
        Console.Write("\nElige tu accion: ");

        return Console.ReadLine();
    }

    // q3 op 2
    public static string CasaMorrinsonAfuera()
    {
        Program.EscribirRetro("Fuera de la casa miras dos caminos.\nUno lleva a la izquierda, el otro a la derecha", 20);
        Program.EscribirRetro("\n¿Hacia donde vas?", 20);
        Console.WriteLine("\n1. Hacia el OxxO");
        Console.WriteLine("2. Hacia un Auto abandonado");
        Console.Write("\nElige tu accion: ");
        return Console.ReadLine();
     }

    // q3 op 1
    public static string CasaMorrinsonAdentro()
    {
        Program.EscribirRetro("Llamas a la puerta.\nNo sabes que esperabas pero no pasa nada.\nSigues llamando.\nNada, no hay nadie...", 20);
        Program.EscribirRetro("\n\nEres bastante perezoso para buscar alguna entrada exterior.\nAdemas... ¿para que?", 20);
        Program.EscribirRetro("\n\nDas una vuelta alrededor de la casa, te atrae algo.\nEn el jardin del lateral derecho de la casa hay algunos metros cuadrados de tierra que no contienen hierbas.\nIncluso parece haber sido pisoteada recientemente...", 20);
        Program.EscribirRetro("\n\nTe acercas a esa tierra.\nTe arrodillas.\nLa tierra esta blanda...\nComo si alguien hubiese estado cavando ahi recientemente...", 20);
        Program.EscribirRetro("\n\n Que haces?: ", 20);
        Console.WriteLine("\n1. Escavar un poco en esa tierra");
        Console.WriteLine("2. Salir de ese lugar, no quieres meterte en problemas");
        Console.Write("\nElige tu accion: ");

        return Console.ReadLine();
    }
    
    //q3 op 1 op 2
    public static void Cuyon()
    {
        Program.EscribirRetro("Decides alejarte de la casa.\nNo quieres meterte en problemas.\nNo quieres saber que hay adentro.\nNo quieres saber que paso aqui...\nNo quieres saber quien eres tu...", 20);
        Program.EscribirRetro("\n\nMientras caminas por la calle, sientes como si algo te estuviera mirando.\nComo si algo estuviera observando cada uno de tus movimientos.\nCada una de tus acciones.\nCada uno de tus pensamientos...", 30, 400);
        Program.EscribirRetro("\n\n[Equilibrio -4]\n[Sientes que algo te esta mirando]", 20);
     }

    // Callejon q2
    public static void Callejon()
    {
        Program.EscribirRetro("El aire aquí es espeso.\nHuele a humedad vieja y a algo metálico, como cobre oxidado.\nDas un paso y la suela de tu zapato se adhiere al asfalto con un crujido pegajoso y húmedo.\nNo puedes ver qué pisaste", 20);
        Program.EscribirRetro("\n\nDe pronto, la penumbra se rasga con un sonido.\nEs un sollozo ahogado, pero viene desde abajo, casi a ras de suelo.\nNo suena humano... o al menos, ya no.\nEl llanto es silenciado por el ruido de algo pesado arrastrándose hacia ti;\nCarne mojada frotándose contra la grava en espasmos erráticos.", 30, 400);
        Program.EscribirRetro("\n\nUn frío punzante te clava alfileres en la nuca.\nEl estómago se te hace un nudo de puro instinto.\nSin pensarlo, tus piernas se mueven solas, huyendo despavorido antes de que la oscuridad te alcance", 20);
        Program.Dialogo("\n\n[Equilibrio -5], [Solo puedes correr]", 70);
    }

    //Auto q4
    public static string Auto()
    {
        Program.EscribirRetro("Encuentras un auto.\nSe ve antiguo y desgastado.\nSe nota que su dueño no lo ha usado en mucho tiempo o no le ha dedicado mucho cariño.", 20);
        Program.EscribirRetro("\n\nMiras hacia dentro del auto.\nMiras que las llaves estan dentro del auto, tiradas en el asiento del conductor.\nReverendo idiota", 20);
        Program.EscribirRetro("\n\nMirando un poco mas usando la poca luz que la calle puede ofrecer, lograr mirar algo parecido a una foto...: ", 20);
        Program.EscribirRetro("\n\nLa foto aun con lo difuminada que la vez muestra cara de alguien adulto.\nQuizas un viejo por lo cansado de sus facciones.\nNotas las ojeras en su mirada aun sin poder verla bien.\nUna cabeza algo descuadrada.\nFuerzas la vista tanto como puedes para lograr mirar la foto mas a detalle", 20);
        Program.EscribirRetro("\n\nLogras distinguir un poco mas la foto.\nEs un hombre con una camisa de cuadros.\nCon un bigote algo descuidado.\nCon una mirada cansada y vacia.\nCon ojeras profundas...\nCon una cabeza algo descuadrada...", 30, 400);
        Program.EscribirRetro("\n\nLo identificas", 40, 300);
        Program.EscribirRetro("\n\nEres tu.", 80, 200);
        Thread.Sleep(2000);
        Program.EscribirRetro("\n\n Que haces?: ", 20);
        Console.WriteLine("\n1. Intentar entrar al auto");
        Console.WriteLine("2. Alejarte del... auto? no se que mas puedes hacer aqui la verdad");
        Console.Write("\nElige tu accion: ");

        return Console.ReadLine();
    }

    //Intentar entrar al auto q4 op 1
    public static void AutoEntrar()
    {
        Program.EscribirRetro("Intentas abrir la puerta del auto.\nTorpemente intentas forzar la puerta\nUna vez\nOtra\nY otra...", 20);
        Program.EscribirRetro("\nPasas aproximadamente 50 minutos intentando abrir la puerta.\nCada intento es mas inutil que el anterior", 20);
        Program.EscribirRetro("\n\nTres patrullas se estacionan a tu lado\nTe detienen\nIntentas apelar, buscar alguna explicacion\nNo te escuchan\nTe tratan como a un criminal\nUn monstruo.", 80, 400);
        Program.EscribirRetro("\nNo tiene sentido, que hiciste?\nQue hiciste?\nNada...", 100, 300);
        Program.EscribirRetro("\n\n No hiciste nada...", 200, 200);
    }

    //OxxO q5 //Pelo largo, moreno, vestido muy casualmente, algo naco
    public static string OxxO()
    {
        Program.EscribirRetro("Entras al OxxO.\nEstas cosas estan abiertas todo el tiempo.\nNo recuerdo alguna vez que haya visto alguno cerrado... ah si, recuerdo una, cuando lo asaltaron", 20);
        Program.EscribirRetro("\n\nEl que te atiende es wey llamado Jony\n¿Como lo sabes?\nNo se\nEl wey es moreno y tiene el pelo largo\nPor como esta vestido sabes que esta peor que tu", 20);
        Program.EscribirRetro("\n\nQue haces?", 20);
        Console.WriteLine("\n\n1. Pedirle una cerveza a Jony [2 monedas]");
        Console.WriteLine("2. Robarle el dinero a Jony [+5 monedas]");
        Console.Write("3. Decirle a Jony que le saludes a su novio (es mujer)");
        Console.Write("\n\n0. ???? [99 monedas]");
        Console.Write("\n\nElige tu accion: ");
        return Console.ReadLine();
    }

    //OxxO q5 op 1
    public static void OxxOPedirCerveza()
    {
        if (Program.monedas >= 2)
        {
            Program.EscribirRetro("Le pides a Jony una cerveza.\nJony te mira con indiferencia, como si no le importara lo que le dijeras.\nLe das las monedas y te da la cerveza sin decir nada mas.", 20);
            Program.EscribirRetro("\n\nSatisfecho como una gorda con sus panditas, sales del OxxO.", 20);
            Program.monedas -= 2;
            Program.equilibrio += 1;
            Program.Dialogo("\n\n[Equilibrio +1][Monedas -2]", 20);
        }
        else
        {
            Program.EscribirRetro("Le pides a Jony una cerveza.\nJony te mira con indiferencia, como si no le importara lo que le dijeras.\nLe dices que no tienes dinero, que no puedes pagarle.\nJony te mira por un momento, luego te llama pendejo y te pide que te vayas a la verga", 20);
            Program.EscribirRetro("\n\n Decides robarle las cervezas a Jony", 30, 900);
            Program.EscribirRetro("\nSales corriendo como gorda en transporte publico", 20);
            Program.equilibrio -= 2;
            Program.modoForzado = 2;
            Program.turnosAnclados = 1;

            Program.Dialogo("\n\n[Equilibrio -2][Ahora estas en modo forzado por robarle a Jony, el proximo turno no podras elegir tu movimiento]", 20);
        }
    }

    //Oxxo q5 op 2
    public static void OxxORobar()
    {
        Program.EscribirRetro("Decides robarle el dinero a Jony.\nJony te mira por un momento, luego te llama pendejo y te pide que te vayas a la verga\nNo le haces caso, le quitas el dinero y sales corriendo...\nYo que se", 20);
        Program.equilibrio -= 4;
        Program.monedas += 5;
        Program.modoForzado = 2;
        Program.turnosAnclados = 1;

        Program.Dialogo("\n\n[Equilibrio -4][Ahora estas en modo forzado por robarle a Jony, el proximo turno no podras elegir tu movimiento]", 20);
    }

    //OxxO q5 op 3
    public static void OxxOAlagar()
    {
        Program.EscribirRetro("Decides decirle a Jony que le saludes a su novio.\nJony te mira por un momento\n -Jony: Si we, gracias voy a saludar a mi NOVIO...\nTe manda a chingar a tu madre\nSales con una sonrisa", 20);
        Program.equilibrio += 5;
        Program.monedas += 1;
        Program.Dialogo("\n\n[Equilibrio +5][Te encontraste una moneda tirada cuando salias, vida buena]", 20);
    }

    //OxxO q5 op 0
    public static void OxxOFinal()
    {
        if (Program.monedas >= 99)
        {
            LanzarJumpscare();
        }
        else
        {
            Program.EscribirRetro("Tu puta madre, regresa cuando tengas el dinero\nEspera..\nNo puedes de manera vanila", 20, 600);
            Program.EscribirRetro("\n\n\t\tJa Ja Ja Ja", 100, 200);
            Thread.Sleep(1000);
        }
    }

    //Oxxo salida
    public static string OxxOSalida()
    {
        Program.EscribirRetro("Sales del OxxO, miras un camino", 20);
        Console.WriteLine("\n\n1. ¿Casa?");
        return Console.ReadLine();
    }

    // Finales
    public static void Finales(int final)
    {
        switch (final)
        {
            //Final de broma
            case 1:
                Program.EscribirRetro("Decides quedarte a pudrirte en el lugar donde despertaste.\nEspero y eventualmente las ratas encuentren tu putrido cuerpo.\nY lo consuman hasta que no quede nada de ti...", 30, 400);
                Thread.Sleep(1000);
                Program.EscribirRetro("\n\nNo hay mejor final.", 40, 300);
                break;

            //Violao
            case 2:
                Program.EscribirRetro("Decides quedarte en el bar en del que acabas de salir.\nRazon? dios sabra", 20);
                Program.EscribirRetro("\n\nTe sientas en la acera del bar.\nTe apoyas contra la pared.\nCierras los ojos, el aire fresco de la noche te golpea la cara y...\nTe terminan violando 3 de los 4 tipos (el barman cerro) que estaban dentro", 20);
                Program.EscribirRetro("\n\nLa verdad, no se que esperabas", 20);
                Thread.Sleep(1000);
                Program.EscribirRetro("\n\nNo regresara wey, ya no la esperes", 70, 400);
                Thread.Sleep(1000);
                break;

            //Atropellado por un auto estacionado
            case 3:
                Program.EscribirRetro("Vas corriendo hacia el auto, no mides tus pasos.\nTu mente se nubla con cada paso.\nTu ritmo cardiaco aumenta, sientes como tu corazon golpea con cada latido en tu pecho", 20);
                Program.EscribirRetro("\n\nAntes de que te des cuenta te tropiezas en casi llegando al auto", 20);
                Program.EscribirRetro("\n\nTu cuerpo se va hacia adelante.\nTu cabeza choca contra el capó del auto.\nEl golpe fue lo suficiente fuerte para dejarte inconciente", 20);
                Thread.Sleep(1000);
                Program.EscribirRetro("\n\nMoriste", 100, 300);
                Program.EscribirRetro("\n\nAtropellado por un auto estacionado", 60, 400);
                Thread.Sleep(1000);
                break;

            //Escarbar en la tierra de la casa Morrinson
            case 4:
                Program.EscribirRetro("Decides escarbar un poco en esa tierra.\nNo sabes que esperas encontrar pero algo te atrae a ese lugar.\nAlgo te dice que es importante, que es importante para ti, que es importante para tu vida...", 20);
                Program.EscribirRetro("\n\nMientras escarbas, sientes como si algo te estuviera mirando.\nComo si algo estuviera observando cada uno de tus movimientos.\nCada una de tus acciones.\nCada uno de tus pensamientos...", 30, 400);
                Program.EscribirRetro("\n\nDe repente, sientes un golpe en la cabeza.\nTodo se vuelve negro.\nSientes como si te estuvieran arrastrando, como si te estuvieran llevando a algun lugar.\nNo sabes a donde, no sabes por que, no sabes quien...\nSolo sientes que te estan llevando a algun lugar...", 20);
                Program.EscribirRetro("\n\nMueres", 100, 300);
                Program.EscribirRetro("\n\nNo sabes que ni por que, pero algo te dice que no deberias haber hecho esto", 60, 400);
                Thread.Sleep(1000);
                break;

            //Final de muerte, equilibrio 0
            case 67:
                Program.EscribirRetro("Caes al suelo\n", 20);
                Program.EscribirRetro("No miras nada, no puedes abrir los ojos.\nApenas puedes respirar\n", 20);
                Program.EscribirRetro("Intentas moverte pero no parece haber extremidad que responda a tu voluntad\n", 20);
                Program.EscribirRetro("Solo puedes escuchar tu respiracion y sentir el latir de tu corazon\n", 20);
                Program.EscribirRetro("Mueres\n", 60, 400);
                Program.EscribirRetro("En silencio\n", 60, 300);
                Program.EscribirRetro("\n\nEs lo que merecias.", 100, 200);
                Thread.Sleep(2000);
                break;

            //Final Bueno
            case 7:
                Program.EscribirRetro("\n\nLa niña te mira, horrorizada.\nLa pequeña apenas te llega a la cintura.\nSu pijama (un juego de conejitos con una camisa rosada y un pans azul pastel) esta llena de sangre que no es de ella.\nSus ojos estan pequeños, desorbitados, rojos y secos.\nComo si hubiese llorado todo este tiempo... cuanto tiempo?", 20);
                Program.EscribirRetro("\n\nSus manos estan raspadas, maltratadas.\nLas uñas de sus manos estan arrancadas, puedes notar sus matrices unglares expuestas, negras por la exposicion al exterior.\nSu cabello esta desarreglado... destrozado.\nParece sollozar pero esos ojos no seran capaces de generar mas lagrimas", 20);
                Program.EscribirRetro("\n\nNo se acerca a ti, te mira... hasta que con su voz, quebrada, temblorosa... te grita: ", 20);
                Program.EscribirRetro("\n\n - Laima : MAMAAAAAA!!!", 20, 1200);
                Program.EscribirRetro("\n\nRepite sin parar, cada vez mas fuerte.\nEscuchas como su voz parece convertise mas en un atismo de gritos desgarradores.\nComo su garganta de desgarra para poder gritar mas", 20);
                Program.EscribirRetro("\n\nIntentas acercarte para calmarla...", 10);
                Program.EscribirRetro("\n\n - Laima : ALEJATE!!!", 10, 1200);
                Program.EscribirRetro("\n - Laima : TU MATASTE A MAMA!!!", 10, 1200);
                Program.EscribirRetro("\n - Laima : MAMA TENIA MIEDO, ELLA SIEMPRE SE ESCONDIA SI TU NO TOMABAS TUS PASTILLAS!!!", 10, 1200);
                Program.EscribirRetro("\n - Laima : TU DIJISTE QUE SI YO TE DECIA DONDE SE-...", 10, 1200);
                Program.EscribirRetro("\n\nSu voz se corta, tose un poco.\nParece que se esta quedando sin voz.\nPero sigue hablando con voz temblorosa, sin aire, se pone roja por el esfuerzo y la falta de aire", 20);
                Program.EscribirRetro("\n\n - Laima : si yo... te decia donde se escondia mama...\n - Laima : tu no necesitarias mas pastillas y yo podria ir a la escuela...\n - Laima : tu no me tendrias que pegar...\n - Laima : tu no me tendrias que gritar...\n - Laima : tu no me tendrias que hacer sentir mal...\n - Laima : tu no me tendrias que hacer sentir miedo...\n - Laima : tu no me tendrias que hacer sentir nada...\n - Laima : tu no me tendrias que hacer sentir nada a mi ni a mama...\n - Laima : tu no me tendrias que hacer sentir nada a nadie!!!", 40, 1000);
                Program.EscribirRetro("\n\nElla tose mas, esta tosiendo sangre.\nYa no puede hablar mas", 20);
                Program.EscribirRetro("\n\nEstas horrorizado, como?... tu hiciste esto?...", 30, 400);
                Program.EscribirRetro("\n\nIntentas acercarte a la niña corriendo.\nIntentando consolarla de alguna manera, saber que todo esto es mentira", 20);
                Program.EscribirRetro("\n\nElla en un acto desesperado intenta gritar, pero ya no puede...", 20);
                Program.EscribirRetro("\n\nLa niña corre hacia ti, desesparada.\nSus pies descalzos casi se tropiezan de la desesperacion", 10);
                Program.EscribirRetro("\n\nLa niña se lanza de lleno hacia tu hacha.\nClava su cara contra el filo ensangrentado del hacha", 80, 300);
                Program.EscribirRetro("\n\nLa niña no muere de primeras.\nSe queda quieta moviendo sus manos debilmente.\nSu boca partida por la mitad parece moverse como si de un pez fuera del agua se tratase", 60, 400);
                Program.EscribirRetro("\n\nNo puede respirar.\nSu nariz ahora es remplazada por el filo del hacha que atraveso todo su hueso nasal", 60, 400);
                Program.EscribirRetro("\n\nSus ojos se mueven con lentitud.\nNo crees que puedan ver nada por la manera inexpresiva en que se mueven", 60, 400);
                Program.EscribirRetro("\n\nLa sangre corre por su cara, casi como una pequeña cascada", 60, 400);
                Program.EscribirRetro("\n\nLa niña muere lentamente.\nSu cuerpo se queda quieto, sus manos caen a los lados de su cuerpo.\nSu boca se queda abierta, su cara completamente cubierta de sangre", 60, 400);
                Program.EscribirRetro("\n\nElla eligio esto...", 100, 300);
                Program.EscribirRetro("\nElla eligio morir...", 100, 300);
                Program.EscribirRetro("\nElla eligio morir por ti...", 100, 300);
                Program.EscribirRetro("\nEs su culpa...", 100, 200);
                Program.EscribirRetro("\nEs su culpa...", 100, 200);
                Program.EscribirRetro("\n...", 150, 200);
                Thread.Sleep(10000);

                Program.EscribirRetro("\n\n\t\t\t FINAL BUENO", 200, 150);
                break;
        }
    }

    // ¿Casa? q6
    // Equilibrio mayor a 10
    public static void MerecesMorir()
    {
        Program.EscribirRetro("Te acercas a una casa.\nTe es tan familiar como para no reconocerla...\nLas puertas estan abiertas, hay apenas una luz tenue emanando de su interior.\nLa valla fue destruida, no es facil intuir que fue un auto el que la destruyo", 20);
        Program.EscribirRetro("\n\nEntras a la casa.\nBastantes cosas estan hechas un desastre.\nVasijas tiradas, cuadros destrozados, rasguñados.\nEl suelo esta manchado de sangre.\nLa sangre marca rastros rectos y forman huellas de lo que parecen ser pies capturados en el suelo.\nNo hay ruido, solo el sonido de tus pisadas retumbando suavemente por toda la casa", 20);
        Program.EscribirRetro("\n\nSigues el rastro hasta un cuarto, tu cuarto...\nTodo esta hecho un desastre.\nHay un hacha tirada en el suelo que parece tener un ojo pegado al filo del hacha ensangrentado.\nEl ojo esta incompleto varias fibras nerviosas estan esparcidas por el suelo.\nLa sangre predomina aqui.\nSi pudieras olerlo... tendrías que ser un cadáver", 20);
        Program.EscribirRetro("\n\nMientras intentas recordar algo, cualquier cosa.\nEntender que paso aqui, quien eres tu.\nBuscar alguna foto, algo que se haya caido, algo que te diga algo.\nAlgo que te muestre, que te ilumine, que te salve, que te saque de esta maldita dud-...", 10);
        Program.EscribirRetro("\n\nPasos se escuchan en la casa...\nDescalzos...\nSuaves...\nNo quiere ser escuchado...?: ", 80, 400);
        Program.EscribirRetro("\n\nEs el causante de todo esto... lo sabes...\nLo puedes sentir en tu corazon que palpita con cada paso que da.\nLo sabes, lo sientes, lo puedes sentir cada vez mas cerca, cada vez mas fuerte, cada vez mas real...", 30, 300);
        Program.EscribirRetro("\n\nTe quedas quieto... tomas el hacha.\nVer el ojo te provoca asco pero no hay tiempo para sentir nada... tienes que sobrevivir", 20);
        Program.EscribirRetro("\n\nUna figura pequeña entra... es... una niña...", 60, 400);
        Thread.Sleep(2000);
    }

    public static void LanzarJumpscare()
    {
    var waveOut = new WaveOutEvent();
    var audioFile = new AudioFileReader("..\\mmdas\\iphone_ringtone_trap_remixbigconverter.mp3");
    waveOut.Init(audioFile);
    waveOut.Play();

    ProcessStartInfo pInfo = new ProcessStartInfo(".\\mmdas\\Answer it.jpg");
    pInfo.UseShellExecute = true;
    Process.Start(pInfo);
    }
}