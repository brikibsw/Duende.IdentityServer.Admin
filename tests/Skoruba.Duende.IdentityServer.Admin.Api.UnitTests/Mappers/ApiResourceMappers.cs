using FluentAssertions;
using Skoruba.Duende.IdentityServer.Admin.Api.Mappers;
using Skoruba.Duende.IdentityServer.Admin.Api.UnitTests.Mocks;
using Skoruba.Duende.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;
using Xunit;

namespace Skoruba.Duende.IdentityServer.Admin.Api.UnitTests.Mappers
{
    public class ApiResourceMappers
    {
        [Fact]
        public void CanMapApiResourceDtoToEntity()
        {
            //Generate DTO
            var apiResourceApiDto = ApiResourceApiDtoMock.GenerateRandomApiResource(1);

            //Try map to entity
            var apiResourceDto = apiResourceApiDto.ToApiResourceApiModel<ApiResourceDto>();

            apiResourceDto.Should().NotBeNull();

            apiResourceApiDto.Should().BeEquivalentTo(apiResourceDto, o => 
                o.Excluding(a => a.UserClaimsItems)
                .Excluding(a => a.AllowedAccessTokenSigningAlgorithmsItems)
                .Excluding(a => a.ScopesItems)); // TODO: examine exludings
        }
	}
}