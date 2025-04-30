using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio02_script : MonoBehaviour
{

    public int dimensione = 10;
    public int minimo = 3;
    public int massimo = 25;
    public int[] stampa = new int[8];
    public int[] cerca = new int[4];
    
    
    


    void generaArray()
    {
        
        for (int i = 0; i < stampa.Length; i++)
        {
            int valore = Random.Range(minimo, massimo + 1);
            
            Debug.Log("Questo è il valore alla posizione " + ( i + 1 ) + " dell'array (" + valore+ ")");

        }
        Debug.Log("Fine funzione GeneraArray");

    }

    void StampaArray() 
    {
        for (int i = 0; i < stampa.Length; i++)
        {
            int x = stampa[i];
            
            Debug.Log("Stampo il valore alla posizione " + ( i + 1) + " dell'array (" + x + ")");

        
        }
        Debug.Log("Fine funzione StampaArray");

    }

    void TrovaMinimo()
    {
        int valoreMinimo = cerca[0];
        
        for (int i = 1; i < cerca.Length; i++)
        {
          
                        
            
            if (cerca[i] < valoreMinimo)
            {
               valoreMinimo = cerca[i];
            }
           
            

        }
        
        Debug.Log("Questo è il valore minimo tra i valori dell'array (" + valoreMinimo + ")" );
        Debug.Log("Fine funzione TrovaMinimo");
    }
    

    void TrovaMassimo()
    {
        
        int valoreMassimo = cerca[0];

        for (int i = 1; i < cerca.Length; i++)
        {

            if (cerca[i] > valoreMassimo) 
            {
            
                valoreMassimo= cerca[i];
            
            }
        
        }

        Debug.Log("Questo è il valore massimo dell'array: (" + valoreMassimo + ")");

    }

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        


        generaArray();
        StampaArray();  
        TrovaMinimo();
        TrovaMassimo();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
