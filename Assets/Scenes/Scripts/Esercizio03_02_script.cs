using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio03_02_script : MonoBehaviour
{
    int[] stampa = new int[0];
    public int dimensione = 10;
    public int minimo = 10;
    public int massimo = 100;

    
    
    
    void GeneraArray(int a, int b, int c)
    {
        stampa = new int[a];

        for (int i = 0; i < stampa.Length; i++)
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

    int TrovaMinimi(int[] a)
    {
        int minimo = a[0];
        int minimo2 = a[1];
        for (int i = 0; i < a.Length; i++)
        {

            if (minimo > a[i])
            {
                minimo = a[i];

            }
            if (minimo2 > a[i] && a[i] > minimo)
            {
                minimo2 = a[i];

            }

        }
        Debug.Log("Questo è il valore minimo dell'array: " + minimo);
        Debug.Log("Questo è il secondo valore minimo dell'array: " + minimo2);
        Debug.Log("Fine funzione TrovaMinimo");
        return minimo;


    }
    int TrovaMassimi(int[] a)
    {
        int massimo = a[0];
        int massimo2 = a[1];
        for (int i = 0; i < a.Length; i++)
        {

            if (massimo < a[i])
            {
                massimo = a[i];

            }
            if (massimo2 < a[i] && a[i] > massimo)
            {
                massimo2 = a[i];
            
            }

        }
        Debug.Log("Questo è il valore massimo dell'array: " + massimo);
        Debug.Log("Questo è il secondo valore massimo dell'array: " + massimo2);
        Debug.Log("Fine funzione TrovaMassimi");
        return massimo;


    }





    // Start is called before the first frame update
    void Start()
    {
        GeneraArray(dimensione, minimo, massimo);
        StampaArray(stampa);
        TrovaMinimi(stampa);
        TrovaMassimi(stampa);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
