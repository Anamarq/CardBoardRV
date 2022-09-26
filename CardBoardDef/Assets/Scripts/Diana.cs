using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    public GameObject door3;
    // Start is called before the first frame update
    

        //Selecciona la diana, y aumenta el contador de dianas necesario para abrir la puerta
    public void DianaSelected()
    {
        gameObject.SetActive(false);
        ++door3.GetComponent<Open3>().contDianas;
    }
}
