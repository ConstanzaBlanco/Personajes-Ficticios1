Decidimos esta principalmente solución ya que no podíamos utilizar tipos ni genericos.

Explicación de la creación del personaje:

Esta clase toma las características de cada personaje dependiendo de su tipo, a su ves, dado que no son tantos, podemos dividirlos en tipo 1,2 y 3. 
Esta clase también debe conocer dichas características del personaje y su inventario. 
Decidimos hacerlo así ya que deja más organizado el código en general ya que por un lado tenes las clases de cada personaje que define sus características 
e items que se le pueden equipar y por otro se puede utilizar personaje para crear cada personaje en donde distinguis su tipo simplemente poniendo número 1,2 o 3. 
De esta manera cumple con SRP

Explicación de las divisiones de clases:

Decidimos crear una clase para cada item ya que consideramos que cada uno tiene características únicas y queda más organizado en diferentes clases. 
Además, a diferencia de los tipos de personaje los cuales se pueden agrupar dentro de una misma clase "personaje", 
al ser muchos más sería más engorroso acordarse qué número representa a cada ítem, y a su vez hay algunos como el arco que tienen funciones más especiales por lo que separarlos en distintas clases lo vimos más óptimo. 

Explicación de los cálculos:

Decidimos separar en 4 clases las cuentas que se realizan a la hora de calcular el daño/defensa/curación que realiza una acción, 
la cuarta siendo "calculos de combate" la cual se encarga de llamar a las otras en el momento adecuado. 
Fue necesario dividirlo para que esté más organizado y cumpla con SRP.

ImpresionEstadoPersonaje:

Decidimos crear esta clase la cual al llamarla imprime los datos del personaje en cuestión (vida, ataque y defensa, considerando los items equipados). 
Esta nos sirve para saber los datos exactos de un personaje en un momento determinado lo cual puede ser útil para comprobar que por ejemplo una poción lo haya curado lo necesario. 

Explicación de las acciones:

Las funciones de curar, defender y atacar las dividimos en distintas clases ya que, similar a los cálculos, 
de esta manera podemos tenerlo más organizado y a su vez cumpliendo con SRP. 
Accion sirve para llamar a cada una de estas funciones.
