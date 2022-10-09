using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class Narsir : MonoBehaviour
{
    public string urlJson = "?format=json";
    private string urls = "https://swapi.dev/api/";
    public TMP_Text text;
    public datas detass;

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            detass.Reset();
        UIs();
    }

    private void UIs()
    {
        deta data = (deta)detass.data;
        text.text = $"people: {data.people}\n" +
            $"planets: {data.planets}\n" +
            $"films: {data.films}\n" +
            $"species: {data.species}\n" +
            $"vehicles: {data.vehicles}\n" +
            $"starships: {data.starships}\n"+"" +
            "\n\n Full v deita";
    }

    public void Nors()
    {
        StartCoroutine(GetNars(urls,-1));
    }

    private IEnumerator GetNars(string url,int id)
    {
        url += urlJson;
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            string[] pages = url.Split();
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:

                    string text = webRequest.downloadHandler.text;
                    switch (id)
                    {
                        case -1:
                            deta dete = JsonUtility.FromJson<deta>(text);
                            detass.data = dete;  // вкурсе што путениса в перемених (простите)
                            StartCoroutine(GetNars(dete.people, 1));
                            StartCoroutine(GetNars(dete.planets, 2));
                            StartCoroutine(GetNars(dete.films, 3));
                            StartCoroutine(GetNars(dete.species, 4));
                            StartCoroutine(GetNars(dete.vehicles, 5));
                            StartCoroutine(GetNars(dete.starships, 6));
                            UIs();
                            break;
                        case 1:
                            detass.data.peopleDeita = JsonUtility.FromJson<peopleDeta>(text);
                            break;
                        case 2:
                            detass.data.planetsDeita = JsonUtility.FromJson<planetsDeta>(text);
                            break;
                        case 3:
                            detass.data.filmsDeita = JsonUtility.FromJson<filmsDeta>(text);
                            break;
                        case 4:
                            detass.data.speciesDeita = JsonUtility.FromJson<speciesDeta>(text);
                            break;
                        case 5:
                            detass.data.vehiclesDeita = JsonUtility.FromJson<vehiclesDeta>(text);
                            break;
                        case 6:
                            detass.data.starshipsDeita = JsonUtility.FromJson<starshipsDeta>(text);
                            break;
                    }
                    
                    break;
            }
        }
    }
}

[System.Serializable]
public struct deta// структура jsona
{
    public string people;
    public string planets;
    public string films;
    public string species;
    public string vehicles;
    public string starships;

    public peopleDeta peopleDeita;
    public planetsDeta planetsDeita;
    public filmsDeta filmsDeita;
    public speciesDeta speciesDeita;
    public vehiclesDeta vehiclesDeita;
    public starshipsDeta starshipsDeita;
}
