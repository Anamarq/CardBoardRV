using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open3: MonoBehaviour
{
    public int contDianas = 0;
    private int numDianas;
    // Start is called before the first frame update
    void Start()
    {
        numDianas = GameObject.FindGameObjectsWithTag("Diana").Length; //Cuenta el número de dianas
    }

    //Abre la puerta si se eliminan todas las dianas
    void Update()
    {
        if(contDianas>=numDianas)
            transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
    }
}
