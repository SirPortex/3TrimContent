using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack<int> originalStack = new Stack<int>(); // Pila-Original
        originalStack.Push(4);
        originalStack.Push(-5);
        originalStack.Push(-10);
        originalStack.Push(88);
        originalStack.Push(2);

        Stack<int> stack1 = new Stack<int>(); // Pila 01
        Stack<int> stack2 = new Stack<int>(); // Pila 02

        // vaciamos la pila original y le damos todos los valores a la pila 1 para empezar a trabajar.

        while (originalStack.Count > 0) // Mientras la Pila original tiene elementos.
        {
            stack1.Push(originalStack.Pop()); // Metemos los elementos de la Pila-Original a la Pila-01.
        }

        while (stack1.Count > 0) // Mientras la Pila-01 tenga elementos ( los que hemos transferido de la Pila-Original ).
        {
            int aux = stack1.Pop(); // Declaramos la variable "aux" como el "Pop" de la Pila-01 (4)
            while (stack1.Count > 0) // Mientras la Pila-01 tenga contenido.
            {
                if (stack1.Peek() < aux)
                {
                    stack2.Push(aux);
                    aux = stack1.Pop();
                }
                else
                {
                    stack2.Push(stack1.Pop());
                }
            }

            // el menor valor eas aux
            originalStack.Push(aux);

            // swap de pilas
            Stack<int> auxStack = stack1;
            stack1 = stack2;
            stack2 = auxStack;
        }

        while (originalStack.Count > 0)
        {
            Debug.Log(originalStack.Pop());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
