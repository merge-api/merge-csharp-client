using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketsRetrieveRequestExpand>))]
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

    [EnumMember(Value = "assigned_teams")]
    AssignedTeams,

    [EnumMember(Value = "assigned_teams,account")]
    AssignedTeamsAccount,

    [EnumMember(Value = "assigned_teams,account,contact")]
    AssignedTeamsAccountContact,

    [EnumMember(Value = "assigned_teams,account,contact,creator")]
    AssignedTeamsAccountContactCreator,

    [EnumMember(Value = "assigned_teams,account,contact,creator,parent_ticket")]
    AssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "assigned_teams,account,contact,parent_ticket")]
    AssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "assigned_teams,account,creator")]
    AssignedTeamsAccountCreator,

    [EnumMember(Value = "assigned_teams,account,creator,parent_ticket")]
    AssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "assigned_teams,account,parent_ticket")]
    AssignedTeamsAccountParentTicket,

    [EnumMember(Value = "assigned_teams,contact")]
    AssignedTeamsContact,

    [EnumMember(Value = "assigned_teams,contact,creator")]
    AssignedTeamsContactCreator,

    [EnumMember(Value = "assigned_teams,contact,creator,parent_ticket")]
    AssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "assigned_teams,contact,parent_ticket")]
    AssignedTeamsContactParentTicket,

    [EnumMember(Value = "assigned_teams,creator")]
    AssignedTeamsCreator,

    [EnumMember(Value = "assigned_teams,creator,parent_ticket")]
    AssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "assigned_teams,parent_ticket")]
    AssignedTeamsParentTicket,

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

    [EnumMember(Value = "assignees,assigned_teams")]
    AssigneesAssignedTeams,

    [EnumMember(Value = "assignees,assigned_teams,account")]
    AssigneesAssignedTeamsAccount,

    [EnumMember(Value = "assignees,assigned_teams,account,contact")]
    AssigneesAssignedTeamsAccountContact,

    [EnumMember(Value = "assignees,assigned_teams,account,contact,creator")]
    AssigneesAssignedTeamsAccountContactCreator,

    [EnumMember(Value = "assignees,assigned_teams,account,contact,creator,parent_ticket")]
    AssigneesAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,account,contact,parent_ticket")]
    AssigneesAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,account,creator")]
    AssigneesAssignedTeamsAccountCreator,

    [EnumMember(Value = "assignees,assigned_teams,account,creator,parent_ticket")]
    AssigneesAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,account,parent_ticket")]
    AssigneesAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,contact")]
    AssigneesAssignedTeamsContact,

    [EnumMember(Value = "assignees,assigned_teams,contact,creator")]
    AssigneesAssignedTeamsContactCreator,

    [EnumMember(Value = "assignees,assigned_teams,contact,creator,parent_ticket")]
    AssigneesAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,contact,parent_ticket")]
    AssigneesAssignedTeamsContactParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,creator")]
    AssigneesAssignedTeamsCreator,

    [EnumMember(Value = "assignees,assigned_teams,creator,parent_ticket")]
    AssigneesAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "assignees,assigned_teams,parent_ticket")]
    AssigneesAssignedTeamsParentTicket,

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

    [EnumMember(Value = "assignees,collections,assigned_teams")]
    AssigneesCollectionsAssignedTeams,

    [EnumMember(Value = "assignees,collections,assigned_teams,account")]
    AssigneesCollectionsAssignedTeamsAccount,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,contact")]
    AssigneesCollectionsAssignedTeamsAccountContact,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,contact,creator")]
    AssigneesCollectionsAssignedTeamsAccountContactCreator,

    [EnumMember(
        Value = "assignees,collections,assigned_teams,account,contact,creator,parent_ticket"
    )]
    AssigneesCollectionsAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,contact,parent_ticket")]
    AssigneesCollectionsAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,creator")]
    AssigneesCollectionsAssignedTeamsAccountCreator,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,creator,parent_ticket")]
    AssigneesCollectionsAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,account,parent_ticket")]
    AssigneesCollectionsAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,contact")]
    AssigneesCollectionsAssignedTeamsContact,

    [EnumMember(Value = "assignees,collections,assigned_teams,contact,creator")]
    AssigneesCollectionsAssignedTeamsContactCreator,

    [EnumMember(Value = "assignees,collections,assigned_teams,contact,creator,parent_ticket")]
    AssigneesCollectionsAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,contact,parent_ticket")]
    AssigneesCollectionsAssignedTeamsContactParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,creator")]
    AssigneesCollectionsAssignedTeamsCreator,

    [EnumMember(Value = "assignees,collections,assigned_teams,creator,parent_ticket")]
    AssigneesCollectionsAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "assignees,collections,assigned_teams,parent_ticket")]
    AssigneesCollectionsAssignedTeamsParentTicket,

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

    [EnumMember(Value = "attachments,assigned_teams")]
    AttachmentsAssignedTeams,

    [EnumMember(Value = "attachments,assigned_teams,account")]
    AttachmentsAssignedTeamsAccount,

    [EnumMember(Value = "attachments,assigned_teams,account,contact")]
    AttachmentsAssignedTeamsAccountContact,

    [EnumMember(Value = "attachments,assigned_teams,account,contact,creator")]
    AttachmentsAssignedTeamsAccountContactCreator,

    [EnumMember(Value = "attachments,assigned_teams,account,contact,creator,parent_ticket")]
    AttachmentsAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,account,contact,parent_ticket")]
    AttachmentsAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,account,creator")]
    AttachmentsAssignedTeamsAccountCreator,

    [EnumMember(Value = "attachments,assigned_teams,account,creator,parent_ticket")]
    AttachmentsAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,account,parent_ticket")]
    AttachmentsAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,contact")]
    AttachmentsAssignedTeamsContact,

    [EnumMember(Value = "attachments,assigned_teams,contact,creator")]
    AttachmentsAssignedTeamsContactCreator,

    [EnumMember(Value = "attachments,assigned_teams,contact,creator,parent_ticket")]
    AttachmentsAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,contact,parent_ticket")]
    AttachmentsAssignedTeamsContactParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,creator")]
    AttachmentsAssignedTeamsCreator,

    [EnumMember(Value = "attachments,assigned_teams,creator,parent_ticket")]
    AttachmentsAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "attachments,assigned_teams,parent_ticket")]
    AttachmentsAssignedTeamsParentTicket,

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

    [EnumMember(Value = "attachments,assignees,assigned_teams")]
    AttachmentsAssigneesAssignedTeams,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account")]
    AttachmentsAssigneesAssignedTeamsAccount,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,contact")]
    AttachmentsAssigneesAssignedTeamsAccountContact,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,contact,creator")]
    AttachmentsAssigneesAssignedTeamsAccountContactCreator,

    [EnumMember(
        Value = "attachments,assignees,assigned_teams,account,contact,creator,parent_ticket"
    )]
    AttachmentsAssigneesAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,contact,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,creator")]
    AttachmentsAssigneesAssignedTeamsAccountCreator,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,creator,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,account,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,contact")]
    AttachmentsAssigneesAssignedTeamsContact,

    [EnumMember(Value = "attachments,assignees,assigned_teams,contact,creator")]
    AttachmentsAssigneesAssignedTeamsContactCreator,

    [EnumMember(Value = "attachments,assignees,assigned_teams,contact,creator,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,contact,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsContactParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,creator")]
    AttachmentsAssigneesAssignedTeamsCreator,

    [EnumMember(Value = "attachments,assignees,assigned_teams,creator,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,assigned_teams,parent_ticket")]
    AttachmentsAssigneesAssignedTeamsParentTicket,

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

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams")]
    AttachmentsAssigneesCollectionsAssignedTeams,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,account")]
    AttachmentsAssigneesCollectionsAssignedTeamsAccount,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,account,contact")]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountContact,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,account,contact,creator")]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountContactCreator,

    [EnumMember(
        Value = "attachments,assignees,collections,assigned_teams,account,contact,creator,parent_ticket"
    )]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(
        Value = "attachments,assignees,collections,assigned_teams,account,contact,parent_ticket"
    )]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,account,creator")]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountCreator,

    [EnumMember(
        Value = "attachments,assignees,collections,assigned_teams,account,creator,parent_ticket"
    )]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,account,parent_ticket")]
    AttachmentsAssigneesCollectionsAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,contact")]
    AttachmentsAssigneesCollectionsAssignedTeamsContact,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,contact,creator")]
    AttachmentsAssigneesCollectionsAssignedTeamsContactCreator,

    [EnumMember(
        Value = "attachments,assignees,collections,assigned_teams,contact,creator,parent_ticket"
    )]
    AttachmentsAssigneesCollectionsAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,contact,parent_ticket")]
    AttachmentsAssigneesCollectionsAssignedTeamsContactParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,creator")]
    AttachmentsAssigneesCollectionsAssignedTeamsCreator,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,creator,parent_ticket")]
    AttachmentsAssigneesCollectionsAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "attachments,assignees,collections,assigned_teams,parent_ticket")]
    AttachmentsAssigneesCollectionsAssignedTeamsParentTicket,

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

    [EnumMember(Value = "attachments,collections,assigned_teams")]
    AttachmentsCollectionsAssignedTeams,

    [EnumMember(Value = "attachments,collections,assigned_teams,account")]
    AttachmentsCollectionsAssignedTeamsAccount,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,contact")]
    AttachmentsCollectionsAssignedTeamsAccountContact,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,contact,creator")]
    AttachmentsCollectionsAssignedTeamsAccountContactCreator,

    [EnumMember(
        Value = "attachments,collections,assigned_teams,account,contact,creator,parent_ticket"
    )]
    AttachmentsCollectionsAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,contact,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,creator")]
    AttachmentsCollectionsAssignedTeamsAccountCreator,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,creator,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,account,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,contact")]
    AttachmentsCollectionsAssignedTeamsContact,

    [EnumMember(Value = "attachments,collections,assigned_teams,contact,creator")]
    AttachmentsCollectionsAssignedTeamsContactCreator,

    [EnumMember(Value = "attachments,collections,assigned_teams,contact,creator,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,contact,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsContactParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,creator")]
    AttachmentsCollectionsAssignedTeamsCreator,

    [EnumMember(Value = "attachments,collections,assigned_teams,creator,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "attachments,collections,assigned_teams,parent_ticket")]
    AttachmentsCollectionsAssignedTeamsParentTicket,

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

    [EnumMember(Value = "collections,assigned_teams")]
    CollectionsAssignedTeams,

    [EnumMember(Value = "collections,assigned_teams,account")]
    CollectionsAssignedTeamsAccount,

    [EnumMember(Value = "collections,assigned_teams,account,contact")]
    CollectionsAssignedTeamsAccountContact,

    [EnumMember(Value = "collections,assigned_teams,account,contact,creator")]
    CollectionsAssignedTeamsAccountContactCreator,

    [EnumMember(Value = "collections,assigned_teams,account,contact,creator,parent_ticket")]
    CollectionsAssignedTeamsAccountContactCreatorParentTicket,

    [EnumMember(Value = "collections,assigned_teams,account,contact,parent_ticket")]
    CollectionsAssignedTeamsAccountContactParentTicket,

    [EnumMember(Value = "collections,assigned_teams,account,creator")]
    CollectionsAssignedTeamsAccountCreator,

    [EnumMember(Value = "collections,assigned_teams,account,creator,parent_ticket")]
    CollectionsAssignedTeamsAccountCreatorParentTicket,

    [EnumMember(Value = "collections,assigned_teams,account,parent_ticket")]
    CollectionsAssignedTeamsAccountParentTicket,

    [EnumMember(Value = "collections,assigned_teams,contact")]
    CollectionsAssignedTeamsContact,

    [EnumMember(Value = "collections,assigned_teams,contact,creator")]
    CollectionsAssignedTeamsContactCreator,

    [EnumMember(Value = "collections,assigned_teams,contact,creator,parent_ticket")]
    CollectionsAssignedTeamsContactCreatorParentTicket,

    [EnumMember(Value = "collections,assigned_teams,contact,parent_ticket")]
    CollectionsAssignedTeamsContactParentTicket,

    [EnumMember(Value = "collections,assigned_teams,creator")]
    CollectionsAssignedTeamsCreator,

    [EnumMember(Value = "collections,assigned_teams,creator,parent_ticket")]
    CollectionsAssignedTeamsCreatorParentTicket,

    [EnumMember(Value = "collections,assigned_teams,parent_ticket")]
    CollectionsAssignedTeamsParentTicket,

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
    ParentTicket,
}
