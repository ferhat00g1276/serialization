using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarGallery
{
    public CarGallery(string name, List<Car> cars)
    {
        Name = name;
        Cars = cars;
    }

    public string Name { get; set; }
    public List<Car> Cars { get; set; }

}
