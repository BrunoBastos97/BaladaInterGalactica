﻿namespace BaladaIntergalactica.API.Entities
{
    public class ObjectNotAllowed
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ObjectNotAllowed(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
