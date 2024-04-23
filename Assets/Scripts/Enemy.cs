using UnityEngine;

namespace CosmicBagel
{
    public class Enemy : MonoBehaviour, IDamageReceiver
    {
        public void TakeDamage(int damage)
        {
            Debug.Log("Enemy took " + damage + " damage");
        }
    }
}
