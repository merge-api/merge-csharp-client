using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

[TestFixture]
public class FieldMappingsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Account": [
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
              "AccountingAttachment": [
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
              "BalanceSheet": [
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
              "CashFlowStatement": [
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
              "CompanyInfo": [
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
              "Contact": [
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
              "IncomeStatement": [
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
              "CreditNote": [
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
              "Item": [
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
              "PurchaseOrder": [
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
              "TrackingCategory": [
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
              "JournalEntry": [
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
              "TaxRate": [
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
              "Invoice": [
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
              "Payment": [
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
              "Expense": [
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
              "VendorCredit": [
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
              "Transaction": [
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
              "AccountingPeriod": [
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
              "GeneralLedgerTransaction": [
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
              "BankFeedAccount": [
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
              "Employee": [
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
              "PaymentMethod": [
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
              "Project": [
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
              "PaymentTerm": [
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
                    .WithPath("/accounting/v1/field-mappings")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Accounting.FieldMapping.FieldMappingsRetrieveAsync(
            new FieldMappingsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FieldMappingApiInstanceResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
