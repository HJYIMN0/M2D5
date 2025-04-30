using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio04_Script : MonoBehaviour
{

    public int[] array = new int[8];
    public int massimo = 80;
    public int minimo = 5;
    public int dimensione = 18;

    void GeneraArray()
    {
        for (int i = 0; i < array.Length; i++) 
        {
            array[i] = Random.Range(minimo, (massimo +1));
            Debug.Log("Alla posizione " + i + " dell'array c'è il numero " + array[i]);        
        
        }
        Debug.Log("Fine funzione GeneraArray");
    
    }


    void CambiaDimensioneArray()
    {
        int[] newArray = new int[dimensione];
        if (dimensione == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log("alla posizione" + i + " dell'array, si trova il numero" + array[i]);
            
            }
            Debug.Log("Non c'è bisogno di creare un nuovo array!");
        
        }
        else if (dimensione < array.Length)
        {

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
                Debug.Log("alla posizione " + i + " dell'array, si trova il numero " + newArray[i]);
            }
            Debug.Log("Abbiamo creato un nuovo array più piccolo!");


        }

        else if (dimensione > array.Length)
        {

            int i = 0;
            if (i < array.Length)
            {
                for (i = 0; i < array.Length; i++)
                {

                    newArray[i] = array[i];
                    Debug.Log("alla posizione " + i + " dell'array, si trova il numero " + newArray[i]);
                }
                for (i = array.Length; i < newArray.Length; i++)
                {

                    newArray[i] = 0;
                    Debug.Log("alla posizione " + i + " dell'array, si trova il numero " + newArray[i]);

                }
            }
            Debug.Log("Abbiamo creato un array più grande!");

        }

        

        Debug.Log("Fine funzione CambiaDimensioneArray");

    }

        

    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        GeneraArray(); 
        CambiaDimensioneArray();    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
