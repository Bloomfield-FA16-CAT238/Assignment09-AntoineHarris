using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour 
{
	public void ChangetoScene(int changetheScene)
	{
		SceneManager.LoadScene (changetheScene);
	}
}
