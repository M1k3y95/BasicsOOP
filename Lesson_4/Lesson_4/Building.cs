using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson_4
{
    class Creator
    {
        public static Hashtable buildingList = new();


        private Creator() {}

        public static void CreateBuild()
        {
            Building newBuilding = new();

            buildingList.Add(newBuilding.BuildingNumber, newBuilding);

        }

        public static void CreateBuild(int height)
        {
            Building newBuilding = new Building(height);

            buildingList.Add(newBuilding.BuildingNumber, newBuilding);
        }

        public static void CreateBuild(int height, int floorAmount)
        {
            Building newBuilding = new Building(height, floorAmount);

            buildingList.Add(newBuilding.BuildingNumber, newBuilding);
        }

        public static void CreateBuild(int height, int floorAmount, int apartmensAmount)
        {
            Building newBuilding = new Building(height, floorAmount, apartmensAmount);

            buildingList.Add(newBuilding.BuildingNumber, newBuilding);
        }

        public static void CreateBuild(int height, int floorAmount, int apartmensAmount, int entranceAmount)
        {
            Building newBuilding = new Building(height, floorAmount, apartmensAmount, entranceAmount);

            buildingList.Add(newBuilding.BuildingNumber, newBuilding);
        }

        public static void PrintList()
        {
            foreach (DictionaryEntry building in buildingList)
            {
                Building build = (Building)building.Value;
                Console.WriteLine($"{build.BuildingNumber}.     Квартир: {build.BuildingApartmensAmount}");
            }
        }

        public static void RemoveBuild(int number)
        {
            try
            {
                buildingList.Remove(number);
            }
            catch (Exception)
            {

                Console.WriteLine("Указанный номер отсутствует в списке");
            }
        }

        private class Building
        {
            static int buildingNumberCount = 1;


            public int BuildingNumber { get; }

            public int BuildingHeight { get; set; }

            public int BuildingFloorAmount { get; set; }

            public int BuildingApartmensAmount { get; set; }

            public int BuildingEntranceAmount { get; set; }


            public Building()
            {
                BuildingNumber = buildingNumberCount++; // постфиксный инкремент повысит значение поля после присвоения
            }

            public Building(int height)
                : this()
            {
                BuildingHeight = height;
            }

            public Building(int height, int floorAmount)
                : this(height)
            {
                BuildingFloorAmount = floorAmount;
            }

            public Building(int height, int floorAmount, int apartmensAmount)
                : this(height, floorAmount)
            {
                BuildingApartmensAmount = apartmensAmount;
            }

            public Building(int height, int floorAmount, int apartmensAmount, int entranceAmount)
                : this(height, floorAmount, apartmensAmount)
            {
                BuildingEntranceAmount = entranceAmount;
            }


            public int CalculateFloorHeight()
            {
                return BuildingHeight / BuildingFloorAmount;
            }

            public int CalculateApartmens_Floor()
            {
                return BuildingApartmensAmount / BuildingFloorAmount;
            }

            public int CalculateApartmens_Entrance()
            {
                return BuildingApartmensAmount / BuildingFloorAmount;
            }
        }
    }

    
}
