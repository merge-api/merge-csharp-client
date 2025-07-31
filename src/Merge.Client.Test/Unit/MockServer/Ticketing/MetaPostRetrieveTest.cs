using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ticketing;

[TestFixture]
public class MetaPostRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "request_schema": {
                "type": "object",
                "properties": {
                  "model": {
                    "type": "object",
                    "required": [
                      "last_name",
                      "first_name",
                      "merge_categories",
                      "new_york_city_neighborhood",
                      "favorite_tv_shows",
                      "favorite_watch"
                    ],
                    "properties": {
                      "email_addresses": {
                        "type": "array",
                        "items": {
                          "type": "object",
                          "properties": {
                            "value": {
                              "type": "string",
                              "title": "value"
                            },
                            "email_address_type": {
                              "type": "string",
                              "title": "email_address_type"
                            },
                            "integration_params": {
                              "type": "object",
                              "title": "integration_params",
                              "properties": {}
                            },
                            "linked_account_params": {
                              "type": "object",
                              "title": "linked_account_params",
                              "properties": {}
                            }
                          }
                        },
                        "title": "email_addresses",
                        "description": "Array of email_addresses objects"
                      },
                      "urls": {
                        "type": "array",
                        "items": {
                          "type": "object",
                          "properties": {
                            "value": {
                              "type": "string",
                              "title": "value"
                            },
                            "url_type": {
                              "type": "string",
                              "title": "url_type"
                            },
                            "integration_params": {
                              "type": "object",
                              "title": "integration_params",
                              "properties": {}
                            },
                            "linked_account_params": {
                              "type": "object",
                              "title": "linked_account_params",
                              "properties": {}
                            }
                          }
                        },
                        "title": "urls",
                        "description": "Array of urls objects"
                      },
                      "first_name": {
                        "type": "string",
                        "title": "first_name",
                        "description": "The first name."
                      },
                      "last_name": {
                        "type": "string",
                        "title": "last_name",
                        "description": "The last name."
                      },
                      "phone_numbers": {
                        "type": "array",
                        "items": {
                          "type": "object",
                          "properties": {
                            "value": {
                              "type": "string",
                              "title": "value"
                            },
                            "phone_number_type": {
                              "type": "string",
                              "title": "phone_number_type"
                            },
                            "integration_params": {
                              "type": "object",
                              "title": "integration_params",
                              "properties": {}
                            },
                            "linked_account_params": {
                              "type": "object",
                              "title": "linked_account_params",
                              "properties": {}
                            }
                          }
                        },
                        "title": "phone_numbers",
                        "description": "Array of phone_numbers objects"
                      },
                      "tags": {
                        "type": "array",
                        "items": {
                          "type": "string",
                          "format": "uuid"
                        },
                        "title": "tags",
                        "description": "Array of tags names"
                      },
                      "attachments": {
                        "type": "array",
                        "items": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "title": "id"
                            },
                            "file_url": {
                              "type": "string",
                              "title": "file_url"
                            },
                            "file_name": {
                              "type": "string",
                              "title": "file_name"
                            },
                            "attachment_type": {
                              "type": "string",
                              "title": "attachment_type"
                            },
                            "integration_params": {
                              "type": "object",
                              "title": "integration_params",
                              "properties": {}
                            },
                            "linked_account_params": {
                              "type": "object",
                              "title": "linked_account_params",
                              "properties": {}
                            }
                          }
                        },
                        "title": "attachments",
                        "description": "Array of attachments objects "
                      },
                      "merge_categories": {
                        "type": "array",
                        "categories": {
                          "type": "string",
                          "enum": [
                            "HRIS",
                            "ATS",
                            "Accounting",
                            "Ticketing",
                            "File Storage",
                            "CRM",
                            "Marketing Automation"
                          ],
                          "enum_information": [
                            {
                              "value": "HRIS",
                              "description": "Merge HRIS Category"
                            },
                            {
                              "value": "ATS",
                              "description": "Merge ATS Category"
                            },
                            {
                              "value": "Accounting",
                              "description": "Merge Accounting Category"
                            },
                            {
                              "value": "Ticketing",
                              "description": "Merge Ticketing Category"
                            },
                            {
                              "value": "File Storage",
                              "description": "Merge File Storage Category"
                            },
                            {
                              "value": "CRM",
                              "description": "Merge CRM Category"
                            },
                            {
                              "value": "Marketing Automation",
                              "description": "Merge Marketing Automation Category"
                            }
                          ]
                        },
                        "title": "Merge Categories",
                        "description": "Array of Merge's Unified API Categories"
                      },
                      "new_york_city_neighborhood": {
                        "type": "string",
                        "title": "Borough",
                        "description": "One of the 5 Boroughs of New York City"
                      },
                      "favorite_tv_shows": {
                        "type": "array",
                        "items": {
                          "type": "string",
                          "format": "uuid"
                        },
                        "title": "Favorite TV Shows",
                        "description": "Array of TV Show objects on merge.tv_shows"
                      },
                      "favorite_watch": {
                        "type": "string",
                        "title": "Favorite Watch",
                        "description": "Favorite watch of all time"
                      }
                    }
                  }
                }
              },
              "remote_field_classes": {
                "key": "value"
              },
              "status": {
                "linked_account_status": "linked_account_status",
                "can_make_request": true
              },
              "has_conditional_params": true,
              "has_required_linked_account_params": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/tickets/meta/post")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.Tickets.MetaPostRetrieveAsync(
            new TicketsMetaPostRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<MetaResponse>(mockResponse)).UsingDefaults()
        );
    }
}
