using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    class ApartmentWithoutAddressFactory : IAccommodationFactory
    {
        public Accommodation CreateAccommodation(Form1 form)
        {

            ApartmentBuilder apartmentBuilder = new ApartmentBuilder();
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

            return apartmentBuilder.GetResult();
        }
        public void ThrowExc(string mes)
        {
            throw new ArgumentException(mes);
        }
    }
}
