﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour 
{
	private static int score = 0 ;
	public Text Score;
	private int count = 0;

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
		} else if ((hitInfo.name == "Side2") && (QuestionMotionAndAction.instance.option2.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer Hit side 2");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();

		} else if ((hitInfo.name == "Side3") && (QuestionMotionAndAction.instance.option3.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer hit side 3");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();

		} else if ((hitInfo.name == "Side4") && (QuestionMotionAndAction.instance.option4.text == QuestionMotionAndAction.instance.GetAnswer ())) {
			Debug.Log ("Correct Answer hit side 4");
			score++;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();


		} else {
			Debug.Log ("Else block");
			score--;
			Score.text = "" + score;
			QuestionMotionAndAction.instance.ResetQuestion ();

		}
	}

	public int GetScore(){
		return score;
	}

	void Start(){
		//Debug.Log (QuestionMotionAndAction.instance.option1.text + " ," + QuestionMotionAndAction.instance.option2.text);
		Score.text = "" + score;
	}

	void Update(){

	}

}