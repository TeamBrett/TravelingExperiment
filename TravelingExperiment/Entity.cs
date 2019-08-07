using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
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
            get { return id; }
            set
            {

                if (value > currentId)
                {
                    currentId = value + 1;
                }

                id = value;
            }
        }

        public abstract string Name { get; set; }
    }
}
