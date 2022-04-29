using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPoolTimer : MonoBehaviour
{
    float timer = 0;
    float deathTime = 3;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer>deathTime)
        {
            //poolStart.Instance.DestroyToPool(this.gameObject);
        }
    }


}
