using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager03 : MonoBehaviour {
	public void StartGame() {
		GameObject.Find("GameManager").transform.Find("GameObjects").gameObject.SetActive(true);
		GameObject.Find("Canvas").SetActive(false);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Escape)) {
			SceneManager.LoadScene("Start");
		}
	}
}
