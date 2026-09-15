using UnityEngine;

public class PJInventory : MonoBehaviour
{
    public int quantidadeMoedas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AdicionarItens(int quantidade)
    {
        quantidadeMoedas += quantidade;

        Debug.Log("Quantidade Moedas: " + quantidadeMoedas);
    }
}
