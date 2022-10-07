   
struct  Weather
{

   public string Country { get; set; }
    public string Name { get; set; }
    public double Temp { get; set; }
   public  string Description { get; set; }

    public Weather(string Country,string Name, double Temp, string Description )
    {
        this.Country = Country;
        this.Name = Name;
        this.Temp = Temp;
        this.Description = Description;

    } 

}

class MainProgram
{

    public static void Main()

    {
        var Collection = new List<Weather>
    {

           
        new Weather() { Country = "RU", Name = "Aykhal", Temp = 261.85, Description = "clear sky" },

        new Weather() { Country = "US", Name = "Teton", Temp = 289.77, Description = "clear sky" },

        new Weather() { Country = "ID", Name = "Bonjol", Temp = 293.79, Description = "few clouds" },

        new Weather() { Country = "ID", Name = "Padangsidempuan", Temp = 295.42, Description = "overcast clouds" },

        new Weather() { Country = "TH", Name = "Thailand", Temp = 297.12, Description = "overcast clouds" },

        new Weather() { Country = "VN", Name = "Quang Ngai", Temp = 301.23, Description = "scattered clouds" },

        new Weather() { Country = "CN", Name = "Sanya", Temp = 301.26, Description = "broken clouds" },

        new Weather() { Country = "CN", Name = "Xincun", Temp = 301.16, Description = "moderate rain" },

        new Weather() { Country = "ME", Name = "Berane", Temp = 278.27, Description = "overcast clouds" },

        new Weather() { Country = "RS", Name = "Kosjerić", Temp = 281.83, Description = "overcast clouds" },

        new Weather() { Country = "RS", Name = "Central Serbia", Temp = 279.18, Description = "overcast clouds" },

        new Weather() { Country = "RO", Name = "Bozovici", Temp = 278.54, Description = "clear sky" },

        new Weather() { Country = "NO", Name = "Finnmark", Temp = 277.14, Description = "broken clouds" },

        new Weather() { Country = "RU", Name = "Maksim", Temp = 279.3, Description = "light rain" },

        new Weather() { Country = "RU", Name = "Vuktyl", Temp = 277.81, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Saranpaul", Temp = 277.53, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Varnek", Temp = 277.14, Description = "overcast clouds" },

        new Weather() { Country = "NA", Name = "Omaheke", Temp = 296.32, Description = "scattered clouds" },

        new Weather() { Country = "BW", Name = "Ghanzi District", Temp = 296.74, Description = "clear sky" },

        new Weather() { Country = "BW", Name = "Khemsbok", Temp = 296.55, Description = "clear sky" },

        new Weather() { Country = "BW", Name = "Botswana", Temp = 298.24, Description = "clear sky" },

        new Weather() { Country = "RU", Name = "Talnakh", Temp = 268.14, Description = "overcast clouds" },

        new Weather() { Country = "CA", Name = "Mill Bay", Temp = 294.02, Description = "clear sky" },

        new Weather() { Country = "US", Name = "Lompoc", Temp = 290.36, Description = "clear sky" },

        new Weather() { Country = "US", Name = "Isla Vista", Temp = 292.17, Description = "few clouds" },

        new Weather() { Country = "RU", Name = "Nagornaya", Temp = 279.67, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Kerchevskiy", Temp = 279.5, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Troitsko-Pechorsk", Temp = 279.26, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Nyrob", Temp = 266.02, Description = "overcast clouds" },

        new Weather() { Country = "CN", Name = "Xitumenzi", Temp = 278.22, Description = "broken clouds" },

        new Weather() { Country = "KP", Name = "Ungsang-nodongjagu", Temp = 284.93, Description = "overcast clouds" },

        new Weather() { Country = "RO", Name = "Bata", Temp = 283.68, Description = "light rain" },

        new Weather() { Country = "RO", Name = "Oșorhei", Temp = 284.91, Description = "light rain" },

        new Weather() { Country = "HU", Name = "Újtanya", Temp = 284.86, Description = "light rain" },

        new Weather() { Country = "SK", Name = "Kamenica nad Cirochou", Temp = 282.26, Description = "overcast clouds" },

        new Weather() { Country = "PL", Name = "Stoczek Łukowski", Temp = 282.63, Description = "clear sky" },

        new Weather() { Country = "BY", Name = "Gusak", Temp = 282.93, Description = "few clouds" },

        new Weather() { Country = "LT", Name = "Druskininkai", Temp = 282.25, Description = "clear sky" },

        new Weather() { Country = "LT", Name = "Širvintos", Temp = 282.67, Description = "broken clouds" },

        new Weather() { Country = "LT", Name = "Pabradė", Temp = 284.51, Description = "broken clouds" },

        new Weather() { Country = "LV", Name = "Jaunpiebalga", Temp = 284.33, Description = "broken clouds" },

        new Weather() { Country = "EE", Name = "Vihula Parish", Temp = 283.96, Description = "few clouds" },

        new Weather() { Country = "PL", Name = "Dzierzkowice", Temp = 282.22, Description = "few clouds" },

        new Weather() { Country = "KP", Name = "Hoemul-li", Temp = 285.26, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Berdigestyakh", Temp = 264.79, Description = "overcast clouds" },

        new Weather() { Country = "RU", Name = "Magan", Temp = 267.74, Description = "overcast clouds" },

        new Weather() { Country = "SB", Name = "Nele", Temp = 301.07, Description = "overcast clouds" },

        new Weather() { Country = "MW", Name = "Mzimba", Temp = 293.99, Description = "clear sky" },

        new Weather() { Country = "ZM", Name = "Ngwata", Temp = 293.47, Description = "clear sky" },

        new Weather() { Country = "MX", Name = "Santa María Ajoloapan", Temp = 290.83, Description = "overcast clouds" },

        new Weather() { Country = "CN", Name = "Qiaotou", Temp = 299.27, Description = "few clouds" } 

    };

        // вывод коллекции на экран 
       /* foreach (Weather weather in Collection)
        {
            Console.WriteLine("Название страны:  " + weather.Country + " | "
                + " Название региона:  " + weather.Name + " | "
                + " Температура в Кельвинах:  " 
                + weather.Temp  + " | " + " Погодные условия:  " + weather.Description);
        } */


        var max = Collection.Max(w => w.Temp); // ищем максимальную температуру 
        Console.Write("Максимальная температура: " + max + " " ) ;
        
         var High = from w in Collection // выводим эту старну и название региона 
                    where w.Temp == max 
                    select w;
         foreach (var w  in High)
         {
             Console.WriteLine(w.Country + " " + w.Name);
         }

        var min = Collection.Min(w => w.Temp);
        Console.Write("Минимальная температура: " + min + " ");

        var Less = from w in Collection
                   where w.Temp == min
                   select w;
        foreach (var w in Less)
        {
            Console.WriteLine(w.Country + " " + w.Name);
        }



        // кол-во всех стран в коллекции 
        int c = (from w in Collection
                 select w.Country).Count();
        Console.WriteLine("Кол-во стран: " + c);

        // средняя температура в мире 
         var sum = Collection.Sum(w => w.Temp);
        Console.WriteLine("Средняя температура: " + sum/c);


        //Первая найденная страна и название местности, в которых Description принимает значение: "clear sky","rain","few clouds"

        var x = from w in Collection.Take(1)
               where w.Description == "clear sky" || w.Description == "rain" || w.Description == "few clouds"
                 select w;

       foreach (var w in x)
       {
           Console.WriteLine("Первая найденная страна в которой погодные условия \"clear sky\",\"rain\",\"few clouds\" : " + w.Country + " " + w.Name);
       }
    }
}