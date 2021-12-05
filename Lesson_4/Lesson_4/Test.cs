using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Test
    {
        public Test(int buildingsAmount)
        {
            CreateSomeBuilding(buildingsAmount);
        }

        private void CreateSomeBuilding(int buildingsAmount)
        {
            for (int i = 0; i < buildingsAmount; i++)
            {
                Creator.CreateBuild((i + 1) * 7, i + 1, (i + 1) * 3, i + 1);
            }
        }

        public void RemoveSomeBuilding(int buildingNumber)
        {
            Creator.RemoveBuild(buildingNumber);
        }
    }
}
