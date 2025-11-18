using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Light dirLight;
    
    void Start(){}

    void Update(){}

    public void SetFixedText()
    {
        Text lbl = GetComponent<Text> ();
        lbl.text = "Button Pressed!";

        dirLight.enabled = false;
    }

    public void UpdateLabel (float value)
    {
        Text lbl = GetComponent<Text> ();
        if (lbl != null)
        {
            lbl.text = Mathf.RoundToInt (value * 100) + "%";
        } 
    }
}
