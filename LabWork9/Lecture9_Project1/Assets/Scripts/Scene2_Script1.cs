using UnityEngine;
using UnityEngine.UI;

public class Scene2_Script1 : MonoBehaviour
{
    public GameObject textLabelXValue;
    public GameObject textLabelYValue;

    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        textLabelXValue.GetComponent<Scene1_Script1> ().UpdateLabelFloat (mouseX);
        textLabelYValue.GetComponent<Scene1_Script1> ().UpdateLabelFloat (mouseY);
    }
}
