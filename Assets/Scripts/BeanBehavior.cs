using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Mr Dealy")
        {
            if(BeanScoreBehavior.scoreValue == 0)
            {
                BeanScoreBehavior.scoreValue = 4;
            }
            
            BeanScoreBehavior.scoreValue += 1;
            Destroy(gameObject);
        }
    }
}
