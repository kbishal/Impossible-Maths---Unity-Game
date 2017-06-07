using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAction : MonoBehaviour {

	public GameObject Square;

	void awake(){
	}
	public void RotateImageRight()
	{
		StartCoroutine (RotateImageRightCoroutine ());
	}
	public IEnumerator RotateImageRightCoroutine(){

		Square = GameObject.FindGameObjectWithTag ("HUD");
		for (int i = 1; i <= 9; i++) {
			yield return new WaitForSeconds (.0001f);
			transform.Rotate (Vector3.forward * -10);
		}

		//		yield return new WaitForSeconds(5);
	}



	public void RotateImageLeft()
	{
		StartCoroutine (RotateImageLeftCoroutine ());
	}
	public IEnumerator RotateImageLeftCoroutine(){

		Square = GameObject.FindGameObjectWithTag ("HUD");
		for (int i = 1; i <= 9; i++) {
			yield return new WaitForSeconds (.0001f);
			transform.Rotate (Vector3.forward * 10);
		}

		//		yield return new WaitForSeconds(5);
	}
}
