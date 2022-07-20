using UnityEngine;
using UnityEngine.UI;

public class Speedtext : MonoBehaviour
{
    // UI Text指定用
    public Text TextFrame;
    // 表示する変数
    GameObject Bike;
    idou script;
    // Use this for initialization
    void Start()
    {
        Bike = GameObject.Find("Bike"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = Bike.GetComponent<idou>(); //u
    }

    // Update is called once per frame
    void Update()
    {
        float frame = script.speed;
        TextFrame.text = string.Format("{0} km/h", frame*-1);
    }
}