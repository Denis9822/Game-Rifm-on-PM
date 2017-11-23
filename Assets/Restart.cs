using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {


		if (Play.countTry == 5) {

			StartCoroutine ("LoadLEvel");

		}

	}

	IEnumerator LoadLEvel()
	{
		yield return new WaitForSeconds (1.5f);

		Play.countTry = 1;

		Application.LoadLevel ("Restart");
	}
}
