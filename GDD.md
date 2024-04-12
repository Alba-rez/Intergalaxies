> # GAME DESIGN DOCUMENT
> 
> Creado por: Alba María Álvarez Alonso
>
> Versión del documento: 1.00
>
> ## HISTORIAL DE REVISIONES
>
>
>| Versión      | Fecha        | Comentarios  |
>|--------------|--------------|--------------|
>| 1.0          |              |              |
>|              |              |              |
> 
> ## RESUMEN
> 
> En un viaje audaz más allá de los confines conocidos, una intrépida astronauta ha desafiado los límites del cosmos, sin percatarse de que el combustible necesario para su retorno a la Tierra, su hogar, se ha agotado. Su espíritu explorador la ha llevado hasta los rincones más remotos de la galaxia, siguiendo meticulosos cálculos científicos concebidos durante la era de la colonización interestelar.
> 
> La especie humana, en su afán por expandirse, logró establecerse en diversos planetas gracias al auxilio de inteligencias artificiales avanzadas. Sin embargo, un acontecimiento astrofísico imprevisto devastó las infraestructuras automatizadas, dejando a los colonos a merced del caos. Los asentamientos dispersos perdieron contacto con la civilización central, incapaces de mantener el control sobre las máquinas y los territorios conquistados.
>
> Ahora, en medio de la vastedad estelar, la astronauta se encuentra atrapada sin suficiente combustible para retornar. Consciente de los recursos desperdiciados en los abandonados enclaves coloniales, comprende que su única esperanza reside en hallar una solución entre los restos de la desbandada intergaláctica. Deberá aterrizar en estos planetas desolados y buscar el combustible que garantice su supervivencia y retorno.
>
> Sin embargo, desconoce que en el planeta árido dos robots averiados, Tars y Case, y en un mundo selvático otros dos, Abbott y Costello, acechan sin piedad. Su misión de "Vuelta a Casa" se ve amenazada por estas máquinas descontroladas, dispuestas a impedir su regreso con violencia.
> 
> ## Concepto
>
> Intergalaxies es un juego de plataformas ambientado en el espacio donde el jugador controla a una astronauta llamada Astro, quien debe llegar al planeta Tierra  consiguiendo combustible en antiguos puertos especiales situados en planetas de la galaxia. El juego se enfoca en la exploración, la recolección de recursos y la superación de obstáculos.
>
> ## Puntos Clave
>
> * Exploración de planetas únicos y diversos.
> * Recolección de combustible para avanzar.
> * Superación de obstáculos y trampas en entornos hostiles.
> * Sistema de puntuación basado en la recolección de objetos.
> * Desafiantes enfrentamientos con robots averiados.
>   
> ## Género
>
> * Plataformas de acción y aventura.
>
> ## Público Objetivo
>
> Intergalaxies está dirigido a jugadores de todas las edades que disfruten de juegos de plataformas desafiantes con una temática 
> espacial. También puede atraer a aficionados a la ciencia ficción y a los juegos de exploración.
>
> ## Experiencia de Juego
>
> Los jugadores experimentarán una emocionante aventura espacial mientras controlan a Astro, exploran planetas alienígenas, recolectan 
recursos, evitan trampas y enfrentan desafíos en cada nivel. La atmósfera del juego estará inmersa en una banda sonora cautivadora y efectos de sonido que realzan la experiencia de juego.
>
> ## DISEÑO
>
> ### Metas de Diseño
>
> * Crear una experiencia de juego que transporte al jugador a un universo alienígena.
> * Diseñar niveles desafiantes con una progresión adecuada de dificultad.
> * Ofrecer mecánicas de juego intuitivas que mantengan el interés del jugador.
> * Impulsar la exploración y el descubrimiento con planetas únicos y detallados.
> * Integrar elementos de riesgo y recompensa para fomentar la estrategia y la toma de decisiones del jugador.
>   
> ## MECÁNICAS DE JUEGO
>
> ### Núcleo de Juego
>
>Intergalaxies se basa en mecánicas de plataformas clásicas con elementos de exploración y recolección. El jugador controla a Astro, quien puede caminar y saltar para navegar por los niveles. Debe recolectar combustible mientras evita trampas y enemigos.
>
> ### Flujo de Juego
>
> El juego se desarrolla en niveles lineales, cada uno ubicado en un planeta diferente. El jugador debe explorar el nivel, recolectar recursos y alcanzar la nave espacial al final para avanzar al siguiente planeta. Si pierde todas sus vidas, la partida se reinicia desde cero en la misma fase.
>
>  * ### Pantalla inicio:
>  ![pantalla inicio](Imágenes/Captura-de-pantalla-2024-04-12-140613.png)
>  <img src="Imágenes/Captura de pantalla 2024 04 12 140613.png"/>
>
> ### Fin de Juego
>
> * Derrotas: Perder todas las vidas.
> * Victoria: Alcanzar la nave espacial con suficiente combustible.
> * Otras situaciones: Reiniciar la partida desde cero.
>
> ### Física de Juego
>
> La física del juego se aplica a los movimientos de Astro, la gravedad en los planetas y las interacciones con objetos y enemigos.
> 
> ### Controles
> 
> * Movimiento: Flechas direccionales o teclas WASD.
> * Barra espaciadora: Saltar.
> * Tecla "ESC": Salir del juego.
>
> ## MUNDO DEL JUEGO
>
> ### Descripción General
>
> El juego se desarrolla en un universo espacial lleno de planetas alienígenas, cada uno con su propia estética y desafíos. Los niveles están diseñados con una combinación de entornos naturales y estructuras artificiales.
>
> ### Personajes
>
> * Jugables: Astro, una astronauta vestida con un traje naranja.
> * Secundarios: Robots averiados.
> * Enemigos: Robots hostiles.
> ### Objetos
>
> * Cajas: Contienen puntos que son el combustible para la nave.
> * Diamantes: Contienen más puntos que son el conbustible para la nave.
>
> ## INTERFAZ
>
> ### Flujo de Pantallas
>
> El juego cuenta con pantallas de inicio y 2 escenas que corresponden con cada fase.
>
> ### HUD
>
> El HUD muestra el marcador de puntos en la esquina superior derecha y las vidas restantes en la esquina superior izquierda. 
> 
> ### ARTE
>
> ### Metas de Arte
>
> Crear un estilo visual único que combine elementos espaciales con un diseño retro de píxeles. El arte debe transmitir la atmósfera del juego y la diversidad de los planetas.
> 
> ### Assets de Arte
> 
> * Imágenes: Sprites de personajes, fondos de niveles, objetos y efectos visuales.
> * Animaciones: Movimientos de personajes, depegue de nave, movimiento de los robots, explosiones de las cajas con puntos, movimiento flotante de los diamantes y de los planetas en la escena inicial y otros efectos.
> ## AUDIO
>
> ### Metas de Audio
>
> Proporcionar una experiencia auditiva envolvente que complemente la acción del juego y mejore la inmersión del jugador en el universo espacial.
>
> ### Assets de Audio
>
> * Música: Banda sonora atmosférica.
> * Sonidos: Recolección de objetos, explosiones y disparos, sonido istriónico de máquina averiada en la pantalla incial, con sonido de teclado al escribirse en pantalla la misión de Astro.Sonido para la pérdida de puntos y despegue de la nave.
> ## DETALLES TÉCNICOS
>
> ### Plataformas Objetivo
>
> El juego se desarrollará inicialmente para PC y se adaptará a otras plataformas según sea necesario.
> 
> ### Herramientas de Desarrollo
>
> * Motor del juego: Unity.
> * Arte: Adobe Photoshop, Asset Store.
> * Música y sonido: Asset Store.
>
>   
