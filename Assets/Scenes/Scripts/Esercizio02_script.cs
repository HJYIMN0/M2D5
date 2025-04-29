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
    
    
    void generaArray()
    {
        int[] x = new int[dimensione];
        for (int i = 0; i < x.Length; i++)
        {
            int valore = Random.Range(minimo, massimo + 1);
            Debug.Log("Questo è il valore alla posizione " + ( i + 1 ) + " dell'array (" + valore+ ")");

        }

    }

    void StampaArray() 
    {
        for (int i = 0; i < stampa.Length; i++)
        {
            int x = stampa[i];
            Debug.Log("Stampo il valore alla posizione " + ( i + 1) + " dell'array (" + x + ")");

        
        }
       
    }

    void TrovaMinimo()
    {
        for (int i = 0; i<stampa.Length; i++)
        {
            int x = stampa[i];
            if (x < stampa[i])
            {
                minimo = x;
            }
            

        }
        Debug.Log(minimo);
    }
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        generaArray();
        StampaArray();  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
