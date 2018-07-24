using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CameraController : MonoBehaviour {

    public float FollowSpeed = 5f;
    public Transform target;
    AttackController AttackCntr;
    public GameObject scope;

    private void Start()
    {
        AttackCntr = GetComponent<AttackController>();
    }

    private void Update()
    {
        Vector3 newPosition = new Vector3((scope.transform.position.x + target.transform.position.x) / 2.0f, (scope.transform.position.y + target.transform.position.y) / 2.0f, -100);
        newPosition.z = -10;
        scope = GameObject.Find("Scope(Clone)");
        transform.position = Vector3.Slerp(this.transform.position, newPosition, FollowSpeed * Time.deltaTime);
        //transform.position = new Vector3((scope.transform.position.x + this.transform.position.x)/2.0f, (scope.transform.position.y + this.transform.position.y) / 2.0f, -100);//scope.transform.position;

    }
}
