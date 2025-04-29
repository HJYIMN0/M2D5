using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio01_Script : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEven()
    {
        if (numero % 2 == 0)
        {
            Debug.Log("Il numero " + numero + " è pari!");
            return true;
        }
        else
        {
            Debug.Log("Il numero " + numero + " non è pari!");
            return false;
        }
    }

    bool isMultiple()
    {
        if (multipleNumber % baseNumber == 0)
        {
            Debug.Log("Il numero " + multipleNumber + " è multiplo di " + baseNumber);
            return true;
        }
        else
        {
            Debug.Log("Il numero " + multipleNumber + " non è multiplo di " + baseNumber);
            return false;
        }

    }

    public int numero = 5;
    public int baseNumber = 3;
    public int multipleNumber = 15;



    void Start()
    {
        isEven();
        isMultiple();

       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
