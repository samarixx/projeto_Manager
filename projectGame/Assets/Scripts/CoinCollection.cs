using UnityEngine;

public class CoinCollection : MonoBehaviour
{

    private int Coin = 0;
    
    public TextMeshProGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++
            coinText.text = "Coin: " + Coin.ToString();    
            Debug.Log(Coin);
        }
    }
}
