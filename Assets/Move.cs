using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8,1.5f,0);
    private void Update()
    {
        
        /*transform.position = Vector3.MoveTowards(transform.position, 
            target, 1);
        
        
        
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position
                , target, ref velo, 0.1f);
        
      
        transform.position =
            Vector3. Lerp(transform.position
                , target, 0.1f);*/
        
        transform. position =
            Vector3.Slerp(transform.position
                , target, 0.005f);
    }
    

    
}
