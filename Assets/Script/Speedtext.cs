using UnityEngine;
using UnityEngine.UI;

public class Speedtext : MonoBehaviour
{
    // UI Text�w��p
    public Text TextFrame;
    // �\������ϐ�
    GameObject Bike;
    idou script;
    // Use this for initialization
    void Start()
    {
        Bike = GameObject.Find("Bike_R"); 
        script = Bike.GetComponent<idou>(); //u
    }

    // Update is called once per frame
    void Update()
    {
        float frame = script.speed2;
        TextFrame.text = string.Format("{0:f2} km/h", frame*-1);
    }

    
}