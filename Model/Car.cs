using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace serializationCarGallery.Model
{
    internal class Car
    {
    }
}
*/
public class Car
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Year { get; set; }

    public override string ToString()
    => $"{Marka}-{Model}-{Year}";
}