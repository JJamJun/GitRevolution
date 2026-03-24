using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Vector2 moveInput;

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    // 움직이는 행위는 매 프레임 반영되기 때문에 Update()를 씀
    void Update()
    {
        Vector3 moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime); // 프레임 영향 받지 않게끔 Time.deltaTime을 곱함.
    }

    // 충돌 발생 시 작동하는 OnCollisionEnter, 파괴 직전 호출하는 Destory가 있음.

}
