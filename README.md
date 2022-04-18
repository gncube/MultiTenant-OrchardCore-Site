# MultiTenant-OrchardCore-Site
MultiTenant site using OrchardCore

### Setup folder structure

mkdir src

mkdir tests

cd src

#### Install OrchardCore CMS

dotnet new occms --help

dotnet new occms -n MultiTenantSite

dotnet restore

dotnet watch run

Server=localhost;Database=MultiTenantSiteDb;Trusted_Connection=True;

#### Install OrchardCore Theme

mkdir Themes

cd themes

dotnet new --list

octheme

Add sln
