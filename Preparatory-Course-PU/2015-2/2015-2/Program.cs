using System;

namespace _2015_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.WriteLine("Enter number of pets");
                n = int.Parse(Console.ReadLine());

            } while (n < 5 || n > 160);

            Pet[] pets = new Pet[n];
            Console.WriteLine("------------------------------------------------");
            InputData(pets);
            FirstSort(pets);
            Console.WriteLine("------------------------------------------------");
            Outputdata(pets);
            Console.WriteLine("------------------------------------------------");
            PrintPetsByOwnerName(pets);

        }
        public static void InputData(Pet[] pets)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                Pet pet = new Pet();

                Console.WriteLine("Enter name of pet");
                pet.NameOfPet = Console.ReadLine();

                Console.WriteLine("Enter type of pet");
                pet.Type = Console.ReadLine();

                Console.WriteLine("Enter age in months");
                pet.AgeInMonths = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter name of owner");
                pet.NameSurnameOfOwner = Console.ReadLine();

                pet.AgeYears = pet.AgeInMonths / 12;
                pet.AgeMonths = pet.AgeInMonths % 12;

                pet.OwnerSurname = pet.NameSurnameOfOwner.Substring(pet.NameSurnameOfOwner.IndexOf(' ') + 1);

                pets[i] = pet;
            }
        }
        public static void FirstSort(Pet[] pets)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                for (int j = 0; j < pets.Length; j++)
                {
                    if (pets[i].Type.CompareTo(pets[i].Type) > 0)
                    {
                        Pet temp = pets[i];
                        pets[i] = pets[j];
                        pets[j] = temp;
                    }
                    else if (pets[i].Type.CompareTo(pets[i].Type) == 0)
                    {
                        if (pets[i].AgeInMonths.CompareTo(pets[i].AgeInMonths) < 0)
                        {
                            Pet temp = pets[i];
                            pets[i] = pets[j];
                            pets[j] = temp;
                        }
                    }
                }
            }
        }
        public static void Outputdata(Pet[] pets)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine(pets[i].NameOfPet + ", "
                    + pets[i].Type + ", "
                    + pets[i].AgeYears + " г. и " 
                    + pets[i].AgeMonths +  " мес., "
                    + pets[i].NameSurnameOfOwner);
            }
        }
        public static void PrintPetsByOwnerName(Pet[] pets)
        {

            Console.WriteLine("Enter surname of owner");
            string nameOwner = Console.ReadLine();

            int counter = 0;
            int age = 0;
            int appAge = 0;
            int appAgeYears = 0;
            int appAgeMonths = 0;


            for (int i = 0; i < pets.Length; i++)
            {
                if (nameOwner == pets[i].OwnerSurname)
                {
                    age = age + pets[i].AgeInMonths;
                    counter++;
                    Console.WriteLine(pets[i].NameOfPet + ", "
                        + pets[i].Type);
                }

            }

            appAge = age / counter;
            appAgeYears = appAge / 12;
            appAgeMonths = appAge % 12;
            Console.Write("Average age: " + appAgeYears + " г. и " + appAgeMonths + " мес.");

        }
    }
}
