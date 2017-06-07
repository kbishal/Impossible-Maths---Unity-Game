using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour 
{
	public Button restart;
//	public Image rotateLeft;
//	public Image rotateRight;
	public Button FullScreenButton;
	
	private static int score = 0 ;
	public Text Score;
	private int count = 0;
	private float speedOffset = 40;


	public static CollisionScript instance;


	void Awake()
	{
		instance = this;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if ((hitInfo.name == "Side1") && (QuestionMotionAndAction.instance.option1.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer Hit Side 1");
			score++;
			Debug.Log ("score =" +score);
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();
			//sideButtons (true);
			FullScreenButton.gameObject.SetActive (true);
			increeseMoveSpeed ();
		} else if ((hitInfo.name == "Side2") && (QuestionMotionAndAction.instance.option2.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer Hit side 2");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();
			//sideButtons(true);
			FullScreenButton.gameObject.SetActive (true);
			increeseMoveSpeed ();
		} else if ((hitInfo.name == "Side3") && (QuestionMotionAndAction.instance.option3.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer hit side 3");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();
			//sideButtons (true);
			increeseMoveSpeed ();
			FullScreenButton.gameObject.SetActive (true);

		} else if ((hitInfo.name == "Side4") && (QuestionMotionAndAction.instance.option4.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer hit side 4");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();
			//sideButtons (true);
			increeseMoveSpeed ();
			FullScreenButton.gameObject.SetActive (true);

		} else {
			Debug.Log ("Else block");
			Score.text = "" + score;
			FullScreenButton.gameObject.SetActive (false);
			QuestionMotionAndAction.instance.MoveQuestion (0);
			StartCoroutine (RestartButtonCoroutine ());
			//sideButtons (false);
			increeseMoveSpeed ();
		}
	}

//	void sideButtons(bool value){
//		rotateLeft.gameObject.SetActive (value);
//		rotateRight.gameObject.SetActive (value);
//	}

	public int GetScore(){
		return score;
	}

	public void SetScore(int _score){
		score = _score;
		Score.text = "" + score;
		increeseMoveSpeed ();
	}

	void Start(){
		//Debug.Log (QuestionMotionAndAction.instance.option1.text + " ," + QuestionMotionAndAction.instance.option2.text);
		Score.text = "";
	}

	void Update(){

	}
		
	void increeseMoveSpeed(){
		switch (score) {
		case 0:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed;
			break;
		case 3:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 6:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 9:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 12:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 15:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 18:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 21:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 25:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 30:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		case 40:
			QuestionMotionAndAction.instance.moveSpeed = QuestionMotionAndAction.instance.moveSpeed + speedOffset;
			break;
		}
	}

	public IEnumerator RestartButtonCoroutine(){
		yield return new WaitForSeconds (0.3f);
		restart.gameObject.SetActive (true);
	}
}
