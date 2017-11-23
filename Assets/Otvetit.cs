using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Otvetit : MonoBehaviour {

	public Text txt;


	public static string VvodimoeSlovo1;

	public static bool iSEter;



	public void VvodimoeSlovo()
	{

		VvodimoeSlovo1 = txt.text.ToUpper();

		//Debug.Log (VvodimoeSlovo1);

		txt.text = "";



		iSEter = true;

	
	}
}
