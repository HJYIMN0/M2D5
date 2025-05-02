using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Esercizio02_02_Script : MonoBehaviour
{

    public int dimensione = 10;
    public int minimo = 3;
    public int massimo = 25;
    int[] stampa = new int[0];







    void GeneraArray(int a, int b, int c)
    {
        stampa = new int[a];

        for (int i = 0; i < a; i++)
        {
            stampa[i] = Random.Range(b, c + 1);
            



        }
        Debug.Log("Fine funzione GeneraArray");
    }

    void StampaArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log("Questo è il valore alla posizione " + (i + 1) + " dell'array (" + stampa[i] + ")");
        }

        Debug.Log("Fine funzione StampaArray");
    }

    int TrovaMinimo(int[] a)
    {
        int minimo = a[0];
        for (int i = 0; i < a.Length; i++)
        {

            if (minimo > a[i])
            {
                minimo = a[i];
            
            }
        
        }
        Debug.Log("Questo è il valore minimo dell'array: " +minimo);
        Debug.Log("Fine funzione TrovaMinimo");
        return minimo;

    
    }
    int TrovaMassimo(int[] a)
    {
        int massimo = a[0];
        for (int i = 0; i < a.Length; i++)
        {

            if (massimo < a[i])
            {
                massimo = a[i];

            }

        }
        Debug.Log("Questo è il valore massimo dell'array: " + massimo);
        Debug.Log("Fine funzione TrovaMassimo");
        return massimo;


    }


    // Start is called before the first frame update
    void Start()
        {
            GeneraArray(dimensione, minimo, massimo);
            StampaArray(stampa);
            TrovaMinimo(stampa);
            TrovaMassimo(stampa);
        
        
        }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
