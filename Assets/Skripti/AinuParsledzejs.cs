using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importé, lai varétu veikt ainu ieládi
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void UzSakumu(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
	}

}
