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
	public void RotateImage()
	{
		StartCoroutine (RotateImageCoroutine ());
	}
	public IEnumerator RotateImageCoroutine(){
		
		Square = GameObject.FindGameObjectWithTag ("HUD");
		for (int i = 1; i <= 9; i++) {
			yield return new WaitForSeconds (.0001f);
			transform.Rotate (Vector3.forward * -10);
		}
			
//		yield return new WaitForSeconds(5);
	}

	IEnumerator Example()
	{
//		print(Time.time);
		yield return new WaitForSeconds(.1f);
//		print(Time.time);
	}
}
