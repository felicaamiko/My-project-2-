using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private int _headCount = 5;
    [SerializeField] private float _gooseTimeLimit = 1;

    public int HeadCount => _headCount;
    public float GooseTimeLimit => _gooseTimeLimit;
}
