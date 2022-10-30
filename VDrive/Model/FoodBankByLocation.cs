namespace VDrive.Model
{
    public class Rootobject
    {
        public Foodbank[] Property1 { get; set; }
    }

    public class Foodbank
    {
        public string name { get; set; }
        public object alt_name { get; set; }
        public string slug { get; set; }
        public string phone { get; set; }
        public string secondary_phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public string lat_lng { get; set; }
        public int distance_m { get; set; }
        public float distance_mi { get; set; }
        public Needs needs { get; set; }
        public Urls urls { get; set; }
        public Charity charity { get; set; }
        public Politics politics { get; set; }
    }

    public class Needs
    {
        public string id { get; set; }
        public string needs { get; set; }
        public DateTime found { get; set; }
        public int number { get; set; }
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
        public int mp_parl_id { get; set; }
        public string ward { get; set; }
        public string district { get; set; }
        public Urls1 urls { get; set; }
    }

    public class Urls1
    {
        public string self { get; set; }
        public string html { get; set; }
    }
}