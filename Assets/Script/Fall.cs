using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Red")
        {
           // Debug.LogWarning("Fall");
            Vector3 angle = red.transform.eulerAngles;
            red.transform.position = new Vector3(19.0f, 4.0f, -75.0f); //èâä˙ílÇ÷ÉèÅ[Év
            angle.y = 90.0f;
            red.transform.eulerAngles = angle; //å¸Ç´ÇªÇÎÇ¶ÇÈ

        }
        if (collider.gameObject.tag == "Blue")
        {
            Vector3 angle = blue.transform.eulerAngles;
            blue.transform.position = new Vector3(23.0f, 4.0f, -75.0f);
            blue.transform.Rotate(0, 90, 0);
            angle.y = 90.0f;
            blue.transform.eulerAngles = angle;

        }
    }
}
