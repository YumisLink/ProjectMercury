﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public List<Role> enm = new List<Role>();
    public Gatels LeftGate;
    public Gatels RightGate;
    public Gatels UpRightGate;
    public Gatels UpLeftGate;
    public Gatels DownRightGate;
    public Gatels DownLeftGate;
    public PolygonCollider2D Limit;
    public Vector2 roomAt;
    public Vector2 RoomCenter => roomAt + (Vector2)transform.position;
    void Start()
    {
        GateInit();
    }
    public void ReSetEnvironment()
    {
        foreach (var a in GetComponentInChildren<Transform>())
        {
            var j = (Transform)a;
            if (j.TryGetComponent<Environment>(out var k))
            {
                k.ReInit();
                j.gameObject.SetActive(true);
            }
        }
    }
    public void LeaveEnviroment()
    {
        foreach (var a in GetComponentInChildren<Transform>())
        {
            var j = (Transform)a;
            if (j.TryGetComponent<Environment>(out var k))
            {
                j.gameObject.SetActive(false);
            }
        }
    }
    void Update()
    {
        
    }
    void GateInit()
    {
        if (LeftGate)
            LeftGate.room = this;
        if (RightGate)
            RightGate.room = this;
        if (UpRightGate)
            UpRightGate.room = this;
        if (UpLeftGate)
            UpLeftGate.room = this;
        if (DownRightGate)
            DownRightGate.room = this;
        if (DownLeftGate)
            DownLeftGate.room = this;
    }
}
