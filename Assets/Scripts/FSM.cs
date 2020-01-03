using UnityEngine;

public class FSM : MonoBehaviour
{
    //1.枚举类型 列出对象包含的所有状态
    public enum PlayerState {
        Idle,
        Run,
        Attack,
        Death
    }

    void Awake() {
        currentState = PlayerState.Idle;
    }
    private PlayerState currentState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            SetState(PlayerState.Idle);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            SetState(PlayerState.Attack);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            SetState(PlayerState.Run);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            SetState(PlayerState.Death);
        }
    }
    //状态转移函数
    public void SetState(PlayerState newState) {
        //当前状态置为newState
        currentState = newState;
        switch (currentState) {
            case PlayerState.Idle:
                Idle();
                break;
            case PlayerState.Run:
                Run();
                break;
            case PlayerState.Attack:
                Attack();
                break;
            case PlayerState.Death:
                Death();
                break;
        }
    }

    void Idle() {
        Debug.Log("PlayerState is "+currentState);
    }

    void Run() {
        Debug.Log("PlayerState is " + currentState);
    }
    void Attack() {
        Debug.Log("PlayerState is " + currentState);
    }
    void Death() {
        Debug.Log("PlayerState is " + currentState);
    }
}
