using AutoMapper;

namespace SMT.Business.AutoMapper
{
    public sealed class GenericAutoMapperConfiguration
    {
        /// <summary>The synchronize root.</summary>
        private static readonly object SyncRoot = new object();

        /// <summary>Gets the instance.</summary>
        /// <value>The instance.</value>
        private static volatile GenericAutoMapperConfiguration instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="GenericAutoMapperConfiguration"/> class from being created.
        /// </summary>
        private GenericAutoMapperConfiguration()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<GenericDtoToEntityMapper>();
            });
        }

        /// <summary>Gets the instance.</summary>
        /// <value>The instance.</value>
        public static GenericAutoMapperConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new GenericAutoMapperConfiguration();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Initialize class level variables here.
        /// </summary>
        public void Initialize()
        {
            // Initialize class level variables here
        }
    }
}
