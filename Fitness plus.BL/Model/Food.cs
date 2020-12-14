using System;

namespace Fitness_plus.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get;  }
        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }
        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }
        /// <summary>
        /// Калории за 100 грамм
        /// </summary>
        public double Callories { get; }

        private double CalloriesOneGram { get { return Callories / 100.0; } }

        private double ProteinsOneGram { get { return Proteins / 100.0; } }

        private double FatsOneGram { get { return Fats / 100.0; } }

        private double CarbohydratesOneGram { get { return Carbohydrates / 100.0; } }

        public Food(string name):this(name, 0, 0, 0, 0){}

        public Food(string name , double callories , double proteins , double fats , double carbohydrates)
        {
            //TODO : проверка
            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
