using UnityEngine;
using UnityEngine.SceneManagement;

public class UiScript : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

