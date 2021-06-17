namespace Pets.Models
{
    using System.Collections.Generic;
    using System;

    public class Animal
    {
        private readonly List<Feeding> feedings;

        public Animal()
        {
            feedings = new List<Feeding>();
        }

        public Animal(string name, AnimalType type, Breed breed, ref bool IsExist)
        {
            CheckAnimal(name, type, ref IsExist);
            Breed = breed;
        }

        public long Id { get; set; }

        public virtual AnimalType Type { get; set; }

        public virtual string Name { get; set; }

        public virtual Breed Breed { get;  set; }
        
        public IEnumerable<Feeding> Feedings
        {
            get { return feedings; }
        }

        public bool IsExist { get; protected set; }

        public void AddFeeding (Feeding feeding)
        {
            feedings.Add(feeding);
            
        }

        public void AddNewPet()
        {
            IsExist = true;
        }
        
        protected internal virtual void CheckAnimal(string name, AnimalType type, ref bool IsExist)
        {
            if (IsExist == true)
                throw new ArgumentException("Animal exist yet", nameof(name));
            Name = name;
            Type = type;
        } 

    }
}
