using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace DarkTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        public ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineStyle("darktheme-mdbootstrap-oc")
                .SetUrl("~/DarkTheme/css/mdb.dark.min.css")
                .SetVersion("1.0.0");
        }
        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}