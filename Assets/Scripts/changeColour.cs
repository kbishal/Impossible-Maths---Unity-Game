using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColour : MonoBehaviour {

	public GameObject Square;
	public Image Rotate;
	private int flag;
	private ColorBlock col;

	void awake(){
	}

	public void RotateImage(){
		
		Square = GameObject.FindGameObjectWithTag ("HUD");
		transform.Rotate (Vector3.forward * -90);	
	
	}
}
