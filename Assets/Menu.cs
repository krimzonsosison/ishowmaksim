using UnityEngine;
using UnityEngine.SceneManagement;



public class scene : MonoBehaviour
{
       public void SceneLoader(string levels)
    {
        SceneManager.LoadScene("levels");
    }



}
   