using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
      if(other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(1);
            Destroy(gameObject);

        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
