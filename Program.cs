namespace GenericAnimalClass
{
    public class Animal < T>
    {
        public T data;

        public Animal(T data)
        {
            this.data = data;
        }
        public T getAnimal()
        {
            Console.WriteLine("Data Passed: " + data);
            return data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Cow");
            Animal<string> animalHabitat = new Animal<string>("Farm");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(20);

            animalName.getAnimal();
            animalHabitat.getAnimal();
            endangered.getAnimal();
            extinct.getAnimal();
            averageLifespan.getAnimal();
        }
    }
}
