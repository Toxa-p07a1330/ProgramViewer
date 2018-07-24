using UnityEngine;
using System.Threading;

public class AttackController : MonoBehaviour {

    public bool isFacingRight;
    MovementController MoveCntr;
    Color color = new Color(0, 0, 0, 0.5f);
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
    public static GameObject scope;
    bool flag1 = false;
    float speedRot = 2.5f;
    float degree = 0;
    int scopeToRight;

    public enum WeaponState {
        BLADE,
        CROSSBOW
    }

    public WeaponState weaponState = WeaponState.BLADE;
    public bool attacks;

	void Start() {
        MoveCntr = GetComponent<MovementController>();
        scope = Instantiate(scoper, MoveCntr.transform.position, Quaternion.identity);
        scopeMinLen = Mathf.Sqrt(Mathf.Abs(MoveCntr.playerHeight*MoveCntr.playerHeight + MoveCntr.playerWidth*MoveCntr.playerWidth));
        
    }
	

	void FixedUpdate() {
        handleInput();
        
    }

    private void handleInput() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            weaponState = WeaponState.BLADE;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            weaponState = WeaponState.CROSSBOW;

        handleKnifeInput();
        handleThrowInput();
        handleAimingInput();
    }
    private void handleThrowInput()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            FlyingArr = Instantiate(Arrow, MoveCntr.transform.position + new Vector3(scopeMinLen * Mathf.Cos(scoperAng * angleRealtion) * scopeToRight, scopeMinLen * Mathf.Sin(scoperAng * angleRealtion)), Quaternion.identity);
            FlyingArr.AddForce((scope.transform.position - MoveCntr.rigidbody.transform.position)*fireForce);
            flag1 = true;
        }
        if(flag1)
        FlyingArr.MoveRotation(degree);
        degree+=speedRot;
    }

    private void handleAimingInput()
    {
        
        if (MoveCntr.isFacingRight)
            scopeToRight = 1;
        else
            scopeToRight = -1;
        scope.transform.position = MoveCntr.transform.position + new Vector3(scoperLen*Mathf.Cos(scoperAng*angleRealtion)*scopeToRight, scoperLen * Mathf.Sin(scoperAng *angleRealtion), -5);
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
    public void observeAttackEnded()
    {
        MoveCntr.attacks = false;
    }
    public void handleKnifeInput()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MoveCntr.attacks = true;
            KnifeBeat = Instantiate(Knife, MoveCntr.transform.position + new Vector3(armLen * Mathf.Cos(scoperAng * angleRealtion) * scopeToRight, armLen * Mathf.Sin(scoperAng * angleRealtion)), Quaternion.identity);
            Destroy(KnifeBeat.gameObject, 0.3f);
            KnifeBeat.transform.localScale = new Vector2(KnifeBeat.transform.lossyScale.x * scopeToRight, KnifeBeat.transform.lossyScale.y);
        }
            
    }
       

}
