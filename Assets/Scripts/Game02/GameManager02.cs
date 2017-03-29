using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager02 : MonoBehaviour {

	public void StartGame() {
		// GameObject.Find("Cube").transform.Find("Cylinder").gameObject.SetActive(true);
		// GameObject.Find("GameObjects").transform.Find("Cube").gameObject.SetActive(true);
		GameObject.Find("Canvas").SetActive(false);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Escape)) {
			SceneManager.LoadScene("Start");
		}
	}
}
