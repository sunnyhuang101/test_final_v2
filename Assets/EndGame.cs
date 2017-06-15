using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("enemy") || colInfo.CompareTag("road") ||colInfo.CompareTag("box") )
		{//Collidable
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Application.LoadLevel("gameover");
			countdown.timer = 300;
		}
	}

}
