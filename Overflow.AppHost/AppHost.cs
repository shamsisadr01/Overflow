var builder = DistributedApplication.CreateBuilder(args);

#pragma warning disable ASPIRECERTIFICATES001

var keycloak = builder
    .AddKeycloak("Keycloak", 6001)
    .WithoutHttpsCertificate()
    .WithDataVolume("Keycloak-Data");

#pragma warning restore ASPIRECERTIFICATES001

var questionService = builder.AddProject<Projects.QuestionService>("question-svc")
    .WithReference(keycloak)
    .WaitFor(keycloak);

builder.Build().Run();
