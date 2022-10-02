using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Shori : MonoBehaviour
{

    public RectTransform finish;
    public GameObject finish1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Red")
        {
            Debug.Log("RED GOAL!!!");
            finish.position = new Vector3(490, 350, 92);
            finish1.SetActive(true);
            Invoke(nameof(red), 3.5f);


        }
        if (collider.gameObject.tag == "Blue")
        {
            finish.position = new Vector3(490, 350, 92);
            finish1.SetActive(true);
            Debug.Log("BLUE GOAL!!!");
            Invoke(nameof(blue), 3.5f);

        }
    }

    void red()
    {
        SceneManager.LoadSceneAsync("RedWin");
    }

    void blue()
    {
        SceneManager.LoadSceneAsync("BlueWin");
    }
}
