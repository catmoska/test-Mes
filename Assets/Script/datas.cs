using UnityEngine;

[CreateAssetMenu(fileName = "neim", menuName = "g")]
public class datas : ScriptableObject
{
    public deta data;  // тут мозна била зделать deta? но я хотел селоризовать переменую

    public void Reset()
    {
        data.people = null; // тогда тут била тотлка одна строчка data = null;
        data.planets = null;
        data.films = null;
        data.species = null; 
        data.vehicles = null;
        data.starships = null;
    }
}
