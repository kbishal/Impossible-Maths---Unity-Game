using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveLabel : MonoBehaviour {

	public Text side1Label;
	public Text side2Label;
	public Text side3Label;
	public Text side4Label;


	void AdjustLabel(Text side){
		if (side.rectTransform.anchoredPosition == new Vector2 (0, -210)) {
			side.rectTransform.anchoredPosition = new Vector2 (150, -360);
			side.alignment = TextAnchor.MiddleLeft; 
		} else if (side.rectTransform.anchoredPosition == new Vector2 (150, -360)) {
			side.rectTransform.anchoredPosition = new Vector2 (0, -510);
			side.alignment = TextAnchor.UpperCenter;
		} else if (side.rectTransform.anchoredPosition == new Vector2 (0, -510)) {
			side.rectTransform.anchoredPosition = new Vector2 (-150, -360);
			side.alignment = TextAnchor.MiddleRight;
		} else if (side.rectTransform.anchoredPosition == new Vector2 (-150, -360)) {
			side.rectTransform.anchoredPosition = new Vector2 (0, -210);
			side.alignment = TextAnchor.LowerCenter;
		}
		Debug.Log (side.GetComponent<RectTransform>().anchoredPosition);
	}

	public void adjustLabel(){
		AdjustLabel (side1Label);
		AdjustLabel (side2Label);
		AdjustLabel (side3Label);
		AdjustLabel (side4Label);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
	// Update is called once per frame
		
	}
}
