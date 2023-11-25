using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x + _offsetX,transform.position.y,transform.position.z);
    }
}
