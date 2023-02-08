using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string nextscene;
    

    public void PlayGame()
    {

        SceneManager.LoadScene(nextscene);
    }
    public void QuitGame()
    {
        //quits game in build mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif  
        Application.Quit();//quit in play mode
    }

}
