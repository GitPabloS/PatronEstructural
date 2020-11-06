Se utilizo el Decorator
En el ejemplo vemos que se pide carne y a la vez su guarnicion y se quiere saber el costo añadido y una descripcion que se vea
lo que se añadio al pedido.
Con el decorator Heredaremos de la clase que tiene el costo y descripcion y cada que pidamos una guarncion nueva se aumentara a la 
"factura" con descripcion y costo. Sin riesgo de que se aumente un nuevo plato o nueva guarnicion afecte a lo demas.