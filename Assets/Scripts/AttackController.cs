using UnityEngine;

public class AttackController : MonoBehaviour {

    public bool isFacingRight;
    MovementController MoveCntr;


    private float scoperLen = 3;
    public float scoperAng = 0;
    private float scopeRotSpeed = 1f;
    private float scopeMoveSpeed = 0.1f;
    private float scopeMaxLen = 15;
    private float scopeMinLen = 1;
    private float fireForce = 100;
    private float bowLen = 1;
    private float fireDirection = 1;
    private const float angleRealtion = 0.0174533f;
    public GameObject scoper;
    public Rigidbody2D Arrow;
    public static Rigidbody2D FlyingArr;
    public static GameObject scope;
    bool flag = false;
    float speedRot = 2.5f;
    float degree = 0;

    public enum WeaponState {
        BLADE,
        CROSSBOW
    }

    public WeaponState weaponState = WeaponState.BLADE;
    public bool attacks;

	void Start() {
        MoveCntr = GetComponent<MovementController>();
        scope = Instantiate(scoper, MoveCntr.transform.position, Quaternion.identity);
        
    }
	

	void FixedUpdate() {
        handleInput();
        
    }

    private void handleInput() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            weaponState = WeaponState.BLADE;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            weaponState = WeaponState.CROSSBOW;
        else if (Input.GetKeyDown(KeyCode.F))
            attacks = true;

        handleThrowInput();
        handleAimingInput();
    }
    private void handleThrowInput()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            FlyingArr = Instantiate(Arrow, (MoveCntr.transform.position + scope.transform.position)/2.0f, Quaternion.identity);
            FlyingArr.AddForce((scope.transform.position - MoveCntr.rigidbody.transform.position)*fireForce);
            flag = true;
        }
        if(flag)
        FlyingArr.MoveRotation(degree);
        degree+=speedRot;
    }

    private void handleAimingInput()
    {
        int scopeToRight;
        if (MoveCntr.isFacingRight)
            scopeToRight = 1;
        else
            scopeToRight = -1;
        scope.transform.position = MoveCntr.transform.position + new Vector3(scoperLen*Mathf.Cos(scoperAng*angleRealtion)*scopeToRight, scoperLen * Mathf.Sin(scoperAng *angleRealtion), 0);
        if (Input.GetKey(KeyCode.Q) && (scoperAng<90))
            scoperAng += scopeRotSpeed;
        if (Input.GetKey(KeyCode.E) && (scoperAng>-90))
            scoperAng -= scopeRotSpeed;

        if (Input.GetKey(KeyCode.RightBracket) && (scoperLen < scopeMaxLen))
            scoperLen += scopeMoveSpeed;

        if (Input.GetKey(KeyCode.LeftBracket) && (scoperLen > scopeMinLen))
            scoperLen -= scopeMoveSpeed;

        fireDirection = MoveCntr.rigidbody.transform.localScale.x;
    }
}
