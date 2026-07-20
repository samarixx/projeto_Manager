using UnityEngine;

public class PlayerObserverManager : MonoBehaviour
{
    
    public static event Action<int> OnCoinCollected;
        
    public static void NotifyCoinCollected(int currentCoins)
    {
        OnCoinCollected?.Invoke(currentCoins);
    }
    
    
    void Update()
    {
    
    }
}
