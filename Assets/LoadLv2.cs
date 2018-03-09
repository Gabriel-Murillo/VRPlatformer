using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLv2 : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			Application.LoadLevel ("Test Demo 2");
		}
	}
}
