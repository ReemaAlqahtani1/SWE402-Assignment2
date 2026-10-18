using UnityEngine;

public class Key : MonoBehaviour
{
    public string KeyName = "key1";

    void OnTriggerEnter(Collider other)
    {
        PlayerMovement player =
            other.GetComponentInParent<PlayerMovement>();

        if (player == null)
            return;

        player.AddKey(KeyName);
        Destroy(gameObject);
    }
}