using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour {
	public GameObject[] virtuluSagataves;
	public float laikaIntervals = 0.9f;
	float minPoz, maxPoz;
	public Transform vecaks;


	// Use this for initialization
	void Start () {
		vecaks = GetComponent<Transform>();
    }
	
	public void SagatavotVirtulus(bool stavoklis)
	{
		if(stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();
	}

	IEnumerator Generet()
	{
		while(true)
		{
            minPoz = vecaks.position.x - 50;
            maxPoz = vecaks.position.x + 50;
			var cipars = Random.Range(minPoz, maxPoz);
			
			var pozicija = new Vector3(cipars, transform.position.y);
			GameObject virtulis =
			Instantiate(virtuluSagataves[Random.Range(0, virtuluSagataves.Length)],
			pozicija, Quaternion.identity, vecaks);
			yield return new WaitForSeconds(laikaIntervals);
        }
	}
}
