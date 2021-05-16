using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_5
{
    class ApartmentWithAddressFactory : IAccommodationFactory
    {
        public Accommodation CreateAccommodation(Form1 form)
        {

            ApartmentBuilder apartmentBuilder = new ApartmentBuilder();
            AddressBuilder addressBuilder = new AddressBuilder();
            apartmentBuilder.Reset();
            apartmentBuilder.SetArea(Convert.ToInt32(form.apartmentArea_numeric.Value));
            apartmentBuilder.SetNumberOfRooms(Convert.ToInt32(form.numberOfRooms_numeric.Value));
            if (form.availability_checkedLB.CheckedItems.Count > 0)
            {
                string Availability = "";
                foreach (string s in form.availability_checkedLB.CheckedItems)
                {
                    Availability += s + " ";
                }
                Availability = Availability.Remove(Availability.Length - 1);
                apartmentBuilder.SetAvailability(Availability);
            }
            if (form.materialBrick_RB.Checked || form.materialMonolith_RB.Checked)
                if (form.materialBrick_RB.Checked) apartmentBuilder.SetMaterial("Brick");
                else apartmentBuilder.SetMaterial("Monolith");
            else ThrowExc("All fields must be filled");
            apartmentBuilder.SetFloor(Convert.ToInt32(form.trackbar_lbl.Text));
            apartmentBuilder.SetYearOfConstruction(Convert.ToInt32(form.yearOfConstruction_DTP.Text));
            //
            if (form.country_CB.Text == "" || form.city_TB.Text == "" || form.street_TB.Text == "")
                ThrowExc("All fields must be filled");
            if (form.city_TB.Text.Any(char.IsDigit) || form.street_TB.Text.Any(char.IsDigit))
               throw new ArgumentException("City or street must not contain a digit");
            addressBuilder.SetCountry(form.country_CB.Text);
            addressBuilder.SetCity(form.city_TB.Text);
            addressBuilder.SetStreet(form.street_TB.Text);
            addressBuilder.SetHouse(Convert.ToInt32(form.house_numeric.Text));
            addressBuilder.SetApartmentNumber(Convert.ToInt32(form.apartmentNumber_numeric.Text));
            apartmentBuilder.SetAddress(addressBuilder.GetResult());

            return apartmentBuilder.GetResult();
        }
        public void ThrowExc(string mes)
        {
            throw new ArgumentException(mes);
        }
    }
}
