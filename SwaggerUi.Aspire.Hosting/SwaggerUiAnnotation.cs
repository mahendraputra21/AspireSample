﻿using Aspire.Hosting.ApplicationModel;

namespace SwaggerUi.Aspire.Hosting;
public class SwaggerUIAnnotation(string[] documentNames, string path, EndpointReference endpointReference) : IResourceAnnotation
{
    public string[] DocumentNames { get; } = documentNames;
    public string Path { get; } = path;
    public EndpointReference EndpointReference { get; } = endpointReference;
}
