using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyMovement : MonoBehaviour
{
    public float distance = 1.5f;  
    public float speed = 2.0f;
    private Vector3 enemyPos;

    public int lifeCount = 3;
    public GameObject live3;
    public GameObject live2;
    public GameObject live1;

    void Start()
    {
        enemyPos = transform.position;
    }

    void Update()
    {
        Vector3 v = enemyPos;
        v.z += distance * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            switch (lifeCount) {
                case 3:
                    live3.SetActive(false);
                    lifeCount--;
                    ScoreManager.instance.ChangeScore(1);
                    break;
                case 2:
                    live2.SetActive(false);
                    lifeCount--;
                    ScoreManager.instance.ChangeScore(1);
                    break;
                case 1:
                    live1.SetActive(false);
                    lifeCount--;
                    ScoreManager.instance.ChangeScore(1);
                    break;
                case 0:
                    Application.Quit();
                    break;
            }
        }

        if (other.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}

