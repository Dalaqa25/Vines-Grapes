
namespace api.Models
{
    public class GrapesModel
    {
        public int Id {get; set;}
        public string Name {get;set;} = string.Empty;
        public DateTime CreatedOn {get; set;} = DateTime.Now;
        public string Description {get;set;} = string.Empty;
    }

}