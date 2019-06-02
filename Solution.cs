namespace _8.OddOcurrencesInArray
{

    /*Se proporciona una matriz no vacía A que consta de N enteros. 
    La matriz contiene un número impar de elementos, y cada elemento de la matriz puede emparejarse 
    con otro elemento que tenga el mismo valor, excepto por un elemento que se deja sin emparejar.
Por ejemplo, en la matriz A tal que:
A [0] = 9 A [1] = 3 A [2] = 9 A [3] = 3 A [4] = 9 A [5] = 7 A [6] = 9 
los elementos en los índices 0 y 2 tienen valor 9, los elementos en los índices 1 y 3 tienen valor 3, 
los elementos en los índices 4 y 6 tienen valor 9, el elemento en el índice 5 tiene valor 7 y no está emparejado. 
Escribe una función:
solución de clase {solución pública int (int [] A); }
que, dada una matriz A que consta de N enteros que cumplen las condiciones anteriores, 
devuelve el valor del elemento no pareado.
Por ejemplo, dada la matriz A tal que:
A [0] = 9 A [1] = 3 A [2] = 9 A [3] = 3 A [4] = 9 A [5] = 7 A [6] = 9 la función debe devolver 7, 
como se explica en el ejemplo anterior.
Escriba un algoritmo eficiente para las siguientes suposiciones:
N es un entero impar dentro del rango [1..1,000,000]; cada elemento de la matriz A es un número entero dentro del rango 
[1..1,000,000,000]; todos menos uno de los valores en A ocurren un número par de veces. */
    public class Solution
    {
        public int solution(int[] A){

           int extension = A.Length;
            if(extension % 2 == 0){
                return 0;
            }else{
                int result=0;
                for(int i1=0; i1<extension; i1++){
                    int coincidencia = 0;

                    for(int i2=0; i2<extension; i2++){
                        if(A[i1]==A[i2]){
                            coincidencia++;
                        }
                        if(coincidencia==1 && i2==extension-1){
                            result = A[i1];
                            break;
                        }
                    }
                    if(result!=0){
                        break;
                    }
                }
                return result;
            }
            
        }


    }
}