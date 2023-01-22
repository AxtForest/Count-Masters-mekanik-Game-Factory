using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    Vector3 fark;
    // Start is called before the first frame update
    void Start()
    {
        fark = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + fark;
    }
}
