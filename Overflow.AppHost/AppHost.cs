var builder = DistributedApplication.CreateBuilder(args);

var keycolak = builder.AddKeycloak("Keycloak", 6001)
    .WithDataVolume("Keycloak-Data");

builder.Build().Run();
