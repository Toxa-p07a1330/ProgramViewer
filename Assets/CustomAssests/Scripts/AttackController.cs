using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour {

    public bool isFacingRight;
    PlayerController MoveCntr;
    private float scoperLen = 3;
    public float scoperAng = 0;
    private float scopeRotSpeed = 1f;
    private float scopeMoveSpeed = 0.1f;
    private float scopeMaxLen = 15;
    private float scopeMinLen = 1;
    private float fireForce = 100;
    private float armLen = 1;
    private float fireDirection = 1;
    private const float angleRealtion = 0.0174533f;
    public GameObject scoper;
    public Rigidbody2D Arrow;
    public static Rigidbody2D FlyingArr;
    public static Rigidbody2D KnifeBeat;
    public Rigidbody2D Knife;
    public GameObject scope;
    bool flag1 = false;
    int scopeToRight = 1;

    bool NindjaNotWizard;

    // Use this for initialization
    void Start ()
    {

        MoveCntr = GetComponent<PlayerController>();
        scope = Instantiate(scoper, MoveCntr.transform.position, Quaternion.identity);
        scopeMinLen = armLen;

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        attackInput();
	}
    void attackInput()
    {
        aimingInput();
        hittingInput();
        throwingInput();
        magicInput();

        if (Input.GetKeyDown(KeyCode.Alpha1))
            NindjaNotWizard = true;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            NindjaNotWizard = false;
    }

    void aimingInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            scopeToRight = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            scopeToRight = -1;
        scope.transform.position = MoveCntr.transform.position + new Vector3(scoperLen * Mathf.Cos(scoperAng * angleRealtion) * scopeToRight, scoperLen * Mathf.Sin(scoperAng * angleRealtion), -5);
        if (Input.GetKey(KeyCode.Q) && (scoperAng < 90))
            scoperAng += scopeRotSpeed;
        if (Input.GetKey(KeyCode.E) && (scoperAng > -90))
            scoperAng -= scopeRotSpeed;

        if (Input.GetKey(KeyCode.RightBracket) && (scoperLen < scopeMaxLen))
            scoperLen += scopeMoveSpeed;

        if (Input.GetKey(KeyCode.LeftBracket) && (scoperLen > scopeMinLen))
            scoperLen -= scopeMoveSpeed;

        fireDirection = MoveCntr.GetComponent<Rigidbody2D>().transform.localScale.x;
    }
    void hittingInput()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            KnifeBeat = Instantiate(Knife, MoveCntr.transform.position + new Vector3(armLen * Mathf.Cos(scoperAng * angleRealtion) * scopeToRight, armLen * Mathf.Sin(scoperAng * angleRealtion)), Quaternion.identity);
            Destroy(KnifeBeat.gameObject, 0.3f);
            KnifeBeat.transform.localScale = new Vector2(KnifeBeat.transform.lossyScale.x * scopeToRight, KnifeBeat.transform.lossyScale.y);
        }
    }
    void throwingInput()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            FlyingArr = Instantiate(Arrow, MoveCntr.transform.position + new Vector3(scopeMinLen * Mathf.Cos(scoperAng * angleRealtion) * scopeToRight, scopeMinLen * Mathf.Sin(scoperAng * angleRealtion)), Quaternion.identity);
            FlyingArr.AddForce((scope.transform.position - MoveCntr.GetComponent<Rigidbody2D>().transform.position) * fireForce);
            flag1 = true;
        }
    }
    void magicInput()
    {

    }
}
