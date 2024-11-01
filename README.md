# Introducción a la programación de juegos 2D. Técnicas
## Ginés Cruz Chávez

1. La cámara está fija, el fondo se va desplazando en cada frame. Se usan dos fondos. Uno de ellos lo va viendo la cámara en todo momento, el otro está preparado para el momento en que se ha avanzado hasta el punto en el que la vista de la cámara ya no abarcaría el fondo inicial. Por tanto, se va actualizando en todo momento la posición de los dos fondos, haciéndolos avanzar hacia la izquierda. Cuando la cámara alcanza el límite, se debe intercambiar el rol de los fondos. Aplicar un fondo con scroll a tu escena utilizando la técnica descrita en a.

![ej1](imgs/ej1.gif)

2. La cámara se desplaza a la derecha y el fondo está estático. Existe nuevamente un fondo de reserva, que pasa a verse cuando el avance de la cámara sobrepasa el límite. El fondo anterior deb ubicarse a continuación del otro para que esté preparado. Aplicar un fondo con scroll a tu escena utilizando la técnica descrita en b.

![ej2](imgs/ej2.gif)

3. Aplicar un fondo a tu escena aplicando la técnica del desplazamiento de textura.

![ej3](imgs/ej3.gif)

4. Aplicar efecto parallax usando la técnica de scroll en la que se mueve continuamente la posición del fondo.

![ej4](imgs/ej4.gif)

5. Aplicar efecto parallax actualizando el offset de la textura.

![ej5](imgs/ej5.gif)