using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Modelo;

namespace test.auth
{
    public class ApplicationIdentityPersonaManager : UserManager<CusPersona>
    {
        public ApplicationIdentityPersonaManager(IUserStore<CusPersona> store,
            IOptions<IdentityOptions> optionsAccesor,
            IPasswordHasher<CusPersona> passwordHasher,
            IEnumerable<IUserValidator<CusPersona>>  userValidators,
            IEnumerable<IPasswordValidator<CusPersona>> passwordValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors,
            IServiceProvider services,
            ILogger<UserManager<CusPersona>> logger
            ) : base(store, optionsAccesor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        { }


        public override async Task<IdentityResult> CreateAsync(CusPersona user, string password)
        {
            return await base.CreateAsync(user, password);
        }
    }
}
