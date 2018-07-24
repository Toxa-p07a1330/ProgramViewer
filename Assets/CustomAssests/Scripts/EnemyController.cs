using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float VisionLen = 10f;
    public float maxAngleUp = 30;
    public float maxAngleDown = -30;
    public float rotationSpeed = 1f;
    int isMovingUp = 1;
    public float angle = 0;
    public int direction = 1; //1 if enemy is looking rigt, -1 if is looking left
    private const float angleRealtion = 0.0174533f;
    RaycastHit2D vision;
    public bool see;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        checkViewArea();

        Debug.DrawRay(this.transform.position, new Vector3(VisionLen * Mathf.Cos(angle * angleRealtion) * direction, VisionLen * Mathf.Sin(angle * angleRealtion)));
        vision = Physics2D.Raycast(this.transform.position, new Vector3(VisionLen * Mathf.Cos(angle * angleRealtion) * direction, VisionLen * Mathf.Sin(angle * angleRealtion)));
        see = false;
        if (vision && vision.distance<=VisionLen)
        {
            if(vision.collider.tag == "Player")
                 see = true;
        }
        		
	}

    void checkViewArea()
    {

        if (true)
        {
            angle += rotationSpeed*isMovingUp;
        }
        if ((angle>=maxAngleUp)||(angle<=maxAngleDown))
        {
            isMovingUp *= -1;
        }


    }
}
