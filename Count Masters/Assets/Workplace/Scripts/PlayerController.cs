using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerCreator playerCreator;
    [SerializeField] private LayerMask Wall;
    private float minXBound = -4.75f;
    private float maxXBound = 4.75f;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckXBound();
    }
    private void CheckXBound()
    {
        float minX = transform.position.x;
        float maxX = transform.position.x;

        for (int i = 0; i < playerCreator.players.Count; i++)
        {
            if (playerCreator.players[i].transform.position.x < minX)
            {
                minX = playerCreator.players[i].transform.position.x;
            }
            if (playerCreator.players[i].transform.position.x > maxX)
            {
                maxX = playerCreator.players[i].transform.position.x;
            }
        }

        Vector3 LeftControl = new Vector3(minX, transform.position.y, transform.position.z);
        Vector3 RightControl = new Vector3(maxX, transform.position.y, transform.position.z);

        if (Physics.Raycast(LeftControl, Vector3.left, 0.5f, Wall))
        {
            minXBound = transform.position.x;
        }
        else
        {
            minXBound = -4.75f;
        }

        if (Physics.Raycast(RightControl, Vector3.right, 0.5f, Wall))
        {
            maxXBound = transform.position.x;
        }
        else
        {
            maxXBound = 4.75f;
        }
    }
    }
