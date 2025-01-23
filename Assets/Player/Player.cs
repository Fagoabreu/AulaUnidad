using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int vida;

    private PlayerInputAdapter playerInput;
    private PlayerMovement playerMovement;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInputAdapter>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        InputFrame inputFrame = playerInput.GetInputFrame();
        playerMovement.SetInputFrame(inputFrame);


    }

}
