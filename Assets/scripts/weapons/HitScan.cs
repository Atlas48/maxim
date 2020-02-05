using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;

public abstract class HitScan : MonoBehaviour, IWeapon {
    Camera MainCamera;
    public int PrimaryClip { get; set; }
    public int SecondaryClip { get; set; }
    public abstract void Fire();
    public abstract void AltFire();
    // Update is called once per frame
    void Awake() {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
}
