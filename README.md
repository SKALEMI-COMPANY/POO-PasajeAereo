# POO-PasajeAereo
Proyecto de control de pasajes aéreos con POO. Clases para promoción, turista y premium. Gestiona reservas, precios y datos de vuelos. Uso educativo, no plagiar. ¡Disfruta aprendiendo! - michaelvinces.skalemi@gmail.com

Entidades	Características	Acciones
1. Pasaje aéreo
   Origen de pasaje, Destino, Dueño de pasaje
   Definir un método que permita mostrar por pantalla todos los datos de las propiedades de la entidad
2. Pasaje aéreo Promoción
   Precio de pasaje, Descuento (50%)
   - Calculo de valor (Multiplicación de los parámetros de esta clase)
3. Pasaje aéreo Turista
   Precio de pasaje, Descuento, Temporada
   - Calculo de valor (Si es “Temporada alta” entonces el valor del pasaje se incrementará en un 30%, caso contrario se mantiene el mismo precio del pasaje)
4. Pasaje aéreo Premium
   Recargo del 15% por servicios Premium
   - Calculo de valor (El precio es un valor fijo de $100)

Se solicita lo siguiente:
Definir la clase padre con sus propiedades y métodos.
Definir las clases hijas que hereden de la clase padre sus propiedades y métodos y adiciones las características y métodos particulares.
Las clases derivadas deben sobrescribir el método que va a demostrar el polimorfismo.
La clase de la consola se encarga de crear las instancias de las clases, ingresar datos estáticamente a los objetos y mostrar los resultados de los métodos de estos objetos.
En la clase de la consola debe crear una lista del tipo de la clase padre, agregar al menos 1 objetos de cada clase derivada a esta lista y por medio de un ciclo for o foreach llamar al método polimórfico para mostrar por pantalla este resultado.
La aplicación debe mostrar por pantalla los datos de todas las entidades y el resultado del método polimórfico.

