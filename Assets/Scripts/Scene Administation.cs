using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class SceneAdministation : MonoBehaviour
{
    public float timer = 0;
    protected abstract string NextSceneName { get; }

    void Start()
    {
        timer = Time.deltaTime;
    }

    void Update()
    {
        if(timer >= 180)
        {
            LoadNextLevel();
            Destroy(gameObject);
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(NextSceneName);
    }

}
