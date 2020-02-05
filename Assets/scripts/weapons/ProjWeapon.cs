using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;

public abstract class ProjWeapon : MonoBehaviour, IWeapon {
    public int PrimaryClip { get; set; }
    public int SecondaryClip { get; set; }
    public abstract void Fire();
    public abstract void AltFire();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
