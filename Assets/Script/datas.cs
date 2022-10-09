using UnityEngine;

[CreateAssetMenu(fileName = "neim", menuName = "g")]
public class datas : ScriptableObject
{
    public deta data;  // ��� ����� ���� ������� deta? �� � ����� ������������ ���������

    public void Reset()
    {
        data.people = null; // ����� ��� ���� ������ ���� ������� data = null;
        data.planets = null;
        data.films = null;
        data.species = null; 
        data.vehicles = null;
        data.starships = null;
    }
}
