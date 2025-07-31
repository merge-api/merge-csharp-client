using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class FieldMappingsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Activity": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Application": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Attachment": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Candidate": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Department": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "EEOC": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "ScheduledInterview": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Job": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "JobPosting": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "JobInterviewStage": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Offer": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Office": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "RejectReason": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Scorecard": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Tag": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "RemoteUser": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ats/v1/field-mappings")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ats.FieldMapping.FieldMappingsRetrieveAsync(
            new FieldMappingsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FieldMappingApiInstanceResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
