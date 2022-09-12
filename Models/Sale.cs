using System.ComponentModel.DataAnnotations;

namespace Act2MVC.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int? numSales { get; set; }
        public int? amtSales { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}

//dotnet-aspnet-codegenerator controller -name SalesController -m Sale -dc SalesContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite