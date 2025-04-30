using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio03_Script : MonoBehaviour
{
    public int[] array = new int[8];
    

    void TrovaMinimi()
    {
        int valoreMinimo = array[0];
        int secondoValoreMinimo = array[0];
        int posizione1 = 0;
        int posizione2 = 0;


        for (int i = 0; i < array.Length; i++) 
        {
        
            
            if (array[i] < valoreMinimo) 
            {
            
                valoreMinimo = array[i];
                posizione1 = i;
            
            }
            if (array[i] > valoreMinimo && secondoValoreMinimo > array[i])
            {

                secondoValoreMinimo = array[i]; 
                posizione2 = i;

            }
        }

        Debug.Log("Questo è il valore più basso: " + valoreMinimo + ", alla posizione " + posizione1);
        Debug.Log("Questo è il secondo valore più basso: " + secondoValoreMinimo + ", alla posizione "+ posizione2);
        Debug.Log("Fine funzione TrovaMinimi");

    }

    void TrovaMassimi()
    {

        int valoreMassimo = array[0];
        int secondoValoreMassimo = array[0];
        int posizione1 = 0;
        int posizione2 = 0;

        for (int i = 1; i < array.Length; i++) 
        {

            if (array[i] > valoreMassimo)
            {

                valoreMassimo = array[i];
                posizione1 = i;
                
            
            }

            if (valoreMassimo > array[i] && array[i] > secondoValoreMassimo)
            {

                secondoValoreMassimo = array[i];
                posizione2 = i;
            
            }
        
        }

        Debug.Log("Questo è il valore più alto: " + valoreMassimo + ", alla posizione " + posizione1);
        Debug.Log("Questo è il secondo valore più alto: " + secondoValoreMassimo + ", alla posizione " + posizione2);
        Debug.Log("Fine funzione TrovaMassimi");
    
    
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        TrovaMinimi();
        TrovaMassimi();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
