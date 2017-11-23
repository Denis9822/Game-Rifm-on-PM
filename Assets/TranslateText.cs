using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslateText : MonoBehaviour {

	public Text CountScoreText;
	public Text HowRifmeText;





	float speed = 4f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	//transform.Translate (new Vector3 (CountScoreText.transform.position.x, CountScoreText.transform.position.y)*speed);
		if (Play.isTransform == true) {
			
			transform.position = Vector3.MoveTowards (transform.position, CountScoreText.transform.position, speed * Time.deltaTime);

			if (transform.localScale.x > 0 || transform.localScale.y > 0) {
				
				if (transform.localScale.x < 0.2f || transform.localScale.y < 0.2f) {
					CountScoreText.text = Play.CountScoreInt.ToString () + "/50";

					HowRifmeText.gameObject.SetActive (false);
				
			
				}

				transform.localScale = new Vector2 (transform.localScale.x - 0.015f, transform.localScale.y - 0.015f);
		

			} else {
		
				Play.isTransform = false;

			}
		}
	}
}
