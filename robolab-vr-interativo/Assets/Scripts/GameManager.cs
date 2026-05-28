// GameManager.cs
// RoboLab VR | Gerenciador central da cena
// Aluno: Alanio Ferreira de Lima | Residencia em TIC 29
// Padrao Singleton -- uma unica instancia persiste entre cenas.

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Audio Ambiente do Laboratorio")]
    public AudioSource audioAmbiente;
    [Range(0f, 1f)]
    public float volumeAmbiente = 0.2f;

    private int _paineisVisitados = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (audioAmbiente != null)
        {
            audioAmbiente.volume = volumeAmbiente;
            audioAmbiente.loop   = true;
            audioAmbiente.Play();
        }
        Debug.Log("[GameManager] RoboLab VR iniciado com sucesso.");
    }

    // Registra visita a um painel -- chamado pelo InteracaoPlaca
    public void RegistrarPainelVisitado()
    {
        _paineisVisitados++;
        Debug.Log("[GameManager] Paineis visitados: " + _paineisVisitados);
    }

    public int TotalPaineisVisitados() => _paineisVisitados;

    public void SairAplicacao()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
