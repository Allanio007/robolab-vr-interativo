# RoboLab VR - Laboratorio Interativo de Robotica
### Web 3.0 | Residencia em TIC 29 | Prof. Ana Beatriz

**Aluno:** Alanio Ferreira de Lima
**GitHub:** github.com/Allanio007/robolab-vr-interativo

---

## Apresentando o Projeto

Laboratorio virtual imersivo no Metaverso onde o visitante interage com
componentes roboticos em escala digital. Ao se aproximar de qualquer
peca, um painel flutuante exibe nome, funcao e especificacoes tecnicas.

> NOTA: Instalacao do Unity pendente por limitacao de hardware
> (RAM e HD insuficientes). Scripts, estrutura e documentacao completos.

---

## Contexto e Objetivos

Resolve o alto custo de laboratorios fisicos de robotica: qualquer aluno
com Meta Quest pratica sem hardware real.
Contexto de Metaverso: educacional e industrial.

---

## Interacao Principal

Ao se aproximar de um componente (OnTriggerEnter), Canvas WorldSpace
aparece com nome, funcao e especificacoes do componente.
Ao se afastar (OnTriggerExit), o painel desaparece automaticamente.
Script implementado: InteracaoPlaca.cs

---

## Processo de Criacao e Dificuldades

Principal dificuldade: impossibilidade de instalar o Unity 6 (6000.0.13f1)
por limitacao de hardware (RAM, HD e ROM insuficientes).
Versoes superiores e inferiores tambem testadas sem sucesso.

Solucao: documentacao tecnica completa + scripts C# prontos para
execucao imediata apos disponibilidade do hardware adequado.

---

## Estrutura do Repositorio

Assets/Scripts/InteracaoPlaca.cs  -- interacao de proximidade
Assets/Scripts/PlayerMovement.cs  -- movimentacao WASD + mouse (PC)
Assets/Scripts/GameManager.cs     -- controle geral da cena
Packages/manifest.json            -- Meta XR SDK + XR Toolkit
docs/                             -- relatorio tecnico PDF
