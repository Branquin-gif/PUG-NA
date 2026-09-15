using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPassing : MonoBehaviour
{
    [SerializeField] private string Fase2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("jogador se adentrou no portal");
            SceneManager.LoadScene("Fase2");
        }
    }
}
