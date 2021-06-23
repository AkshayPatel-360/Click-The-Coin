using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAnimations : MonoBehaviour
{
    [SerializeField]private Animation bitCoinAnimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BitCoinAnimationPlay()
    {
        bitCoinAnimation.Play();
    }
}
