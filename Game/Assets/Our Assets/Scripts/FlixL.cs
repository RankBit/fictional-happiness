using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlixL : MonoBehaviour
{
    Light testLight;
	public float min;
	public float max;
	
	void Start () {
		testLight = GetComponent<Light>();
		StartCoroutine(Flashing());
	}
	
	IEnumerator Flashing ()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(min,max));
			testLight.enabled = ! testLight.enabled;

		}
	}
}
