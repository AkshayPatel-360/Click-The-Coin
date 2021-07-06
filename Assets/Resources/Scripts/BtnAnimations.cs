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

    public void MiniBitcoinAnimationPlay()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 worldPoint2d = new Vector2(worldPoint.x, worldPoint.y);
        GameObject obj = ObjectPuller.currentObjectPuller.DepullObject();
        obj.transform.position = worldPoint2d;
       

       // Destroy(miniBitCoin, 0.7f);
    }
}
