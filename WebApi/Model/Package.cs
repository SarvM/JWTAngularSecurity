using System;

namespace WebApi.Model
{
    public class Package 
    {
        public string Id { get; set;}       
        public string Name { get; set;}
        public string Mode { get; set;}
        public string Rate { get; set;}
        public string Description { get; set;}

        public Package(string id, string name, string mode, string rate, string description)
        {
            Id = id;
            Name = name;
            Mode = mode;
            Rate = rate;
            Description = description;
        }
    }
}