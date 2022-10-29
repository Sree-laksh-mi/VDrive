namespace VDrive.Model
{
    public class FoodBanks
    {
        public string name { get; set; }
        public object alt_name { get; set; }
        public string slug { get; set; }
        public string phone { get; set; }
        public object secondary_phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public bool closed { get; set; }
        public string lat_lng { get; set; }
        public string network { get; set; }
        public DateTime created { get; set; }
        public Urls urls { get; set; }
        public Charity charity { get; set; }
        public object[] locations { get; set; }
        public Politics politics { get; set; }
        public Need need { get; set; }
        public Nearby_Foodbanks[] nearby_foodbanks { get; set; }
    }
}

public class Urls
{
    public string self { get; set; }
    public string html { get; set; }
    public string homepage { get; set; }
    public string shopping_list { get; set; }
    public string map { get; set; }
}

public class Charity
{
    public string registration_id { get; set; }
    public string register_url { get; set; }
}

public class Politics
{
    public string parliamentary_constituency { get; set; }
    public string mp { get; set; }
    public string mp_party { get; set; }
    public string ward { get; set; }
    public string district { get; set; }
    public Urls1 urls { get; set; }
}

public class Urls1
{
    public string self { get; set; }
    public string html { get; set; }
}

public class Need
{
    public string id { get; set; }
    public string needs { get; set; }
    public DateTime created { get; set; }
    public string self { get; set; }
}

public class Nearby_Foodbanks
{
    public string name { get; set; }
    public string slug { get; set; }
    public Urls2 urls { get; set; }
    public string address { get; set; }
    public string lat_lng { get; set; }
}

public class Urls2
{
    public string self { get; set; }
    public string html { get; set; }
    public string homepage { get; set; }
    public string shopping_list { get; set; }
}
