using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    //Cambia de color las figuras de manera aleatoria.
    public void setColor()
    {
        int n = Random.Range(0, 7);
        switch (n)
        {
            case 0:
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 1:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case 2:
                GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case 3:
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 4:
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case 5:
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case 6:
                GetComponent<MeshRenderer>().material.color = Color.magenta;
                break;
        }
    }
  
}

