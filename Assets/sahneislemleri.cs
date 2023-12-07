using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneislemleri : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(0);
        SceneManager.sceneLoaded += SahneYuklendimi;
        SceneManager.sceneUnloaded += SahneKaldirildimi;
        

        //SceneManager.LoadScene("Sahnem", LoadSceneMode.Additive);
        //SceneManager.LoadScene(2);

        /*Scene scene = SceneManager.GetSceneByName("Sahnem 2");
        Debug.Log("sahne index'im : " + scene.buildIndex);*/

        /*Scene scene = SceneManager.GetSceneByBuildIndex(0);
        Debug.Log("aktif sahne adı : " + scene.name);*/

        /*Scene scene = SceneManager.GetSceneAt(0);
        Debug.Log("sahne adın : " + scene.name);
        Debug.Log(scene.isLoaded ? "yüklendi" : "yüklenmedi"); //if else gibi düşün. Tek satır sorgu.
        Debug.Log(scene.buildIndex);*/

        /*Scene scene = SceneManager.GetActiveScene(); //aktif sahneyi scene değişkenine verir.
        Debug.Log("Aktif sahnenin adı : " + scene.name);*/

        //Debug.Log(SceneManager.sceneCountInBuildSettings);
        //Debug.Log(SceneManager.sceneCount); //aktif sahne sayısı.
    }

    void SahneYuklendimi(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("yüklenen sahnem : " + scene.name);
    }
    void SahneKaldirildimi(Scene scene)
    {
        Debug.Log("kaldirilan sahnem : " + scene.name);
    }
}
