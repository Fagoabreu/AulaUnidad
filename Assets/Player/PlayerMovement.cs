using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidade = 10f;
    [SerializeField] private float forcaPulo = 40f;
    private InputFrame inputFrame;
    private Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (inputFrame == null)
        {
            return;
        }
        rigid.AddForce(velocidade * inputFrame.move);

        if (inputFrame.Jump)
        {
            rigid.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
        }
    }

    public void SetInputFrame(InputFrame inputFrame)
    {
        this.inputFrame = inputFrame;
    }
}
