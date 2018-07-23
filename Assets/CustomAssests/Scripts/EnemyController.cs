using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float maxVisionLen = 10f;
    public float maxAngleUp = 30;
    public float maxAngleDown = -30;
    public float rotationSpeed = 3f;
    int isMovingUp = 1;
    public float angle = 0;
    public int direction = -1; //1 if enemy is looking rigt, -1 if is looking left
    private const float angleRealtion = 0.0174533f;
    RaycastHit2D vision;
    public bool see;
    public float timeOfUndetection = 0.25f;
    float lastSeenAt;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        circulation();
        debugDraw();
        detect();
        find();

	}

    void circulation()
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

    void debugDraw()
    {
        float realVisionLen = vision.distance;
        if (realVisionLen > maxVisionLen || vision.collider==null)
            realVisionLen = maxVisionLen;
        Color colorOfRay = Color.white;
        if (vision.collider !=null && vision.collider.tag == "Ground" && vision.distance <= maxVisionLen)
            colorOfRay = Color.grey;

        if ((vision.collider != null && vision.collider.tag == "Player" && vision.distance <= maxVisionLen) || (see == true))
            colorOfRay = Color.red;
        Debug.DrawRay(this.transform.position, new Vector3(realVisionLen * Mathf.Cos(angle * angleRealtion) * direction, realVisionLen * Mathf.Sin(angle * angleRealtion)), colorOfRay);
      
    }

    void detect()
    {

        vision = Physics2D.Raycast(this.transform.position, new Vector3(maxVisionLen * Mathf.Cos(angle * angleRealtion) * direction, maxVisionLen * Mathf.Sin(angle * angleRealtion)));
        if (vision && vision.distance <= maxVisionLen)
        {
            if (vision.collider.tag == "Player")
                lastSeenAt = Time.time;
        }

    }

    void find()
    {
        if ((Time.time - lastSeenAt > timeOfUndetection)||(Time.time<5))
            see = false;
        else
            see = true;

    }
}
