﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionMotionAndAction : MonoBehaviour {

	public Text textScore;
	public Text question;
	public Text option1;
	public Text option2;
	public Text option3;
	public Text option4;
	public Button restart;
	public Button startButton;
	public Button FullScreenButton;

	private Rigidbody2D rb2d;
	private Vector2 vel;
	private int operand1;
	private int operand2;
	protected int Answer;
	private RectTransform pos;
	public float moveSpeed = 160f;

	public static QuestionMotionAndAction instance;

	void Awake()
	{
		instance = this;
	}

	void Start () {
		rb2d = question.GetComponent<Rigidbody2D> ();
		//GameObject.FindGameObjectWithTag("restart").SetActive(false);
		restart.gameObject.SetActive(false);
		FullScreenButton.gameObject.SetActive (false);
		textScore.text = "";
//		CollisionScript.instance.rotateLeft.gameObject.SetActive (false);
//		CollisionScript.instance.rotateRight.gameObject.SetActive (false);
	}

	public void EnterTheGame(){
//		CollisionScript.instance.rotateLeft.gameObject.SetActive (true);
//		CollisionScript.instance.rotateRight.gameObject.SetActive (true);
		FullScreenButton.gameObject.SetActive (true);
		textScore.text = "Score";
		CollisionScript.instance.SetScore (0);
		//GameObject.FindGameObjectWithTag ("startButton").SetActive (false);
		startButton.gameObject.SetActive (false);
		FrameQuestion ();
		MoveQuestion (-moveSpeed);
	}

    public void FrameQuestion(){


		int Qselector = Random.Range (0, 4);

		if (Qselector == 0) {
			
			operand1 = Random.Range (1, 9);
			operand2 = Random.Range (5, 10);

			question.text = string.Format ("{0} + {1}", operand1, operand2);
			Answer = operand1 + operand2;
		} else if (Qselector == 1) {
			operand1 = Random.Range (1, 9);
			operand2 = Random.Range (0, 9);

			question.text = string.Format ("{0} - {1}", operand1, operand2);
			Answer = operand1 - operand2;
		} else if (Qselector == 2) {
			operand1 = Random.Range (1, 9);
			operand2 = Random.Range (2, 10);

			question.text = string.Format ("{0} X {1}", operand1, operand2);
			Answer = operand1 * operand2;
		} else {
			operand1 = Random.Range (2, 9);
			operand2 = Random.Range (2, 9);
			
			int temp = operand1 * operand2;

			question.text = string.Format ("{0} / {1}", temp, operand1);
			Answer = operand2;
		}



		int num = Random.Range (0, 4);
		if (num == 0) {
			option1.text = "" + Answer;
			option2.text = "" + (Answer+1);
			option3.text = "" + (Answer-2);
			option4.text = "" + (Answer-1);
		} else if (num == 1) {
			option2.text = "" + Answer;
			option1.text = "" + (Answer+1);
			option3.text = "" + (Answer+2);
			option4.text = "" + (Answer-1);			
		} else if (num == 2) {
			option3.text = "" + Answer;
			option2.text = "" + (Answer+1);
			option1.text = "" + (Answer-4);
			option4.text = "" + (Answer-1);
		} else {
			option4.text = "" + Answer;
			option2.text = "" + (Answer+1);
			option3.text = "" + (Answer-2);
			option1.text = "" + (Answer-1);
		}



	}

	public void MoveQuestion(float y, float x = 0){
		vel.x = x;
		vel.y = y;
		rb2d.velocity = vel;
	}

	public void Restart(){
		CollisionScript.instance.Score.text = "" + 0;
		CollisionScript.instance.SetScore (0);
		ResetQuestion ();
//		CollisionScript.instance.rotateLeft.gameObject.SetActive (true);
//		CollisionScript.instance.rotateRight.gameObject.SetActive (true);
		FullScreenButton.gameObject.SetActive (true);
	}
	/*void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "square")
		{
			CheckAnswer ();

		}
	}*/
	
	// Update is called once per frame
	void Update () {



	}

	public void ResetQuestion(){
		pos = question.GetComponent<RectTransform> ();
		pos.anchoredPosition = new Vector2 (0, 325);
		FrameQuestion ();
		MoveQuestion (-moveSpeed);
		//GameObject.FindGameObjectWithTag("restart").SetActive(false); instead use the statement below.
		restart.gameObject.SetActive(false);
	}



	public string GetOption1(){
		return option1.text;
	}

	public string GetOption2(){
		return option2.text;
	}

	public string GetOption3(){
		return option3.text;
	}

	public string GetOption4(){
		return option4.text;
	}

	public string GetAnswer(){
		return Answer.ToString();
	}
}
