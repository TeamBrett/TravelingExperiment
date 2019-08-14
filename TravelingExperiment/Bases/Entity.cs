using System;

namespace CelestialTravels0_1.Bases
{
    public abstract class Entity
    {
        private static int currentId = 0;

        private int id;

        protected Entity()
        {
            this.Id = currentId++;
        }

        public int Id
        {
            get { return this.id; }

            set
            {
                if (value > currentId)
                {
                    currentId = value + 1;
                }

                this.id = value;
            }
        }

        public abstract string Name { get; set; }
    }
}
