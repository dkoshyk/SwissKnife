﻿using MediatR;
using System.Runtime.Serialization;

namespace SwissKnife.API.Application.Commands
{
    // DDD and CQRS patterns comment: Note that it is recommended to implement immutable Commands
    // In this case, its immutability is achieved by having all the setters as private
    // plus only being able to update the data just once, when creating the object through its constructor.
    // References on Immutable Commands:  
    // http://cqrs.nu/Faq
    // https://docs.spine3.org/motivation/immutability.html 
    // http://blog.gauffin.org/2012/06/griffin-container-introducing-command-support/
    // https://msdn.microsoft.com/en-us/library/bb383979.aspx


    [DataContract]
    public class CreateProductCommand : IRequest<bool>
    {
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public string Description { get; private set; }

        public CreateProductCommand() { }

        public CreateProductCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
