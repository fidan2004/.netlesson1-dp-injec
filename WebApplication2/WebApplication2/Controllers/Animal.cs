namespace WebApplication2.Controllers
{
    public class Animal:IAnimal
    {
        public string GetAnimal()
        {
            return "Aslan";
        }
    }
    public interface IAnimal
    {
        string GetAnimal();
    }
}
