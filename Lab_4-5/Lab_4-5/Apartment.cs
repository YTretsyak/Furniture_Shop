using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab_4_5
{
    class Apartment : Accommodation, IDeSerealization<Apartment>
    {
        [JsonConstructorAttribute]
        public Apartment(int apartmentArea, int numberOfRooms, string availability, string material, int floor, int yearOfConstruction, Address address)
        {
            Area = apartmentArea;
            NumberOfRooms = numberOfRooms;
            Availability = availability;
            Material = material;
            Floor = floor;
            YearOfConstruction = yearOfConstruction;
            Address = address;
        }
        public Apartment()
        {

        }
        public override Accommodation clone()
        {
            if (Address != null)
                return new Apartment(Area, NumberOfRooms, Availability, Material, Floor, YearOfConstruction, new Address(this.Address.Country, this.Address.City, this.Address.City, this.Address.House, this.Address.ApartmentNumber));
            else return new Apartment(Area, NumberOfRooms, Availability, Material, Floor, YearOfConstruction, null);
        }
        public override string ToString()
        {   
            return "APPARTMENT\n" + "Apartment area: " + Area + "; Number of rooms: " + NumberOfRooms + "; Availability: " + Availability + "; Material: " + Material + "; Floor: " + Floor + "; Year of construction: " + YearOfConstruction + '\n' + Address ;
        }
        public List<Apartment> Deserializing(string path)
        {
            string strings = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Apartment>>(strings);
        }
        public void Serializing(Apartment apartment, string path)//path = path+filename
        {
            List<Apartment> apartments = new List<Apartment>();
            string json;
            string strings = File.ReadAllText(path);
            List<Apartment> listFromFile = JsonConvert.DeserializeObject<List<Apartment>>(strings);
            if (listFromFile == null)
                apartments.Add(apartment);
            else
            {
                foreach (Apartment item in listFromFile)
                    apartments.Add(item);
                apartments.Add(apartment);
            }
            json = JsonConvert.SerializeObject(apartments);
            using (StreamWriter fs = new StreamWriter(path, false))
            {
                fs.Write(json);
            }
        }
    }
}
