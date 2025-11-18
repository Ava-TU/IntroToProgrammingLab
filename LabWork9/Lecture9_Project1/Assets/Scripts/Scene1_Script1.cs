using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Scene1_Script1 : MonoBehaviour {

    public Light dirLight;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetFixedText ()
	{
		Text lbl = GetComponent<Text> ();
		lbl.text = "Button Pressed!";
        if(dirLight.enabled){
            dirLight.enabled = false;
        }
        else{
            dirLight.enabled = true;
        }
       
	}

	public void UpdateLabel (float value)
	{
		Text lbl = GetComponent<Text> ();
		if (lbl != null)
			lbl.text = Mathf.RoundToInt (value * 100) + "%";
	}

	public void UpdateLabelFloat (float value)
	{
		Text lbl = GetComponent<Text> ();
		if (lbl != null)
			lbl.text = value.ToString ();
	}
}
