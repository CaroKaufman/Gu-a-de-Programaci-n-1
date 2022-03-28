using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1_Ej5 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
       if (num2 == 0) {
       Debug.Log("No se puede dividir por cero");
}
       else {
       Debug.Log(num1 + "/" + num2 + "=" + num1 / num2);
}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
