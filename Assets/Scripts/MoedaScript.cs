using UnityEngine;

public class MoedaScript : MonoBehaviour
{
    int A = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se quem entrou no gatilho foi o Jogador
        if (other.CompareTag("Player"))
        {
            PJInventory inventory = other.GetComponent<PJInventory>();
            if(inventory != null)
            {
                inventory.AdicionarItens(A);
            }
            Destroy(gameObject);
        }
    }

}