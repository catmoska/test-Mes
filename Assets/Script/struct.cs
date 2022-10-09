
[System.Serializable]
public struct peopleDeta
{
    public int count;
    public string next;
    public string previous;
    public peopleDeta2[] results;
}

[System.Serializable]
public struct peopleDeta2
{
    public string name;
    public string height;
    public string mass;
    public string hair_color;
    public string skin_color;
    public string eye_color;
    public string birth_year;
    public string gender;
    public string homeworld;
    public string[] films;
    public string[] species;
    public string[] vehicles;
    public string[] starships;
    public string created;
    public string edited;
    public string url;
}


//
[System.Serializable]
public struct planetsDeta
{
    public int count;
    public string next;
    public string previous;
    public planetsDeta2[] results;
}

[System.Serializable]
public struct planetsDeta2
{
    public string name;
    public string rotation_period;
    public string orbital_period;
    public string diameter;
    public string climate;
    public string gravity;
    public string terrain;
    public string surface_water;
    public string population;
    public string[] residents;
    public string[] films;
    public string created;
    public string edited;
    public string url;
}

//
[System.Serializable]
public struct filmsDeta
{
    public int count;
    public string next;
    public string previous;
    public filmsDeta2[] results;
}

[System.Serializable]
public struct filmsDeta2
{
    public string title;
    public string episode_id;
    public string opening_crawl;
    public string director;
    public string producer;
    public string release_date;
    public string[] characters;
    public string[] planets;
    public string[] starships;
    public string[] vehicles;
    public string[] species;
    public string created;
    public string edited;
    public string url;
}



//
[System.Serializable]
public struct speciesDeta
{
    public int count;
    public string next;
    public string previous;
    public speciesDeta2[] results;
}

[System.Serializable]
public struct speciesDeta2
{
    public string name;
    public string classification;
    public string designation;
    public string average_height;
    public string skin_colors;
    public string hair_colors;
    public string eye_colors;
    public string average_lifespan;
    public string homeworld;
    public string language;
    public string[] people;
    public string[] films;
    public string created;
    public string edited;
    public string url;
}



//
[System.Serializable]
public struct vehiclesDeta
{
    public int count;
    public string next;
    public string previous;
    public vehiclesDeta2[] results;
}

[System.Serializable]
public struct vehiclesDeta2
{
    public string name;
    public string model;
    public string manufacturer;
    public string cost_in_credits;
    public string length;
    public string max_atmosphering_speed;
    public string crew;
    public string passengers;
    public string cargo_capacity;
    public string consumables;
    public string vehicle_class;
    public string[] pilots;
    public string[] films;
    public string created;
    public string edited;
    public string url;
}



//
[System.Serializable]
public struct starshipsDeta
{
    public int count;
    public string next;
    public string previous;
    public starshipsDeta2[] results;
}

[System.Serializable]
public struct starshipsDeta2
{
    public string name;
    public string model;
    public string manufacturer;
    public string cost_in_credits;
    public string length;
    public string max_atmosphering_speed;
    public string crew;
    public string passengers;
    public string cargo_capacity;
    public string consumables;
    public string hyperdrive_rating;
    public string MGLT;
    public string starship_class;
    public string[] pilots;
    public string[] films;
    public string created;
    public string edited;
    public string url;
}
