using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager01 : MonoBehaviour
{

    public static bool hasStarted = false;

    public void StartGame()
    {
        GameObject.Find("Spawner").GetComponent<Spawner>().enabled = true;
        GameObject.Find("Canvas").SetActive(false);

        hasStarted = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
