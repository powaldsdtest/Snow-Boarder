using UnityEngine;
using UnityEngine.SceneManagement;

public class Crasher : MonoBehaviour
{
    Scene scene;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
