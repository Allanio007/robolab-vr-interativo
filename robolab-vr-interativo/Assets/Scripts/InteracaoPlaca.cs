// InteracaoPlaca.cs
// RoboLab VR - Laboratorio Interativo de Robotica
// Aluno: Alanio Ferreira de Lima | Residencia em TIC 29
//
// Ativa painel de informacoes ao se aproximar de um componente robotico.
// Interacao por proximidade (OnTriggerEnter / OnTriggerExit).
// Nao requer botao -- funciona automaticamente ao se aproximar.

using UnityEngine;
using TMPro;

public class InteracaoPlaca : MonoBehaviour
{
    [Header("Dados do Componente")]
    public string nomeComponente   = "Braco Robotico Industrial";
    public string funcaoComponente = "Movimentacao de pecas na linha de montagem";
    public string especificacoes   = "6 DOF | Carga: 10kg | Alcance: 1.3m";

    [Header("Referencias UI")]
    public GameObject painelInfo;   // Canvas WorldSpace
    public TextMeshPro textoNome;
    public TextMeshPro textoFuncao;
    public TextMeshPro textoEspec;

    [Header("Feedback Sonoro")]
    public AudioSource audioSource;
    public AudioClip   somAtivacao;

    // Inicializa os textos e oculta o painel
    private void Start()
    {
        if (textoNome)   textoNome.text   = nomeComponente;
        if (textoFuncao) textoFuncao.text = funcaoComponente;
        if (textoEspec)  textoEspec.text  = especificacoes;
        if (painelInfo)  painelInfo.SetActive(false);
    }

    // Ativa o painel quando o jogador se aproxima
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (painelInfo) painelInfo.SetActive(true);
        if (audioSource && somAtivacao)
            audioSource.PlayOneShot(somAtivacao);
        Debug.Log("[InteracaoPlaca] Ativado: " + nomeComponente);
    }

    // Desativa o painel quando o jogador se afasta
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (painelInfo) painelInfo.SetActive(false);
    }
}
