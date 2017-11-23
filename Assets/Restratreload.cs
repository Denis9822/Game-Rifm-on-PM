using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restratreload : MonoBehaviour {

	public GameObject SAFalse;

	public void Reload()
	{

		Application.LoadLevel ("game");
	}

	public void Open()
	{

		if(SAFalse.activeSelf==true)
			SAFalse.SetActive (false);
		else
			SAFalse.SetActive (true);


	}

				

}
