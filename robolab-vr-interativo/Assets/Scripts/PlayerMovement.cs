// PlayerMovement.cs
// RoboLab VR | Movimentacao WASD + mouse (modo PC/Editor)
// Aluno: Alanio Ferreira de Lima | Residencia em TIC 29

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Velocidade de Movimento")]
    public float velocidadeCaminhada = 3.0f;
    public float velocidadeCorrida   = 6.0f;

    [Header("Configuracoes de Camera")]
    [Range(0.5f, 5.0f)]
    public float sensibilidadeMouse = 2.0f;
    public float limiteVertical     = 80.0f;
    public Transform cameraTransform;

    private CharacterController _controller;
    private float _rotacaoVertical = 0f;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        if (cameraTransform == null)
            cameraTransform = Camera.main?.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible   = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible   = true;
        }
        MoverJogador();
        RotacionarCamera();
    }

    // Movimentacao WASD + Shift para correr
    private void MoverJogador()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float speed = Input.GetKey(KeyCode.LeftShift)
            ? velocidadeCorrida : velocidadeCaminhada;
        Vector3 dir = transform.right * h + transform.forward * v;
        dir.y = -2.0f;
        _controller.Move(dir * speed * Time.deltaTime);
    }

    // Rotacao da camera com o mouse
    private void RotacionarCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeMouse;
        _rotacaoVertical -= mouseY;
        _rotacaoVertical  = Mathf.Clamp(_rotacaoVertical, -limiteVertical, limiteVertical);
        cameraTransform.localRotation = Quaternion.Euler(_rotacaoVertical, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
