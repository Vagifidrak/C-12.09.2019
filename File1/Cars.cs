using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File1
{
    class Cars
    {
        public string marka;
        public string model;
        public double currentFuel;
        public double maxFuel;
        public double useFuel;
        public Cars(string marka, string model, double maxFuel, double useFuel, double currentFuel = 35)
        {
            this.marka = marka;
            this.model = model;
            this.maxFuel = maxFuel;
            this.useFuel = useFuel;
            this.currentFuel = currentFuel;
          
        }
        public void TopUp()
        {
            Console.WriteLine("Ne qeder benzin vurum???");
            string addFuel = Console.ReadLine();
            
            if (addFuel == "fuel")
            {
                currentFuel += maxFuel - currentFuel;
                Console.WriteLine("Tam Yanacaq doldurdunuz. Hal hazirda {0} litr benzim var", currentFuel);
            }
            else
            {
                double addedFuel = Convert.ToDouble(addFuel);

                if (maxFuel < addedFuel + currentFuel)
                {

                    Console.WriteLine("Yanacaq bakiniz kifayet etmir");
                }
                else
                {
                    currentFuel += addedFuel;
                    Console.WriteLine("Yanacaq bakiniza {0} litr elave edildi. Pulu veriniz. Hal hazirda {1} litr yanacaq var", addedFuel, currentFuel);
                }
            }
            
        }
        public void Go()
        {double ndKm = 0;
        while (ndKm == 0)
        {
            Console.WriteLine("Nece Km getmek isteyirsiz?");
            string neededkm = Console.ReadLine();
           
            if(CheckInput(neededkm))
            {
                    ndKm = Convert.ToDouble(neededkm);
                    if (currentFuel > ndKm / 100 * useFuel)
                    {
                        currentFuel -= ndKm / 100 * useFuel;
                        Console.WriteLine("Siz {0} km getdiniz, masinda {1} litr benzin qaldi", ndKm, currentFuel);
                    }
                    else
                    {
                        Console.WriteLine("Benzin kifayet etmir, benzin vurun.");
                    }
                }
            }
        }
        

        public bool CheckInput(string input)
        {
            try
            {
                Convert.ToDouble(input);
                return true;
            }
            catch(Exception)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin");
                return false;
            }
        }
    }
}
