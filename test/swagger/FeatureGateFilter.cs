using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace test.swagger
{
    public class FeatureGateFilter : IDocumentFilter
    {

        private readonly IFeatureManager _featureManager;

        public FeatureGateFilter(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var pathsToRemove = new List<string>();

            foreach(var apiDescription in context.ApiDescriptions)
            {
                var controllerFeatureGate = apiDescription.ActionDescriptor.EndpointMetadata
                    .OfType<FeatureGateAttribute>()
                    .FirstOrDefault();

                if(controllerFeatureGate != null)
                {
                    var nombreFeature = controllerFeatureGate.Features.FirstOrDefault();
                    var isEnabled = _featureManager.IsEnabledAsync(nombreFeature).GetAwaiter().GetResult();
                    if (!isEnabled)
                    {
                        pathsToRemove.Add("/" + apiDescription.RelativePath);
                    }

                }
            }

            foreach (var path in pathsToRemove.Distinct())
            {
                swaggerDoc.Paths.Remove(path);
            }

        }

    }
}
