var builder = DistributedApplication.CreateBuilder(args);



builder.AddProject<Projects.ctcom_identity_service>("ctcom-identity-service");



builder.AddProject<Projects.ctcom_product_service>("ctcom-product-service");



builder.Build().Run();
