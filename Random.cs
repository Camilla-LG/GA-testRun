

using System.ComponentModel.DataAnnotations;

namespace testRun
{
    internal class RandomHelper
    {  
        
        public static string HowToUseRandom()
        {
            string[] hobbies = { "tennisspiller", "dartspiller", "footballspiller", "rallysjåfør", "artist" };

            Random rand = new Random();
            int index = rand.Next(0, hobbies.Length);
            int randomIndex = Convert.ToInt32(index);
            string randomHobby = hobbies[randomIndex];
            return randomHobby;
        }

    }
}
