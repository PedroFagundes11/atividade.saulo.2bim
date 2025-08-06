using UnityEngine;
using UnityEngine.SceneManagement;

public class Carregarcena : MonoBehaviour
{
    public string NomeDaCena;

    public void Carregar()
    {
    SceneManager.LoadScene(NomeDaCena);
    }
}
