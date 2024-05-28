using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum TicketsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,contact")]
    AccountContact,

    [EnumMember(Value = "account,contact,creator")]
    AccountContactCreator,

    [EnumMember(Value = "account,contact,creator,parent_ticket")]
    AccountContactCreatorParentTicket,

    [EnumMember(Value = "account,contact,parent_ticket")]
    AccountContactParentTicket,

    [EnumMember(Value = "account,creator")]
    AccountCreator,

    [EnumMember(Value = "account,creator,parent_ticket")]
    AccountCreatorParentTicket,

    [EnumMember(Value = "account,parent_ticket")]
    AccountParentTicket,

    [EnumMember(Value = "assignees")]
    Assignees,

    [EnumMember(Value = "assignees,account")]
    AssigneesAccount,

    [EnumMember(Value = "assignees,account,contact")]
    AssigneesAccountContact,

    [EnumMember(Value = "assignees,account,contact,creator")]
    AssigneesAccountContactCreator,

    [EnumMember(Value = "assignees,account,contact,creator,parent_ticket")]
    AssigneesAccountContactCreatorParentTicket,

    [EnumMember(Value = "assignees,account,contact,parent_ticket")]
    AssigneesAccountContactParentTicket,

    [EnumMember(Value = "assignees,account,creator")]
    AssigneesAccountCreator,

    [EnumMember(Value = "assignees,account,creator,parent_ticket")]
    AssigneesAccountCreatorParentTicket,

    [EnumMember(Value = "assignees,account,parent_ticket")]
    AssigneesAccountParentTicket,

    [EnumMember(Value = "assignees,collections")]
    AssigneesCollections,

    [EnumMember(Value = "assignees,collections,account")]
    AssigneesCollectionsAccount,

    [EnumMember(Value = "assignees,collections,account,contact")]
    AssigneesCollectionsAccountContact,

    [EnumMember(Value = "assignees,collections,account,contact,creator")]
    AssigneesCollectionsAccountContactCreator,

    [EnumMember(Value = "assignees,collections,account,contact,creator,parent_ticket")]
    AssigneesCollectionsAccountContactCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,account,contact,parent_ticket")]
    AssigneesCollectionsAccountContactParentTicket,

    [EnumMember(Value = "assignees,collections,account,creator")]
    AssigneesCollectionsAccountCreator,

    [EnumMember(Value = "assignees,collections,account,creator,parent_ticket")]
    AssigneesCollectionsAccountCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,account,parent_ticket")]
    AssigneesCollectionsAccountParentTicket,

    [EnumMember(Value = "assignees,collections,contact")]
    AssigneesCollectionsContact,

    [EnumMember(Value = "assignees,collections,contact,creator")]
    AssigneesCollectionsContactCreator,

    [EnumMember(Value = "assignees,collections,contact,creator,parent_ticket")]
    AssigneesCollectionsContactCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,contact,parent_ticket")]
    AssigneesCollectionsContactParentTicket,

    [EnumMember(Value = "assignees,collections,creator")]
    AssigneesCollectionsCreator,

    [EnumMember(Value = "assignees,collections,creator,parent_ticket")]
    AssigneesCollectionsCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,parent_ticket")]
    AssigneesCollectionsParentTicket,

    [EnumMember(Value = "assignees,contact")]
    AssigneesContact,

    [EnumMember(Value = "assignees,contact,creator")]
    AssigneesContactCreator,

    [EnumMember(Value = "assignees,contact,creator,parent_ticket")]
    AssigneesContactCreatorParentTicket,

    [EnumMember(Value = "assignees,contact,parent_ticket")]
    AssigneesContactParentTicket,

    [EnumMember(Value = "assignees,creator")]
    AssigneesCreator,

    [EnumMember(Value = "assignees,creator,parent_ticket")]
    AssigneesCreatorParentTicket,

    [EnumMember(Value = "assignees,parent_ticket")]
    AssigneesParentTicket,

    [EnumMember(Value = "attachments")]
    Attachments,

    [EnumMember(Value = "attachments,account")]
    AttachmentsAccount,

    [EnumMember(Value = "attachments,account,contact")]
    AttachmentsAccountContact,

    [EnumMember(Value = "attachments,account,contact,creator")]
    AttachmentsAccountContactCreator,

    [EnumMember(Value = "attachments,account,contact,creator,parent_ticket")]
    AttachmentsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,account,contact,parent_ticket")]
    AttachmentsAccountContactParentTicket,

    [EnumMember(Value = "attachments,account,creator")]
    AttachmentsAccountCreator,

    [EnumMember(Value = "attachments,account,creator,parent_ticket")]
    AttachmentsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,account,parent_ticket")]
    AttachmentsAccountParentTicket,

    [EnumMember(Value = "attachments,assignees")]
    AttachmentsAssignees,

    [EnumMember(Value = "attachments,assignees,account")]
    AttachmentsAssigneesAccount,

    [EnumMember(Value = "attachments,assignees,account,contact")]
    AttachmentsAssigneesAccountContact,

    [EnumMember(Value = "attachments,assignees,account,contact,creator")]
    AttachmentsAssigneesAccountContactCreator,

    [EnumMember(Value = "attachments,assignees,account,contact,creator,parent_ticket")]
    AttachmentsAssigneesAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,account,contact,parent_ticket")]
    AttachmentsAssigneesAccountContactParentTicket,

    [EnumMember(Value = "attachments,assignees,account,creator")]
    AttachmentsAssigneesAccountCreator,

    [EnumMember(Value = "attachments,assignees,account,creator,parent_ticket")]
    AttachmentsAssigneesAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,account,parent_ticket")]
    AttachmentsAssigneesAccountParentTicket,

    [EnumMember(Value = "attachments,assignees,collections")]
    AttachmentsAssigneesCollections,

    [EnumMember(Value = "attachments,assignees,collections,account")]
    AttachmentsAssigneesCollectionsAccount,

    [EnumMember(Value = "attachments,assignees,collections,account,contact")]
    AttachmentsAssigneesCollectionsAccountContact,

    [EnumMember(Value = "attachments,assignees,collections,account,contact,creator")]
    AttachmentsAssigneesCollectionsAccountContactCreator,

    [EnumMember(Value = "attachments,assignees,collections,account,contact,creator,parent_ticket")]
    AttachmentsAssigneesCollectionsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,account,contact,parent_ticket")]
    AttachmentsAssigneesCollectionsAccountContactParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,account,creator")]
    AttachmentsAssigneesCollectionsAccountCreator,

    [EnumMember(Value = "attachments,assignees,collections,account,creator,parent_ticket")]
    AttachmentsAssigneesCollectionsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,account,parent_ticket")]
    AttachmentsAssigneesCollectionsAccountParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,contact")]
    AttachmentsAssigneesCollectionsContact,

    [EnumMember(Value = "attachments,assignees,collections,contact,creator")]
    AttachmentsAssigneesCollectionsContactCreator,

    [EnumMember(Value = "attachments,assignees,collections,contact,creator,parent_ticket")]
    AttachmentsAssigneesCollectionsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,contact,parent_ticket")]
    AttachmentsAssigneesCollectionsContactParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,creator")]
    AttachmentsAssigneesCollectionsCreator,

    [EnumMember(Value = "attachments,assignees,collections,creator,parent_ticket")]
    AttachmentsAssigneesCollectionsCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,parent_ticket")]
    AttachmentsAssigneesCollectionsParentTicket,

    [EnumMember(Value = "attachments,assignees,contact")]
    AttachmentsAssigneesContact,

    [EnumMember(Value = "attachments,assignees,contact,creator")]
    AttachmentsAssigneesContactCreator,

    [EnumMember(Value = "attachments,assignees,contact,creator,parent_ticket")]
    AttachmentsAssigneesContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,contact,parent_ticket")]
    AttachmentsAssigneesContactParentTicket,

    [EnumMember(Value = "attachments,assignees,creator")]
    AttachmentsAssigneesCreator,

    [EnumMember(Value = "attachments,assignees,creator,parent_ticket")]
    AttachmentsAssigneesCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,parent_ticket")]
    AttachmentsAssigneesParentTicket,

    [EnumMember(Value = "attachments,collections")]
    AttachmentsCollections,

    [EnumMember(Value = "attachments,collections,account")]
    AttachmentsCollectionsAccount,

    [EnumMember(Value = "attachments,collections,account,contact")]
    AttachmentsCollectionsAccountContact,

    [EnumMember(Value = "attachments,collections,account,contact,creator")]
    AttachmentsCollectionsAccountContactCreator,

    [EnumMember(Value = "attachments,collections,account,contact,creator,parent_ticket")]
    AttachmentsCollectionsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,account,contact,parent_ticket")]
    AttachmentsCollectionsAccountContactParentTicket,

    [EnumMember(Value = "attachments,collections,account,creator")]
    AttachmentsCollectionsAccountCreator,

    [EnumMember(Value = "attachments,collections,account,creator,parent_ticket")]
    AttachmentsCollectionsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,account,parent_ticket")]
    AttachmentsCollectionsAccountParentTicket,

    [EnumMember(Value = "attachments,collections,contact")]
    AttachmentsCollectionsContact,

    [EnumMember(Value = "attachments,collections,contact,creator")]
    AttachmentsCollectionsContactCreator,

    [EnumMember(Value = "attachments,collections,contact,creator,parent_ticket")]
    AttachmentsCollectionsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,contact,parent_ticket")]
    AttachmentsCollectionsContactParentTicket,

    [EnumMember(Value = "attachments,collections,creator")]
    AttachmentsCollectionsCreator,

    [EnumMember(Value = "attachments,collections,creator,parent_ticket")]
    AttachmentsCollectionsCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,parent_ticket")]
    AttachmentsCollectionsParentTicket,

    [EnumMember(Value = "attachments,contact")]
    AttachmentsContact,

    [EnumMember(Value = "attachments,contact,creator")]
    AttachmentsContactCreator,

    [EnumMember(Value = "attachments,contact,creator,parent_ticket")]
    AttachmentsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,contact,parent_ticket")]
    AttachmentsContactParentTicket,

    [EnumMember(Value = "attachments,creator")]
    AttachmentsCreator,

    [EnumMember(Value = "attachments,creator,parent_ticket")]
    AttachmentsCreatorParentTicket,

    [EnumMember(Value = "attachments,parent_ticket")]
    AttachmentsParentTicket,

    [EnumMember(Value = "collections")]
    Collections,

    [EnumMember(Value = "collections,account")]
    CollectionsAccount,

    [EnumMember(Value = "collections,account,contact")]
    CollectionsAccountContact,

    [EnumMember(Value = "collections,account,contact,creator")]
    CollectionsAccountContactCreator,

    [EnumMember(Value = "collections,account,contact,creator,parent_ticket")]
    CollectionsAccountContactCreatorParentTicket,

    [EnumMember(Value = "collections,account,contact,parent_ticket")]
    CollectionsAccountContactParentTicket,

    [EnumMember(Value = "collections,account,creator")]
    CollectionsAccountCreator,

    [EnumMember(Value = "collections,account,creator,parent_ticket")]
    CollectionsAccountCreatorParentTicket,

    [EnumMember(Value = "collections,account,parent_ticket")]
    CollectionsAccountParentTicket,

    [EnumMember(Value = "collections,contact")]
    CollectionsContact,

    [EnumMember(Value = "collections,contact,creator")]
    CollectionsContactCreator,

    [EnumMember(Value = "collections,contact,creator,parent_ticket")]
    CollectionsContactCreatorParentTicket,

    [EnumMember(Value = "collections,contact,parent_ticket")]
    CollectionsContactParentTicket,

    [EnumMember(Value = "collections,creator")]
    CollectionsCreator,

    [EnumMember(Value = "collections,creator,parent_ticket")]
    CollectionsCreatorParentTicket,

    [EnumMember(Value = "collections,parent_ticket")]
    CollectionsParentTicket,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,creator")]
    ContactCreator,

    [EnumMember(Value = "contact,creator,parent_ticket")]
    ContactCreatorParentTicket,

    [EnumMember(Value = "contact,parent_ticket")]
    ContactParentTicket,

    [EnumMember(Value = "creator")]
    Creator,

    [EnumMember(Value = "creator,parent_ticket")]
    CreatorParentTicket,

    [EnumMember(Value = "parent_ticket")]
    ParentTicket
}
