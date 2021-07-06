using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCoinAnimationController : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnEnable()
    {
        Invoke("DisableObj", 100.5f);
    }


    private void DisableObj()
    {
        gameObject.SetActive(false);

    }
}
