using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollider : MonoBehaviour
{
    private PlayerMovement _ThisMovementScript;
    private int coin = 0;
    public TextMeshProUGUI _TextCoins;

    private void Start()
    {
        _ThisMovementScript = GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider CollisonCoin)
    {
        if (CollisonCoin.CompareTag("Coin"))
        {
            coin++;
            _TextCoins.text = coin.ToString();
            Destroy(CollisonCoin.gameObject);
        }
    }
    private void OnCollisionEnter(Collision CollisonObstacle)
    {
       if (CollisonObstacle.gameObject.CompareTag("Obstacles"))
        {
            _ThisMovementScript.enabled = false;
        }
    
    }
    
}