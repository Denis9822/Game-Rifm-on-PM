using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTotalScore : MonoBehaviour {
	public Text thisText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Play.isGood1 == true) {
			if (PlayerPrefs.GetFloat ("TotalCount") > PlayerPrefs.GetFloat ("TotalCountOld")) {
				PlayerPrefs.SetFloat ("TotalCountOld", PlayerPrefs.GetFloat ("TotalCountOld") + 1f);
				thisText.text = PlayerPrefs.GetFloat ("TotalCountOld").ToString ();
			}
				else
					Play.isGood1 = false;
			
		}
	}
}
