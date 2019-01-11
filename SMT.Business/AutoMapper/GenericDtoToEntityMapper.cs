using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace SMT.Business.AutoMapper
{
    class GenericDtoToEntityMapper : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDtoToEntityMapper"/> class.
        /// </summary>
        public GenericDtoToEntityMapper()
        {
        }

        /// <summary>
        /// Gets the name of the profile.
        /// </summary>
        /// <value>The name of the profile.</value>
        public override string ProfileName
        {
            get { return this.GetType().Name; }
        }

        ///// <summary>
        ///// Override this method in a derived class and call the CreateMap method to associate that map with this profile.
        ///// Avoid calling the <see cref="T:AutoMapper.Mapper" /> class from this method.
        ///// </summary>
        //protected override void Configure()
        //{
            
        //}
    }
}
