// O casting de tipo de variável é quando colocamos um valor de uma variável em outra variável em que o tipo de dado aloca uma quantidade de espaço diferente na memória.

Int valor = 1;
long valorGrande = valor;

// Como o tipo 'long' aloca um espaço na memória maior que 'int' não existe problemas.

Int valor = 1;
short valorPequeno = valor;

// Nesse caso o compilador irá retornar um erro pois o valor que está na variável 'int' pode não caber na nova variável 'short' ( que aloca um espaço menor na memória) .

// Para forçar o compilador a fazer a conversão:

Int valor = 1;
short valorPequeno = (short) valor;
