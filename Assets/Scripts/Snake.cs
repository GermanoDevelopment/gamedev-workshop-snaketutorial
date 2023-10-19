using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        lastPiece = headPiece;
        switch (Random.Range(0, 4)) {
            case 0:
                direction = Vector3.right;
                dir = 2;
                break;
            case 1:
                direction = -Vector3.right;
                dir = -2;
                break;
            case 2:
                direction = Vector3.forward;
                dir = 1;
                break;
            case 3:
                direction = -Vector3.forward;
                dir = -1;
                break;
        }
        StartCoroutine(Move());
    }

    public float tick = 1f;

    public float speed;

    Vector3 direction = Vector3.zero;

    void Update()
    {
        // alterando direção de movimento da cobra
        ChangeDirectionInput();
    }

    IEnumerator Move()
    {
        while(true) {
            // movendo a posição da cobra
            transform.position = transform.position + direction;

            // verificar se saiu do mapa

            yield return new WaitForSeconds(tick);
        }
    }

    int dir = 0;

    void ChangeDirectionInput()
    {
        if (Input.GetKeyDown(KeyCode.W) && dir+1 != 0)
        {
            direction = Vector3.forward;
            dir = 1;
        }

        if (Input.GetKeyDown(KeyCode.S) && dir-1 != 0)
        {
            direction = -Vector3.forward;
            dir = -1;
        }
        
        if (Input.GetKeyDown(KeyCode.A) && dir-2 != 0)
        {
            direction = -Vector3.right;
            dir = -2;
        }
        
        if (Input.GetKeyDown(KeyCode.D) && dir+2 != 0)
        {
            direction = Vector3.right;
            dir = 2;
        }
    }

    public GameObject headPiece;
    public GameObject bodyPiece;

    GameObject lastPiece;

    void GrowSnake()
    {
        GameObject bodyGO = Instantiate(bodyPiece);
        bodyGO.transform.position = lastPiece.transform.position;
        lastPiece = bodyGO;
    }
}
